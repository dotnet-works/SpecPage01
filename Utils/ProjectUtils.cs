using FluentAssertions.Common;
using Microsoft.Extensions.Configuration;
using RazorEngine.Configuration;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecPage01.Utils
{
    public class ProjectUtils
    {
        public static string _ProjectPath   // property
        {
            get { return Directory.GetCurrentDirectory().Split("bin")[0]; }   // get method
        }

        public static void GetSettingsData()
        {
            var settingFile = _ProjectPath + "appSettings.json";
            var builder = new ConfigurationBuilder()
                              .SetBasePath(_ProjectPath)
                              .AddJsonFile(settingFile, optional: true, reloadOnChange: true);
            IConfiguration configuration = builder.Build();
            string MyCustomKeyValue = configuration.GetValue<string>("MyCustomKey");
            Console.WriteLine(MyCustomKeyValue);
            Console.WriteLine(MyCustomKeyValue);



            //        var builder = new ConfigurationBuilder()
            //                          .SetBasePath(_ProjectPath)
            //.AddJsonFile("appsettings.json", optional: true, reloadOnChange: true)
        }

        public static dynamic GetSettingsDataValue(string keyName)
        {
            var settingFile = _ProjectPath + "appSettings.json";
            var builder = new ConfigurationBuilder()
                              .SetBasePath(_ProjectPath)
                              .AddJsonFile(settingFile, optional: true, reloadOnChange: true);
                              

            IConfiguration configuration = builder.Build();
            dynamic MyCustomKeyValue = configuration.GetSection(keyName);
            return MyCustomKeyValue;  // configuration.GetValue<dynamic>(keyName); ;

            //Console.WriteLine(MyCustomKeyValue);
            //Console.WriteLine(MyCustomKeyValue);


        }

        //public static dynamic GetSettingsDataValue1(string[] args)
        //{
        //    var settingFile = _ProjectPath + "appSettings.json";
        //    var builder = new ConfigurationBuilder()
        //                      .SetBasePath(_ProjectPath)
        //                      .AddJsonFile(settingFile, optional: true, reloadOnChange: true)
        //                      .AddEnvironmentVariables().AddCommandLine(args);


        //    //IConfiguration configuration = builder.Build();
        //    //dynamic MyCustomKeyValue = configuration.GetSection(keyName);
        //    //return MyCustomKeyValue;  // configuration.GetValue<dynamic>(keyName); ;


        //    //Console.WriteLine(MyCustomKeyValue);
        //    //Console.WriteLine(MyCustomKeyValue);


        //}
    }
}
