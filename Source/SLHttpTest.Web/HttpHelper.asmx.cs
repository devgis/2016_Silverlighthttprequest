﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Net;

namespace SLHttpTest.Web
{
    /// <summary>
    /// HttpHelper 的摘要说明
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // 若要允许使用 ASP.NET AJAX 从脚本中调用此 Web 服务，请取消对下行的注释。
    // [System.Web.Script.Services.ScriptService]
    public class HttpHelper : System.Web.Services.WebService
    {

        [WebMethod]
        public string GetURL(string URL)
        {
            WebClient client = new WebClient();
            return client.DownloadString(URL);
        }
    }
}
