using System.Runtime.InteropServices.JavaScript;

namespace DSA_Deep_Dive_C_.Patterns;

public sealed class Logger
{
        private static object _lock = new Object();
        private static Logger _instance;
        public int id;
        private Logger() {}

        public static Logger Instance(int id)
        {
                lock (_lock)
                {
                        if (_instance == null)
                        {
                                _instance = new Logger();
                                _instance.id = id;
                        }

                        return _instance;
                }
        }
}
