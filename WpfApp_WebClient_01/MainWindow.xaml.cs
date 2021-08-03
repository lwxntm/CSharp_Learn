using ServiceStack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Windows;
using System.Windows.Documents;

namespace WpfApp_WebClient_01
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //为程序创建一个类内公用的 HttpClient
        HttpClient client = new HttpClient();
        public MainWindow()
        {
            //程序初始化时，定义主要访问的地址和数据类型（Json）
            client.BaseAddress = new Uri("http://localhost:5000");
            client.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));
            InitializeComponent();
        }

        private async void button_query_Click(object sender, RoutedEventArgs e)
        {
            //若Id输入框未输入字符，查询所有用户信息
            if (String.IsNullOrEmpty(textBox.Text))
            {
                //对指定路由执行get方法，异步获取回复
                var resp = await client.GetAsync("api/Users");
                resp.EnsureSuccessStatusCode();
                //把获得的回复内容读取为字符串
                var resp_str = await resp.Content.ReadAsStringAsync();
                //用ServiceStack类的扩展方法把字符串转换为User的List
                var results = resp_str.FromJson<IEnumerable<User>>();
                var users = results.ToList();
                //创建一个字符串列表来储存想要显示的内容
                var list = new List<string>();
                foreach (var user in users)
                {
                    var line = String.Join("-", user.Id, user.FirstName,
                        user.LastName, user.Sex, user.Salary);
                    list.Add(line);
                }
                //如果有要显示的内容，显示到richTextBox里
                if (list.Count > 0)
                {
                    var para = new Paragraph();
                    para.Inlines.Add(String.Join(Environment.NewLine, list));
                    richTextBox.Document.Blocks.Add(para);
                }
            }
            else
            {
                richTextBox.Document.Blocks.Clear();
                var resp = await client.GetAsync("api/Users/" + textBox.Text);
                resp.EnsureSuccessStatusCode();
                var resp_str = await resp.Content.ReadAsStringAsync();
                var user = resp_str.FromJson<User>();
                if (user != null)
                {
                    var line = String.Join("-", user.Id, user.FirstName,
                        user.LastName, user.Sex, user.Salary);

                    textBox.Text = String.Empty;
                    var para = new Paragraph();
                    para.Inlines.Add(line);

                    richTextBox.Document.Blocks.Add(para);
                }
                else
                {
                    textBox.Text = String.Empty;
                    var para = new Paragraph();
                    para.Inlines.Add("not found this User");
                    richTextBox.Document.Blocks.Add(para);
                }


            }
        }

        private async void button_post_Click(object sender, RoutedEventArgs e)
        {
            var newUser = new User();
            newUser.Id = 201;
            newUser.FirstName = "xiaotian";
            newUser.LastName = "lei";
            newUser.Sex = "male";
            newUser.Salary = 9999;
            newUser.Address = "华石南路699号";

            //client.PostAsync方法需要HttpContent对象作为参数。该对象实际上为一个json字符串。
            HttpContent content = new StringContent(newUser.ToJson());
            content.Headers.ContentType = new System.Net.Http.Headers.MediaTypeHeaderValue("application/json");
            //带着HttpContent 发送Post请求
            var result = await client.PostAsync("api/Users/", content);
            MessageBox.Show(result.StatusCode.ToString());
        }

        private async void button_delete_Click(object sender, RoutedEventArgs e)
        {
            if (!String.IsNullOrEmpty(textBox.Text))
            {
                var result = await client.DeleteAsync("api/Users/" + textBox.Text);
                MessageBox.Show(result.StatusCode.ToString());
            }
        }
    }

    public class User
    {
        public int Id { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? Sex { get; set; }
        public string? Address { get; set; }
        public float Salary { get; set; }
    }
}
