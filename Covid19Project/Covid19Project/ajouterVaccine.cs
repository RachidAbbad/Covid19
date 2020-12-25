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
    public partial class ajouterVaccine : Form
    {
        string cin;
        DateTime dateVaccination;
        string typeVaccin;
        public ajouterVaccine()
        {
            InitializeComponent();
        }
        public ajouterVaccine(string _cin)
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
