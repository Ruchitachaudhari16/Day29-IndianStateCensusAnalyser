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
        public static string pathStateCode = @"C:\RFP288Batch\IndianCensusAnalyserDay29\Day29-IndianStateCensusAnalyser\IndianStatesCensusAnalser\IndianStatesCensusAnalser\Files\StateCodeData.csv";
        static void Main(string[] args)
        {
            CSVState cSV_State = new CSVState();
            cSV_State.DisplayData(pathStateCode);
            Console.ReadLine();

          
                }
            }
        }
    
    
