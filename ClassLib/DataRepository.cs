using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLib
{
    public class DataRepository
    {
        public List<DataSet1> GetSampleData()
        {
            return new List<DataSet1>
        {
            new DataSet1 { Id = 1, Name = "Hasan Monsur" },
            new DataSet1 { Id = 2, Name = "Linux RDLC Report" },
            new DataSet1 { Id = 3, Name = "ReportViewerCore.NETCore Test" }
        };
        }
    }
}
