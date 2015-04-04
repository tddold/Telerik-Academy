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

    public class Table : Furniture, ITable, IFurniture, IFurnitureFactory
    {
        private const decimal InitialValue = 0M;

        private decimal length;
        private decimal width;
        private decimal area;

        public Table(string model, string material, decimal price, decimal height, decimal length, decimal width)
            :base(model, material, price, height)
        {
            this.Length = length;
            this.Width = width;
            // this.Area = area;
        }

        public decimal Length
        {
            get
            {
                return this.length;
            }

            private set
            {
                Validator.CheckIfPriceOrHightIsNull(value, InitialValue, "Length cannot be 0!");

                this.length = value;
            }
        }

        public decimal Width
        {
            get
            {
                return this.width;
            }

            private set
            {
                Validator.CheckIfPriceOrHightIsNull(value, InitialValue, "Width cannot be 0!");

                this.width = value;
            }
        }

        public decimal Area
        {
            get
            {
                return this.length * this.width;
            }
        }

        

        public override string ToString()
        {
            return base.ToString() + string.Format(", Length: {0}, Width: {1}, Area: {2}",  this.Length, this.Width, this.Area);

            
        }
    }
}
