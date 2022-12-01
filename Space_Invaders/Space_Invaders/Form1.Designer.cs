namespace Space_Invaders
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.vida3 = new System.Windows.Forms.PictureBox();
            this.vida1 = new System.Windows.Forms.PictureBox();
            this.vida2 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.vida3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vida1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vida2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Showcard Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(1, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "Score:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Showcard Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(79, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 27);
            this.label2.TabIndex = 1;
            this.label2.Text = "000";
            // 
            // vida3
            // 
            this.vida3.BackColor = System.Drawing.SystemColors.WindowText;
            this.vida3.Image = ((System.Drawing.Image)(resources.GetObject("vida3.Image")));
            this.vida3.Location = new System.Drawing.Point(1143, 0);
            this.vida3.Name = "vida3";
            this.vida3.Size = new System.Drawing.Size(35, 35);
            this.vida3.TabIndex = 2;
            this.vida3.TabStop = false;
            // 
            // vida1
            // 
            this.vida1.BackColor = System.Drawing.SystemColors.WindowText;
            this.vida1.Image = ((System.Drawing.Image)(resources.GetObject("vida1.Image")));
            this.vida1.Location = new System.Drawing.Point(1059, 0);
            this.vida1.Name = "vida1";
            this.vida1.Size = new System.Drawing.Size(35, 35);
            this.vida1.TabIndex = 3;
            this.vida1.TabStop = false;
            // 
            // vida2
            // 
            this.vida2.BackColor = System.Drawing.SystemColors.WindowText;
            this.vida2.Image = ((System.Drawing.Image)(resources.GetObject("vida2.Image")));
            this.vida2.Location = new System.Drawing.Point(1101, 0);
            this.vida2.Name = "vida2";
            this.vida2.Size = new System.Drawing.Size(35, 35);
            this.vida2.TabIndex = 4;
            this.vida2.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1180, 657);
            this.Controls.Add(this.vida2);
            this.Controls.Add(this.vida1);
            this.Controls.Add(this.vida3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1200, 700);
            this.MinimumSize = new System.Drawing.Size(1200, 700);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Space Invaders";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            ((System.ComponentModel.ISupportInitialize)(this.vida3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vida1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vida2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private PictureBox vida3;
        private PictureBox vida1;
        private PictureBox vida2;
        private System.Windows.Forms.Timer timer1;
    }
}