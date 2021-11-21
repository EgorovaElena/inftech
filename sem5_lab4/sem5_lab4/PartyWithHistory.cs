using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sem5_lab4
{
    public class PartyWithHistory : Party
    {
        private int numberPartyLastYear;

        public PartyWithHistory(string name, int memberCount, double votesPersent, int numberPartyLastYear)
            : base(name, memberCount, votesPersent)
        {
            this.numberPartyLastYear = numberPartyLastYear;
        }

        public override double Quality()
        {
            if (memberCount > numberPartyLastYear)
            {
                return base.Quality() * 1.2;
            }
            else
            {
                return base.Quality() * 0.8;
            }

        }


    }
}
