using System;
using MathOperationsLib;
using log4net;
[assembly: log4net.Config.XmlConfigurator(ConfigFile = "log4net.config",Watch = true)]
namespace CalOperations
{
    public static class Logger
    {
        private static readonly ILog Log = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        public static void Error(object msg)
        {
            Log.Error(msg);
        }
        public static void Error(object msg, Exception ex)
        {
            Log.Error(msg, ex);
        }
        public static void Error(Exception ex)
        {
            Log.Error(ex.Message, ex);
        }
        public static void Info(object msg)
        {
            Log.Info(msg);
        }
    }
   
}