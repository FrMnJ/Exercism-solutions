using System.Collections.ObjectModel;

public class Authenticator
{
    private class EyeColor
    {
        public const string Blue = "blue";
        public const string Green = "green";
        public const string Brown = "brown";
        public const string Hazel = "hazel";
        public const string Grey = "grey";
    }

    public Authenticator(Identity admin)
    {
        this.admin = admin;
    }

    private readonly Identity admin;

    private readonly IDictionary<string, Identity> developers
        = new Dictionary<string, Identity>
        {
            ["Bertrand"] = new Identity("bert@ex.ism","blue"),
            ["Anders"] = new Identity("anders@ex.ism", "brown")
        };

    public Identity Admin
    {
        get => new Identity(admin.Email, admin.EyeColor);
    }

    public IDictionary<string, Identity> GetDevelopers()
    {
        return new ReadOnlyDictionary<string, Identity>(developers);
    }
}

public struct Identity(string email, string eyeColor)
{
    public string Email { get; set; } = email;

    public string EyeColor { get; set; } = eyeColor;
}
