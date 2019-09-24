using Microsoft.Win32.SafeHandles;
using System;
using System.Runtime.InteropServices;

namespace Interfaces
{
    public class Person : IDisposable
    {
        public string Name { get; set; }


        bool disposed = false;

        SafeHandle handle = new SafeFileHandle(IntPtr.Zero, true);

        public void Dispose()

        {

            Dispose(true);

            GC.SuppressFinalize(this);

        }



        protected virtual void Dispose(bool disposing)

        {

            if (disposed)

                return;

            if (disposing)

            {

                handle.Dispose();

            }

            disposed = true;

        }
    }
}
