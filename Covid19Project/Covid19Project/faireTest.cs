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
    public partial class faireTest : Form
    {
        string cin;
        DateTime dateTest;
        string typeTest;
        public faireTest()
        {
            InitializeComponent();
        }
        public faireTest(string _cin)
        {
            InitializeComponent();
            cin = _cin;
            typeTestCombobox.Text = cin;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
