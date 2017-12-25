using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GameLogic;

namespace _13._21
{ /*
    Выключить свет! – http://www.2flashgames.com/f/f-35.htm
Предусмотреть несколько уровней (уровни выбираются в меню). Описание уровней должно храниться в виде текстовых файлов level_01.txt, level_02.txt в директории levels,
которая расположена в директории, в которой находится сам исполняемый файл игры. 
     */
    public partial class Form1 : Form
    {
        int LevelCount = 5;
        Game game;
        bool run = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < LevelCount; i++)
            {
                SelectLevel.Items.Add("level " + (i + 1));
            }
            SelectLevel.SelectedIndex = 0;
            GameGrid.RowCount = 5;
            for (int i = 0; i < 5; i++)
            {
                GameGrid.Rows[i].Height = 60;
            }
            Win.Visible = false;
        }
        private void Update(bool[,] Map)
        {
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    if (Map[i, j])
                        GameGrid[j, i].Style.BackColor = Color.Yellow;
                    else
                        GameGrid[j, i].Style.BackColor = Color.White;
                }
            }
        }

        private void StartBtn_Click(object sender, EventArgs e)
        {
            game = new Game(SelectLevel.SelectedIndex + 1);
            run = true;
            Win.Visible = false;
            Update(game.GameMap);
        }

        private void GameGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(run)
            {
                game.Switch(e.RowIndex, e.ColumnIndex, out bool win);
                Update(game.GameMap);
                if(win)
                {
                    Win.Visible = true;
                    run = false;
                }
            }
        }

        private void GameGrid_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            e.PaintBackground(e.CellBounds, false);
            e.Handled = true;
        }
    }
}
