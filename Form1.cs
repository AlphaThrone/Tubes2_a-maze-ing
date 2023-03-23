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
        private System.Media.SoundPlayer soundPlayer;

        public Window()
        {
            InitializeComponent();
            controller = new Controller();
            soundPlayer = new System.Media.SoundPlayer();
         soundPlayer.SoundLocation = "../../Resources/bg-soundtrack.wav";
            soundPlayer.PlayLooping();
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
                try
                {
                    controller.ImportMaze(ofd.FileName);
                    this.MazeFile.Text = ofd.SafeFileName;
                    ExecTimeVal.Text = "0 ms";
                    NodesVal.Text = "0";
                    StepsVal.Text = "0";
                    RouteVal.Text = "-";
                }
                
                 catch (Exception err)
                {
                    MessageBoxButtons buttons = MessageBoxButtons.OK;
                    MessageBox.Show(err.Message, "Invalid file", buttons, MessageBoxIcon.Error);
                }
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

        private void button1_Click_1(object sender, EventArgs e)
        {
            try
            {
                if(controller.Maze.SourceFile == "")
                {
                    throw new Exception("Please import a maze file");
                }
                if(controller.SelectedAlgorithm == -1)
                {
                    throw new Exception("Please select an algorithm");
                }
                controller.Solve();
                ExecTimeVal.Text = controller.Solutions[controller.SelectedAlgorithm].ExecTime.ToString() + " ms";
                NodesVal.Text = controller.Solutions[controller.SelectedAlgorithm].VisitedNode.ToString();
                StepsVal.Text = controller.Solutions[controller.SelectedAlgorithm].Route.Steps.ToString();
                RouteVal.Text = controller.Solutions[controller.SelectedAlgorithm].Route.RouteStr;
            }
            catch (Exception err)
            {
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                MessageBox.Show(err.Message, "Cannot solve maze", buttons, MessageBoxIcon.Error);
            }
        }

        private void ExecTimeVal_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void button1_Click_2(object sender, EventArgs e)
        {

        }

        private void RouteVal_Click(object sender, EventArgs e)
        {

        }
    }
}
