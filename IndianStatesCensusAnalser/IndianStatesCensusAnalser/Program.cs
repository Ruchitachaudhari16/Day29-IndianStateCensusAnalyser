using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndianStatesCensusAnalser
{
    public class Program
    {

        public static string path = @"C:\RFP288Batch\IndianCensusAnalyserDay29\Day29-IndianStateCensusAnalyser\IndianStatesCensusAnalser\IndianStatesCensusAnalser\Files\StateCensusData.csv";
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Enter Your Choose");
                Console.WriteLine("1-File Exists or not ");
                Console.WriteLine("2-File extension");
                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        Console.WriteLine(path);
                        StateCensusAnalyser stateCensusAnalyser = new StateCensusAnalyser();
                        stateCensusAnalyser.ReadStateCensusData(path);
                        break;
                    case 2:
                        CSV_Census cSV_Census = new CSV_Census();
                        cSV_Census.ReadStateCensusData(path);
                        break;
                        Console.ReadLine();
                }
            }
        }
    }
}
    
