using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsConceptDemo.Interface
{
    public interface ITest1
    {
        void MethodA();
        void MethodB();
    }
    public interface ITest2 : ITest1
    {
        void MethodC();
    }
}
