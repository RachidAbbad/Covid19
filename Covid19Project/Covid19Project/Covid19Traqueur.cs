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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            patientPanel.Visible = false;
            suspectPanel.Visible = false;
            vaccinateurPanel.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            patientPanel.Visible = false;
            suspectPanel.Visible = false;
            vaccinateurPanel.Visible = false;
            citoyenPanel.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            patientPanel.Visible = false;
            suspectPanel.Visible = true;
            vaccinateurPanel.Visible = false;
            citoyenPanel.Visible = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            patientPanel.Visible = true;
            suspectPanel.Visible = false;
            vaccinateurPanel.Visible = false;
            citoyenPanel.Visible = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            patientPanel.Visible = false;
            suspectPanel.Visible = false;
            citoyenPanel.Visible = false;
            vaccinateurPanel.Visible = true;
        }
    }
}
