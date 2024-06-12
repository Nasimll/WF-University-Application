using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Collections.Specialized.BitVector32;

namespace UniversityLIst
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            Students.ReadFile();

            foreach (string x in Students.dictionary.Keys)
            {
                comboBox1.Items.Add(x);
            }

        }
        private string ReadProductFromFile()
        {
            string line = "";
            FileStream fileStream = new FileStream("dataFile.txt", FileMode.Open, FileAccess.Read);
            StreamReader streamReader = new StreamReader(fileStream);

            while(!streamReader.EndOfStream)
            {
                line = streamReader.ReadLine();
            }


            streamReader.Close();
            fileStream.Close();
            return line;
        }


        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedItem = comboBox1.SelectedItem.ToString();
            if (!String.IsNullOrEmpty(selectedItem))
            {
                listBox1.Items.Clear();
                List<string> answer = Students.getWordsBasedOnKey(selectedItem);

                for (int i = 0; i < answer.Count; i++)
                {
                    listBox1.Items.Add(answer[i]);
                }

            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (var entry in Students.dictionary)
            {
                foreach (var data in entry.Value)
                {

                    Students st = new Students(data);


                    if (data.Contains(listBox1.SelectedItem.ToString()))
                    {

                        pname.Text = st.name;
                        plastname.Text = st.lastname;
                        pCLass.Text = st.classes;
                        pID.Text = st.id;

                        return;
                    }
                }
            }

        }

        private void backbtn_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            this.Hide();
            f1.ShowDialog();
            this.Close();

        }
    }
}
