using System;
using System.Web;
using System.Web.Routing;

namespace HRMS.Web
{
    public class Global : System.Web.HttpApplication
    {
        
        #region 【主体】
        // 在应用程序启动时运行的代码
        protected void Application_Start(object sender, EventArgs e)
        {
            #region 【这里需要IIS对应的应用池设置为经典模式】
            RegisterRoutes(RouteTable.Routes);
            #endregion
        }
        
        // 在新会话启动时运行的代码
        protected void Session_Start(object sender, EventArgs e)
        {
            
        }

        protected void Application_BeginRequest(object sender, EventArgs e)
        {
            
        }

        protected void Application_AuthenticateRequest(object sender, EventArgs e)
        {

        }

        // 在出现未处理的错误时运行的代码
        protected void Application_Error(object sender, EventArgs e)
        {
            
        }

        // 在会话结束时运行的代码。 
        protected void Session_End(object sender, EventArgs e)
        {

        }

        //  在应用程序关闭时运行的代码
        protected void Application_End(object sender, EventArgs e)
        {

        }

        #endregion

        #region 【重写URL地址,如伪静态】
        /// <summary>
        /// 重写URL地址,如伪静态
        /// </summary>
        /// <param name="routes"></param>
        void RegisterRoutes(RouteCollection routes)
        {
            string list = "~/item/list.aspx";
            RouteTable.Routes.MapPageRoute("list", "list/{fid}", list);

            string show = "~/item/show.aspx";
            RouteTable.Routes.MapPageRoute("show", "show/{fid}/{d}", show);

            string login = "~/user/login.aspx";
            RouteTable.Routes.MapPageRoute("login", "login", login);

            string userhome = "~/user/index.aspx";
            RouteTable.Routes.MapPageRoute("userhome", "user/{fid}", userhome);

            string alogin = "~/admin/loginto.aspx";
            RouteTable.Routes.MapPageRoute("alogin", "loginto", alogin);

        }
        #endregion

    }
}