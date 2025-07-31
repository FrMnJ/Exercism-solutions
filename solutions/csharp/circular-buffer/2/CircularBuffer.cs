public class CircularBuffer<T>
{
    private T[] buffer;
    private int oldestWrite = 0;
    private int lastWrite = -1;
    private int count = 0;

    public CircularBuffer(int capacity)
    {
        if (capacity <= 0)
        {
            throw new ArgumentException("Capacity must be greater than zero.", nameof(capacity));
        }
        buffer = new T[capacity];
    }

    public T Read()
    {
        if (count == 0)
        {
            throw new InvalidOperationException("Buffer is empty");
        }

        T value = buffer[oldestWrite];
        buffer[oldestWrite] = default;
        oldestWrite = NextOldestIndex();
        count--;

        return value;
    }

    public void Write(T value)
    {
        if (count == buffer.Length)
        {
            throw new InvalidOperationException("Buffer is full");
        }

        lastWrite = NextWriteIndex();
        buffer[lastWrite] = value;
        count++;

        if (count == 1) 
        {
            oldestWrite = lastWrite;
        }
    }

    private int NextWriteIndex() => (lastWrite + 1) % buffer.Length;

    public void Overwrite(T value)
    {
        if (count < buffer.Length)
        {
            Write(value);
        }
        else
        {
            oldestWrite = NextOldestIndex();
            lastWrite = NextWriteIndex();
            buffer[lastWrite] = value;
        }
    }

    private int NextOldestIndex() => (oldestWrite + 1) % buffer.Length;
    public void Clear()
    {
        for (int i = 0; i < buffer.Length; i++)
        {
            buffer[i] = default;
        }
        oldestWrite = 0;
        lastWrite = -1;
        count = 0;
    }
}