namespace ConsoleApp1;

public class Knight: Unit
{
    public string SwordName { get; set; }
    
    public override void Attack()
    {
        Console.WriteLine($"Knight attacks enemy his {SwordName} sword, damage is {Damage} ");
    }
}