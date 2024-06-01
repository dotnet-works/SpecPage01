using AventStack.ExtentReports;
using Gherkin.Ast;
using System;
using System.Runtime.CompilerServices;


namespace SpecPage01.SpecExtent
{
    public class SpecExtentManager
    {
       
        [ThreadStatic]
        private static ExtentTest? _Feature;

        [ThreadStatic]
        private static ExtentTest? _Scenario;

        [MethodImpl(MethodImplOptions.Synchronized)]
        public static ExtentTest CreateParentTest(string testName, string? description = null)
        {

            //_Feature = SpecExtentService.GetExtent().CreateTest(testName, description);
            _Feature = SpecExtentService.GetExtent().CreateTest(testName, description);
            return _Feature;
        }


        [MethodImpl(MethodImplOptions.Synchronized)]
        public static ExtentTest CreateTest(string testName, string description = null)
        {

            _Scenario = _Feature.CreateNode(testName, description);
            return _Scenario;
        }

        [MethodImpl(MethodImplOptions.Synchronized)]
        public static ExtentTest GetExtentTest()
        {
            return _Scenario;
        }
    }
}

