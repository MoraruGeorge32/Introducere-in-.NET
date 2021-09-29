using System;

namespace Lab1
{
    abstract class Employee{
        protected int Id;
        protected string FirstName;
        protected string LastName;
        protected DateTime StartDate;
        protected DateTime EndDate;
        protected int Salary;

        public string getFullName(){
            return this.FirstName + " " + this.LastName;
        }

        public bool isActive(){
            return ((this.EndDate-this.StartDate).TotalDays>0 ? true : false);
        }

        public abstract string salutation();
    }
}