using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grupp_3_CI_CD
{
    public class Opersion
    {
        public long personmmerToInt(string personnummer)
        {
            // om personnummer varit 12 sif så det tar bort första 19 
            // person nummert ska vara 10 sif
            long result = 0;
            personnummer = personnummer.Replace("-","");
            if(personnummer.Length > 10)
            {
                personnummer = personnummer.Substring(2);
                result = Convert.ToInt64(personnummer);
                return result;
            }
            if(personnummer.Length < 10)
            {
                return 0;
            }
            result = Convert.ToInt64(personnummer);
            return result;
        }

        public bool checkPersonNummer(string personnummer)
        {
            // // mikael 
            // // kollar om person nummert är korekt eller inte
            return true;
        }

        public string Gender(string personmmer)
        {
            //     // säga till om person nummert är män eller kvinna ! 

            return " ";
        }
    }
}
