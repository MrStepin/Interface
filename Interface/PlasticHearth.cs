using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    class PlasticHearth : IHeart
    {
        public double HeartRate { get; set; }
        public int SerialNumber { get; set; }
        public string GetStatus()
        {
            string statusOfHeart = Convert.ToString(SerialNumber);
            string heartRate = Convert.ToString(HeartRate);
            return "Serial number: " + statusOfHeart + ", rate:" + heartRate;
        }
        public void Connect()
        {
            Console.WriteLine("plastic heart is installed.");
        }
    }
}
