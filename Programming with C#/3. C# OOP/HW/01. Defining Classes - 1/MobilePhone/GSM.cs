﻿namespace MobilePhone
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class GSM
    {
        private const decimal PricePerMinet = 0.30M;

        // defining the mobile phone information (fields)
        private static GSM iPhone4S; 
        /* new GSM(
            model = "iPhone5S", manufacturer = "Apple", owner = "Gosho Goshev", price = 800,
            new Battery(BatteryType.LiPo, "1560mAh", 250, 10),
            new Display(4, 16000000));*/
       
        private string model;
        private string manufacturer;
        private string owner;
        private decimal price;
        private Battery battery;
        private Display display;
        private GSMCallHistoryTest calls;

        private List<Call> callHistory;

        // making the constructor
        public GSM()
        {
        }

        public GSM(string model = null, string owner = null, decimal price = 0)
        {
            this.model = model;
            this.owner = owner;
            this.price = price;
            this.callHistory = new List<Call>();
        }

        public GSM(string model = null, string manufacturer = null, string owner = null, decimal price = 0)
            : this(model, owner, price)
        {
            this.manufacturer = manufacturer;
        }

        public GSM(string model = null, string manufacturer = null, string owner = null, decimal price = 0, Battery battery = null, Display display = null)
            : this(model, manufacturer, owner, price)
        {
            this.PhoneBattery = battery;
            this.PhoneDisplay = display;
        }

        // making the properties - making it public so it can be adjusted by the outside
        public string Model
        {
            get
            {
                return this.model;
            }

            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Incorect model!");
                }

                this.model = value;
            }
        }

        public string Manufacturer
        {
            get
            {
                return this.manufacturer;
            }

            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Incorect manufacturer!");
                }

                this.manufacturer = value;
            }
        }

        public string Owner
        {
            get
            {
                return this.owner;
            }

            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Incorect owner!");
                }

                this.owner = value;
            }
        }

        public decimal Price
        {
            get
            {
                return this.price;
            }

            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Incorect price!");
                }

                this.price = value;
            }
        }

        public Battery PhoneBattery
        {
            get
            {
                return this.battery;
            }

            set
            {
                // if (value == null)
                // {
                //    throw new ArgumentException("Incorect battery parametars!");
                // }
                this.battery = value;
            }
        }

        public Display PhoneDisplay
        {
            get
            {
                return this.display;
            }

            set
            {
                // if (value == null)
                // {
                //    throw new ArgumentException("Incorect display parametars!");
                // }
                this.display = value;
            }
        }

        public GSM IPhone4S
        {
            get
            {
                return iPhone4S;
            }

            set
            {
                iPhone4S = value;
            }
        }

        public List<Call> CallHistory
        {
            get
            {
                return this.callHistory;
            }

            set
            {
                this.callHistory = value;
            }
        }

        // making a method to add a Call in my List<Calls>
        public void AddCall(string dialedNumbe, uint duration)
        {
            DateTime now = DateTime.Now;
            dialedNumbe = "+359889889889";
            duration = 120;
            this.callHistory.Add(new Call(now.Date, now.Date, dialedNumbe, duration));
        }

        // this method deletes the element by the given index
        public void DeleteCall(int index)
        {
            this.callHistory.RemoveAt(index);
        }

        // removing all elements in the List<Calls>
        public void ClearCall()
        {
            this.callHistory.Clear();
        }

        // this method call price
        public decimal CalculateTotalCallPrice(decimal pricePerMinet)
        {
            decimal totalPrice = 0;

            foreach (var call in this.callHistory)
            {
                decimal min = (decimal)TimeSpan.FromSeconds(call.Duration).TotalMinutes;
                totalPrice += min * pricePerMinet;
            }

            return totalPrice;
        }

        // overriding ToString() method
        public override string ToString()
        {
            StringBuilder informations = new StringBuilder();

            informations.AppendLine(string.Format("Model:        --> {0,5}", this.model));
            informations.AppendLine(string.Format("Manufacturer: --> {0}", this.manufacturer));
            informations.AppendLine(string.Format("Owner:        --> {0,5}", this.owner));
            informations.AppendLine(string.Format("Price:        --> {0,5:F2}lv", this.price));
            informations.AppendLine(string.Format("Battery:      --> {0}", BatteryType.LiPo));
            return informations.ToString();
        }
    }
}
