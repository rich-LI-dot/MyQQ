using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;//引入配置文件

namespace MyQQ
{
    /// <summary>
    /// 配置文件连接数据库字符串
    /// </summary>
    class DBHelper
    {
        /// <summary>
        /// 设置连接字符串
        /// </summary>
        public static string Connstr = ConfigurationManager.ConnectionStrings["connstr"].ConnectionString;//设置连接字符串
    }
}
