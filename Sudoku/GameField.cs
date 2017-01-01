namespace Sudoku
{
    internal class GameField
    {
        private Cell[,] Field { get; }
        public Row[] Rows { get; }
        public Column[] Columns { get; }
        public Block[] Blocks { get; }

        public GameField(string field)
        {
            Rows = new Row[9];
            Columns = new Column[9];
            Blocks = new Block[9];
            for (var i = 0; i < 9; i++)
            {
                Rows[i] = new Row(this, i);
                Columns[i] = new Column(this, i);
                Blocks[i] = new Block(this, i);
            }

            var fieldData = field.Split('\n');
            Field = new Cell[9, 9];
            for (var i = 0; i < 9; i++)
                for (var j = 0; j < 9; j++)
                    Field[i, j] = new Cell((Numbers)(fieldData[i][j] - '0'), this, i, j);

        }

        public Cell this[int i, int j]
        {
            get { return Field[i, j]; }
            set { Field[i, j] = value; }
        }
    }
}
