using System;
using System.Text;

namespace Sudoku
{
    internal class Block
    {
        private readonly GameField field;
        private readonly int number;

        public Block(GameField field, int number)
        {
            this.field = field;
            this.number = number;
        }

        public Cell this[int i]
        {
            get { return field[number%3*3 + i%3, number/3*3 + i/3]; }
            set { field[number % 3 * 3 + i % 3, number / 3 * 3 + i / 3] = value; }
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