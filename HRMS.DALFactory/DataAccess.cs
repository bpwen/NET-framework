using System;
using System.Reflection;
using System.Configuration;

namespace HRMS.DALFactory
{
    /// <summary>
    /// Abstract Factory pattern to create the DAL。
    /// 如果在这里创建对象报错，请检查web.config里是否修改了<add key="DAL" value="HRMS.SQLServerDAL" />。
    /// </summary>
    public sealed class DataAccess
    {
        private static readonly string AssemblyPath = ConfigurationManager.AppSettings["DAL"];

        #region CreateObject
        //使用缓存
        private static object CreateObject(string AssemblyPath, string classNamespace)
        {
            object objType = DataCache.GetCache(classNamespace);//从缓存读取
            if (objType == null)
            {
                try
                {
                    objType = Assembly.Load(AssemblyPath).CreateInstance(classNamespace);//反射创建
                    DataCache.SetCache(classNamespace, objType);// 写入缓存
                }
                catch//(System.Exception ex)
                {
                    //string str=ex.Message;// 记录错误日志
                }
            }
            return objType;
        }
        #endregion

    }
}