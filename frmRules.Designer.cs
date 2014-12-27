namespace PentominosSharp
{
    partial class frmRules
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRules));
            this.okayBtnRules = new System.Windows.Forms.Button();
            this.rulesLabel1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // okayBtnRules
            // 
            this.okayBtnRules.Location = new System.Drawing.Point(280, 333);
            this.okayBtnRules.Name = "okayBtnRules";
            this.okayBtnRules.Size = new System.Drawing.Size(147, 23);
            this.okayBtnRules.TabIndex = 0;
            this.okayBtnRules.Text = "Все понятно!";
            this.okayBtnRules.UseVisualStyleBackColor = true;
            this.okayBtnRules.Click += new System.EventHandler(this.okayBtnRules_Click);
            // 
            // rulesLabel1
            // 
            this.rulesLabel1.AutoSize = true;
            this.rulesLabel1.Font = new System.Drawing.Font("Microsoft New Tai Lue", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rulesLabel1.Location = new System.Drawing.Point(12, 9);
            this.rulesLabel1.Name = "rulesLabel1";
            this.rulesLabel1.Size = new System.Drawing.Size(618, 320);
            this.rulesLabel1.TabIndex = 1;
            this.rulesLabel1.Text = resources.GetString("rulesLabel1.Text");
            this.rulesLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(612, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(258, 254);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click_1);
            // 
            // frmRules
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(916, 368);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.rulesLabel1);
            this.Controls.Add(this.okayBtnRules);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmRules";
            this.Text = "Правила игры";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button okayBtnRules;
        private System.Windows.Forms.Label rulesLabel1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}