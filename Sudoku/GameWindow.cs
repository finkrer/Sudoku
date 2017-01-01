using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sudoku
{
    public partial class GameWindow : Form
    {
        public GameWindow()
        {
            InitializeComponent();
            var gameState = new GameState("Field.txt");
            GameField gameData = gameState.GameField;

            const int cellSize = 30;
            gameField.ColumnCount = 9;
            for (var i = 0; i < 9; i++)
            {
                var row = new DataGridViewRow {Height = cellSize};
                for (var j = 0; j < 9; j++)
                    row.Cells.Add(new DataGridViewTextBoxCell { Value = gameData[i, j] });
                gameField.Rows.Add(row);
            }
            foreach (DataGridViewColumn column in gameField.Columns)
                column.Width = cellSize;
        }
    }
}
