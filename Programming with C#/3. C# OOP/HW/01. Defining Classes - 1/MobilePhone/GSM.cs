namespace MobilePhone
{
    using System;
    using System.Text;

    public class GSM
    {
        // defining the mobile phone information (fields)
        private string model;
        private string manufacturer;
        private string owner;
        private decimal price;
        private Battery battery;
        private Display display;

        // making the constructor
        public GSM()
        {
        
        }
        
        public GSM(string model = null, string manufacturer = null, string owner = null, decimal price = 0 )
        {
            this.model = model;
            this.manufacturer = manufacturer;
            this.owner = owner;
            this.price = price;
            //this.Battery = battery;
            //this.Dysplay = display;
        }

        // making the properties - making it public so it can be adjusted by the outside
        public string Model
        {
            get { return this.model; }

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
            get { return this.manufacturer; }

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
            get { return this.owner; }

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
            get { return this.price; }

            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Incorect price!");
                }

                this.price = value;
            }
        }

        //public Battery Battery
        //{
        //    get { return this.battery; }

        //    set
        //    {
        //        if (value == null)
        //        {
        //            throw new ArgumentException("Incorect battery parametars!");
        //        }

        //        this.battery = value;
        //    }
        //}

        //public Display Dysplay
        //{
        //    get { return this.display; }
        //    set
        //    {
        //        //if (true)
        //        //{
                    
        //        //}

        //        this.display = value;
        //    }
        //}


        //overriding ToString() method
        public override string ToString()
        {
            StringBuilder informations = new StringBuilder();

            informations.AppendLine(string.Format("Model:        --> {0,5}", model));
            informations.AppendLine(string.Format("Manufacturer: --> {0}", manufacturer));
            informations.AppendLine(string.Format("Owner:        --> {0,5}", owner));
            informations.AppendLine(string.Format("Price:        --> {0,5:F2}lv", price));
            return informations.ToString();
        }

       
    }
}
