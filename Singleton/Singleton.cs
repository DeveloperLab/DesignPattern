using System;

namespace Singleton
{
    public class Singleton
    {
        public Guid Id { get; private set; }

        private Singleton() 
        {
            Id =  Guid.NewGuid();
        }


        private static Singleton _singleton;

        public static Singleton GetInstance()
        {
            if (_singleton == null)
                _singleton = new Singleton();

            return _singleton;
        }
    }
}
