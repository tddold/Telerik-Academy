namespace Events
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    //Class that subscribes to an event
    class Subscriber
    {
        private string id;

        public Subscriber(string id, Publisher pub)
        {
            this.ID = id;
            pub.RaiseCustomEvent += HandleCustomEvent;
        }

        public string ID 
        {
            get { return this.id; }
            private set { this.id = value; }
        }

         // Define what actions to take when the event is raised. 
        void HandleCustomEvent(object sender, EventArgs e)
        {
            Console.WriteLine("\nThis is how the event is handled:\n");
            Console.WriteLine(this.id + " receved this message: ");
            
        }
    }
}
