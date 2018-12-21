using NLog;
using System.Configuration;

namespace Masglobal.DAL
{
    public class Base
    {
        protected Logger _log { get; private set; }
        protected string _strURL;

        public Base()
        {
            _strURL = ConfigurationManager.AppSettings["strUrl"].ToString();
            _log = LogManager.GetLogger(GetType().FullName);
        }
    }

}