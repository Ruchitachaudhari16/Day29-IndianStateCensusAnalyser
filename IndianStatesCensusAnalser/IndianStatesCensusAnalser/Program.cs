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
            StateCensusAnalyser stateCensusAnalyser = new StateCensusAnalyser();
            stateCensusAnalyser.ReadStateCensusData(path);
            Console.ReadLine();
        }
    }
}
    
