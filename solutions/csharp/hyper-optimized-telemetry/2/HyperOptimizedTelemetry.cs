using System.Buffers.Binary;

public static class TelemetryBuffer
{
    public static byte[] ToBuffer(long reading)
    {
        byte[] buffer = new byte[9];
        (byte typeMarker, int length) = reading switch
        {
            >= long.MinValue and <= (long)int.MinValue - 1 => ((byte)0xF8, 8),
            >= int.MinValue and <= short.MinValue - 1 => ((byte)0xFC, 4),
            >= short.MinValue and <= -1 => ((byte)0xFE, 2),
            >= 0 and <= ushort.MaxValue => ((byte)0x02, 2),
            >= ushort.MaxValue + 1L and <= int.MaxValue => ((byte)0xFC, 4),
            >= (long)uint.MaxValue + 1 and <= long.MaxValue => ((byte)0xF8, 8),
            >= int.MaxValue + 1L and <= uint.MaxValue => ((byte)0x04, 4),
        };
            

        buffer[0] = typeMarker;

        for (int i = 1; i <= length; i++)
        {
            buffer[i] = (byte)(reading & 0xFF);
            reading >>= 8;
        }

        return buffer;
    }

    public static long FromBuffer(byte[] buffer) =>
       buffer[0] switch {
            0x02 => BitConverter.ToUInt16(buffer, 1),     // unsigned 2
            0x04 => BitConverter.ToUInt32(buffer, 1),     // unsigned 4
            0xFE => BitConverter.ToInt16(buffer, 1),     // signed 2
            0xFC => BitConverter.ToInt32(buffer, 1),     // signed 4
            0xF8 => BitConverter.ToInt64(buffer, 1),     // signed 8
            _ => 0,
        };
}
