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
            ofd.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
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
    }
}
