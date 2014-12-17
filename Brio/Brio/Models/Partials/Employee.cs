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
            return type.payAmount(this);
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

        abstract public int payAmount(Employee employee);
    }
    class Engineer : EmployeeType
    {
        public int getTypeCode()
        {
            return EmployeeType.ENGINEER;
        }

        public int payAmount(Employee employee)
        {
            return employee.monthlySalary;
        }
    }
    class Salesman : EmployeeType
    {
        public int getTypeCode()
        {
            return EmployeeType.SALESMAN;
        }

        public int payAmount(Employee employee)
        {
            return employee.monthlySalary + employee.commission;
        }
    }
    class Manager : EmployeeType
    {
        public int getTypeCode()
        {
            return EmployeeType.MANAGER;
        }

        public int payAmount(Employee employee)
        {
            return employee.monthlySalary + employee.bonus;
        }
    }
}
