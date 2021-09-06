namespace Smart_Sales
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.Exit_btn = new System.Windows.Forms.Button();
            this.Login_btn = new System.Windows.Forms.Button();
            this.Username_lbl = new System.Windows.Forms.Label();
            this.Password_lbl = new System.Windows.Forms.Label();
            this.UserName_txt = new System.Windows.Forms.TextBox();
            this.Password_text = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.LogInTop_Corner_Img = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LogInTop_Corner_Img)).BeginInit();
            this.SuspendLayout();
            // 
            // Exit_btn
            // 
            this.Exit_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Exit_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Exit_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Exit_btn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Exit_btn.Image = global::Smart_Sales.Properties.Resources.cross;
            this.Exit_btn.Location = new System.Drawing.Point(658, 3);
            this.Exit_btn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Exit_btn.Name = "Exit_btn";
            this.Exit_btn.Size = new System.Drawing.Size(23, 21);
            this.Exit_btn.TabIndex = 0;
            this.Exit_btn.Text = "X";
            this.Exit_btn.UseVisualStyleBackColor = false;
            this.Exit_btn.Click += new System.EventHandler(this.Exit_btn_Click);
            // 
            // Login_btn
            // 
            this.Login_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Login_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Login_btn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Login_btn.Image = global::Smart_Sales.Properties.Resources.database_go;
            this.Login_btn.Location = new System.Drawing.Point(337, 295);
            this.Login_btn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Login_btn.Name = "Login_btn";
            this.Login_btn.Size = new System.Drawing.Size(74, 31);
            this.Login_btn.TabIndex = 1;
            this.Login_btn.Text = "Login";
            this.Login_btn.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.Login_btn.UseVisualStyleBackColor = false;
            this.Login_btn.Click += new System.EventHandler(this.Login_btn_Click);
            // 
            // Username_lbl
            // 
            this.Username_lbl.AutoSize = true;
            this.Username_lbl.BackColor = System.Drawing.Color.Transparent;
            this.Username_lbl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Username_lbl.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Username_lbl.ForeColor = System.Drawing.Color.Purple;
            this.Username_lbl.Location = new System.Drawing.Point(120, 222);
            this.Username_lbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Username_lbl.Name = "Username_lbl";
            this.Username_lbl.Size = new System.Drawing.Size(82, 18);
            this.Username_lbl.TabIndex = 2;
            this.Username_lbl.Text = "User Name:";
            // 
            // Password_lbl
            // 
            this.Password_lbl.AutoSize = true;
            this.Password_lbl.BackColor = System.Drawing.Color.Transparent;
            this.Password_lbl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Password_lbl.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Password_lbl.ForeColor = System.Drawing.Color.Purple;
            this.Password_lbl.Location = new System.Drawing.Point(128, 254);
            this.Password_lbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Password_lbl.Name = "Password_lbl";
            this.Password_lbl.Size = new System.Drawing.Size(72, 18);
            this.Password_lbl.TabIndex = 3;
            this.Password_lbl.Text = "Password:";
            // 
            // UserName_txt
            // 
            this.UserName_txt.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.UserName_txt.ForeColor = System.Drawing.SystemColors.Info;
            this.UserName_txt.Location = new System.Drawing.Point(210, 222);
            this.UserName_txt.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.UserName_txt.Multiline = true;
            this.UserName_txt.Name = "UserName_txt";
            this.UserName_txt.Size = new System.Drawing.Size(289, 22);
            this.UserName_txt.TabIndex = 4;
            // 
            // Password_text
            // 
            this.Password_text.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.Password_text.ForeColor = System.Drawing.SystemColors.Info;
            this.Password_text.Location = new System.Drawing.Point(208, 254);
            this.Password_text.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Password_text.Multiline = true;
            this.Password_text.Name = "Password_text";
            this.Password_text.PasswordChar = '*';
            this.Password_text.Size = new System.Drawing.Size(291, 22);
            this.Password_text.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Purple;
            this.label1.Location = new System.Drawing.Point(204, 13);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(293, 31);
            this.label1.TabIndex = 6;
            this.label1.Text = "A. Timothy Sales Entry";
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnClear.Image = global::Smart_Sales.Properties.Resources.database_edit;
            this.btnClear.Location = new System.Drawing.Point(255, 295);
            this.btnClear.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(74, 31);
            this.btnClear.TabIndex = 8;
            this.btnClear.Text = "Clear";
            this.btnClear.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.DarkSlateGray;
            this.pictureBox2.Image = global::Smart_Sales.Properties.Resources.gpe_su;
            this.pictureBox2.Location = new System.Drawing.Point(498, 222);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(49, 54);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 9;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Smart_Sales.Properties.Resources.acode;
            this.pictureBox1.Location = new System.Drawing.Point(220, 49);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(277, 167);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // LogInTop_Corner_Img
            // 
            this.LogInTop_Corner_Img.BackColor = System.Drawing.Color.Gray;
            this.LogInTop_Corner_Img.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LogInTop_Corner_Img.Image = global::Smart_Sales.Properties.Resources.office_chart_pie1;
            this.LogInTop_Corner_Img.Location = new System.Drawing.Point(2, 3);
            this.LogInTop_Corner_Img.Name = "LogInTop_Corner_Img";
            this.LogInTop_Corner_Img.Size = new System.Drawing.Size(26, 27);
            this.LogInTop_Corner_Img.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.LogInTop_Corner_Img.TabIndex = 10;
            this.LogInTop_Corner_Img.TabStop = false;
            // 
            // Login
            // 
            this.ApplyImageInvert = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Smart_Sales.Properties.Resources.akregator_2;
            this.BackImage = global::Smart_Sales.Properties.Resources.akregator_2;
            this.ClientSize = new System.Drawing.Size(685, 391);
            this.ControlBox = false;
            this.Controls.Add(this.LogInTop_Corner_Img);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Password_text);
            this.Controls.Add(this.UserName_txt);
            this.Controls.Add(this.Password_lbl);
            this.Controls.Add(this.Username_lbl);
            this.Controls.Add(this.Login_btn);
            this.Controls.Add(this.Exit_btn);
            this.DisplayHeader = false;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.DimGray;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.ImeMode = System.Windows.Forms.ImeMode.Close;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Login";
            this.Padding = new System.Windows.Forms.Padding(20, 30, 20, 20);
            this.Style = MetroFramework.MetroColorStyle.White;
            this.Text = "Login";
            this.Theme = MetroFramework.MetroThemeStyle.Default;
            this.TransparencyKey = System.Drawing.Color.Green;
            this.Load += new System.EventHandler(this.Login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LogInTop_Corner_Img)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Exit_btn;
        private System.Windows.Forms.Button Login_btn;
        private System.Windows.Forms.Label Username_lbl;
        private System.Windows.Forms.Label Password_lbl;
        private System.Windows.Forms.TextBox UserName_txt;
        private System.Windows.Forms.TextBox Password_text;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox LogInTop_Corner_Img;
    }
}

