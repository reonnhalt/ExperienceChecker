using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Akatuki.Model
{
    class Exp
    {
        //ランクごとの必要経験値分布
        private Dictionary<string, int> need_exp = new Dictionary<string, int>()
        {
            { "rank1", 22631   },
            { "rank2", 59043   },
            { "rank3", 154854  },
            { "rank4", 443165  },
            { "rank5", 1238428 },
            { "rank6", 3370720 },
        };
        //各アイテムでの取得経験値分布
        private Dictionary<string, int> add_exp = new Dictionary<string, int>()
        {
            { "bronze1" , 5000    },
            { "bronze2" , 15000   },
            { "bronze3" , 35000   },
            { "silver1" , 50000   },
            { "silver2" , 150000  },
            { "silver3" , 350000  },
            { "gold1"   , 500000  },
            { "gold1"   , 1500000 },
        };
        //ランクの必要経験値取得
        public int getNeedExp(string rank)
        {
            if (need_exp.ContainsKey(rank))
            {
                return need_exp[rank];
            }
            else
            {
                return 0;
            }
        }
        //アイテムの取得経験値取得
        public int getAddExp(string kind)
        {
            if (add_exp.ContainsKey(kind))
            {
                return add_exp[kind];
            }
            else
            {
                return 0;
            }
        }
    }
}
