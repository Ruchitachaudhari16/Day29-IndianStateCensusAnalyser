using IndianStatesCensusAnalser;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace IndianStatesCensusAnalyser_Test
{
    public class StateCensus_Test
    {
        StateCensusAnalyser stateCensusAnalyser = new StateCensusAnalyser();
        public static string stateCensusCSVFile_Path = @"C:\RFP288Batch\IndianCensusAnalyserDay29\Day29-IndianStateCensusAnalyser\IndianStatesCensusAnalser\IndianStatesCensusAnalser\Files\StateCensusData.csv";
       public static string inCorrect_Path =@"C:\RFP288Batch\IndianCensusAnalyserDay29\Day29-IndianStateCensusAnalyser\IndianStatesCensusAnalser\IndianStatesCensusAnalser\Files";


        [Test]
        public void GivenStateCensusData_WhenAnalyzed_ShouldReturnNoOfRecordsMatches()
        {
            CSV_Census cSV_Census = new CSV_Census();
            Assert.AreEqual(cSV_Census.ReadStateCensusData(stateCensusCSVFile_Path), stateCensusAnalyser.ReadStateCensusData(stateCensusCSVFile_Path));
        }
        [Test]
        public void givenstatecensus_csv_file_incorrectreturns_customexception()
        {
            try
            {
                int records = stateCensusAnalyser.ReadStateCensusData(inCorrect_Path);
            }
            catch (Exception ex)
            {
                Assert.AreEqual(ex.Message,"file is not found");
            }
        }
       
    }
}

