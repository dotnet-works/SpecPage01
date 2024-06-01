using AventStack.ExtentReports.Reporter;
using AventStack.ExtentReports;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SpecPage01.Utils;

namespace SpecPage01.SpecExtent
{
    public class SpecExtentService
    {
        public static ExtentReports extent;

        public static ExtentReports GetExtent()
        {

            if (extent == null)
            {
                extent = new ExtentReports();
                string reportDir = Path.Combine(ProjectUtils._ProjectPath, "Reports");
                Console.WriteLine(reportDir);
                if (!Directory.Exists(reportDir))
                    Directory.CreateDirectory(reportDir);

                string path = Path.Combine(reportDir, "index.html");
                ExtentSparkReporter reporter = new ExtentSparkReporter(path);
                reporter.Config.Theme = AventStack.ExtentReports.Reporter.Config.Theme.Dark;
                reporter.Config.ReportName = "QA Spec Report";
                //reporter.LoadJSONConfig(ProjectUtils._ProjectPath + "config/spark-config.json");
                //reporter.LoadXMLConfig(ProjectUtil.GetProjectBaseDir() + "config/spark-config.xml");
                extent.AttachReporter(reporter);

            }
            return extent;
        }


    }
}
