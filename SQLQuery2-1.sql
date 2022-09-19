drop table employee_payroll

create table employee_payroll
(
EmployeeId int primary key identity,
EmployeeName varchar(255),
PhoneNumber varchar(10),
Address varchar(255),
Department varchar(255),
Gender char(1),
BasicPay float,
Deduction float,
TaxablePay float,
Tax float,
NetPay float,
StartDate Date,
City varchar(255),
Country varchar(255),
)