using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Akatuki.Model;

namespace Akatuki.Model
{
    class Input
    {
        private List<Rank> rank_list;

        public void setRankList()
        {
            rank_list = new List<Rank>();
            rank_list.Add(new Rank("rank1", "☆１"));
            rank_list.Add(new Rank("rank2", "☆２"));
            rank_list.Add(new Rank("rank3", "☆３"));
            rank_list.Add(new Rank("rank4", "☆４"));
            rank_list.Add(new Rank("rank5", "☆５"));
            rank_list.Add(new Rank("rank6", "☆６"));
        }
        public List<Rank> getRankList()
        {
            return rank_list;
        }

    }
}
