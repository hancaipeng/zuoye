using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace zuoye
{
    public partial class Form2 : Form
    {
        public string[] str = new string[13];
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            this.textBox1.Text = str[0];
            this.textBox2.Text = str[7];
            this.textBox3.Text = str[2];
            this.textBox4.Text = str[3];
            this.textBox5.Text = str[4];
            this.textBox6.Text = str[5];
            this.textBox7.Text = str[6];
          
            this.textBox9.Text = str[8];
          
            this.textBox11.Text = str[10];
            this.textBox12.Text = str[11];
            this.textBox13.Text = str[12];
        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
          
        }
      

        private void checkedListBox1_ItemCheck_1(object sender, ItemCheckEventArgs e)
        {
            if (checkedListBox1.CheckedItems.Count > 0)
            {
                for (int i = 0; i < checkedListBox1.Items.Count; i++)
                {
                    if (i != e.Index)
                    {
                        
                        checkedListBox1.SetItemChecked(i, false);
                    }
                }
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void checkedListBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void checkedListBox2_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            if (checkedListBox2.CheckedItems.Count > 0)
            {
                for (int i = 0; i < checkedListBox2.Items.Count; i++)
                {
                    if (i != e.Index)
                    {
                        
                        checkedListBox2.SetItemChecked(i, false);
                    }
                }
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
           
            string box1 = "";
            string box2 = "";
            for (int i = 0; i < checkedListBox1.Items.Count; i++)
            {
                if (checkedListBox1.GetItemChecked(i))//是否选中
                {
                    box1 = checkedListBox1.Items[i].ToString();
                }
            }
            for (int i = 0; i < checkedListBox2.Items.Count; i++)
            {
                if (checkedListBox2.GetItemChecked(i))//是否选中
                {
                    box2 = checkedListBox2.Items[i].ToString();
                }
            }
            filecz fi = new filecz();
            fi.updateXml(textBox1.Text, box1, textBox3.Text, textBox4.Text, textBox5.Text, textBox6.Text, textBox7.Text, textBox2.Text, textBox9.Text, box2, textBox11.Text, textBox12.Text, textBox13.Text);

            }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
