using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeePayroll_Threading
{
    public class EmployeePayroll
    {
        public List<EmployeeDetails> employeePolyeeDetailList = new List<EmployeeDetails>();

        //UC 2
        public void addEmployeeToPayrollWithThread(List<EmployeeDetails> employeePayrollDataList)
        {
            employeePayrollDataList.ForEach(employeeData =>
            {
                Task thread = new Task(() =>
                {
                    //For Every iterarion of foreach loop, every record will get in to thread, every thread will be
                    //running in a single process to make execution quick and fast.

                    Console.WriteLine("Employee Being Added :" + employeeData.EmployeeName);
                    this.addEmployeeToPayroll(employeeData);
                    Console.WriteLine("Employee added : " + employeeData.EmployeeName);
                });
                thread.Start();
            });
            Console.WriteLine(this.employeePolyeeDetailList.Count);
        }
        public void addEmployeeToPayroll(EmployeeDetails emp)
        {
            employeePolyeeDetailList.Add(emp);
        }
    }
}
