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

    public class Company : CompanyFactory, ICompany, ICompanyFactory
    {
        private const int MinLenght = 5;
        private const int RegNumberLenght = 10;

        private string name;
        private string registrationNumber;
        private ICollection<IFurniture> furnitures;

        public Company(string name, string registrationNumber)
        {
            this.Name = name;
            this.RegistrationNumber = registrationNumber;
            this.furnitures = new List<IFurniture>();
        }

        public string Name
        {
            get
            {
                return this.name;
            }

            private set
            {
                Validator.CheckIfStringIsNullOrEmptyOrMinLenght(value, MinLenght, "Company name cannot be empty, null or with less than 5 symbols!");

                this.name = value;
            }


        }

        public string RegistrationNumber
        {
            get
            {
                return this.registrationNumber;
            }

            private set
            {
                if (value.Length != RegNumberLenght || !Char.IsDigit(value, 0))
                {
                    throw new ArgumentOutOfRangeException("Registration number must be exactly 10 symbols and must contain only digits!");
                }

                this.registrationNumber = value;
            }
        }

        public ICollection<IFurniture> Furnitures
        {
            get
            {
                return new List<IFurniture>(this.furnitures);
            }
        }

        public void Add(IFurniture furniture)
        {
            if (furniture == null)
            {
                throw new ArgumentNullException("Cannot be add nullble elements!");
            }

            this.furnitures.Add(furniture);
        }

        public void Remove(IFurniture furniture)
        {
            foreach (var item in furnitures)
            {
                if (item == furniture)
                {
                    this.furnitures.Remove(item);
                    break;
                }
            }
        }

        public IFurniture Find(string model)
        {
            //foreach (var item in furnitures)
            //{
            //    if (item.ToString() == model)
            //    {
            //        return item;

            //    }
            //}

            //return null;

            return this.furnitures.FirstOrDefault(x => x.Model.ToUpper() == model.ToUpper());

        }

        public virtual string Catalog()
        {
            var sb = new StringBuilder();

            var sortedFurnitures = this.furnitures
                .OrderBy(x => x.Price)
                .ThenBy(x => x.Model);

            var isFurnituresOrNo =
              this.Furnitures.Count != 0
              ? this.Furnitures.Count.ToString()
              : "no";

            var oneOrManyFurniture =
                this.Furnitures.Count != 1
                ? "furnitures"
                : "furniture";

            sb.AppendLine(string.Format("{0} - {1} - {2} {3}",
           this.Name, this.RegistrationNumber, isFurnituresOrNo, oneOrManyFurniture));

            foreach (var item in sortedFurnitures)
            {

                sb.AppendLine(item.ToString());

                //sb.AppendLine(string.Format("Type: {0}, Model: {1}, Material: {2}, Price: {3}, Height: {4}", item.GetType().Name, item.Model, item.Material, item.Price, item.Height));                
            }

            return sb.ToString().Trim();
        }

        //public override string ToString()
        //{
        //    var sb = new StringBuilder();

        //   var isFurnituresOrNo =
        //       this.Furnitures.Count != 0
        //       ? this.Furnitures.Count.ToString()
        //       : "no";

        //    var oneOrManyFurniture =
        //        this.Furnitures.Count != 1
        //        ? "furnitures"
        //        : "furniture";


        //    sb.Append(string.Format("{0} - {1} - {2} {3}",
        //        this.Name, this.RegistrationNumber, isFurnituresOrNo, oneOrManyFurniture));

        //    return sb.ToString().Trim();
        //}
    }
}
