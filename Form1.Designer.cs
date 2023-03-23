namespace Amazeing
{
    partial class Window
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Window));
            this.importBtn = new System.Windows.Forms.Button();
            this.MazeFile = new System.Windows.Forms.Label();
            this.AlgoDesc = new System.Windows.Forms.Label();
            this.BfsBtn = new System.Windows.Forms.Button();
            this.DfsBtn = new System.Windows.Forms.Button();
            this.AlgoTitle = new System.Windows.Forms.PictureBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.SearchBtn = new System.Windows.Forms.Button();
            this.ExecTimeLabel = new System.Windows.Forms.Button();
            this.ExecTimeVal = new System.Windows.Forms.Label();
            this.Nodes = new System.Windows.Forms.Button();
            this.NodesVal = new System.Windows.Forms.Label();
            this.StepsLabel = new System.Windows.Forms.Button();
            this.StepsVal = new System.Windows.Forms.Label();
            this.RouteLabel = new System.Windows.Forms.Button();
            this.RouteVal = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.AlgoTitle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // importBtn
            // 
            this.importBtn.BackColor = System.Drawing.Color.Transparent;
            this.importBtn.BackgroundImage = global::Amazeing.Properties.Resources.import_file_btn;
            this.importBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.importBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.importBtn.FlatAppearance.BorderSize = 0;
            this.importBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.importBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.importBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.importBtn.Location = new System.Drawing.Point(967, 553);
            this.importBtn.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.importBtn.MaximumSize = new System.Drawing.Size(166, 75);
            this.importBtn.MinimumSize = new System.Drawing.Size(166, 75);
            this.importBtn.Name = "importBtn";
            this.importBtn.Size = new System.Drawing.Size(166, 75);
            this.importBtn.TabIndex = 0;
            this.importBtn.UseVisualStyleBackColor = false;
            this.importBtn.Click += new System.EventHandler(this.importBtn_Click);
            // 
            // MazeFile
            // 
            this.MazeFile.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.MazeFile.BackColor = System.Drawing.Color.Transparent;
            this.MazeFile.Font = new System.Drawing.Font("Montserrat Medium", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MazeFile.ForeColor = System.Drawing.Color.Yellow;
            this.MazeFile.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.MazeFile.Location = new System.Drawing.Point(639, 574);
            this.MazeFile.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.MazeFile.MaximumSize = new System.Drawing.Size(300, 30);
            this.MazeFile.MinimumSize = new System.Drawing.Size(300, 30);
            this.MazeFile.Name = "MazeFile";
            this.MazeFile.Size = new System.Drawing.Size(300, 30);
            this.MazeFile.TabIndex = 1;
            this.MazeFile.Text = "No file";
            this.MazeFile.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.MazeFile.Click += new System.EventHandler(this.MazeFile_Click);
            // 
            // AlgoDesc
            // 
            this.AlgoDesc.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.AlgoDesc.BackColor = System.Drawing.Color.Transparent;
            this.AlgoDesc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AlgoDesc.Font = new System.Drawing.Font("Montserrat", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AlgoDesc.ForeColor = System.Drawing.Color.Yellow;
            this.AlgoDesc.Location = new System.Drawing.Point(33, 260);
            this.AlgoDesc.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.AlgoDesc.MaximumSize = new System.Drawing.Size(550, 90);
            this.AlgoDesc.MinimumSize = new System.Drawing.Size(550, 90);
            this.AlgoDesc.Name = "AlgoDesc";
            this.AlgoDesc.Size = new System.Drawing.Size(550, 90);
            this.AlgoDesc.TabIndex = 2;
            this.AlgoDesc.Click += new System.EventHandler(this.label1_Click);
            // 
            // BfsBtn
            // 
            this.BfsBtn.BackColor = System.Drawing.Color.Transparent;
            this.BfsBtn.BackgroundImage = global::Amazeing.Properties.Resources.bfs_btn;
            this.BfsBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BfsBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BfsBtn.FlatAppearance.BorderSize = 0;
            this.BfsBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.BfsBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.BfsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BfsBtn.Location = new System.Drawing.Point(37, 353);
            this.BfsBtn.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.BfsBtn.MaximumSize = new System.Drawing.Size(166, 75);
            this.BfsBtn.MinimumSize = new System.Drawing.Size(166, 75);
            this.BfsBtn.Name = "BfsBtn";
            this.BfsBtn.Size = new System.Drawing.Size(166, 75);
            this.BfsBtn.TabIndex = 3;
            this.BfsBtn.UseVisualStyleBackColor = false;
            this.BfsBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // DfsBtn
            // 
            this.DfsBtn.BackColor = System.Drawing.Color.Transparent;
            this.DfsBtn.BackgroundImage = global::Amazeing.Properties.Resources.dfs_btn;
            this.DfsBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.DfsBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DfsBtn.FlatAppearance.BorderSize = 0;
            this.DfsBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.DfsBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.DfsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DfsBtn.ForeColor = System.Drawing.Color.Yellow;
            this.DfsBtn.Location = new System.Drawing.Point(222, 353);
            this.DfsBtn.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.DfsBtn.MaximumSize = new System.Drawing.Size(166, 75);
            this.DfsBtn.MinimumSize = new System.Drawing.Size(166, 75);
            this.DfsBtn.Name = "DfsBtn";
            this.DfsBtn.Size = new System.Drawing.Size(166, 75);
            this.DfsBtn.TabIndex = 4;
            this.DfsBtn.UseVisualStyleBackColor = false;
            this.DfsBtn.Click += new System.EventHandler(this.DfsBtn_Click);
            // 
            // AlgoTitle
            // 
            this.AlgoTitle.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.AlgoTitle.BackColor = System.Drawing.Color.Transparent;
            this.AlgoTitle.BackgroundImage = global::Amazeing.Properties.Resources.select_label1;
            this.AlgoTitle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.AlgoTitle.Location = new System.Drawing.Point(37, 214);
            this.AlgoTitle.MaximumSize = new System.Drawing.Size(282, 47);
            this.AlgoTitle.MinimumSize = new System.Drawing.Size(282, 47);
            this.AlgoTitle.Name = "AlgoTitle";
            this.AlgoTitle.Size = new System.Drawing.Size(282, 47);
            this.AlgoTitle.TabIndex = 5;
            this.AlgoTitle.TabStop = false;
            this.AlgoTitle.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(616, 12);
            this.dataGridView1.MaximumSize = new System.Drawing.Size(520, 520);
            this.dataGridView1.MinimumSize = new System.Drawing.Size(520, 520);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(520, 520);
            this.dataGridView1.TabIndex = 7;
            // 
            // SearchBtn
            // 
            this.SearchBtn.BackColor = System.Drawing.Color.Transparent;
            this.SearchBtn.BackgroundImage = global::Amazeing.Properties.Resources.search_btn;
            this.SearchBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.SearchBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SearchBtn.FlatAppearance.BorderSize = 0;
            this.SearchBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.SearchBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.SearchBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SearchBtn.ForeColor = System.Drawing.Color.Yellow;
            this.SearchBtn.Location = new System.Drawing.Point(407, 353);
            this.SearchBtn.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.SearchBtn.MaximumSize = new System.Drawing.Size(166, 75);
            this.SearchBtn.MinimumSize = new System.Drawing.Size(166, 75);
            this.SearchBtn.Name = "SearchBtn";
            this.SearchBtn.Size = new System.Drawing.Size(166, 75);
            this.SearchBtn.TabIndex = 8;
            this.SearchBtn.UseVisualStyleBackColor = false;
            this.SearchBtn.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // ExecTimeLabel
            // 
            this.ExecTimeLabel.BackColor = System.Drawing.Color.Transparent;
            this.ExecTimeLabel.BackgroundImage = global::Amazeing.Properties.Resources.exec_time_label;
            this.ExecTimeLabel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ExecTimeLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ExecTimeLabel.Enabled = false;
            this.ExecTimeLabel.FlatAppearance.BorderSize = 0;
            this.ExecTimeLabel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.ExecTimeLabel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.ExecTimeLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExecTimeLabel.ForeColor = System.Drawing.Color.Yellow;
            this.ExecTimeLabel.Location = new System.Drawing.Point(407, 562);
            this.ExecTimeLabel.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ExecTimeLabel.MaximumSize = new System.Drawing.Size(120, 55);
            this.ExecTimeLabel.MinimumSize = new System.Drawing.Size(120, 55);
            this.ExecTimeLabel.Name = "ExecTimeLabel";
            this.ExecTimeLabel.Size = new System.Drawing.Size(120, 55);
            this.ExecTimeLabel.TabIndex = 9;
            this.ExecTimeLabel.UseVisualStyleBackColor = false;
            // 
            // ExecTimeVal
            // 
            this.ExecTimeVal.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.ExecTimeVal.BackColor = System.Drawing.Color.Transparent;
            this.ExecTimeVal.Font = new System.Drawing.Font("Montserrat Medium", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExecTimeVal.ForeColor = System.Drawing.Color.Yellow;
            this.ExecTimeVal.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ExecTimeVal.Location = new System.Drawing.Point(549, 574);
            this.ExecTimeVal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ExecTimeVal.MaximumSize = new System.Drawing.Size(100, 30);
            this.ExecTimeVal.MinimumSize = new System.Drawing.Size(100, 30);
            this.ExecTimeVal.Name = "ExecTimeVal";
            this.ExecTimeVal.Size = new System.Drawing.Size(100, 30);
            this.ExecTimeVal.TabIndex = 10;
            this.ExecTimeVal.Text = "0 ms";
            this.ExecTimeVal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ExecTimeVal.Click += new System.EventHandler(this.ExecTimeVal_Click);
            // 
            // Nodes
            // 
            this.Nodes.BackColor = System.Drawing.Color.Transparent;
            this.Nodes.BackgroundImage = global::Amazeing.Properties.Resources.nodes_label;
            this.Nodes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Nodes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Nodes.Enabled = false;
            this.Nodes.FlatAppearance.BorderSize = 0;
            this.Nodes.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.Nodes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.Nodes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Nodes.ForeColor = System.Drawing.Color.Yellow;
            this.Nodes.Location = new System.Drawing.Point(37, 575);
            this.Nodes.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Nodes.MaximumSize = new System.Drawing.Size(80, 28);
            this.Nodes.MinimumSize = new System.Drawing.Size(80, 28);
            this.Nodes.Name = "Nodes";
            this.Nodes.Size = new System.Drawing.Size(80, 28);
            this.Nodes.TabIndex = 11;
            this.Nodes.UseVisualStyleBackColor = false;
            // 
            // NodesVal
            // 
            this.NodesVal.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.NodesVal.BackColor = System.Drawing.Color.Transparent;
            this.NodesVal.Font = new System.Drawing.Font("Montserrat Medium", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NodesVal.ForeColor = System.Drawing.Color.Yellow;
            this.NodesVal.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.NodesVal.Location = new System.Drawing.Point(135, 575);
            this.NodesVal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.NodesVal.MaximumSize = new System.Drawing.Size(70, 30);
            this.NodesVal.MinimumSize = new System.Drawing.Size(70, 30);
            this.NodesVal.Name = "NodesVal";
            this.NodesVal.Size = new System.Drawing.Size(70, 30);
            this.NodesVal.TabIndex = 12;
            this.NodesVal.Text = "0";
            this.NodesVal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.NodesVal.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // StepsLabel
            // 
            this.StepsLabel.BackColor = System.Drawing.Color.Transparent;
            this.StepsLabel.BackgroundImage = global::Amazeing.Properties.Resources.steps_label;
            this.StepsLabel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.StepsLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.StepsLabel.Enabled = false;
            this.StepsLabel.FlatAppearance.BorderSize = 0;
            this.StepsLabel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.StepsLabel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.StepsLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.StepsLabel.ForeColor = System.Drawing.Color.Yellow;
            this.StepsLabel.Location = new System.Drawing.Point(222, 575);
            this.StepsLabel.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.StepsLabel.MaximumSize = new System.Drawing.Size(80, 34);
            this.StepsLabel.MinimumSize = new System.Drawing.Size(80, 28);
            this.StepsLabel.Name = "StepsLabel";
            this.StepsLabel.Size = new System.Drawing.Size(80, 34);
            this.StepsLabel.TabIndex = 13;
            this.StepsLabel.UseVisualStyleBackColor = false;
            this.StepsLabel.Click += new System.EventHandler(this.button1_Click_2);
            // 
            // StepsVal
            // 
            this.StepsVal.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.StepsVal.BackColor = System.Drawing.Color.Transparent;
            this.StepsVal.Font = new System.Drawing.Font("Montserrat Medium", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StepsVal.ForeColor = System.Drawing.Color.Yellow;
            this.StepsVal.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.StepsVal.Location = new System.Drawing.Point(319, 575);
            this.StepsVal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.StepsVal.MaximumSize = new System.Drawing.Size(70, 30);
            this.StepsVal.MinimumSize = new System.Drawing.Size(70, 30);
            this.StepsVal.Name = "StepsVal";
            this.StepsVal.Size = new System.Drawing.Size(70, 30);
            this.StepsVal.TabIndex = 14;
            this.StepsVal.Text = "0";
            this.StepsVal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // RouteLabel
            // 
            this.RouteLabel.BackColor = System.Drawing.Color.Transparent;
            this.RouteLabel.BackgroundImage = global::Amazeing.Properties.Resources.route_label;
            this.RouteLabel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.RouteLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RouteLabel.Enabled = false;
            this.RouteLabel.FlatAppearance.BorderSize = 0;
            this.RouteLabel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.RouteLabel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.RouteLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RouteLabel.ForeColor = System.Drawing.Color.Yellow;
            this.RouteLabel.Location = new System.Drawing.Point(37, 458);
            this.RouteLabel.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.RouteLabel.MaximumSize = new System.Drawing.Size(80, 28);
            this.RouteLabel.MinimumSize = new System.Drawing.Size(80, 28);
            this.RouteLabel.Name = "RouteLabel";
            this.RouteLabel.Size = new System.Drawing.Size(80, 28);
            this.RouteLabel.TabIndex = 15;
            this.RouteLabel.UseVisualStyleBackColor = false;
            // 
            // RouteVal
            // 
            this.RouteVal.BackColor = System.Drawing.Color.Transparent;
            this.RouteVal.Font = new System.Drawing.Font("Montserrat Medium", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RouteVal.ForeColor = System.Drawing.Color.Yellow;
            this.RouteVal.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.RouteVal.Location = new System.Drawing.Point(135, 457);
            this.RouteVal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.RouteVal.MaximumSize = new System.Drawing.Size(420, 90);
            this.RouteVal.MinimumSize = new System.Drawing.Size(420, 90);
            this.RouteVal.Name = "RouteVal";
            this.RouteVal.Size = new System.Drawing.Size(420, 90);
            this.RouteVal.TabIndex = 16;
            this.RouteVal.Text = "-";
            this.RouteVal.Click += new System.EventHandler(this.RouteVal_Click);
            // 
            // Window
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Amazeing.Properties.Resources.bg;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1148, 647);
            this.Controls.Add(this.RouteVal);
            this.Controls.Add(this.RouteLabel);
            this.Controls.Add(this.StepsVal);
            this.Controls.Add(this.StepsLabel);
            this.Controls.Add(this.NodesVal);
            this.Controls.Add(this.Nodes);
            this.Controls.Add(this.ExecTimeVal);
            this.Controls.Add(this.ExecTimeLabel);
            this.Controls.Add(this.SearchBtn);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.AlgoTitle);
            this.Controls.Add(this.DfsBtn);
            this.Controls.Add(this.BfsBtn);
            this.Controls.Add(this.AlgoDesc);
            this.Controls.Add(this.MazeFile);
            this.Controls.Add(this.importBtn);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximumSize = new System.Drawing.Size(1164, 686);
            this.MinimumSize = new System.Drawing.Size(1164, 686);
            this.Name = "Window";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.AlgoTitle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button importBtn;
        private System.Windows.Forms.Label MazeFile;
        private System.Windows.Forms.Label AlgoDesc;
        private System.Windows.Forms.Button BfsBtn;
        private System.Windows.Forms.Button DfsBtn;
        private System.Windows.Forms.PictureBox AlgoTitle;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button SearchBtn;
        private System.Windows.Forms.Button ExecTimeLabel;
        private System.Windows.Forms.Label ExecTimeVal;
        private System.Windows.Forms.Button Nodes;
        private System.Windows.Forms.Label NodesVal;
        private System.Windows.Forms.Button StepsLabel;
        private System.Windows.Forms.Label StepsVal;
        private System.Windows.Forms.Button RouteLabel;
        private System.Windows.Forms.Label RouteVal;
    }
}

