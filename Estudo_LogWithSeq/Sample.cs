using Serilog;
using System;
using System.Collections.Generic;
using System.Text;

namespace Estudo_LogWithSeq
{
    public class Sample
    {
        public Sample()
        {
            Log.Logger = new LoggerConfiguration()
                                .WriteTo.Seq("http://localhost:5341")
                                .CreateLogger();
        }

        public void LogSample()
        {


            Log.Information("Usando Serilog...");


        }

        public void LogSample(string message)
        {
            Log.Information(message);

            Log.CloseAndFlush();
        }

        public void CloseAndFlush()
        {
            Log.CloseAndFlush();
        }
    }
}
