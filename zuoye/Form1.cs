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

    public partial class Form1 : Form
    {

        filecz cz = new filecz();
       
        public string file;
        public Form1()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void bindingSource1_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
          
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }
      

        private void button1_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            List<file> ff = new List<file>();
            ff = cz.fii();
            foreach (file x in ff)
            {
                ListViewItem lvi = new ListViewItem();//开辟行数据空间
                lvi.SubItems[0].Text = x.Id.ToString();
                lvi.SubItems.Add(x.Yx);
                lvi.SubItems.Add(x.Fl);
                lvi.SubItems.Add(x.Xx);
                lvi.SubItems.Add(x.Pl);
                lvi.SubItems.Add(x.Fj);
                lvi.SubItems.Add(x.User);
                lvi.SubItems.Add(x.Date.ToString("d"));
                lvi.SubItems.Add(x.Zyz);
                lvi.SubItems.Add(x.Zt);
                lvi.SubItems.Add(x.Qrz);
                lvi.SubItems.Add(x.Qr.ToString("d"));
                lvi.SubItems.Add(x.Gx.ToString("d"));
                listView1.Items.Add(lvi);
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 fm = new Form2();
            try
            {
                int a = listView1.FocusedItem.Index;
                for (int i = 0; i < 13; i++)
                {
                    fm.str[i] = this.listView1.Items[a].SubItems[i].Text;
                }
                fm.ShowDialog();
            }
            catch(Exception ex)
            {
                MessageBox.Show("请选中一组数据");
            }

        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {

        }

        private void 保存ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cz.saveXml();
        }



        private void Form1_SizeChanged(object sender, EventArgs e)
        {
            int _Count = listView1.Columns.Count;
            int _Width = listView1.Width;
            foreach (ColumnHeader ch in listView1.Columns)
            {
                ch.Width = _Width / _Count;
            }
        }

        private void 打开ToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.Multiselect = true;
            fileDialog.Title = "请选择文件";
            fileDialog.Filter = "所有文件(*xml*)|*.xml*"; //设置要选择的文件的类型
            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                file = fileDialog.FileName;//返回文件的完整路径      
                Program.mypath = file;
            }
            List<file> ff = new List<file>();
            ff = cz.getXml(file);

            foreach (file x in ff)
            {
                ListViewItem lvi = new ListViewItem();//开辟行数据空间
                lvi.SubItems[0].Text = x.Id.ToString();
                lvi.SubItems.Add(x.Yx);
                lvi.SubItems.Add(x.Fl);
                lvi.SubItems.Add(x.Xx);
                lvi.SubItems.Add(x.Pl);
                lvi.SubItems.Add(x.Fj);
                lvi.SubItems.Add(x.User);
                lvi.SubItems.Add(x.Date.ToString("d"));
                lvi.SubItems.Add(x.Zyz);
                lvi.SubItems.Add(x.Zt);
                lvi.SubItems.Add(x.Qrz);
                lvi.SubItems.Add(x.Qr.ToString("d"));
                lvi.SubItems.Add(x.Gx.ToString("d"));
                listView1.Items.Add(lvi);
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form3 fm = new Form3();
            fm.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int a = listView1.FocusedItem.Index;
            string b=this.listView1.Items[a].SubItems[0].Text;
            cz.deletexml(b);
            MessageBox.Show("删除成功");
            listView1.Items.Clear();
            List<file> ff = new List<file>();
            ff = cz.fii();
            foreach (file x in ff)
            {
                ListViewItem lvi = new ListViewItem();//开辟行数据空间
                lvi.SubItems[0].Text = x.Id.ToString();
                lvi.SubItems.Add(x.Yx);
                lvi.SubItems.Add(x.Fl);
                lvi.SubItems.Add(x.Xx);
                lvi.SubItems.Add(x.Pl);
                lvi.SubItems.Add(x.Fj);
                lvi.SubItems.Add(x.User);
                lvi.SubItems.Add(x.Date.ToString("d"));
                lvi.SubItems.Add(x.Zyz);
                lvi.SubItems.Add(x.Zt);
                lvi.SubItems.Add(x.Qrz);
                lvi.SubItems.Add(x.Qr.ToString("d"));
                lvi.SubItems.Add(x.Gx.ToString("d"));
                listView1.Items.Add(lvi);
            }

        }

        private void 文件ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }

   
}
