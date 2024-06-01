using AventStack.ExtentReports.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecPage01.SpecExtent
{
    public class SpecReportLog
    {
        public static void Pass(string message)
        {
            SpecExtentManager.GetExtentTest().Pass(message);

        }
        /*
        public static void Fail(string message)
        {
            ExtentTestManager.GetExtentTest().Fail(message);
            
        }

        public static void Fail(string message, string base64Png=null) 
        {
            //var mediaModel1 = MediaEntityBuilder.CreateScreenCaptureFromBase64String("screenshot.png").Build();
            //var mediaModel = media.CreateScreenCaptureFromPath("screenshot.png").Build();
            //test.Fail("details", mediaModel);

            ExtentTestManager.GetExtentTest().Fail(message);
            ExtentTestManager.GetExtentTest().Fail(message, MediaEntityBuilder.CreateScreenCaptureFromPath(base64Png).Build());
            
        }*/

        public static void Fail(string message)
        {
            SpecExtentManager.GetExtentTest().Fail(message);
        }
        public static void Fail(string message, Media m = null)
        {

            SpecExtentManager.GetExtentTest().Fail(message, m);
        }

        public static void Fail(string message, String m = null)
        {

            SpecExtentManager.GetExtentTest().Fail(message).AddScreenCaptureFromBase64String(m);
        }

        public static void Skip(string message)
        {
            SpecExtentManager.GetExtentTest().Skip(message);
            //ExtentTestManager.GetExtentTest().Fail(message,);
        }

        public static void TestLogging(string message) { SpecExtentManager.GetExtentTest().Info(message); }


    }
}

