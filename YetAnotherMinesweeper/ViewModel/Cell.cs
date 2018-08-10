using YetAnotherMinesweeper.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YetAnotherMinesweeper.ViewModel
{
    public class Cell : ObservableObject
    {
        public int X { get; set; }
        public int Y { get; set; }
        public int BombQuantityAround { get; set; }
        public bool IsBomb { get; set; }

        private string _title;
        public string Title
        {
            get { return _title; }
            set
            {
                if (_title != value)
                {
                    _title = value;
                    RaisePropertyChanged();
                }
            }
        }
        


        public Cell(int x, int y)
        {
            X = x;
            Y = y;
        }
        

    }
}
