using System;

namespace Lab1
{
    class Architect : Employee {

        // public Architect(int Id, string FirstName, string LastName, DateTime StartDate, DateTime EndDate, int Salary){
        //     this.Id=Id;
        //     this.FirstName=FirstName;
        //     this.LastName=LastName;
        //     this.StartDate=StartDate;
        //     this.EndDate=EndDate;
        //     this.Salary=Salary;
        // }
        public Architect()
        {}

        public override string salutation() => "Hello architect!";
    }
}