namespace PlenussZKTeco1
{
    partial class Form1
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
            this.conectarBtn = new System.Windows.Forms.Button();
            this.ipTB = new System.Windows.Forms.TextBox();
            this.portTB = new System.Windows.Forms.TextBox();
            this.IpLabel = new System.Windows.Forms.Label();
            this.portLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // conectarBtn
            // 
            this.conectarBtn.Location = new System.Drawing.Point(12, 29);
            this.conectarBtn.Name = "conectarBtn";
            this.conectarBtn.Size = new System.Drawing.Size(75, 23);
            this.conectarBtn.TabIndex = 0;
            this.conectarBtn.Text = "Conectar";
            this.conectarBtn.UseVisualStyleBackColor = true;
            this.conectarBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // ipTB
            // 
            this.ipTB.Location = new System.Drawing.Point(12, 104);
            this.ipTB.Name = "ipTB";
            this.ipTB.Size = new System.Drawing.Size(100, 20);
            this.ipTB.TabIndex = 1;
            // 
            // portTB
            // 
            this.portTB.Location = new System.Drawing.Point(172, 104);
            this.portTB.Name = "portTB";
            this.portTB.Size = new System.Drawing.Size(100, 20);
            this.portTB.TabIndex = 2;
            // 
            // IpLabel
            // 
            this.IpLabel.AutoSize = true;
            this.IpLabel.Location = new System.Drawing.Point(18, 88);
            this.IpLabel.Name = "IpLabel";
            this.IpLabel.Size = new System.Drawing.Size(17, 13);
            this.IpLabel.TabIndex = 4;
            this.IpLabel.Text = "IP";
            // 
            // portLabel
            // 
            this.portLabel.AutoSize = true;
            this.portLabel.Location = new System.Drawing.Point(169, 88);
            this.portLabel.Name = "portLabel";
            this.portLabel.Size = new System.Drawing.Size(38, 13);
            this.portLabel.TabIndex = 5;
            this.portLabel.Text = "Puerto";
            this.portLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.portLabel);
            this.Controls.Add(this.IpLabel);
            this.Controls.Add(this.portTB);
            this.Controls.Add(this.ipTB);
            this.Controls.Add(this.conectarBtn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button conectarBtn;
        private System.Windows.Forms.TextBox ipTB;
        private System.Windows.Forms.TextBox portTB;
        private System.Windows.Forms.Label IpLabel;
        private System.Windows.Forms.Label portLabel;
    }
}

