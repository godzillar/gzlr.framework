using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using Gzlr.Service.Interfaces;

namespace Gzlr.Service
{
    public class Class1 : IClass1
    {
        public string Name { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;

        public void SomeMethod()
        {
            throw new NotImplementedException();
        }


    }
}
