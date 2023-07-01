﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeDict
{
    public class Employee
    {
        private static int empNoCounter = 0;
        private int empNo;
        private string name;
        private decimal basic;
        private short deptNo;

        public Employee()
        {
            empNo = ++empNoCounter;
        }
        public Employee(string name, int basic = 31000, short deptNo = 1)
        {
            empNo = ++empNoCounter;
            Name = name;
            Basic = basic;
            DeptNo = deptNo;
        }
        public string Name
        {
            get { return name; }
            set
            {
                if (value.Trim().Length != 0)
                    name = value;
                else
                    throw new InvalidInputException("Name should not be empty");
            }
        }

        public int EmpNo
        {
            get { return empNo; }
        }

        public decimal Basic
        {
            get { return basic; }
            set
            {
                if (value > 30000 && value <= 90000)
                    basic = value;
                else
                    throw new InvalidInputException("Basic should be between 30000 and 90000");
            }
        }

        public short DeptNo
        {
            get { return deptNo; }
            set
            {
                if (value > 0)
                    deptNo = value;
                else
                    throw new InvalidInputException("Dept. no should be greater than 0 ");
            }
        }
        public decimal GetNetSalary()
        {
            return 1.2m * Basic;
        }

        public override string? ToString()
        {
            return $"Emp No = {EmpNo}, Name = {Name}, Basic = {Basic}, Dept = {DeptNo}";
        }


    }


    public class InvalidInputException : ApplicationException
    {
        public InvalidInputException(string message) : base(message)
        {
        }
    }
}
