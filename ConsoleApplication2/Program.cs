using ConsoleApplication2.ClassHero;

namespace ConsoleApplication2
{
    public class Program
    {
        public void Main()
        {
            Warrior userWarrior = new Warrior();
            userWarrior.Attack();
            userWarrior.Defend();
            Mage userMage = new Mage();
            userMage.Attack();
            userMage.Defend();
        }
    }
}