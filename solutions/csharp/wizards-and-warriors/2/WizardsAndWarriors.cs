abstract class Character
{
    private readonly string characterType;

    protected Character(string characterType)
    {
        this.characterType = characterType;
    }

    public abstract int DamagePoints(Character target);

    public virtual bool Vulnerable() => false;

    public override string ToString() => $"Character is a {characterType}";
    
}

class Warrior : Character
{
    public Warrior() : base(nameof(Warrior))
    {
    }

    public override int DamagePoints(Character target) =>
        target.Vulnerable() ? 10 : 6;
}

class Wizard : Character
{
    private bool isSpellPrepared;
    public Wizard() : base(nameof(Wizard))
    {
    }

    public override int DamagePoints(Character target) =>
        isSpellPrepared ? 12 : 3;

    public void PrepareSpell() => isSpellPrepared = true;

    public override bool Vulnerable() => !isSpellPrepared;
    
}
