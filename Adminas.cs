using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RenginiuBilietai2
{
    class Adminas : Prisijungimas
    {
        public override string LoginTable {
            get { 
                return "adminai"; 
            }

        } 
    }
}
