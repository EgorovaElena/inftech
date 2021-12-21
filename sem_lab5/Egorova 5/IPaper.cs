using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Egorova_5
{
    interface IPaper
    {
        bool paper_colored
        {
            get;
            set;
        }

        void paint_paper();
        void wipe_off_paint();
        
    }
}
