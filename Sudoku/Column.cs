using System.Text;

namespace Sudoku
{
    internal class Column
    {
        private readonly GameField field;
        private readonly int number;

        public Column(GameField field, int number)
        {
            this.field = field;
            this.number = number;
        }

        public Cell this[int i]
        {
            get { return field[i, number]; }
            set { field[i, number] = value; }
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