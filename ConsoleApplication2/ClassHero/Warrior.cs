using ConsoleApplication2.AllInterface;

namespace ConsoleApplication2.ClassHero
{
    public class Warrior : AllMob, ICharacter 
    {
        
        public void Defend()
        {
            DefenseX = 3;
            DefensePoint *= DefenseX;
        }
        public void Attack()
        {
            AttackP = 10 - DefenseX;
        }
    }
}