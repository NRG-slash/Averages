namespace Averages
{
    partial class Averages
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
            this.lblMark1 = new System.Windows.Forms.Label();
            this.lblMark2 = new System.Windows.Forms.Label();
            this.lblMark3 = new System.Windows.Forms.Label();
            this.lblMark4 = new System.Windows.Forms.Label();
            this.lblMark5 = new System.Windows.Forms.Label();
            this.txtMark1 = new System.Windows.Forms.TextBox();
            this.txtMark2 = new System.Windows.Forms.TextBox();
            this.txtMark3 = new System.Windows.Forms.TextBox();
            this.txtMark4 = new System.Windows.Forms.TextBox();
            this.txtMark5 = new System.Windows.Forms.TextBox();
            this.lblDisplay = new System.Windows.Forms.Label();
            this.btnAverage = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblMark1
            // 
            this.lblMark1.Location = new System.Drawing.Point(436, 147);
            this.lblMark1.Name = "lblMark1";
            this.lblMark1.Size = new System.Drawing.Size(119, 23);
            this.lblMark1.TabIndex = 0;
            this.lblMark1.Text = "Enter first mark";
            // 
            // lblMark2
            // 
            this.lblMark2.Location = new System.Drawing.Point(436, 174);
            this.lblMark2.Name = "lblMark2";
            this.lblMark2.Size = new System.Drawing.Size(119, 23);
            this.lblMark2.TabIndex = 1;
            this.lblMark2.Text = "Enter second mark";
            // 
            // lblMark3
            // 
            this.lblMark3.Location = new System.Drawing.Point(436, 201);
            this.lblMark3.Name = "lblMark3";
            this.lblMark3.Size = new System.Drawing.Size(119, 23);
            this.lblMark3.TabIndex = 2;
            this.lblMark3.Text = "Enter third mark";
            // 
            // lblMark4
            // 
            this.lblMark4.Location = new System.Drawing.Point(436, 225);
            this.lblMark4.Name = "lblMark4";
            this.lblMark4.Size = new System.Drawing.Size(119, 23);
            this.lblMark4.TabIndex = 3;
            this.lblMark4.Text = "Enter fourth mark";
            // 
            // lblMark5
            // 
            this.lblMark5.Location = new System.Drawing.Point(436, 250);
            this.lblMark5.Name = "lblMark5";
            this.lblMark5.Size = new System.Drawing.Size(119, 23);
            this.lblMark5.TabIndex = 4;
            this.lblMark5.Text = "Enter fifth mark";
            // 
            // txtMark1
            // 
            this.txtMark1.Location = new System.Drawing.Point(561, 144);
            this.txtMark1.Name = "txtMark1";
            this.txtMark1.Size = new System.Drawing.Size(196, 20);
            this.txtMark1.TabIndex = 5;
            this.txtMark1.TextChanged += new System.EventHandler(this.txtMark1_TextChanged);
            // 
            // txtMark2
            // 
            this.txtMark2.Location = new System.Drawing.Point(561, 171);
            this.txtMark2.Name = "txtMark2";
            this.txtMark2.Size = new System.Drawing.Size(196, 20);
            this.txtMark2.TabIndex = 6;
            this.txtMark2.TextChanged += new System.EventHandler(this.txtMark2_TextChanged);
            // 
            // txtMark3
            // 
            this.txtMark3.Location = new System.Drawing.Point(561, 198);
            this.txtMark3.Name = "txtMark3";
            this.txtMark3.Size = new System.Drawing.Size(196, 20);
            this.txtMark3.TabIndex = 7;
            this.txtMark3.TextChanged += new System.EventHandler(this.txtMark3_TextChanged);
            // 
            // txtMark4
            // 
            this.txtMark4.Location = new System.Drawing.Point(561, 222);
            this.txtMark4.Name = "txtMark4";
            this.txtMark4.Size = new System.Drawing.Size(196, 20);
            this.txtMark4.TabIndex = 8;
            this.txtMark4.TextChanged += new System.EventHandler(this.txtMark4_TextChanged);
            // 
            // txtMark5
            // 
            this.txtMark5.Location = new System.Drawing.Point(561, 247);
            this.txtMark5.Name = "txtMark5";
            this.txtMark5.Size = new System.Drawing.Size(196, 20);
            this.txtMark5.TabIndex = 9;
            this.txtMark5.TextChanged += new System.EventHandler(this.txtMark5_TextChanged);
            // 
            // lblDisplay
            // 
            this.lblDisplay.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lblDisplay.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblDisplay.Location = new System.Drawing.Point(436, 455);
            this.lblDisplay.Name = "lblDisplay";
            this.lblDisplay.Size = new System.Drawing.Size(321, 141);
            this.lblDisplay.TabIndex = 10;
            this.lblDisplay.Click += new System.EventHandler(this.lblDisplay_Click);
            // 
            // btnAverage
            // 
            this.btnAverage.Location = new System.Drawing.Point(439, 315);
            this.btnAverage.Name = "btnAverage";
            this.btnAverage.Size = new System.Drawing.Size(318, 108);
            this.btnAverage.TabIndex = 11;
            this.btnAverage.Text = "Calculate Average";
            this.btnAverage.UseVisualStyleBackColor = true;
            this.btnAverage.Click += new System.EventHandler(this.btnAverage_Click);
            // 
            // Averages
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1327, 635);
            this.Controls.Add(this.btnAverage);
            this.Controls.Add(this.lblDisplay);
            this.Controls.Add(this.txtMark5);
            this.Controls.Add(this.txtMark4);
            this.Controls.Add(this.txtMark3);
            this.Controls.Add(this.txtMark2);
            this.Controls.Add(this.txtMark1);
            this.Controls.Add(this.lblMark5);
            this.Controls.Add(this.lblMark4);
            this.Controls.Add(this.lblMark3);
            this.Controls.Add(this.lblMark2);
            this.Controls.Add(this.lblMark1);
            this.Name = "Averages";
            this.Text = "Averages";
            this.Load += new System.EventHandler(this.Averages_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMark1;
        private System.Windows.Forms.Label lblMark2;
        private System.Windows.Forms.Label lblMark3;
        private System.Windows.Forms.Label lblMark4;
        private System.Windows.Forms.Label lblMark5;
        private System.Windows.Forms.TextBox txtMark1;
        private System.Windows.Forms.TextBox txtMark2;
        private System.Windows.Forms.TextBox txtMark3;
        private System.Windows.Forms.TextBox txtMark4;
        private System.Windows.Forms.TextBox txtMark5;
        private System.Windows.Forms.Label lblDisplay;
        private System.Windows.Forms.Button btnAverage;
    }
}

