using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_Deep_Dive_C_.Patterns.Singleton
{
    internal sealed class UploadService
    {
        private UploadService() {}

        private static UploadService _instance;

        public static UploadService Instance()
        {
            if(_instance == null)
            {
                return _instance = new UploadService();
            }
            return _instance;
        }
    }
}
