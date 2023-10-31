namespace ćwiczenia2_algorytmy_i_stuktury_danych
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
            this.btnStart = new System.Windows.Forms.Button();
            this.liczbaN = new System.Windows.Forms.NumericUpDown();
            this.btnSb = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.liczbaN)).BeginInit();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(326, 319);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(149, 50);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "btnStart";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // liczbaN
            // 
            this.liczbaN.Location = new System.Drawing.Point(339, 375);
            this.liczbaN.Name = "liczbaN";
            this.liczbaN.Size = new System.Drawing.Size(120, 23);
            this.liczbaN.TabIndex = 1;
            this.liczbaN.ValueChanged += new System.EventHandler(this.liczbaN_ValueChanged);
            // 
            // btnSb
            // 
            this.btnSb.Location = new System.Drawing.Point(540, 319);
            this.btnSb.Name = "btnSb";
            this.btnSb.Size = new System.Drawing.Size(114, 35);
            this.btnSb.TabIndex = 2;
            this.btnSb.Text = "SB";
            this.btnSb.UseVisualStyleBackColor = true;
            this.btnSb.Click += new System.EventHandler(this.btnSb_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(835, 477);
            this.Controls.Add(this.btnSb);
            this.Controls.Add(this.liczbaN);
            this.Controls.Add(this.btnStart);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.liczbaN)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Button btnStart;
        private NumericUpDown liczbaN;
        private Button btnSb;
    }
}