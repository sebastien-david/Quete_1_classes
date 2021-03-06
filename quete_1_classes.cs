using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    class Program
    {
        public class Character
        {
            public string name;
            public int PV;
            public int attackPoint;
            public int defensePoint;

            public bool IsAlive()
            {

                if (PV > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }

            public void Attack(Character character2)
            {
                character2.PV = (character2.PV) - (attackPoint - character2.defensePoint);

            }
        }
        static void Main(string[] args)
        {
            Character J1 = new Character();
            Character J2 = new Character();

            J1.name = "joueur 1";
            J1.PV = 100;
            J1.attackPoint = 20;
            J1.defensePoint = 10;

            J2.name = "joueur 2";
            J2.PV = 200;
            J2.attackPoint = 40;
            J2.defensePoint = 20;

            while (J2.IsAlive() && J1.IsAlive())
            {
                J1.Attack(J2);
                J2.Attack(J1);
            }

            if (J1.IsAlive())
            {
                Console.Write(" Le joueur 1 a gagné ");
                Console.ReadLine();
            }
            else if (J2.IsAlive())
            {
                Console.Write(" Le joueur 2 a gagné ");
                Console.ReadLine();
            }
        }
    }
}
