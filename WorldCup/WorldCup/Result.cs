using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorldCup
{

    /// <summary>Class <c>Result</c> 
    /// <list>This Class use to mangage Teem Result as they Enter Each Play Round </list>
    /// <list> Which is handle the job to call the DatabaseConnector Class and deliver their record</list>
    /// .</summary>
    public class Result
    {
        public List<Teem> teem = new List<Teem>();
        public int writeResultToDatabase(Teem Winner, Teem Losser,int stage = 0, int ground = 0, string sroce = "")
        {
            DatabaseConnector database = new DatabaseConnector();
            if (database.WriteMatchToDB(Winner, Losser, stage, ground, sroce))
            {
                return 1;
            } else { 
            return 0; }
        }



    }
}
