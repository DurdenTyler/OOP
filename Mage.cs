namespace ConsoleApp1;

public class Mage: Unit
{
    public string MagicColor { get; set; }
    
    public override void Attack()
    {
        Console.WriteLine($"Mage attacks {MagicColor} magic, bring to enemy {Damage} damage");
    }
}