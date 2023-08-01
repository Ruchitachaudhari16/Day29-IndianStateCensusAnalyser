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
        public static string inCorrectTypePath = @"C:\RFP288Batch\IndianCensusAnalyserDay29\Day29-IndianStateCensusAnalyser\IndianStatesCensusAnalser\IndianStatesCensusAnalser\Files\StateCensusData.txt";

        //TC 1:-Records matches
        [Test]
        public void GivenStateCensusData_WhenAnalyzed_ShouldReturnNoOfRecordsMatches()
        {
            CSV_Census cSV_Census = new CSV_Census();
            Assert.AreEqual(cSV_Census.ReadStateCensusData(stateCensusCSVFile_Path), stateCensusAnalyser.ReadStateCensusData(stateCensusCSVFile_Path));
        }
        //TC2:-Incorrect File Path
        [Test]
        public void givenstatecensus_csv_file_incorrectreturns_customexception()
        {
            try
            {
                int records = stateCensusAnalyser.ReadStateCensusData(inCorrect_Path);
            }
            catch (Exception ex)
            {
                Assert.AreEqual(ex.Message,"file  not found");
            }
        }

        //TC3:-Incorrect file type 
        [Test]
        public void GivenStateCensus_CSV_File_CorrectBut_Type_IncorrectReturns_CustomException()
        {

            try
            {
                CSV_Census cSV_Census = new CSV_Census();
                int records = cSV_Census.ReadStateCensusData(inCorrectTypePath);
            }
            catch (StateCensusException ex)
            {
                Assert.AreEqual(ex.Message, "File isnt CSV type");
            }
        }
    }
}
       
    

