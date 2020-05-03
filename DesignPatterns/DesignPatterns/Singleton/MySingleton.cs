using System;

namespace DesignPatterns.Singleton
{
    public class MySingleton
    {
        private static readonly Lazy<MySingleton> myMySingleton = new Lazy<MySingleton>(() =>
            new MySingleton());
        private MySingleton()
        {

        }

        public static MySingleton GetInstance()
        {
            return myMySingleton.Value;
        }
    }
}
