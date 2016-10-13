using System;
using System.Collections.Generic;
using Swift;

namespace Server
{
    // 服务器对象
    public class Server : Core
    {
        // 服务器逻辑真间隔（毫秒）
        public int Interval = 50;

        public Server()
        { 
        
        }

        // 启动服务器
        public void Start()
        {
            Console.WriteLine("server starting ...");
            Console.ReadLine();
        }

        // 停止服务器
        public void Stop()
        { 
        
        }
    }
}
