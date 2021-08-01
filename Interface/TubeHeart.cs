using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    class TubeHeart : IHeart
    {
        public double Price { get; set; }
        public double HeartRate { get; set; }

        public string GetStatus()
        {
            string statusOfHeart = Convert.ToString(Price);
            string heartRate = Convert.ToString(HeartRate);
            return "Price: " + statusOfHeart + ", rate:" + heartRate;
        }

    public void Connect()
        {
            Console.WriteLine("tube heart is installed.");
        }
    }
}
