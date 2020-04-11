using System;
using Microsoft.Extensions.Configuration;

namespace ConfigurationEnvironmentVariableDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            var builder = new ConfigurationBuilder();
            builder.AddEnvironmentVariables();

            var configurationRoot = builder.Build();
            Console.WriteLine($"Key1:{configurationRoot["key1"]}");

            #region 分层键
            var section = configurationRoot.GetSection("SECTION1");
            Console.WriteLine($"KEY3:{section["KEY3"]}");

            var section2 = configurationRoot.GetSection("SECTION1:SECTION2");
            Console.WriteLine($"KEY4:{section2["KEY4"]}");
            #endregion

            #region 前缀过滤
            //builder.AddEnvironmentVariables("XIAO_");
            //var configurationRoot = builder.Build();
            //Console.WriteLine($"key1:{configurationRoot["key1"]}");
            #endregion


        }
    }
}
