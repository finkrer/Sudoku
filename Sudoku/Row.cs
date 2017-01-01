using System.Text;

namespace Sudoku
{
    internal class Row
    {
        private readonly GameField field;
        private readonly int number;

        public Row(GameField field, int number)
        {
            this.field = field;
            this.number = number;
        }

        public Cell this[int i]
        {
            get { return field[number, i]; }
            set { field[number, i] = value; }
        }

        public override string ToString()
        {
            var result = new StringBuilder();
            for (var i = 0; i < 9; i++)
                result.Append(this[i] + " ");
            return result.ToString().TrimEnd();
        }
    }
}