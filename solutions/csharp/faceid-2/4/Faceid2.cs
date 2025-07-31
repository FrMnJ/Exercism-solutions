public class FacialFeatures
{
    public string EyeColor { get; }
    public decimal PhiltrumWidth { get; }

    public FacialFeatures(string eyeColor, decimal philtrumWidth)
    {
        EyeColor = eyeColor;
        PhiltrumWidth = philtrumWidth;
    }

    public override bool Equals(object? obj) 
        => obj == this ||
            Equals(obj as FacialFeatures);

    bool Equals(FacialFeatures? other) 
        => other != null &&
                this.EyeColor == other.EyeColor &&
                this.PhiltrumWidth == other.PhiltrumWidth;
    
    
    public override int GetHashCode() => HashCode.Combine(EyeColor, PhiltrumWidth);
}

public class Identity
{
    public string Email { get; }
    public FacialFeatures FacialFeatures { get; }

    public Identity(string email, FacialFeatures facialFeatures)
    {
        Email = email;
        FacialFeatures = facialFeatures;
    }

    public override bool Equals(object? obj) =>
        obj == this ||
        Equals(obj as Identity);

    private bool Equals(Identity? other) 
        => other != null &&
                this.Email == other.Email &&
                this.FacialFeatures.Equals(other.FacialFeatures);
    

    public override int GetHashCode() 
        => HashCode.Combine(Email, FacialFeatures);

}

public class Authenticator
{
    private readonly Identity adminIdentity = new(
        "admin@exerc.ism",
        new FacialFeatures("green", 0.9m)
    );

    private HashSet<Identity> registeredIdentities = new();

    public static bool AreSameFace(FacialFeatures faceA, FacialFeatures faceB)
        => faceA.Equals(faceB);

    public bool IsAdmin(Identity identity) 
        => identity.Equals(adminIdentity);


    public bool Register(Identity identity) 
        => registeredIdentities.Add(identity);

    public bool IsRegistered(Identity identity) 
        => registeredIdentities.Contains(identity);
    

    public static bool AreSameObject(Identity identityA, Identity identityB)
        => identityA == identityB;
}
