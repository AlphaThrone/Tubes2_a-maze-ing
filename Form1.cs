using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Amazeing
{
    public partial class Window : Form
    {
        private Controller controller;
        private System.Media.SoundPlayer soundPlayer;
        private bool isPlaySound;
        private int visualizerSpeed;

        public Window()
        {
            InitializeComponent();
            controller = new Controller();
            soundPlayer = new System.Media.SoundPlayer();
            isPlaySound = true;
            soundPlayer.SoundLocation = "../../Resources/bg-soundtrack.wav";
            soundPlayer.PlayLooping();
            visualizerSpeed = 500;
            SpeedInput.Text = visualizerSpeed.ToString();
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

                    // Maze Display Styling
                    MazeGrid.RowHeadersVisible = false;
                    MazeGrid.ColumnHeadersVisible = false;
                    MazeGrid.Enabled = false;
                    MazeGrid.ReadOnly = true;
                    MazeGrid.AllowUserToAddRows = false;
                    MazeGrid.AllowUserToDeleteRows = false;
                    MazeGrid.AllowUserToResizeColumns = false;
                    MazeGrid.AllowUserToResizeRows = false;
                    MazeGrid.ScrollBars = ScrollBars.None;
                    MazeGrid.MultiSelect = false;
                    MazeGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    MazeGrid.CellBorderStyle = DataGridViewCellBorderStyle.None;

                    // Initialize Maze Display Data
                    MazeGrid.ColumnCount = controller.Maze.Width;
                    MazeGrid.RowCount = controller.Maze.Depth;

                    int rowHeight = MazeGrid.ClientSize.Height / MazeGrid.RowCount;
                    for(int i = 0; i < MazeGrid.RowCount; i++)
                    {
                        MazeGrid.Rows[i].Height = rowHeight;
                    }

                    MazeGrid.CurrentCell = null;

                    // Initialize Maze Display Colours
                    for (int i = 0; i < MazeGrid.RowCount; i++)
                    {
                        for (int j = 0; j <  MazeGrid.ColumnCount; j++)
                        {
                            if (controller.Maze.Matrix[i, j] == 'X')
                            {
                                MazeGrid.Rows[i].Cells[j].Style.BackColor = Color.Black;
                            }
                            else if (controller.Maze.Matrix[i,j] == 'R')
                            {
                                MazeGrid.Rows[i].Cells[j].Style.BackColor = Color.SaddleBrown;
                            }
                            else if (controller.Maze.Matrix[i, j] == 'T')
                            {
                                MazeGrid.Rows[i].Cells[j].Style.BackColor = Color.Gold;
                            }
                            else if (controller.Maze.Matrix[i, j] == 'K')
                            {
                                MazeGrid.Rows[i].Cells[j].Style.BackColor = Color.DeepSkyBlue;
                            }
                        }
                    }
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

        private async void button1_Click_1(object sender, EventArgs e)
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

                for(int i = 0; i < 100; i++)
                {
                    await Task.Delay(visualizerSpeed);

                    if (controller.Solutions[controller.SelectedAlgorithm].Route.RouteGraph[i] == null)
                    {
                        break;
                    }

                    MazeGrid.Rows[controller.Solutions[controller.SelectedAlgorithm].Route.RouteGraph[i].X].Cells[controller.Solutions[controller.SelectedAlgorithm].Route.RouteGraph[i].Y].Style.BackColor = Color.LightSkyBlue;
                    if (i != 0)
                    {
                        MazeGrid.Rows[controller.Solutions[controller.SelectedAlgorithm].Route.RouteGraph[i - 1].X].Cells[controller.Solutions[controller.SelectedAlgorithm].Route.RouteGraph[i - 1].Y].Style.BackColor = Color.LightSalmon;
                    }
                }

                for (int i = 0; i < controller.Solutions[controller.SelectedAlgorithm].Route.NSelectedRoute; i++)
                {
                    Console.WriteLine(i);
                    await Task.Delay(visualizerSpeed/2);

                    if (controller.Solutions[controller.SelectedAlgorithm].Route.SelectedRouteGraph[i] != null)
                    { 
                        if(MazeGrid.Rows[controller.Solutions[controller.SelectedAlgorithm].Route.SelectedRouteGraph[i].X].Cells[controller.Solutions[controller.SelectedAlgorithm].Route.SelectedRouteGraph[i].Y].Style.BackColor == Color.PaleGreen)
                        {
                            MazeGrid.Rows[controller.Solutions[controller.SelectedAlgorithm].Route.SelectedRouteGraph[i].X].Cells[controller.Solutions[controller.SelectedAlgorithm].Route.SelectedRouteGraph[i].Y].Style.BackColor = Color.YellowGreen;
                        }
                        else if (MazeGrid.Rows[controller.Solutions[controller.SelectedAlgorithm].Route.SelectedRouteGraph[i].X].Cells[controller.Solutions[controller.SelectedAlgorithm].Route.SelectedRouteGraph[i].Y].Style.BackColor == Color.YellowGreen)
                        {
                            MazeGrid.Rows[controller.Solutions[controller.SelectedAlgorithm].Route.SelectedRouteGraph[i].X].Cells[controller.Solutions[controller.SelectedAlgorithm].Route.SelectedRouteGraph[i].Y].Style.BackColor = Color.DarkSeaGreen;
                        }
                        else
                        {
                            MazeGrid.Rows[controller.Solutions[controller.SelectedAlgorithm].Route.SelectedRouteGraph[i].X].Cells[controller.Solutions[controller.SelectedAlgorithm].Route.SelectedRouteGraph[i].Y].Style.BackColor = Color.PaleGreen;
                        }                        
                    }
                }
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

        private void SoundBtn_Click(object sender, EventArgs e)
        {
            if(isPlaySound)
            {
                soundPlayer.Stop();
                this.SoundBtn.BackgroundImage = global::Amazeing.Properties.Resources.sound_off;
                isPlaySound = false;

            }
            else
            {
                soundPlayer.PlayLooping();
                this.SoundBtn.BackgroundImage = global::Amazeing.Properties.Resources.sound_on;
                isPlaySound = true;
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void SpeedInput_TextChanged(object sender, EventArgs e)
        {
            if(SpeedInput.Text != "" && SpeedInput.Text.Length < 5)
            {
                visualizerSpeed = Convert.ToInt32(SpeedInput.Text);
                SpeedSlider.Value = visualizerSpeed / 100;
            }
        }

        private void SpeedSlider_Scroll(object sender, EventArgs e)
        {
            visualizerSpeed = SpeedSlider.Value * 100;
            SpeedInput.Text = visualizerSpeed.ToString();

        }
    }
}
