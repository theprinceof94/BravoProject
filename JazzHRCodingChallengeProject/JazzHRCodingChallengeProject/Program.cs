using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JazzHRCodingChallengeProject
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Customer> customerList = new List<Customer>();
            Customer widget = new Customer("Widget Co");
            Customer syn = new Customer("Synergy Inc");
            Customer elev = new Customer("Elevation Executives");
            Customer mome = new Customer("Momentum Partners");

            customerList.Add(widget);
            customerList.Add(syn);
            customerList.Add(elev);
            customerList.Add(mome);

            Assign(customerList);

            Console.Write(widget.Group.ToString());

        }

        public static void Assign(List<Customer> customerList)
        {
            Random random = new Random();
            double roll;

            string featureA = "Feature A";
            string featureB = "Feature B";
            string featureC = "Feature C";
            string featureD = "Feature D";

            List<string> g1features = new List<string>();
            g1features.Add(featureA);
            g1features.Add(featureB);

            Group group1 = new Group(g1features);

            List<string> g2features = new List<string>();
            g2features.Add(featureB);
            g2features.Add(featureC);

            Group group2 = new Group(g2features);

            List<string> g3features = new List<string>();
            g3features.Add(featureC);

            Group group3 = new Group(g3features);

            List<string> g4features = new List<string>();
            g4features.Add(featureA);
            g4features.Add(featureC);
            g4features.Add(featureD);

            Group group4 = new Group(g4features);


            foreach (Customer c in customerList)
            {
                roll = random.NextDouble();
                if(roll<0.10)
                {
                    c.Group = group1;
                }
                else if(roll<0.3 && roll>0.1)
                {
                    c.Group = group2;
                }
                else if(roll<0.5 && roll>0.30)
                {
                    c.Group = group3;
                }
                else
                {
                    c.Group = group4;
                }
            }
        }
    }
    class Customer
    {
        public Group Group { get; set; }
        public string Name { get; set; }
        public Customer(string customerName)
        {
            this.Name = customerName;
        }
    }
    class Group
    {
        public Group( List<string> groupFeatures)
        {

        }
    }
}
