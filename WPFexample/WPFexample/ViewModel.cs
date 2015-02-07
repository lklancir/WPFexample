using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFexample
{
    public class ViewModel
    {
        private DataModel dm = new DataModel();

        public string ApiResult
        {
            get { return dm.apiResult; }
            set { dm.apiResult = value; }
        }
    }
}
