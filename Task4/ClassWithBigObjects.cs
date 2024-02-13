using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    internal class ClassWithBigObjects : IDisposable
    {
        private bool _disposed;
        private decimal[] _bigObj;

        public ClassWithBigObjects(long size)
        {
            _bigObj = new decimal[size];
            for(long i = 0; i < _bigObj.Length; i++)
            {
                _bigObj[i] = i;
            }
        }

        public void PrintArr()
        {
            for (long i = 0; i < _bigObj.Length; i++)
            {
                Console.WriteLine(_bigObj[i]);
            }
        }
        protected virtual void Dispose(bool disposing)
        {
            if (!_disposed)
            {
                if (disposing)
                {
                    if (_bigObj != null)
                    {
                        _bigObj = null;
                    }
                }


                _disposed = true;
            }
        }
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);

            //info to check work of this class
            Console.WriteLine("Disposed");
        }

        ~ClassWithBigObjects()
        {
            Dispose(false);

            //info to check work of this class
            Console.WriteLine("Destructed");
        }
    }
}
