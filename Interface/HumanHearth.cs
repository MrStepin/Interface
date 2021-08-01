using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    class HumanHearth : IHeart
    {
        public double HeartRate { get; set; }
        public string PreviousOwnerName { get; set; }

        public string GetStatus()
        {
            string statusOfHeart = PreviousOwnerName;
            string heartRate = Convert.ToString(HeartRate);
            return "Previous owner: " + statusOfHeart + ", rate:" + heartRate;
        }
        public void Connect()
        {
            Console.WriteLine("human heart is installed.");
        }
    }
}
