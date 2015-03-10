namespace Bunnies
{
    public class AirCraft
    {
        public static double CalculateDistance(AirCraft first, AirCraft second)
        {
            double xDistance = (first.Coordinates.X - second.Coordinates.X) * (first.Coordinates.X - second.Coordinates.X);
            double yDistance = (first.Coordinates.Y - second.Coordinates.Y) * (first.Coordinates.Y - second.Coordinates.Y);

            return System.Math.Sqrt(xDistance + yDistance);
        }

        public int Id { get; set; }

        public string Name { get; set; }

        public int Damage { get; set; }

        public Bunny Pilot { get; private set; }

        public Coordinates Coordinates { get; private set; }

        public AirCraft(Bunny bunny, int damage)
        {
            this.Pilot = bunny;
            this.Damage = damage;
            this.Coordinates = new Coordinates();
        }

        public void Attack(AirCraft target)
        {
            if (this.Pilot.Color == target.Pilot.Color)
            {
                return;
            }

            target.Pilot.Health -= this.Damage;
        }

        public void Move(Coordinates coor)
        {
            this.Coordinates.X = coor.X;
            this.Coordinates.Y = coor.Y;
        }
    }
}
