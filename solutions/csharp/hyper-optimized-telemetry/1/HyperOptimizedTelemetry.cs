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

    public static long FromBuffer(byte[] buffer)
    {
        if (buffer == null || buffer.Length < 2)
            throw new ArgumentException("Buffer is too short.");

        byte marker = buffer[0];
        int type = marker switch
        {
            0x02 => 2,     // unsigned 2
            0x04 => 4,     // unsigned 4
            0xFE => 2,     // signed 2
            0xFC => 4,     // signed 4
            0xF8 => 8,     // signed 8
            _ => 0,
        };

        if (type == 0)
            return 0;

        Span<byte> span = stackalloc byte[8];
        buffer.AsSpan(1, type).CopyTo(span);

        return marker switch
        {
            0x02 => BinaryPrimitives.ReadUInt16LittleEndian(span),
            0x04 => BinaryPrimitives.ReadUInt32LittleEndian(span),
            0xFE => BinaryPrimitives.ReadInt16LittleEndian(span),
            0xFC => BinaryPrimitives.ReadInt32LittleEndian(span),
            0xF8 => BinaryPrimitives.ReadInt64LittleEndian(span),
            _ => 0
        };
    }
}
