using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Akatuki.Model;
using System.ComponentModel;

namespace Akatuki.ViewModel
{
    class InputViewModel : INotifyPropertyChanged
    {
        private Input input;
        private List<Rank> _CharacterRank;
        public  List<Rank> CharacterRank
        {
            get { return _CharacterRank; }
            set { _CharacterRank = value; OnPropertyChanged("CharacterRank"); }
        }
        private string _SelectRank;
        public  string SelectRank
        {
            get { return _SelectRank; }
            set { _SelectRank = value; OnPropertyChanged("SelectRank"); }
        }

        public InputViewModel()
        {
            input = new Input();
            input.setRankList();
            CharacterRank = input.getRankList();
        }

        public event PropertyChangedEventHandler PropertyChanged;

        //プロパティーの変更通知送信
        private void OnPropertyChanged(String propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}
