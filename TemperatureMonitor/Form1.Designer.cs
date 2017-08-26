namespace TemperatureMonitor
{
    partial class formTemp
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
            this.btnSunny = new System.Windows.Forms.Button();
            this.btnRainy = new System.Windows.Forms.Button();
            this.btnAdhoc = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblTemp = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnSunny
            // 
            this.btnSunny.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnSunny.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSunny.Location = new System.Drawing.Point(12, 80);
            this.btnSunny.Name = "btnSunny";
            this.btnSunny.Size = new System.Drawing.Size(75, 23);
            this.btnSunny.TabIndex = 0;
            this.btnSunny.Text = "Sunny";
            this.btnSunny.UseVisualStyleBackColor = false;
            // 
            // btnRainy
            // 
            this.btnRainy.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnRainy.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRainy.Location = new System.Drawing.Point(106, 78);
            this.btnRainy.Name = "btnRainy";
            this.btnRainy.Size = new System.Drawing.Size(74, 25);
            this.btnRainy.TabIndex = 1;
            this.btnRainy.Text = "Rainy";
            this.btnRainy.UseVisualStyleBackColor = false;
            // 
            // btnAdhoc
            // 
            this.btnAdhoc.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnAdhoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdhoc.Location = new System.Drawing.Point(193, 78);
            this.btnAdhoc.Name = "btnAdhoc";
            this.btnAdhoc.Size = new System.Drawing.Size(75, 25);
            this.btnAdhoc.TabIndex = 2;
            this.btnAdhoc.Text = "Ad-hoc";
            this.btnAdhoc.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.259F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(39, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Now temperature is : ";
            // 
            // lblTemp
            // 
            this.lblTemp.AutoSize = true;
            this.lblTemp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTemp.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblTemp.Location = new System.Drawing.Point(181, 29);
            this.lblTemp.Name = "lblTemp";
            this.lblTemp.Size = new System.Drawing.Size(0, 15);
            this.lblTemp.TabIndex = 4;
            this.lblTemp.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // formTemp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(280, 136);
            this.Controls.Add(this.lblTemp);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAdhoc);
            this.Controls.Add(this.btnRainy);
            this.Controls.Add(this.btnSunny);
            this.Name = "formTemp";
            this.Text = "Temperature Monitor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSunny;
        private System.Windows.Forms.Button btnRainy;
        private System.Windows.Forms.Button btnAdhoc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTemp;
    }
}

