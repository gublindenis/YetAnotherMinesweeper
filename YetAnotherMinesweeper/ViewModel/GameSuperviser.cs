using YetAnotherMinesweeper.Helpers;

namespace YetAnotherMinesweeper.ViewModel
{
    public class GameSuperviser : ObservableObject
    {
        private Minefield _mainMinefield;
        public Minefield MainMinefield
        {
            get { return _mainMinefield; }
            set
            {
                if (_mainMinefield != value)
                {
                    _mainMinefield = value;
                    RaisePropertyChanged();
                }
            }
        }

        private int _numCols;
        public int NumCols
        {
            get { return _numCols; }
            set
            {
                if (_numCols != value)
                {
                    _numCols = value;
                    RaisePropertyChanged();
                }
            }
        }


        private int _numRows;
        public int NumRows
        {
            get
            { return _numRows; }
            set
            {
                if (_numRows != value)
                {
                    _numRows = value;
                    RaisePropertyChanged();
                }
            }
        }

        private int _numBombs;
        public int NumBombs
        {
            get
            { return _numBombs; }
            set
            {
                if (_numBombs != value)
                {
                    _numBombs = value;
                    RaisePropertyChanged();
                }
            }
        }

        public void CreateMinefield()
        {
            MainMinefield = new Minefield(NumCols, NumRows, NumBombs);
        }

        public GameSuperviser()
        {
            NumCols = 9;
            NumRows = 9;
            NumBombs = 10;
        }

    }
}
