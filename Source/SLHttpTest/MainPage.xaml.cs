using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using System.IO;

namespace SLHttpTest
{
    public partial class MainPage : UserControl
    {
        string url = "http://210.21.98.82/common?CMD=login&user_name=test&pwd=12345678";
        WebClient client = new WebClient();

        public MainPage()
        {
            InitializeComponent();
            client.DownloadStringCompleted += new DownloadStringCompletedEventHandler(client_DownloadStringCompleted);
        }

        void client_DownloadStringCompleted(object sender, DownloadStringCompletedEventArgs e)
        {
            if (e.Error != null)
            {
                MessageBox.Show("ERROR:" + e.Error.Message);
                
            }
            else
            {
                MessageBox.Show(e.Result);
            }
            
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MYHTTPSR.HttpHelperSoapClient client = new MYHTTPSR.HttpHelperSoapClient();
            client.GetURLCompleted += new EventHandler<MYHTTPSR.GetURLCompletedEventArgs>(client_GetURLCompleted);
            client.GetURLAsync(url);

            #region 无用
            ////client.DownloadStringAsync(new Uri(url));

            ////设置Uri地址

            //Uri endpoint = new Uri(url);
            ////获取POST到Server端的数据
            //WebRequest request = WebRequest.Create(endpoint);  

            //request.Method = "POST";

            //request.ContentType = "application/x-www-form-urlencoded";



            ////向服务器端POST信息#region 向服务器端POST信息
            //request.BeginGetRequestStream(new AsyncCallback(RequestCallBack), request);
            #endregion
        }

        #region 无用
        void client_GetURLCompleted(object sender, MYHTTPSR.GetURLCompletedEventArgs e)
        {
            if (e.Error != null)
            {
                MessageBox.Show("ERROR:" + e.Error.Message);
            }
            else
            {
                MessageBox.Show(e.Result);
            }
        }

        private  void RequestCallBack(IAsyncResult asynchronousResult)
        {

            WebRequest request = (WebRequest)asynchronousResult.AsyncState;
            request.BeginGetResponse(new AsyncCallback(OnResponse), request);
        }

        protected void OnResponse(IAsyncResult ar)
        {
            WebRequest wrq = (WebRequest)ar.AsyncState;

            //对应 BeginGetResponse()方法，在此处调用EndGetResponse()搜集结果。

            //WebResponse类代表从服务器获取的数据。调用EndGetResponse方法，实际上是把请求发送给Web服务器，创建一个Response对象。

            WebResponse wrs = wrq.EndGetResponse(ar);

            // 读取WebResponse对象中内含的从服务器端返回的结果数据流

            using (Stream responseStream = wrs.GetResponseStream())
            {
                StreamReader reader = new StreamReader(responseStream);
                string retGet = reader.ReadToEnd();
                MessageBox.Show(retGet);
            }
        }
        #endregion
    }
}
