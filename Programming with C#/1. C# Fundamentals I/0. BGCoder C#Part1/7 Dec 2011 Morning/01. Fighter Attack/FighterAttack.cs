using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Fighter_Attack
{
    class FighterAttack
    {
        static void Main(string[] args)
        {
            int pX1 = int.Parse(Console.ReadLine());
            int pY1 = int.Parse(Console.ReadLine());
            int pX2 = int.Parse(Console.ReadLine());
            int pY2 = int.Parse(Console.ReadLine());
            int fX = int.Parse(Console.ReadLine());
            int fY = int.Parse(Console.ReadLine());
            int d = int.Parse(Console.ReadLine());

            int down;
            int top;
            int left;
            int right;


            if (pX1 < pX2)
            {
                left = pX1;
                right = pX2;
            }
            else
            {
                left = pX2;
                right = pX1;
            }

            if (pY1 < pY2)
            {
                down = pY1;
                top = pY2;
            }
            else
            {
                down = pY2;
                top = pY1;
            }

            Console.WriteLine("{0}%", CalculateDamige(down, top, left, right, fX, fY, d));

        }

        private static int CalculateDamige(int down, int top, int left, int right, int fX, int fY, int d)
        {
            int newX = fX + d;
            int damag = 0;

            // 0 damage
            if (fY < down - 1 || fY > top + 1 || newX < left - 1 || newX > right)
            {
                return damag;
            }

            // 75% damage
            if (fY >= down && fY <= top && newX == left - 1)
            {
                return damag = 75;
            }

            // 50% damage
            if ((fY == down - 1 || fY == top + 1) && newX >= left && newX <= right)
            {
                return damag = 50;
            }

            //100%
            if (fY == down && fY == top && newX == left && newX == right)
            {
                return damag = 100;
            }

            // 150% damage
            if ((fY == down || fY == top) && newX == right)
            {
                return damag = 150;
            }

            // 200% damage
            if (fY >= down + 1 && fY <= top - 1 && newX == right)
            {
                return damag = 200;
            }

            // 225% damage
            if ((fY == down || fY == top) && newX >= left && newX <= right - 1)
            {
                return damag = 225;
            }

            // 275% damage
            if (fY >= down + 1 && fY <= top - 1 && newX >= left && newX <= right - 1)
            {
                return damag = 275;
            }
            
            return damag;
        }
    }
}
