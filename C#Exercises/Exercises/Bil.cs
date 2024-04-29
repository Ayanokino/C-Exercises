using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Exercises
{
    public class Bil
    {
       private int _aargang;
        public int Aargang
        {
            get { return _aargang; }
            set { _aargang = value; }
        }
        public Bil()
        {

        }
        public decimal Pris()
        {
            return 100000m;
        }
    }
}
