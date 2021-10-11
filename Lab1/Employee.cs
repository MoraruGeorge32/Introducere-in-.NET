using System;

namespace Lab1
{
    abstract class Employee{
        protected int id;
        protected string firstName;
        protected string lastName;
        protected DateTime startDate;
        protected DateTime endDate;
        protected int salary;

        public string getFullName(){
            return this.firstName + " " + this.lastName;
        }
        public bool isActive(){
            DateTime today = DateTime.Today;
            if ((this.endDate-today).TotalDays>0)
                {
                    if((today-this.startDate).TotalDays>0)
                        return ((this.endDate-this.startDate).TotalDays>0 ? true : false);
                    else return false;
                }
            else return false;
        }

        public abstract string salutation();
        public int Id{
            get{
                return id;
            }
            set{
                id=value;
            }
        }
        public string FirstName{
            get{
                return firstName;
            }
            set{
                if(value!=null)
                {firstName=value;}

                }
            }
          public string LastName{
            get{
                return lastName;
            }
            set{
                if(value!=null)
                {lastName=value;}

                }
            }
         public int Salary{
            get{
                return salary;
            }
            set{
                salary=value;
            }
         }
            public DateTime StartDate{
            get{
                return startDate;
            }
            set{
                startDate=value;
            }
            }
             public DateTime EndDate{
            get{
                return endDate;
            }
            set{
                endDate=value;
            }
            }
    }
}