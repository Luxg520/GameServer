using System;
using System.Collections.Generic;
using Swift;

namespace Server
{
    class Program
    {
        static void Main(string[] args)
        {
            Server srv = new Server();
            //CsScriptShell<ScriptObject> css = srv.Get<CsScriptShell<ScriptObject>>();            
            //css.DSP.AddNamespace("Server");
            //css.DSP.AddAssembly(System.Reflection.Assembly.GetExecutingAssembly().Location);

            //// 执行启动脚本
            //foreach (string cfg in args)
            //    css.RunScript(cfg, "init", srv);

            srv.Start();
        }
    }
}
