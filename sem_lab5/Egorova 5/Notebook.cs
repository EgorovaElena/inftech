using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Egorova_5
{
    abstract class Notebook : IPaper
    {
        int amount_of_sheets;
        string size_of_sheets;

        public Notebook(int amount_of_sheets, string size_of_sheets)
        {
            this.amount_of_sheets = amount_of_sheets;
            this.size_of_sheets = size_of_sheets;
        }

        public bool paper_colored { get; set; }

        public void paint_paper()
        {
            paper_colored = true;
        }

        public void wipe_off_paint()
        {
            paper_colored = false;
        }
        public int get_amount_of_sheets()
        {
            return amount_of_sheets;
        }

        public string get_size_of_sheets()
        {
            return size_of_sheets;
        }
    }
}
