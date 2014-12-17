using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Brio.Models
{
    public class Employee
    {
        private EmployeeType type;
        public int getTypeCode()
        {
            return type.getTypeCode();
        }

        public int monthlySalary;
        public int commission;
        public int bonus;
        public int payAmount()
        {
            switch (getTypeCode())
            {
                case EmployeeType.ENGINEER:
                    return monthlySalary;
                case EmployeeType.SALESMAN:
                    return monthlySalary + commission;
                case EmployeeType.MANAGER:
                    return monthlySalary + bonus;
                default:
                    throw new Exception("Incorrect Employee Code");
            }
        }
    }

    abstract class EmployeeType
    {
        public static const int ENGINEER = 0;
        public static const int SALESMAN = 1;
        public static const int MANAGER = 2;

        abstract public int getTypeCode();
        public static EmployeeType newType(int code)
        {
            switch (code)
            {
                case ENGINEER:
                    return new Engineer();
                case SALESMAN:
                    return new Salesman();
                case MANAGER:
                    return new Manager();
                default:
                    throw new Exception("dsf");
            }
        }
    }
    class Engineer : EmployeeType
    {
        public int getTypeCode()
        {
            return EmployeeType.ENGINEER;
        }
    }
    class Salesman : EmployeeType
    {
        public int getTypeCode()
        {
            return EmployeeType.SALESMAN;
        }
    }
    class Manager : EmployeeType
    {
        public int getTypeCode()
        {
            return EmployeeType.MANAGER;
        }
    }
}
