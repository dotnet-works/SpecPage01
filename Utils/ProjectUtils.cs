using System;
using System.Collections.Generic;
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
    }
}
