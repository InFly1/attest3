using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GridViewLibrary;
using ToolsLibrary;

namespace _10._21
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DataGridViewUtils.InitGridForArr(Input, 99, false, false, false, true, false, false);
            DataGridViewUtils.InitGridForArr(Output, 99, true, false, false, false, false, false);
        }

        private void open_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    CutsFile file = new CutsFile(openFileDialog.FileName);
                    List<Cut> Cuts = file.ReadCuts();
                    DataGridViewUtils.Array2ToGrid(Input, CutConvert.CutsListToMatrix(Cuts));
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "ошибка");
                }
            }
        }

        private void save_Click(object sender, EventArgs e)
        {
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    CutsFile file = new CutsFile(openFileDialog.FileName);
                    file.WriteCuts(CutConvert.MatrixToCutsList(DataGridViewUtils.GridToArray2<double>(Output)));
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "ошибка");
                }
            }
        }

        private void Combine_Click(object sender, EventArgs e)
        {
            try
            {
                List<Cut> cuts = CutConvert.MatrixToCutsList(DataGridViewUtils.GridToArray2<double>(Input));
                List<Cut> CombineCuts = Cut.Combine(cuts);
                DataGridViewUtils.Array2ToGrid(Output,CutConvert.CutsListToMatrix(CombineCuts));
                save.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ошибка");
            }
        }
    }
}
