using System;
using Swift;

namespace Server
{
    /// <summary>
    /// 服务器日志
    /// </summary>
    public class ServerLogger : Swift.ILog
    {
        static bool inited = false;
        public static void Init(string configXmlFile)
        {
            inited = true;
        }

        public ServerLogger(Type t)
        {
            if (!inited)
                throw new Exception("should be inited first by ServerLogger.Init");

        }

        public ServerLogger(string name)
        {
            if (!inited)
                throw new Exception("should be inited first by ServerLogger.Init");

        }

        // 信息
        public void Info(string str)
        {
            
        }

        // 错误
        public void Error(string str)
        {
            
        }

        // 警告
        public void Warn(string str)
        {
            
        }

        // 调试
        public void Debug(string str)
        {
            
        }

    }
}
