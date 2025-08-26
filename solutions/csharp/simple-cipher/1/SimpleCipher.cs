using System.Text;

public class SimpleCipher
{
    private string _key;

    public SimpleCipher()
    {
        _key = GenerateKey();
    }

    public SimpleCipher(string key)
    {
        _key = key;
    }

    public string Key => _key;

    private string GenerateKey()
    {
        StringBuilder key = new();
        for (int i = 0; i < 100; i++)
        {
            key.Append((char)(Random.Shared.Next(26) + 'a'));
        }
        return key.ToString();
    }

    public string Encode(string plaintext)
    {
        StringBuilder encoded = new();
        int keyShiftIndex = 0;

        for (int i = 0; i < plaintext.Length; i++)
        {
            char ch = plaintext[i];
            if (!char.IsLetter(ch))
            {
                encoded.Append(ch);
                continue;
            }

            int c = ch - 'a';
            int shift = _key[keyShiftIndex] - 'a';

            encoded.Append(Shift(c, shift));

            keyShiftIndex = (keyShiftIndex + 1) % _key.Length;
        }

        return encoded.ToString();
    }

    public string Decode(string ciphertext)
    {
        StringBuilder decoded = new();
        int keyShiftIndex = 0;

        for (int i = 0; i < ciphertext.Length; i++)
        {
            char ch = ciphertext[i];
            if (!char.IsLetter(ch))
            {
                decoded.Append(ch);
                continue;
            }

            int c = ch - 'a';
            int shift = _key[keyShiftIndex] - 'a';

            decoded.Append(UnShift(c, shift));

            keyShiftIndex = (keyShiftIndex + 1) % _key.Length;
        }

        return decoded.ToString();
    }

    private char Shift(int c, int shift)
    {
        int shiftC = (c + shift) % 26;
        return (char)(shiftC + 'a');
    }

    private char UnShift(int c, int shift)
    {
        int shiftC = (c - shift + 26) % 26;
        return (char)(shiftC + 'a');
    }
}
