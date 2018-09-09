using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace zuoye
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            filecz cz = new filecz();
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
            foreach (file x in Program.fill)
            {
                if (x.Id == int.Parse(textBox1.Text))
                {

                    MessageBox.Show("编号不能重复");
                }else
                {
                    cz.addxml(textBox1.Text, box1, textBox3.Text, textBox4.Text, textBox5.Text, textBox6.Text, textBox7.Text, textBox2.Text, textBox9.Text, box2, textBox11.Text, textBox12.Text, textBox13.Text);
                    this.Close();
                    MessageBox.Show("添加成功");
                }
            }
          
        }

        private void checkedListBox1_ItemCheck(object sender, ItemCheckEventArgs e)
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
    }
}
