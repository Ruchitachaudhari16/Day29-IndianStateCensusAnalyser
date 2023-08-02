using CsvHelper;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndianStatesCensusAnalser
{
    public class CSVState
    {
        public void DisplayData(string path)
        {
            using (var read = new StreamReader(path))
            {
                using (var records = new CsvReader(read, CultureInfo.InvariantCulture))
                {
                    var data = records.GetRecords<CSVCodeModel>().ToList();
                    foreach (var record in data)
                    {
                        Console.WriteLine(record.SrNo + "  " + record.StateName + "  " + record.TIN + "  " + record.StateCode + "  ");
                    }

                }
            }
        }
    }
}
