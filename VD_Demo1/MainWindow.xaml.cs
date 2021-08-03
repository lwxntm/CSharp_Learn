using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Documents;
namespace VD_Demo1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            //从获得的输入窗口里创建新的User类
            var User = new User
            {
                Id = Convert.ToInt32(textBox_Id.Text),
                FirstName = textBox1_First_Name.Text,
                LastName = textBox2_Last_Name.Text,
                Sex = textBox3_Sex.Text,
                Email = textBox4_Email.Text,
                Salary = (float)Convert.ToDecimal(textBox5_Salary.Text)
            };
            //创建验证器
            var userValidator = new UserValidator();
            //执行验证，获取结果
            var results = userValidator.Validate(User);
            //创建用于储存错误信息的数组
            var errors = new List<string>();
            foreach (var error in results.Errors)
            {
                //把错误信息添加到数组中
                errors.Add(error.ToString());
            }
            //老一套，把数组里所有字符串换行显示到richTextBox里
            var para = new Paragraph();
            para.Inlines.Add(String.Join(Environment.NewLine, errors));
            richTextBox.Document.Blocks.Clear();
            richTextBox.Document.Blocks.Add(para);

        }
    }
}
