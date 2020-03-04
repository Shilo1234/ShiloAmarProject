namespace ShiloAmarsProj
{
    partial class MainMenu
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
            this.Content = new System.Windows.Forms.Panel();
            this.SideBar = new System.Windows.Forms.Panel();
            this.NavBar = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.NavBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // Content
            // 
            this.Content.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Content.ForeColor = System.Drawing.Color.Black;
            this.Content.Location = new System.Drawing.Point(300, 88);
            this.Content.Name = "Content";
            this.Content.Size = new System.Drawing.Size(616, 316);
            this.Content.TabIndex = 2;
            // 
            // SideBar
            // 
            this.SideBar.BackColor = System.Drawing.Color.Silver;
            this.SideBar.Dock = System.Windows.Forms.DockStyle.Left;
            this.SideBar.Location = new System.Drawing.Point(0, 88);
            this.SideBar.Name = "SideBar";
            this.SideBar.Size = new System.Drawing.Size(300, 316);
            this.SideBar.TabIndex = 3;
            // 
            // NavBar
            // 
            this.NavBar.BackColor = System.Drawing.Color.MediumTurquoise;
            this.NavBar.Controls.Add(this.label1);
            this.NavBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.NavBar.Location = new System.Drawing.Point(0, 0);
            this.NavBar.Name = "NavBar";
            this.NavBar.Size = new System.Drawing.Size(916, 88);
            this.NavBar.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.MediumTurquoise;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(576, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(257, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "התיכון הוירטואלי";
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(916, 404);
            this.Controls.Add(this.Content);
            this.Controls.Add(this.SideBar);
            this.Controls.Add(this.NavBar);
            this.Name = "MainMenu";
            this.Text = "MainMenu";
            this.NavBar.ResumeLayout(false);
            this.NavBar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Panel Content;
        private System.Windows.Forms.Panel SideBar;
        private System.Windows.Forms.Panel NavBar;
        private System.Windows.Forms.Label label1;
    }
}