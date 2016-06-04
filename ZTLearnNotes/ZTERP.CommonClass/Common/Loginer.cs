
using System;

namespace ZTERP.CommonClass
{   
    [Serializable]
    public class Loginer
    {
        public Loginer()
        { }
        public Loginer(Loginer user)
        {
            this.Account = user.Account;
            this.AccountName = user.AccountName;
            this.DataSetID = user.DataSetID;
            this.DataSetName = user.DataSetName;
            this.DBName = user.DBName;
            this.DBServer = user.DBServer;
            this.DBUserID = user.DBUserID;
            this.DBUserPwd = user.DBUserPwd;
            this.FlagAdmin = user.FlagAdmin;
            this.IP = user.IP;
            this.LoginTime = user.LoginTime;
            this.MAC = user.MAC;
            this.Password = user.Password;
            this.DataSetIdAll = user.DataSetIdAll;
        }
        
        private static Loginer _User = new Loginer();
                
        public static Loginer CurrentUser
        {
            get { return _User; }
            set { _User = value; }
        }
        
        private string _Account = "";
        private string _Password = "";
        private string _DataSetID = "";
        private string _DataSetName = "";
        private string _DBServer = "";
        private string _DBName = "";
        private string _DBUserID = "";
        private string _DBUserPwd = "";
        private string _IP = "";
        private string _MAC = "";
        private string _AccountName = "";
        private DateTime _LoginTime;
        private string _FlagAdmin = "N";
        private string _LicenseID = "";
        private string _DataSetIdAll = "";

        /// <summary>
        /// 我的所有帐套编号，,SH,XA,
        /// </summary>
        public string DataSetIdAll { get { return _DataSetIdAll; } set { _DataSetIdAll = value; } }

        /// <summary>
        /// 许可证编号，客户识别码
        /// </summary>
        public string LicenseID { get { return _LicenseID; } set { _LicenseID = value; } }

        /// <summary>
        /// 登录的数据库服务器
        /// </summary>
        public string DBServer { get { return _DBServer; } set { _DBServer = value; } }

        /// <summary>
        /// 登录的数据库
        /// </summary>
        public string DBName { get { return _DBName; } set { _DBName = value; } }

        /// <summary>
        /// 数据库用户
        /// </summary>
        public string DBUserID { get { return _DBUserID; } set { _DBUserID = value; } }

        /// <summary>
        /// 数据库密码
        /// </summary>
        public string DBUserPwd { get { return _DBUserPwd; } set { _DBUserPwd = value; } }

        /// <summary>
        /// 用户帐号，登录帐号
        /// </summary>
        public string Account { get { return _Account; } set { _Account = value; } }

        /// <summary>
        /// 登录密码
        /// </summary>
        public string Password { get { return _Password; } set { _Password = value; } }

        /// <summary>
        /// 当前登录的网点
        /// </summary>
        public string DataSetID { get { return _DataSetID; } set { _DataSetID = value; } }

        /// <summary>
        /// 当前登录的网点名称
        /// </summary>
        public string DataSetName { get { return _DataSetName; } set { _DataSetName = value; } }

        /// <summary>
        /// 当前用户的IP
        /// </summary>
        public string IP { get { return _IP; } set { _IP = value; } }

        /// <summary>
        /// 当前网卡信息
        /// </summary>
        public string MAC { get { return _MAC; } set { _MAC = value; } }

        #region 属性定义

        /// <summary>
        /// 用户名
        /// </summary>
        public string AccountName { get { return _AccountName; } set { _AccountName = value; } }

        /// <summary>
        /// 登录时间
        /// </summary>
        public DateTime LoginTime { get { return _LoginTime; } set { _LoginTime = value; } }

        /// <summary>
        /// ADMIN标记, Y/N
        /// </summary>
        public string FlagAdmin { get { return _FlagAdmin; } set { _FlagAdmin = value; } }

        /// <summary>
        /// 是否ADMIN
        /// </summary>
        /// <returns></returns>
        public bool IsAdmin() { return _FlagAdmin == "Y"; }

        #endregion

    }

}

