using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Akatuki.Model
{
    class Rank
    {
        public string rank      { get; set; }
        public string disp_rank { get; set; }

        public Rank(string rank, string disp_rank)
        {
            this.rank      = rank;
            this.disp_rank = disp_rank;
        }

    }
}
