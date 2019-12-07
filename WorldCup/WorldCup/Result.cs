using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorldCup
{   
    // This Class use to mangage Teem Result as they Enter Each Play Round 
    // Which is handle the job to call the DatabaseConnector Class and Divier their record
    public class Result
    {
        public Teem teem { set; get; }
        public int writeResultToDatabase()
        {

            return 0;
        }
    }
}
