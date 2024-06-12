using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UniversityLIst
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        string classlet;
        private void button1_Click(object sender, EventArgs e)
        {
            Students st = new Students(inputName.Text, inputLastname.Text, inputClass.Text, inputID.Text);
            Students.writeProduct(st);
            MessageBox.Show("Student Succesfully Added");

            CleanAll();
        }
        

        private void CleanAll()
        {
            inputName.Text = string.Empty;
            inputLastname.Text = string.Empty;
            inputID.Text = string.Empty;
            inputClass.Text = string.Empty;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            this.Hide();
            f1.ShowDialog();
            this.Close();
        }
    }
}
