public class Robot
{
    private string name;
    private static HashSet<string> names = new HashSet<string>();

    public Robot()
    {
        Reset();
    }

    public string Name
    {
        get => name;
    }

    public void Reset()
    {
        while(true)
        {
            string newName = GenerateName();
            if (names.Add(newName))
            {
                name = newName;
                break;
            }
        }
    }

    private string GenerateName()
    {
        string letters = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        string digits = "0123456789";
        string letterPart = letters[Random.Shared.Next(letters.Length)].ToString() +
                            letters[Random.Shared.Next(letters.Length)].ToString();
        string digitPart = digits[Random.Shared.Next(digits.Length)].ToString() +
                            digits[Random.Shared.Next(digits.Length)].ToString() +
                            digits[Random.Shared.Next(digits.Length)].ToString();
        return letterPart + digitPart;
    }
}