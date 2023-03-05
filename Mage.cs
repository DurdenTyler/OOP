namespace ConsoleApp1;

public class Mage: Unit
{
    public string MagicColor { get; private set; }

    public Mage(string magicColor, int damage)
    {
        MagicColor = magicColor;
        Damage = damage;
    }

    public override void Attack()
    {
        Console.WriteLine($"Mage attacks {MagicColor} magic, bring to enemy {Damage} damage");
    }
}