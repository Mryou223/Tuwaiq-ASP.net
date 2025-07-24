// See https://aka.ms/new-console-template for more information
using firstDay.Models;

Console.WriteLine("Hello, World!");

var context = new HrContext();
var numOfEmp =  context.Employees.Count();
Console.WriteLine("The Number Of Employees is "+numOfEmp);

