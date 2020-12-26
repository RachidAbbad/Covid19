namespace Covid19Project
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuPanel = new System.Windows.Forms.Panel();
            this.button16 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.citoyenPanel = new System.Windows.Forms.Panel();
            this.button7 = new System.Windows.Forms.Button();
            this.citoyenDataGrid = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.suspectPanel = new System.Windows.Forms.Panel();
            this.suspectDataGrid = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.button10 = new System.Windows.Forms.Button();
            this.patientPanel = new System.Windows.Forms.Panel();
            this.button6 = new System.Windows.Forms.Button();
            this.patientDataGrid = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.button13 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.retablieDataGrid = new System.Windows.Forms.DataGridView();
            this.retabliePanel = new System.Windows.Forms.Panel();
            this.vaccinePanel = new System.Windows.Forms.Panel();
            this.vaccineDataGrid = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.ajoutVaccineVP = new System.Windows.Forms.Button();
            this.menuPanel.SuspendLayout();
            this.citoyenPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.citoyenDataGrid)).BeginInit();
            this.suspectPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.suspectDataGrid)).BeginInit();
            this.patientPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.patientDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.retablieDataGrid)).BeginInit();
            this.retabliePanel.SuspendLayout();
            this.vaccinePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vaccineDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // menuPanel
            // 
            this.menuPanel.BackColor = System.Drawing.Color.MediumTurquoise;
            this.menuPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.menuPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.menuPanel.Controls.Add(this.button16);
            this.menuPanel.Controls.Add(this.button4);
            this.menuPanel.Controls.Add(this.button3);
            this.menuPanel.Controls.Add(this.button2);
            this.menuPanel.Controls.Add(this.button1);
            this.menuPanel.Location = new System.Drawing.Point(-5, 78);
            this.menuPanel.Name = "menuPanel";
            this.menuPanel.Size = new System.Drawing.Size(207, 469);
            this.menuPanel.TabIndex = 0;
            // 
            // button16
            // 
            this.button16.BackColor = System.Drawing.Color.MintCream;
            this.button16.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button16.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button16.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button16.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button16.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button16.Location = new System.Drawing.Point(0, 376);
            this.button16.Name = "button16";
            this.button16.Size = new System.Drawing.Size(204, 85);
            this.button16.TabIndex = 4;
            this.button16.Text = "Vaccinés";
            this.button16.UseVisualStyleBackColor = false;
            this.button16.Click += new System.EventHandler(this.button16_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.MintCream;
            this.button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button4.Location = new System.Drawing.Point(0, 285);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(204, 85);
            this.button4.TabIndex = 3;
            this.button4.Text = "Rétablies";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.MintCream;
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button3.Location = new System.Drawing.Point(0, 194);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(204, 85);
            this.button3.TabIndex = 2;
            this.button3.Text = "Patient";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.MintCream;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button2.Location = new System.Drawing.Point(0, 103);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(204, 85);
            this.button2.TabIndex = 1;
            this.button2.Text = "Suspect";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.MintCream;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.Location = new System.Drawing.Point(0, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(204, 85);
            this.button1.TabIndex = 0;
            this.button1.Text = "Citoyen";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.AutoSize = true;
            this.flowLayoutPanel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(208, 104);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(0, 0);
            this.flowLayoutPanel2.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(259, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(635, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "Suivre et le contrôle de la propagation de la pandémie covid 19";
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(843, 153);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(153, 60);
            this.button5.TabIndex = 4;
            this.button5.Text = "Ajouter au liste du vaccinés";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // citoyenPanel
            // 
            this.citoyenPanel.AllowDrop = true;
            this.citoyenPanel.BackColor = System.Drawing.Color.MediumTurquoise;
            this.citoyenPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.citoyenPanel.Controls.Add(this.button7);
            this.citoyenPanel.Controls.Add(this.citoyenDataGrid);
            this.citoyenPanel.Controls.Add(this.label3);
            this.citoyenPanel.Controls.Add(this.button5);
            this.citoyenPanel.Location = new System.Drawing.Point(217, 78);
            this.citoyenPanel.Name = "citoyenPanel";
            this.citoyenPanel.Size = new System.Drawing.Size(1003, 469);
            this.citoyenPanel.TabIndex = 7;
            // 
            // button7
            // 
            this.button7.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.Location = new System.Drawing.Point(843, 46);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(153, 60);
            this.button7.TabIndex = 10;
            this.button7.Text = "Ajouter au liste du suspects";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // citoyenDataGrid
            // 
            this.citoyenDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.citoyenDataGrid.Location = new System.Drawing.Point(13, 46);
            this.citoyenDataGrid.Name = "citoyenDataGrid";
            this.citoyenDataGrid.Size = new System.Drawing.Size(824, 372);
            this.citoyenDataGrid.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(243, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(143, 21);
            this.label3.TabIndex = 8;
            this.label3.Text = "Liste des citoyens";
            // 
            // suspectPanel
            // 
            this.suspectPanel.AllowDrop = true;
            this.suspectPanel.BackColor = System.Drawing.Color.MediumTurquoise;
            this.suspectPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.suspectPanel.Controls.Add(this.suspectDataGrid);
            this.suspectPanel.Controls.Add(this.label2);
            this.suspectPanel.Controls.Add(this.button10);
            this.suspectPanel.Location = new System.Drawing.Point(217, 78);
            this.suspectPanel.Name = "suspectPanel";
            this.suspectPanel.Size = new System.Drawing.Size(1003, 469);
            this.suspectPanel.TabIndex = 8;
            // 
            // suspectDataGrid
            // 
            this.suspectDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.suspectDataGrid.Location = new System.Drawing.Point(13, 46);
            this.suspectDataGrid.Name = "suspectDataGrid";
            this.suspectDataGrid.Size = new System.Drawing.Size(824, 372);
            this.suspectDataGrid.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(243, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 21);
            this.label2.TabIndex = 8;
            this.label2.Text = "Liste des suspects";
            // 
            // button10
            // 
            this.button10.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button10.Location = new System.Drawing.Point(843, 46);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(153, 60);
            this.button10.TabIndex = 4;
            this.button10.Text = "Faire Test";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // patientPanel
            // 
            this.patientPanel.AllowDrop = true;
            this.patientPanel.BackColor = System.Drawing.Color.MediumTurquoise;
            this.patientPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.patientPanel.Controls.Add(this.button6);
            this.patientPanel.Controls.Add(this.patientDataGrid);
            this.patientPanel.Controls.Add(this.label4);
            this.patientPanel.Controls.Add(this.button13);
            this.patientPanel.Location = new System.Drawing.Point(217, 78);
            this.patientPanel.Name = "patientPanel";
            this.patientPanel.Size = new System.Drawing.Size(1003, 469);
            this.patientPanel.TabIndex = 9;
            // 
            // button6
            // 
            this.button6.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.Location = new System.Drawing.Point(843, 153);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(153, 60);
            this.button6.TabIndex = 10;
            this.button6.Text = "Mettre En Quarantine";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // patientDataGrid
            // 
            this.patientDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.patientDataGrid.Location = new System.Drawing.Point(13, 46);
            this.patientDataGrid.Name = "patientDataGrid";
            this.patientDataGrid.Size = new System.Drawing.Size(824, 372);
            this.patientDataGrid.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(243, 11);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(141, 21);
            this.label4.TabIndex = 8;
            this.label4.Text = "Liste des Patients";
            // 
            // button13
            // 
            this.button13.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button13.Location = new System.Drawing.Point(843, 46);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(153, 60);
            this.button13.TabIndex = 4;
            this.button13.Text = "Faire Test";
            this.button13.UseVisualStyleBackColor = true;
            this.button13.Click += new System.EventHandler(this.button13_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(243, 11);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(149, 21);
            this.label5.TabIndex = 8;
            this.label5.Text = "Liste des Rétablies";
            // 
            // retablieDataGrid
            // 
            this.retablieDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.retablieDataGrid.Location = new System.Drawing.Point(13, 46);
            this.retablieDataGrid.Name = "retablieDataGrid";
            this.retablieDataGrid.Size = new System.Drawing.Size(972, 372);
            this.retablieDataGrid.TabIndex = 9;
            // 
            // retabliePanel
            // 
            this.retabliePanel.AllowDrop = true;
            this.retabliePanel.BackColor = System.Drawing.Color.MediumTurquoise;
            this.retabliePanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.retabliePanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.retabliePanel.Controls.Add(this.retablieDataGrid);
            this.retabliePanel.Controls.Add(this.label5);
            this.retabliePanel.Location = new System.Drawing.Point(217, 78);
            this.retabliePanel.Name = "retabliePanel";
            this.retabliePanel.Size = new System.Drawing.Size(1003, 469);
            this.retabliePanel.TabIndex = 10;
            // 
            // vaccinePanel
            // 
            this.vaccinePanel.AllowDrop = true;
            this.vaccinePanel.BackColor = System.Drawing.Color.MediumTurquoise;
            this.vaccinePanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.vaccinePanel.Controls.Add(this.vaccineDataGrid);
            this.vaccinePanel.Controls.Add(this.label6);
            this.vaccinePanel.Controls.Add(this.ajoutVaccineVP);
            this.vaccinePanel.Location = new System.Drawing.Point(220, 78);
            this.vaccinePanel.Name = "vaccinePanel";
            this.vaccinePanel.Size = new System.Drawing.Size(1003, 469);
            this.vaccinePanel.TabIndex = 11;
            // 
            // vaccineDataGrid
            // 
            this.vaccineDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.vaccineDataGrid.Location = new System.Drawing.Point(13, 46);
            this.vaccineDataGrid.Name = "vaccineDataGrid";
            this.vaccineDataGrid.Size = new System.Drawing.Size(825, 372);
            this.vaccineDataGrid.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(243, 11);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(146, 21);
            this.label6.TabIndex = 8;
            this.label6.Text = "Liste des Vaccinés";
            // 
            // ajoutVaccineVP
            // 
            this.ajoutVaccineVP.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ajoutVaccineVP.Location = new System.Drawing.Point(844, 47);
            this.ajoutVaccineVP.Name = "ajoutVaccineVP";
            this.ajoutVaccineVP.Size = new System.Drawing.Size(153, 60);
            this.ajoutVaccineVP.TabIndex = 6;
            this.ajoutVaccineVP.Text = "Ajouter Vacciné";
            this.ajoutVaccineVP.UseVisualStyleBackColor = true;
            this.ajoutVaccineVP.Click += new System.EventHandler(this.ajoutVaccineVP_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1232, 544);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.flowLayoutPanel2);
            this.Controls.Add(this.menuPanel);
            this.Controls.Add(this.patientPanel);
            this.Controls.Add(this.vaccinePanel);
            this.Controls.Add(this.retabliePanel);
            this.Controls.Add(this.citoyenPanel);
            this.Controls.Add(this.suspectPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Activated += new System.EventHandler(this.Form1_Activated);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuPanel.ResumeLayout(false);
            this.citoyenPanel.ResumeLayout(false);
            this.citoyenPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.citoyenDataGrid)).EndInit();
            this.suspectPanel.ResumeLayout(false);
            this.suspectPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.suspectDataGrid)).EndInit();
            this.patientPanel.ResumeLayout(false);
            this.patientPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.patientDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.retablieDataGrid)).EndInit();
            this.retabliePanel.ResumeLayout(false);
            this.retabliePanel.PerformLayout();
            this.vaccinePanel.ResumeLayout(false);
            this.vaccinePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vaccineDataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel menuPanel;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Panel citoyenPanel;
        private System.Windows.Forms.DataGridView citoyenDataGrid;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel suspectPanel;
        private System.Windows.Forms.DataGridView suspectDataGrid;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Panel patientPanel;
        private System.Windows.Forms.DataGridView patientDataGrid;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView retablieDataGrid;
        private System.Windows.Forms.Panel retabliePanel;
        private System.Windows.Forms.Button button16;
        private System.Windows.Forms.Panel vaccinePanel;
        private System.Windows.Forms.DataGridView vaccineDataGrid;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button ajoutVaccineVP;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button6;
    }
}

