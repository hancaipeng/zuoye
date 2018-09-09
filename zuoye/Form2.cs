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
            this.dateTimePicker1.Value =DateTime.Parse(str[7]);


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
            this.Close();
            MessageBox.Show("更新成功");
            

            }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox9_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox12_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox13_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click_1(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
