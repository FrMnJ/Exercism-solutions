public class CircularBuffer<T>
{
    private T[] buffer;
    private int oldestWrite = -1;
    private int lastWrite = -1;
    private int count = 0;
    public CircularBuffer(int capacity)
    {
       buffer = new T[capacity]; 
    }

    public T Read()
    {
        if(count == 0)
        {
            throw new InvalidOperationException("Buffer is empty");
        }
        T value = buffer[oldestWrite];
        count--;
        oldestWrite++;
        oldestWrite %= buffer.Length;
        return value;
    }

    public void Write(T value)
    { 
        if(oldestWrite == -1)
            oldestWrite = 0;
        lastWrite++;
        lastWrite %= buffer.Length;
        count++;
        if(count > buffer.Length)
        {
            count--;
            throw new InvalidOperationException("Buffer is full");
        }
        buffer[lastWrite] = value;
    }

    public void Overwrite(T value)
    {
        if(count < buffer.Length)
        {
            Write(value);
            return;
        }
        lastWrite++;
        lastWrite %= buffer.Length;
        buffer[lastWrite] = value;
        oldestWrite++;
        oldestWrite %= buffer.Length;
    }

    public void Clear()
    {
        lastWrite = -1;
        oldestWrite = -1;
        count = 0;
    }
}