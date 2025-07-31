public class Authenticator
{
    // TODO: Implement the Authenticator.Admin property
    public Identity Admin { get; } = new Identity
    {
        Email = "admin@ex.ism",
        NameAndAddress = new List<string>
        {
            "Chanakya",
            "Mumbai",
            "India"
        },
        FacialFeatures = new FacialFeatures
        {
            EyeColor = "green",
            PhiltrumWidth = 0.9m
        }
    };

    // TODO: Implement the Authenticator.Developers property
    public IDictionary<string, Identity> Developers { get; } = new Dictionary<string, Identity>()
    {
        ["Bertrand"] = new()
        {
            Email = "bert@ex.ism",
            NameAndAddress = new List<string>
            {
                "Bertrand",
                "Paris",
                "France"
            },
            FacialFeatures = new FacialFeatures
            {
                EyeColor = "blue",
                PhiltrumWidth = 0.8m
            }
        },
        ["Anders"] = new()
        {
            Email = "anders@ex.ism",
            NameAndAddress = new List<string>
            {
                "Anders",
                "Redmond",
                "USA"
            },
            FacialFeatures = new FacialFeatures
            {
                EyeColor = "brown",
                PhiltrumWidth = 0.85m
            }
        }
    };
}

//**** please do not modify the FacialFeatures class ****
public class FacialFeatures
{
    public required string EyeColor { get; set; }
    public required decimal PhiltrumWidth { get; set; }
}

//**** please do not modify the Identity class ****
public class Identity
{
    public required string Email { get; set; }
    public required FacialFeatures FacialFeatures { get; set; }
    public required IList<string> NameAndAddress { get; set; }
}
