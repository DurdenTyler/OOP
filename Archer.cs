namespace ConsoleApp1;

public class Archer: Unit
{
    public int ArrowsCount { get; private set; }

    public Archer(int arrowsCount, int damage)
    {
        ArrowsCount = arrowsCount;
        Damage = damage;
    }

    public override void Attack()
    {
        Console.WriteLine($"Archer attacks, he has {ArrowsCount} arrows, an arrow will take {Damage} damage");
    }
}