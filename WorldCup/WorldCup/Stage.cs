using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorldCup
{
    class Stage
    {
        List<Teem> teems = new List<Teem>();
        public bool InitcheckTeem()
        {
            bool checkfag=false;
            foreach (var item in teems)
            {
                if (item.listOfPlayer.Count>7 || item.listOfPlayer.Count <15)
                {
                    checkfag = true;
                }
                if (true)
                {

                }
            }
            return checkfag;
        }

    }
}
