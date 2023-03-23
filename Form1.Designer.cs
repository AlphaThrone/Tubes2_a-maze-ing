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
            ((System.ComponentModel.ISupportInitialize)(this.AlgoTitle)).BeginInit();
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
            this.importBtn.Location = new System.Drawing.Point(940, 553);
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
            this.MazeFile.Location = new System.Drawing.Point(746, 583);
            this.MazeFile.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.MazeFile.MaximumSize = new System.Drawing.Size(175, 30);
            this.MazeFile.MinimumSize = new System.Drawing.Size(175, 30);
            this.MazeFile.Name = "MazeFile";
            this.MazeFile.Size = new System.Drawing.Size(175, 30);
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
            this.AlgoDesc.MaximumSize = new System.Drawing.Size(502, 90);
            this.AlgoDesc.MinimumSize = new System.Drawing.Size(502, 90);
            this.AlgoDesc.Name = "AlgoDesc";
            this.AlgoDesc.Size = new System.Drawing.Size(502, 90);
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
            this.AlgoTitle.BackColor = System.Drawing.Color.Transparent;
            this.AlgoTitle.BackgroundImage = global::Amazeing.Properties.Resources.select_label1;
            this.AlgoTitle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.AlgoTitle.Location = new System.Drawing.Point(37, 214);
            this.AlgoTitle.Name = "AlgoTitle";
            this.AlgoTitle.Size = new System.Drawing.Size(282, 47);
            this.AlgoTitle.TabIndex = 5;
            this.AlgoTitle.TabStop = false;
            this.AlgoTitle.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Window
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Amazeing.Properties.Resources.bg;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1148, 647);
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
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button importBtn;
        private System.Windows.Forms.Label MazeFile;
        private System.Windows.Forms.Label AlgoDesc;
        private System.Windows.Forms.Button BfsBtn;
        private System.Windows.Forms.Button DfsBtn;
        private System.Windows.Forms.PictureBox AlgoTitle;
    }
}

