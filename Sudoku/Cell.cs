using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sudoku
{
    internal class Cell
    {
        public Numbers Value { get; set; }
        public Row Row { get; }
        public Column Column { get; }
        public Block Block { get; }

        public Cell(Numbers value, GameField field, int x, int y)
        {
            Value = value;
            Row = field.Rows[x];
            Column = field.Columns[y];
            Block = field.Blocks[x/3*3 + y/3];
        }

        public override string ToString() => Value == 0 ? " " : ((int) Value).ToString();
    }
}
