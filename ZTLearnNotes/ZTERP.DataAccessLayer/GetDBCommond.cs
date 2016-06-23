using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.OleDb;
using System.Data.OracleClient;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection;
using System.Security;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;
using ZTERP.CommonClass;

namespace ZTERP.DataAccessLayer
{

    public sealed class GetDataBaseType
    {
        private static readonly GetDataBaseType instance = new GetDataBaseType();

        private GetDataBaseType() { }

        public static GetDataBaseType Instance
        {
            get { return instance; }
        }

        public DataBaseType DbType
        {
            get            {                return _dbType;            }

            set            {                _dbType = value;            }
        }

        private DataBaseType _dbType;
        public DataBaseType CreateDataBaseType(string ClassName, object[] args)
        {
            _dbType= this.createDataBaseType(ClassName, args);
            return _dbType;
        }
        private DataBaseType createDataBaseType(string ClassName, object[] args)
        {
            DataBaseType con = null;
            string SpaceName = typeof(DALDLL).Assembly.GetName().Name;
            BindingFlags bf = BindingFlags.CreateInstance | BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public;

            #region 方法一
            //var asm = Assembly.LoadFile(typeof(DALDLL).Assembly.Location);
            //Type T1 = asm.GetType();
            //Type tmp = null;
            //foreach (Type t1 in asm.DefinedTypes)
            //{
            //    if (t1.Name == ClassName)
            //    {
            //        tmp = t1;
            //        break;
            //    }
            //}            
            //con = tmp.InvokeMember(null, bf, null, null, args);
            #endregion

            //方法二
            //try
            //{
            //    con = (DataBaseType)typeof(DALDLL).Assembly.CreateInstance(SpaceName + "." + ClassName, true,
            //            bf, null, args, null, null);
            //}
            //catch (Exception ex)
            //{
            //    throw new Exception(ex.Message);
            //}

            if (ClassName == "MSSQL") con = ConnectDataBaseMSSQL.Instance;
            else if (ClassName == "Oracle") con = DataBaseOracle.Instance;
            else if (ClassName == "MySQL") con = DataBaseMySQL.Instance;
            else if (ClassName == "Accese") con = DataBaseAccese.Instance;
            return con;
        }

    }




    public abstract class DataBaseType : DbProviderFactory, IServiceProvider
    {
        public virtual object GetService(Type serviceType)
        {
            return null;
        }
    }

    public class DataBaseMSSQL : DataBaseType
    {
        public DataBaseMSSQL()
        { }
        public override DbCommand CreateCommand()
        {
            return new SqlCommand();
        }

        public override DbCommandBuilder CreateCommandBuilder()
        {
            return new SqlCommandBuilder();
        }

        public override DbConnection CreateConnection()
        {
            string CONN_FORMAT_STRING = "Server={0};Database={1};User ID={2};Password={3};Connection TimeOut={4};Pooling=true;Max Pool Size = 512;";
            string sConn = String.Format(CONN_FORMAT_STRING, Loginer.CurrentUser.DBServer, Loginer.CurrentUser.DBName, Loginer.CurrentUser.DBUserID, Loginer.CurrentUser.DBUserPwd, 20);

            return new SqlConnection(sConn);
        }
        public DbConnection CreateConnection(bool IsSysDB)
        {
            if (!IsSysDB)
                return this.CreateConnection();
            else
                return new SqlConnection("连接系统库");
        }

        public override DbConnectionStringBuilder CreateConnectionStringBuilder()
        {
            return new SqlConnectionStringBuilder();
        }

        public override DbDataAdapter CreateDataAdapter()
        {
            return new SqlDataAdapter();
        }

        public override DbDataSourceEnumerator CreateDataSourceEnumerator()
        {
            return SqlDataSourceEnumerator.Instance;
        }

        public override DbParameter CreateParameter()
        {
            return new SqlParameter();
        }

        public override CodeAccessPermission CreatePermission(PermissionState state)
        {
            return new SqlClientPermission(state);
        }

    }
    public class ConnectDataBaseMSSQL : DataBaseType
    {
        public static readonly ConnectDataBaseMSSQL Instance = new ConnectDataBaseMSSQL();

        private ConnectDataBaseMSSQL()
        {
        }

        public override DbCommand CreateCommand()
        {
            return new SqlCommand();
        }

        public override DbCommandBuilder CreateCommandBuilder()
        {
            return new SqlCommandBuilder();
        }

        public override DbConnection CreateConnection()
        {
            return new SqlConnection();
        }

        public override DbConnectionStringBuilder CreateConnectionStringBuilder()
        {
            return new SqlConnectionStringBuilder();
        }

        public override DbDataAdapter CreateDataAdapter()
        {
            return new SqlDataAdapter();
        }

        public override DbDataSourceEnumerator CreateDataSourceEnumerator()
        {
            return SqlDataSourceEnumerator.Instance;
        }

        public override DbParameter CreateParameter()
        {
            return new SqlParameter();
        }

        public override CodeAccessPermission CreatePermission(PermissionState state)
        {
            return new SqlClientPermission(state);
        }

    }
    public class DataBaseOracle : DataBaseType
    {
        public static readonly DataBaseOracle Instance = new DataBaseOracle();

        // 构造函数
        private DataBaseOracle()
        {
        }
        public override DbCommand CreateCommand()
        {  // 创建具体产品
            return new OracleCommand();
        }
        public override DbConnection CreateConnection()
        {
            string CONN_FORMAT_STRING = "Server={0};Database={1};User ID={2};Password={3};Connection TimeOut={4};Pooling=true;Max Pool Size = 512;";
            string sConn = String.Format(CONN_FORMAT_STRING, Loginer.CurrentUser.DBServer, Loginer.CurrentUser.DBName, Loginer.CurrentUser.DBUserID, Loginer.CurrentUser.DBUserPwd, 20);

            return new OracleConnection(sConn);
        }
    }
    public class DataBaseMySQL : DataBaseType
    {
        public static readonly DataBaseMySQL Instance = new DataBaseMySQL();

        // 构造函数
        private DataBaseMySQL()
        {

        }
    }
    public class DataBaseAccese : DataBaseType
    {
        public static readonly DataBaseAccese Instance = new DataBaseAccese();

        // 构造函数
        private DataBaseAccese()
        {
        }
        public override DbCommand CreateCommand()
        {  // 创建具体产品
            return new OleDbCommand();
        }

    }



}
