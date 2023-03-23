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
            this.importBtn.Location = new System.Drawing.Point(767, 454);
            this.importBtn.Name = "importBtn";
            this.importBtn.Size = new System.Drawing.Size(195, 95);
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
            this.MazeFile.Location = new System.Drawing.Point(600, 495);
            this.MazeFile.MaximumSize = new System.Drawing.Size(150, 26);
            this.MazeFile.Name = "MazeFile";
            this.MazeFile.Size = new System.Drawing.Size(150, 26);
            this.MazeFile.TabIndex = 1;
            this.MazeFile.Text = "No file";
            this.MazeFile.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.MazeFile.Click += new System.EventHandler(this.MazeFile_Click);
            // 
            // Window
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Amazeing.Properties.Resources.bg;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(984, 561);
            this.Controls.Add(this.MazeFile);
            this.Controls.Add(this.importBtn);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(1000, 600);
            this.MinimumSize = new System.Drawing.Size(1000, 600);
            this.Name = "Window";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button importBtn;
        private System.Windows.Forms.Label MazeFile;
    }
}

