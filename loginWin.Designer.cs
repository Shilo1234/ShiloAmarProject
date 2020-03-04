namespace ShiloAmarsProj
{
    partial class loginWin
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
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.userNameTextBox1 = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialFlatButton1 = new MaterialSkin.Controls.MaterialFlatButton();
            this.materialFlatButton2 = new MaterialSkin.Controls.MaterialFlatButton();
            this.materialCheckBox2 = new MaterialSkin.Controls.MaterialCheckBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.passwordLine = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.SideBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // SideBar
            // 
            this.SideBar.Controls.Add(this.checkBox1);
            this.SideBar.Controls.Add(this.passwordLine);
            this.SideBar.Controls.Add(this.materialCheckBox2);
            this.SideBar.Controls.Add(this.pictureBox2);
            this.SideBar.Controls.Add(this.pictureBox1);
            this.SideBar.Controls.Add(this.materialFlatButton2);
            this.SideBar.Controls.Add(this.materialFlatButton1);
            this.SideBar.Controls.Add(this.userNameTextBox1);
            this.SideBar.Controls.Add(this.materialLabel2);
            this.SideBar.Controls.Add(this.materialLabel1);
            this.SideBar.Size = new System.Drawing.Size(300, 375);
            // 
            // Content
            // 
            this.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.Content.Size = new System.Drawing.Size(901, 375);
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(304, 132);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(69, 19);
            this.materialLabel1.TabIndex = 0;
            this.materialLabel1.Text = "שם משתמש";
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(320, 194);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(40, 19);
            this.materialLabel2.TabIndex = 1;
            this.materialLabel2.Text = "סיסמה";
            // 
            // userNameTextBox1
            // 
            this.userNameTextBox1.Depth = 0;
            this.userNameTextBox1.Hint = "";
            this.userNameTextBox1.Location = new System.Drawing.Point(71, 128);
            this.userNameTextBox1.MouseState = MaterialSkin.MouseState.HOVER;
            this.userNameTextBox1.Name = "userNameTextBox1";
            this.userNameTextBox1.PasswordChar = '\0';
            this.userNameTextBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.userNameTextBox1.SelectedText = "";
            this.userNameTextBox1.SelectionLength = 0;
            this.userNameTextBox1.SelectionStart = 0;
            this.userNameTextBox1.Size = new System.Drawing.Size(215, 23);
            this.userNameTextBox1.TabIndex = 2;
            this.userNameTextBox1.Text = "הכנס שם משתמש";
            this.userNameTextBox1.UseSystemPasswordChar = false;
            this.userNameTextBox1.Click += new System.EventHandler(this.userNameTextBox1_Click);
            this.userNameTextBox1.Leave += new System.EventHandler(this.userNameTextBox1_Leave);
            // 
            // materialFlatButton1
            // 
            this.materialFlatButton1.AutoSize = true;
            this.materialFlatButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialFlatButton1.BackColor = System.Drawing.Color.Black;
            this.materialFlatButton1.Depth = 0;
            this.materialFlatButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.materialFlatButton1.Location = new System.Drawing.Point(80, 305);
            this.materialFlatButton1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialFlatButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialFlatButton1.Name = "materialFlatButton1";
            this.materialFlatButton1.Primary = false;
            this.materialFlatButton1.Size = new System.Drawing.Size(47, 36);
            this.materialFlatButton1.TabIndex = 4;
            this.materialFlatButton1.Text = "כניסה";
            this.materialFlatButton1.UseVisualStyleBackColor = false;
            this.materialFlatButton1.Click += new System.EventHandler(this.materialFlatButton1_Click);
            // 
            // materialFlatButton2
            // 
            this.materialFlatButton2.AutoSize = true;
            this.materialFlatButton2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialFlatButton2.Depth = 0;
            this.materialFlatButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.materialFlatButton2.Location = new System.Drawing.Point(162, 305);
            this.materialFlatButton2.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialFlatButton2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialFlatButton2.Name = "materialFlatButton2";
            this.materialFlatButton2.Primary = false;
            this.materialFlatButton2.Size = new System.Drawing.Size(124, 36);
            this.materialFlatButton2.TabIndex = 5;
            this.materialFlatButton2.Text = "שכחתי את הסיסמה";
            this.materialFlatButton2.UseVisualStyleBackColor = true;
            // 
            // materialCheckBox2
            // 
            this.materialCheckBox2.AutoSize = true;
            this.materialCheckBox2.Depth = 0;
            this.materialCheckBox2.Font = new System.Drawing.Font("Roboto", 10F);
            this.materialCheckBox2.Location = new System.Drawing.Point(33, 213);
            this.materialCheckBox2.Margin = new System.Windows.Forms.Padding(0);
            this.materialCheckBox2.MouseLocation = new System.Drawing.Point(-1, -1);
            this.materialCheckBox2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCheckBox2.Name = "materialCheckBox2";
            this.materialCheckBox2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.materialCheckBox2.Ripple = true;
            this.materialCheckBox2.Size = new System.Drawing.Size(85, 30);
            this.materialCheckBox2.TabIndex = 9;
            this.materialCheckBox2.Text = "זכור אותי";
            this.materialCheckBox2.UseVisualStyleBackColor = true;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::ShiloAmarsProj.Properties.Resources.key;
            this.pictureBox2.Location = new System.Drawing.Point(33, 182);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(30, 30);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 7;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ShiloAmarsProj.Properties.Resources.user;
            this.pictureBox1.Location = new System.Drawing.Point(33, 121);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(30, 30);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // passwordLine
            // 
            this.passwordLine.Depth = 0;
            this.passwordLine.Hint = "";
            this.passwordLine.Location = new System.Drawing.Point(66, 190);
            this.passwordLine.MouseState = MaterialSkin.MouseState.HOVER;
            this.passwordLine.Name = "passwordLine";
            this.passwordLine.PasswordChar = '\0';
            this.passwordLine.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.passwordLine.SelectedText = "";
            this.passwordLine.SelectionLength = 0;
            this.passwordLine.SelectionStart = 0;
            this.passwordLine.Size = new System.Drawing.Size(215, 23);
            this.passwordLine.TabIndex = 11;
            this.passwordLine.Text = "הכנס סיסמה";
            this.passwordLine.UseSystemPasswordChar = true;
            this.passwordLine.Click += new System.EventHandler(this.passwordLine_Click);
            this.passwordLine.Leave += new System.EventHandler(this.passwordLine_Leave);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(69, 190);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(46, 17);
            this.checkBox1.TabIndex = 12;
            this.checkBox1.Text = "הצג";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // loginWin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(901, 463);
            this.Name = "loginWin";
            this.Text = "loginWin";
            this.SideBar.ResumeLayout(false);
            this.SideBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialFlatButton materialFlatButton2;
        private MaterialSkin.Controls.MaterialFlatButton materialFlatButton1;
        private MaterialSkin.Controls.MaterialSingleLineTextField userNameTextBox1;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialCheckBox materialCheckBox2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private MaterialSkin.Controls.MaterialSingleLineTextField passwordLine;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}