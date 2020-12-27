using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Covid19Project
{
    public partial class carnetSanitaire : Form
    {
        private string cin;
        private string faitvaccin;
        private string DateVaccination;

        public carnetSanitaire(string _cin, string _faitvaccin, string _DateVaccination)
        {
            cin = _cin;
            faitvaccin = _faitvaccin;
            DateVaccination = _DateVaccination.Substring(0,10);
            InitializeComponent();
            fillLabels();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void fillLabels()
        {
            cinLabel.Text += cin;
            if (faitvaccin == "0")
                faitvaccinLabel.Text = "Vaccin non Fait";
            else if(faitvaccin == "1")
                faitvaccinLabel.Text = "Vaccin Fait";
            datevaccinationLabel.Text = DateVaccination;
        }
    }
}
