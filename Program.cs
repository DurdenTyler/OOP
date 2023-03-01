


using ConsoleApp1;

var knight = new Knight();
var archer = new Archer();
var mage = new Mage();

knight.SwordName = "Escalibur";
knight.Damage = 100;

archer.ArrowsCount = 60;
archer.Damage = 12;

mage.MagicColor = "Red";
mage.Damage = 65;

knight.Attack();
archer.Attack();
mage.Attack();


Unit hero = null;
hero = knight;  // Неявнное преобразование типа Upcasting
hero.Attack();