using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Egorova_5
{
    class Notebook_for_drawing : Notebook
    {
        int price;
        bool isPresent;

        public Notebook_for_drawing(int price, bool isPresent, int amount_of_sheets, string size_of_sheets) 
            : base(amount_of_sheets, size_of_sheets)
        {
            this.price = price;
            this.isPresent = isPresent;
        }

        public int get_price()
        {
            return price;
        }

        public void set_price(int price)
        {
            this.price = price;
        }

        public bool get_isPresent()
        {
            return isPresent;
        }

        public void set_isPresent(bool isPresent)
        {
            this.isPresent = isPresent;
        }
    }
}
