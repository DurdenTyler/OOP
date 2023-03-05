namespace ConsoleApp1;

public abstract class Unit
{
    public int Damage { get; set; }
    public abstract void Attack(); // значит что потомки должны будут переопределить этот метод
}