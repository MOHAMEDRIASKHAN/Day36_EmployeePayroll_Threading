using EmployeePayroll_Threading;
using System.Diagnostics;

namespace EmployeePayrollTest
{
    [TestClass]
    public class Tests
    {
        [TestMethod]
        public void Given10Employee_WhenAddedToList_ShouldMatchEmployeeEntries()
        {
            List<EmployeeDetails> employeeDetails = new List<EmployeeDetails>();
            employeeDetails.Add(new EmployeeDetails(EmployeeID: 1, EmployeeName: "Riyas", PhoneNumber: "9876543210", Address: "pondicherry", Department: "Manager", Gender: 'M', BasicPay: 25000, Deductions: 1000, TaxablePay: 24000, Tax: 1000, NetPay: 23000, City: "Pondicherry", Country: "abc"));
            employeeDetails.Add(new EmployeeDetails(EmployeeID: 2, EmployeeName: "Khan", PhoneNumber: "9872633993", Address: "pondy", Department: "Manager", Gender: 'M', BasicPay: 50000, Deductions: 2000, TaxablePay: 48000, Tax: 1000, NetPay: 47000, City: "aaa", Country: "def"));
            employeeDetails.Add(new EmployeeDetails(EmployeeID: 3, EmployeeName: "Uma", PhoneNumber: "7393030399", Address: "Singapore", Department: "Manager", Gender: 'F', BasicPay: 25000, Deductions: 1000, TaxablePay: 24000, Tax: 1000, NetPay: 23000, City: "bbb", Country: "ghi"));
            employeeDetails.Add(new EmployeeDetails(EmployeeID: 4, EmployeeName: "Prince", PhoneNumber: "9999877338", Address: "chennai", Department: "Assistant Manager", Gender: 'M', BasicPay: 50000, Deductions: 2000, TaxablePay: 48000, Tax: 1000, NetPay: 47000, City: "ccc", Country: "jkl"));
            employeeDetails.Add(new EmployeeDetails(EmployeeID: 5, EmployeeName: "Princess", PhoneNumber: "8933738383", Address: "chennai", Department: "Assistant Manager", Gender: 'F', BasicPay: 25000, Deductions: 1000, TaxablePay: 24000, Tax: 1000, NetPay: 23000, City: "ddd", Country: "mno"));
            employeeDetails.Add(new EmployeeDetails(EmployeeID: 6, EmployeeName: "Vijay", PhoneNumber: "9838764289", Address: "Bangalore", Department: "Manager", Gender: 'M', BasicPay: 25000, Deductions: 1000, TaxablePay: 24000, Tax: 1000, NetPay: 23000, City: "eee", Country: "pqr"));
            employeeDetails.Add(new EmployeeDetails(EmployeeID: 7, EmployeeName: "Ajith", PhoneNumber: "8963265449", Address: "Pondicherry", Department: "Assistant Manager", Gender: 'F', BasicPay: 50000, Deductions: 2000, TaxablePay: 48000, Tax: 1000, NetPay: 47000, City: "fff", Country: "stuv"));
            employeeDetails.Add(new EmployeeDetails(EmployeeID: 8, EmployeeName: "Kamal", PhoneNumber: "9996788771", Address: "Madurai", Department: "Assistant Manager", Gender: 'M', BasicPay: 25000, Deductions: 1000, TaxablePay: 24000, Tax: 1000, NetPay: 23000, City: "ggg", Country: "wxyz"));

            DateTime starttime = DateTime.Now;
            EmployeePayroll employeePayrollOperations = new EmployeePayroll();
            employeePayrollOperations.addEmployeeToPayroll(employeeDetails);
            DateTime endtime = DateTime.Now;

        }
        [TestMethod]
        public void Given8Employee_WhenAddedToDataBAse_ShouldMatchEmployeeEntries()
        {
            List<EmployeeDetails> employeeDetails = new List<EmployeeDetails>();
            employeeDetails.Add(new EmployeeDetails(EmployeeID: 1, EmployeeName: "Riyas", PhoneNumber: "9876543210", Address: "pondicherry", Department: "Manager", Gender: 'M', BasicPay: 25000, Deductions: 1000, TaxablePay: 24000, Tax: 1000, NetPay: 23000, City: "Pondicherry", Country: "abc"));
            employeeDetails.Add(new EmployeeDetails(EmployeeID: 2, EmployeeName: "Khan", PhoneNumber: "9872633993", Address: "pondy", Department: "Manager", Gender: 'M', BasicPay: 50000, Deductions: 2000, TaxablePay: 48000, Tax: 1000, NetPay: 47000, City: "aaa", Country: "def"));
            employeeDetails.Add(new EmployeeDetails(EmployeeID: 3, EmployeeName: "Uma", PhoneNumber: "7393030399", Address: "Singapore", Department: "Manager", Gender: 'F', BasicPay: 25000, Deductions: 1000, TaxablePay: 24000, Tax: 1000, NetPay: 23000, City: "bbb", Country: "ghi"));
            employeeDetails.Add(new EmployeeDetails(EmployeeID: 4, EmployeeName: "Prince", PhoneNumber: "9999877338", Address: "chennai", Department: "Assistant Manager", Gender: 'M', BasicPay: 50000, Deductions: 2000, TaxablePay: 48000, Tax: 1000, NetPay: 47000, City: "ccc", Country: "jkl"));
            employeeDetails.Add(new EmployeeDetails(EmployeeID: 5, EmployeeName: "Princess", PhoneNumber: "8933738383", Address: "chennai", Department: "Assistant Manager", Gender: 'F', BasicPay: 25000, Deductions: 1000, TaxablePay: 24000, Tax: 1000, NetPay: 23000, City: "ddd", Country: "mno"));
            employeeDetails.Add(new EmployeeDetails(EmployeeID: 6, EmployeeName: "Vijay", PhoneNumber: "9838764289", Address: "Bangalore", Department: "Manager", Gender: 'M', BasicPay: 25000, Deductions: 1000, TaxablePay: 24000, Tax: 1000, NetPay: 23000, City: "eee", Country: "pqr"));
            employeeDetails.Add(new EmployeeDetails(EmployeeID: 7, EmployeeName: "Ajith", PhoneNumber: "8963265449", Address: "Pondicherry", Department: "Assistant Manager", Gender: 'F', BasicPay: 50000, Deductions: 2000, TaxablePay: 48000, Tax: 1000, NetPay: 47000, City: "fff", Country: "stuv"));
            employeeDetails.Add(new EmployeeDetails(EmployeeID: 8, EmployeeName: "Kamal", PhoneNumber: "9996788771", Address: "Madurai", Department: "Assistant Manager", Gender: 'M', BasicPay: 25000, Deductions: 1000, TaxablePay: 24000, Tax: 1000, NetPay: 23000, City: "ggg", Country: "wxyz"));
            Stopwatch stopwatch1 = new Stopwatch();
            stopwatch1.Start();
            DateTime starttime = DateTime.Now;
            EmployeePayroll employeePayrollOperations = new EmployeePayroll();
            employeePayrollOperations.addEmployeeToPayrollDataBase(employeeDetails);
            DateTime endtime = DateTime.Now;
            stopwatch1.Stop();
            Console.WriteLine("Total time for operation" + stopwatch1.ElapsedMilliseconds);
            Console.WriteLine("Total time: {0}", starttime - endtime);
        }
    }
}