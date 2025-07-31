[Flags]
public enum Allergen : byte
{
    Eggs = 0b0000_0001,
    Peanuts = 0b0000_0010,
    Shellfish = 0b0000_0100,
    Strawberries = 0b0000_1000,
    Tomatoes = 0b0001_0000,
    Chocolate = 0b0010_0000,
    Pollen = 0b0100_0000,
    Cats = 0b1000_0000,
}

public class Allergies
{
    private readonly int mask;

    public Allergies(int mask)
    {
        this.mask = mask;
    }

    public bool IsAllergicTo(Allergen allergen)
        => (mask & (int)allergen) == (int)allergen;

    public Allergen[] List()
        => Enum.GetValues<Allergen>()
            .Where(allergen => IsAllergicTo(allergen))
            .ToArray();
    
}