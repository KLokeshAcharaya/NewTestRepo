using OopsConceptDemo.AbstractClass;
using OopsConceptDemo.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsConceptDemo
{
    class Program
    {
        public static void Main()
        {
            //Changes in master branch
            Console.WriteLine("Hello world");
            BaseEmployee humanObj;
            humanObj = new BaseEmployee();
            humanObj.ShowMobileNumber("+1", 1234561234);

            humanObj = new Employee();
            humanObj.ShowMobileNumber("+1", 1234561234);
            humanObj.ShowMobileNumber("+91", 4564564564);

            //Method shadowing
            Employee oobj = new Employee();
            Console.WriteLine(oobj.GetMethodName());

            EmployeeName empNameObj = new EmployeeName();
            empNameObj.firstName = "K";
            empNameObj.middleName = "Lokesh";
            empNameObj.lastName = "Acharaya";
            empNameObj.ShowFullName(empNameObj.firstName, empNameObj.lastName);
            empNameObj.ShowFullName(empNameObj.firstName, empNameObj.middleName, empNameObj.lastName);

            //Comment for merge
            //Comment done
            Test testObj = new Test();
            testObj.MethodA();
            testObj.MethodB();
            testObj.MethodC();
            testObj.MethodD();
            testObj.AbstractMethodA();
            testObj.AbstractMethodB();

            Console.ReadKey();
        }

    }

    //Interface implementation
    public class Test : AbstractClassDemo, ITest2, ITest3
    {
        public void MethodA()
        {
            Console.WriteLine("Method A from ITest1");
        }

        public void MethodB()
        {
            Console.WriteLine("Method B from ITest1");
        }

        public void MethodC()
        {
            Console.WriteLine("Method C from ITest2");
        }

        public void MethodD()
        {
            Console.WriteLine("Method D from ITest3");
        }
    }

    public class EmployeeName
    {
        private string firstname; // field
        public string firstName   // property
        {
            get { return firstname; }
            set { firstname = value; }
        }

        private string middlename; // field
        public string middleName   // property
        {
            get { return middlename; }
            set { middlename = value; }
        }

        private string lastname; // field
        public string lastName   // property
        {
            get { return lastname; }
            set { lastname = value; }
        }
        public void ShowFullName(string firstName, string lastName)
        {
            Console.WriteLine(firstName + " " + lastName);
        }

        public void ShowFullName(string firstName, string middleName, string lastName)
        {
            Console.WriteLine(firstName + " " + middleName + " " + lastName);
        }
    }

    public class BaseEmployee
    {
        public virtual void ShowMobileNumber(string countyCode, long mobileNumber)
        {
            Console.WriteLine(countyCode + " " + mobileNumber);
        }
        public string GetMethodName()
        {
            return "Base Class";
        }
    }

    class Employee : BaseEmployee
    {
        public override void ShowMobileNumber(string countyCode, long mobileNumber)
        {
            if(countyCode.Equals("+91"))
            {
                Console.WriteLine(countyCode + " " + mobileNumber);
            }
            else
            {
                Console.WriteLine("Please enter the country code for India");
            }
        }
        public new string GetMethodName()
        {
            return "Child Class Method";
        }
    }    
}
