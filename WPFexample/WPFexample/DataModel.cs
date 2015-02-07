using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFexample
{
    public class DataModel
    {
        public string apiResult = "null";

        private void GetDataFromApi()
        {
            // Some web service
            apiResult = "SOME RESULT FROM WEB API";
        }
    }
}
