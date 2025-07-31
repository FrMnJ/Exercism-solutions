public class FacialFeatures
{
    public string EyeColor { get; }
    public decimal PhiltrumWidth { get; }

    public FacialFeatures(string eyeColor, decimal philtrumWidth)
    {
        EyeColor = eyeColor;
        PhiltrumWidth = philtrumWidth;
    }
    // TODO: implement equality and GetHashCode() methods
    public override bool Equals(object? obj)
    {
        if(obj is FacialFeatures other)
        {
            return this.EyeColor == other.EyeColor &&
                   this.PhiltrumWidth == other.PhiltrumWidth;
        }
        return false; 
    }
    public override int GetHashCode()
    {
        return EyeColor.GetHashCode() ^ PhiltrumWidth.GetHashCode();
    }
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
    // TODO: implement equality and GetHashCode() methods
    public override bool Equals(object? obj)
    {
        if(obj is Identity other)
        {
            return this.Email == other.Email &&
                   this.FacialFeatures.Equals(other.FacialFeatures);
        }
        return false;
    }

    public override int GetHashCode()
    {
        return Email.GetHashCode() ^ FacialFeatures.GetHashCode();
    }
}

public class Authenticator
{
    private readonly Identity adminIdentity = new(
        "admin@exerc.ism",
        new FacialFeatures("green", 0.9m)
    );

    private HashSet<Identity> registeredIdentities = new();

    public static bool AreSameFace(FacialFeatures faceA, FacialFeatures faceB)
    {
        return faceA.Equals(faceB);
    }

    public bool IsAdmin(Identity identity)
    {
        return adminIdentity.Equals(identity);
    }

    public bool Register(Identity identity)
    {
        if (!IsRegistered(identity))
        {
            registeredIdentities.Add(identity);
            return true;
        }
        return false;
    }

    public bool IsRegistered(Identity identity)
    {
        return registeredIdentities.Contains(identity);
    }

    public static bool AreSameObject(Identity identityA, Identity identityB)
    {
        return identityA == identityB;
    }
}
