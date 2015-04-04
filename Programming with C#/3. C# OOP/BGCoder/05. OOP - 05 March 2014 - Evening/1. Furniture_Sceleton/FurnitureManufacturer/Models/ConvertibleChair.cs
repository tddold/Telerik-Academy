namespace FurnitureManufacturer.Models
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    using Engine.Factories;
    using Interfaces;
    using Interfaces.Engine;
    using Engine;
    using Common;

    public class ConvertibleChair : Chair, IConvertibleChair, IChair, IFurniture, IFurnitureFactory
    {
        private const int InitialValue = 0;
        private const decimal ConvertedHeght = 0.10M;

        private bool isConverted = false;

        public ConvertibleChair(string model, string material, decimal price, decimal height, int numberOfLegs)
            : base(model, material, price, height, numberOfLegs)
        {

        }

        public bool IsConverted
        {
            get
            {
                return this.isConverted;
            }
        }

        public void Convert()
        {
            if (this.isConverted)
            {
                this.isConverted = false;
            }
            else
            {
                this.isConverted = true;
            }
        }

        public override decimal Height
        {
            get
            {

                if (this.isConverted)
                {
                    return ConvertedHeght;
                }
                else
                {
                    return base.Height;

                }
            }
            protected set
            {
                base.Height = value;
            }
        }

        public override string ToString()
        {
            return base.ToString() + string.Format(", State: {0}", this.IsConverted ? "Converted" : "Normal");
        }
    }
}
