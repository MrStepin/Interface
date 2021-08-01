using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter type of heart: Tube, Human or Plastic");
            string typeOfHeart = Console.ReadLine();
            Rockfeller rockfeller = new Rockfeller();

            if (typeOfHeart == "Tube")
            {
                TubeHeart tubeHeart = new TubeHeart();
                tubeHeart.Price = 10000.0;
                tubeHeart.HeartRate = 60;
                rockfeller.InstallHeart(tubeHeart);
                Console.WriteLine(tubeHeart.GetStatus());
            }
            if (typeOfHeart == "Human")
            {
                HumanHearth humanHeart = new HumanHearth();
                humanHeart.PreviousOwnerName = "Valera";
                humanHeart.HeartRate = 70;
                rockfeller.InstallHeart(humanHeart);
                Console.WriteLine(humanHeart.GetStatus());

            }
            if (typeOfHeart == "Plastic")
            {
                PlasticHearth plasticHeart = new PlasticHearth();
                plasticHeart.SerialNumber = 2343465;
                plasticHeart.HeartRate = 65;
                rockfeller.InstallHeart(plasticHeart);
                Console.WriteLine(plasticHeart.GetStatus());
            }

            Console.ReadKey();
        }
    }
}
