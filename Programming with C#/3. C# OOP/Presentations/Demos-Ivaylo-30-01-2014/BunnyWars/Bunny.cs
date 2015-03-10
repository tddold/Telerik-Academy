namespace Bunnies
{
    using System;
    using Animals;

    public class Bunny : Animal
    {
        private const int InitialHealth = 200;
        private const int InitialCarrots = 0;

        private ColorType color;
        private ulong carrotsCount;

        public Bunny(string bunnyName)
        {
            this.Name = bunnyName;
            this.Health = InitialHealth;
            this.carrotsCount = InitialCarrots;
            this.IsRetired = false;
        }

        public Bunny(string bunnyName, ColorType playerColor)
            : this(bunnyName)
        {
            this.Color = playerColor;
        }

        public ColorType Color
        {
            get
            {
                return this.color;
            }
            set
            {
                this.color = value;
            }
        }

        public bool IsRetired { get; private set; }

        public ulong AddCarrots(uint carrots)
        {
            this.carrotsCount += carrots;
            return this.carrotsCount;
        }

        public void Retire()
        {
            if (this.Health < 0)
            {
                this.IsRetired = true;
            }
        }

        public int Damage
        {
            get
            {
                if (this.Health < 0)
                {
                    return InitialHealth;
                }

                int damage = InitialHealth - this.Health;

                return damage;
            }
        }

        public override string ToString()
        {
            return this.Name + " " + this.Health;
        }
    }
}
