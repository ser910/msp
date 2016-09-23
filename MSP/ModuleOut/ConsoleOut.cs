using System;
using static System.Console;

namespace ModuleOut
{
    public class ConsoleOut : IOut
    {
        private object result;
        private IFormatter format;
  

        public ConsoleOut(object result)
        {
            this.result = result;
        }

        public object Format(object result)
        {
            throw new NotImplementedException();
        }

        public void Out(object result)
        {
            throw new NotImplementedException();
        }
    }
        }

        public string Precision
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public string prompt
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public Type type
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public string Value
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public void Out(object result)
        {
            WriteLine()
        }
    }
}
