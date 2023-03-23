using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Amazeing
{
    public partial class Window : Form
    {
        private Controller controller;

        public Window()
        {
            InitializeComponent();
            controller = new Controller();
        }

        private void importBtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.InitialDirectory = @"../../test/";
            ofd.Title = "Browse Maze File";
            ofd.DefaultExt = "txt";
            ofd.Filter = "Text files (*.txt)|*.txt";
            ofd.CheckFileExists = true;
            ofd.CheckPathExists = true;
            if (ofd.ShowDialog() == DialogResult.OK )
            {
                controller.importMaze(ofd.FileName);
                this.MazeFile.Text = ofd.SafeFileName;
            }
        }

        private void MazeFile_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            controller.SelectedAlgorithm = 0;
            this.AlgoDesc.Text = controller.Algorithms[controller.SelectedAlgorithm].Desc;
            this.AlgoTitle.BackgroundImage = global::Amazeing.Properties.Resources.bfs_label;
        }

        private void DfsBtn_Click(object sender, EventArgs e)
        {
            controller.SelectedAlgorithm = 1;
            this.AlgoDesc.Text = controller.Algorithms[controller.SelectedAlgorithm].Desc;
            this.AlgoTitle.BackgroundImage = global::Amazeing.Properties.Resources.dfs_label;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
