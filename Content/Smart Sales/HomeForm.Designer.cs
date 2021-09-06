namespace Smart_Sales
{
    partial class HomeForm
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
            this.Dashboard_lbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Dashboard_lbl
            // 
            this.Dashboard_lbl.AutoSize = true;
            this.Dashboard_lbl.Font = new System.Drawing.Font("Monotxt", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Dashboard_lbl.ForeColor = System.Drawing.Color.OldLace;
            this.Dashboard_lbl.Location = new System.Drawing.Point(401, 9);
            this.Dashboard_lbl.Name = "Dashboard_lbl";
            this.Dashboard_lbl.Size = new System.Drawing.Size(195, 35);
            this.Dashboard_lbl.TabIndex = 0;
            this.Dashboard_lbl.Text = "Dashboard";
            // 
            // HomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(950, 519);
            this.Controls.Add(this.Dashboard_lbl);
            this.Name = "HomeForm";
            this.Text = "HomeForm";
            this.Load += new System.EventHandler(this.HomeForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Dashboard_lbl;
    }
}