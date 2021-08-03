using System;
using System.Net;
using System.Text;
namespace Net_Misc_Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        public static string DownloadString(string url)//取网页源码，编码转换，调用FindString()
        {
            try
            {
                var client = new WebClient();
                var clientText = client.DownloadData(url); //取网页源码
                var text = Encoding.GetEncoding("UTF-8").GetString(clientText); //编码转换
                                                                                //string str = FindString(text);
                return text;
            }
            catch (Exception e)
            {
                return e.ToString();
            }
        }

        public static void SendServerMsg(string title = "默认title", string desp = "默认desp")
        {
            // string title = "默认title";
            // string desp = "默认desp";
            string sjUrl = $"https://sctapi.ftqq.com/SCT58835ThE0bjx5vXBBsmNq8OijEvvmM.send?title={title}&desp={desp}";
            WebClient webClient = new WebClient();
            webClient.DownloadData(sjUrl);
        }
    }
}
