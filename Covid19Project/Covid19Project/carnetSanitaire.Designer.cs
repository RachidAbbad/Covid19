namespace Covid19Project
{
    partial class carnetSanitaire
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
            this.button1 = new System.Windows.Forms.Button();
            this.cinLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.datevaccinationLabel = new System.Windows.Forms.Label();
            this.faitvaccinLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(123, 208);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(117, 46);
            this.button1.TabIndex = 0;
            this.button1.Text = "Quitter";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cinLabel
            // 
            this.cinLabel.AutoSize = true;
            this.cinLabel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cinLabel.Location = new System.Drawing.Point(23, 53);
            this.cinLabel.Name = "cinLabel";
            this.cinLabel.Size = new System.Drawing.Size(217, 25);
            this.cinLabel.TabIndex = 1;
            this.cinLabel.Text = "Carnet Sanitaire Pour : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 21);
            this.label2.TabIndex = 2;
            this.label2.Text = "Vaccin Fait :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(139, 21);
            this.label3.TabIndex = 3;
            this.label3.Text = "Date Vaccination :";
            // 
            // datevaccinationLabel
            // 
            this.datevaccinationLabel.AutoSize = true;
            this.datevaccinationLabel.Location = new System.Drawing.Point(173, 145);
            this.datevaccinationLabel.Name = "datevaccinationLabel";
            this.datevaccinationLabel.Size = new System.Drawing.Size(34, 21);
            this.datevaccinationLabel.TabIndex = 5;
            this.datevaccinationLabel.Text = "----";
            // 
            // faitvaccinLabel
            // 
            this.faitvaccinLabel.AutoSize = true;
            this.faitvaccinLabel.Location = new System.Drawing.Point(173, 101);
            this.faitvaccinLabel.Name = "faitvaccinLabel";
            this.faitvaccinLabel.Size = new System.Drawing.Size(34, 21);
            this.faitvaccinLabel.TabIndex = 4;
            this.faitvaccinLabel.Text = "----";
            // 
            // carnetSanitaire
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(352, 276);
            this.Controls.Add(this.datevaccinationLabel);
            this.Controls.Add(this.faitvaccinLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cinLabel);
            this.Controls.Add(this.button1);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "carnetSanitaire";
            this.Text = "carnetSanitaire";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label cinLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label datevaccinationLabel;
        private System.Windows.Forms.Label faitvaccinLabel;
    }
}