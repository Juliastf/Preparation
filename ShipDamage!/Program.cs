using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShipDamage_
{
    class Program
    {
        static void Main(string[] args)

        {
            int shipX1 = int.Parse(Console.ReadLine());
            int shipY1 = int.Parse(Console.ReadLine());
            int shipX2 = int.Parse(Console.ReadLine());
            int shipY2 = int.Parse(Console.ReadLine());
            int horizon = int.Parse(Console.ReadLine());
            int catapult1X1 = int.Parse(Console.ReadLine());
            int catapult1Y1 = int.Parse(Console.ReadLine());
            int catapult2X2 = int.Parse(Console.ReadLine());
            int catapult2Y2 = int.Parse(Console.ReadLine());
            int catapult3X3 = int.Parse(Console.ReadLine());
            int catapult3Y3 = int.Parse(Console.ReadLine());

            int hitCat1 = CalculateHitPoint(catapult1Y1, horizon);
            int hitCat2 = CalculateHitPoint(catapult2Y2, horizon);
            int hitCat3 = CalculateHitPoint(catapult3Y3, horizon);

            int totalDamage = 0;
            int damageCatapult1 = CalculateDamage(catapult1X1, hitCat1, shipX1, shipY1, shipX2, shipY2);
            int damageCatapult2 = CalculateDamage(catapult2X2, hitCat2, shipX1, shipY1, shipX2, shipY2);
            int damageCatapult3 = CalculateDamage(catapult3X3, hitCat3, shipX1, shipY1, shipX2, shipY2);
            totalDamage = damageCatapult1 + damageCatapult2 + damageCatapult3;
            Console.WriteLine(totalDamage+"%");

        }

        private static int CalculateDamage(int hitPointX1, int hitPointY1, int shipX1, int shipY1, int shipX2, int shipY2)
        {
            int damage = 0;
            int minX = Math.Min(shipX1, shipX2);
            int maxX = Math.Max(shipX1, shipX2);
            int minY = Math.Min(shipY1, shipY2);
            int maxY = Math.Max(shipY1, shipY2);

            if ((hitPointX1 == minX && hitPointY1 == minY) || (hitPointX1 == minX && hitPointY1 == maxY) || (hitPointX1 == maxX && hitPointY1 == minY) ||
                (hitPointX1 == maxX && hitPointY1 == maxY))
            {
                damage = 25;
            }
            else if ((hitPointX1==minX&&hitPointY1>minY&&hitPointY1<maxY)||(hitPointX1==maxX&& hitPointY1 > minY && hitPointY1 < maxY)||
                (hitPointY1==minY&&hitPointX1>minX&&hitPointX1<maxX)||(hitPointY1 == maxY && hitPointX1 > minX && hitPointX1 < maxX))
            {
                damage = 50;
            }
            else if (hitPointX1 >=minX&&hitPointX1<=maxX && hitPointY1 >= minY && hitPointY1 <= maxY)
            {
                damage = 100;
            }

            return damage;
        }

        private static int CalculateHitPoint(int catapultY, int horizon)
        {
            int hitPoint = 0;
            int distance = 0;
            if (catapultY >= 0 && horizon <= 0)
            {
                distance = Math.Abs(catapultY) + Math.Abs(horizon);
                hitPoint = horizon - distance;
            }
            else if (catapultY < 0 && horizon >= 0)
            {
                distance = Math.Abs(catapultY) + Math.Abs(horizon);
                hitPoint = horizon + distance;
            }
            else if (catapultY < 0 && horizon < 0)
            {
                if (catapultY > horizon)
                {
                    distance = Math.Abs(horizon) - Math.Abs(catapultY);
                    hitPoint = horizon - distance;
                }
                else
                {
                    distance = Math.Abs(catapultY) - Math.Abs(horizon);
                    hitPoint = horizon + distance;
                }

            }
            else if (catapultY >= 0 && horizon > 0)
            {
                if (catapultY > horizon)
                {
                    distance = Math.Abs(catapultY) - Math.Abs(horizon);
                    hitPoint = horizon - distance;
                }
                else
                {
                    distance = Math.Abs(horizon) - Math.Abs(catapultY);
                    hitPoint = horizon + distance;
                }
            }
            return hitPoint;
        }
    }
}
