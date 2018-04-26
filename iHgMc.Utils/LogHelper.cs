using iHgMc.Utils.Model;
using log4net;
using System.Collections.Generic;
using System.Threading;

namespace iHgMc.Utils
{
    public class LogHelper
    {
        /// <summary>
        /// 写日志间隔时间
        /// </summary>
        private const int WRITE_INTERVAL= 1000;
        /// <summary>
        /// 日志队列
        /// </summary>
        public static Queue<LogMessage> LogQueue = new Queue<LogMessage>();
        /// <summary>
        /// 写日志
        /// </summary>
        public static void Logger()
        {
            log4net.Config.XmlConfigurator.Configure();
            ThreadPool.QueueUserWorkItem(o =>
            {
                while (true)
                {
                    if (LogQueue != null && LogQueue.Count > 0)
                    {
                        var msg = LogQueue.Dequeue();
                        if (msg != null)
                        {
                            var logger = LogManager.GetLogger(msg.Name);
                            switch (msg.Type)
                            {
                                case LogType.Error:
                                    logger.Error(msg.Message);
                                    break;
                                case LogType.Info:
                                    logger.Info(msg.Message);
                                    break;
                            }
                        }
                        else
                        {
                            Thread.Sleep(WRITE_INTERVAL);
                        }
                    }
                    else
                    {
                        Thread.Sleep(WRITE_INTERVAL);
                    }
                }
            });
        }
    }
}
