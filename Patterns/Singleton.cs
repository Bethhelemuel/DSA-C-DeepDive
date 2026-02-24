    using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_Deep_Dive_C_.Patterns
{
    class UploadService{
        public int id {get; set;}
        private static  volatile UploadService _instance;
        public static readonly object _lock = new object();
        private UploadService() {}

        public static UploadService Instance(int id)
        {
            if (_instance == null)
            {
                lock (_lock)
                {
                    if (_instance == null)
                    {
                        _instance = new UploadService();
                        _instance.id = id;
                    }
                }
            }
            
            return _instance;
        }

    }
}
