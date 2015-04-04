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

    public abstract class Furniture : FurnitureFactory, IFurniture, IFurnitureFactory
    {
        private const int MinLenght = 3;
        private const decimal InitialPrice = 0M;
        private const decimal InitialHight = 0M;

        private string model;
        private decimal height;
        private decimal price;

        public Furniture(string model, string material, decimal price, decimal height)
        {
            this.Model = model;
            this.Material = material;
            this.Price = price;
            this.Height = height;
        }

        public virtual string Model
        {
            get
            {
                return this.model;
            }

            protected set
            {
                Validator.CheckIfStringIsNullOrEmptyOrMinLenght(value, MinLenght, "Model cannot be empty, null or with less than 3 symbols!");

                this.model = value;
            }
        }

        public virtual string Material { get; protected set; }


        public virtual decimal Price
        {
            get
            {
                return this.price;
            }
            set
            {
                Validator.CheckIfPriceOrHightIsNull(value, InitialPrice, "Price cannot be less or equal to $0.00!");

                this.price = value;
            }
        }

        public virtual decimal Height
        {
            get
            {
                return this.height;
            }

            protected set
            {
                if (value <= InitialHight)
                {
                    throw new ArgumentOutOfRangeException("Height cannot be less or equal to 0.00 m!");
                }

                this.height = value;
            }
        }

        public override string ToString()
        {
            var sb = new StringBuilder();

           // sb.AppendLine(base.ToString());

            sb.AppendLine(string.Format("Type: {0}, Model: {1}, Material: {2}, Price: {3}, Height: {4}", this.GetType().Name, this.Model, this.Material, this.Price, this.Height));
                    
             return sb.ToString().TrimEnd();
        }
    }
}
