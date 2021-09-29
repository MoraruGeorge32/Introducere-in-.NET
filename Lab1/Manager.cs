using System;

namespace Lab1
{
    class Manager : Employee {
        
        public Manager(int Id, string FirstName, string LastName, DateTime StartDate, DateTime EndDate, int Salary){
            this.Id=Id;
            this.FirstName=FirstName;
            this.LastName=LastName;
            this.StartDate=StartDate;
            this.EndDate=EndDate;
            this.Salary=Salary;
        }
        public override string salutation() => "Hello manager!";
    }
}