﻿using System;
using System.IO;

namespace Programa_STPMJ
{
    public static class Logger
    {


        public static void WriteLog(string path, string message, string nomeLogin)
        {
            //string logPath = ConfigurationManager.AppSettings["logPath"];


            using (StreamWriter writer = new StreamWriter(path, true))
            {
                writer.WriteLine($"{DateTime.Now} | {nomeLogin.ToUpper()} | {message.ToUpper()}");
            }
        }

    }
}
