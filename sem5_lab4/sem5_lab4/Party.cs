using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sem5_lab4
{
    public class Party
    {
        private string  name;
        protected int  memberCount;
        protected double  votesPersent;

        public Party (string name, int memberCount, double votesPersent)
        {
            this.name = name;
            this.memberCount = memberCount;
            this.votesPersent = votesPersent;

        }

        public string Name
        {
            get
            {
                return name;    // возвращаем значение свойства
            }
            set
            {
                name = value;   // устанавливаем новое значение свойства
            }
        }

        public virtual double Quality()
        {
            return 0.3 * memberCount + 0.7 * votesPersent;

        }


    }
}
