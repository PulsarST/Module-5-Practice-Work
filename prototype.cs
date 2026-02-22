namespace module5cw;

public class Character(Weapon weapon, Armor armor, Skill skill) : ICloneable
{
    public Weapon Weapon { get; set; } = weapon;
    public Armor Armor { get; set; } = armor;
    public Skill Skill { get; set; } = skill;

    public object Clone()
    {
        return new Character((Weapon)Weapon.Clone(), (Armor)Armor.Clone(), (Skill)Skill.Clone());
    }
}

public class Weapon(int damage) : ICloneable
{
    public int Damage { get; private set; } = damage;

    public object Clone()
    {
        return new Weapon(Damage);
    }
}

public class Armor(int defence) : ICloneable
{
    public int Defence { get; private set; } = defence;

    public object Clone()
    {
        return new Armor(Defence);
    }
}

public class Skill(int mana) : ICloneable
{
    public int Mana { get; private set; } = mana;

    public object Clone()
    {
        return new Skill(Mana);
    }
}
