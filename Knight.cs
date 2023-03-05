namespace ConsoleApp1;

public class Knight: Unit
{
    public string SwordName { get; private set; } // Значит что можем посмотреть из вне, а изменить только через метод класса

    public Knight(string swordName, int damage)
    {
        SwordName = swordName;
        Damage = damage; // досталось свойство по наследству которое определяем здесь в конструкторе
    }

    // от класса по наследству достался abstract метод который нужно переопределить здесь
    public override void Attack()
    {
        Console.WriteLine($"Knight attacks enemy his {SwordName} sword, damage is {Damage} ");
    }
}