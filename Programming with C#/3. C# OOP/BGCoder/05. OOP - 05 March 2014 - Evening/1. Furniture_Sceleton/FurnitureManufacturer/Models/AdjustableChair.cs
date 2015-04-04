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

    public class AdjustableChair : Chair, IAdjustableChair, IChair, IFurniture, IFurnitureFactory
    {
        //private const int InitialValue = 0;

        //private int numberOfLegs;

        public AdjustableChair(string model, string material, decimal price, decimal height, int numberOfLegs)
            : base(model, material, price, height, numberOfLegs)
        {            
        }

        public void SetHeight(decimal height)
        {
            this.Height = height;
        }
    }
}
