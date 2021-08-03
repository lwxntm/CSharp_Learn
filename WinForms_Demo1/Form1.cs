using System;
using System.Windows.Forms;

namespace WinForms_Demo1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //使用using语句，当其代码块内的代码运行完成后，资源会自动释放
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "E:\\";
                openFileDialog.Filter = "Exe File (*.exe)|*.exe|All (*.*)|*.*";
                openFileDialog.FilterIndex = 2;  //默认使用第几个过滤器
                openFileDialog.RestoreDirectory = true;
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    var filePath = openFileDialog.FileName;
                    if (!String.IsNullOrEmpty(filePath))
                    {
                        this.label1.Text = filePath;
                    }
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBox1_item.Text))
            {
                ;
                listBox1.BeginUpdate();
                listBox1.Items.Add(textBox1_item.Text);
                listBox1.EndUpdate();
                textBox1_item.Text = String.Empty;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string msg = String.Empty;

            foreach (var item in listBox1.SelectedItems)
            {
                msg += item.ToString() + ", ";
            }

            MessageBox.Show(msg);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            listBox1.BeginUpdate();
            for (int i = listBox1.SelectedItems.Count; i > 0; i--)
            {
                listBox1.Items.Remove(listBox1.SelectedItems[i - 1]);
            }
            listBox1.EndUpdate();
        }

        private void RadioCheckedChanged(object sender, EventArgs e)
        {
            if (radioButton_Red.Checked)
            { label3.ForeColor = System.Drawing.Color.Red; }

            else if (radioButton_Blue.Checked) { label3.ForeColor = System.Drawing.Color.Blue; }

            else if (radioButton3_Green.Checked) { label3.ForeColor = System.Drawing.Color.Green; }
        }
    }
}
