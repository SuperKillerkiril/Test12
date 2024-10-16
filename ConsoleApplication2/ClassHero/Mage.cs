using ConsoleApplication2.AllInterface;

namespace ConsoleApplication2.ClassHero
{
    public class Mage : AllMob, ICharacter
    {
        public void Defend()
        {
            DefenseX = 2;
            DefensePoint *= DefenseX;
        }
        public void Attack()
        {
            AttackP = 100 % DefenseX;
        }
    }
}