using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sudoku
{
    public class GameState
    {
        internal readonly GameField GameField;

        public GameState(string fileName)
        {
            string field;
            using (var sr = new StreamReader(fileName))
            {
                field = sr.ReadToEnd();
            }
            GameField = new GameField(field);
        }
    }
}
