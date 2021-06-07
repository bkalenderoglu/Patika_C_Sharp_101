using System;

namespace interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            FileLogger fileLogger = new FileLogger();
            fileLogger.writeLog();

            DatabaseLogger database = new DatabaseLogger();
            database.writeLog();

            SmsLogger smsLogger = new();
            smsLogger.writeLog();

            LogManager logManager = new LogManager(new FileLogger());
            logManager.writeLog();
        }
    }
}
