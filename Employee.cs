﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharpdemo
{
    abstract class Person
    {
        protected String name, email;
        public Person(String name, String email)
        {
            this.name = name;
            this.email = email;
        }
        public virtual void Print()
        {
            Console.WriteLine(name);
            Console.WriteLine(email);
        }

        public abstract string GetOccupation();
    }

    class Employee : Person
    {
        protected String company;
        protected String job;
        public Employee(String name, String email, String company,
        String job) : base(name, email)
        {
            this.company = company;
            this.job = job;
        }
        public override void Print()
        {
            base.Print();
            Console.WriteLine(job);
            Console.WriteLine(company);
        }

        public override string GetOccupation()
        {
            return "Works for " + company + " as " + job;
        }
    }


    class OSEmployee : Employee
    {
        protected String country;

        public OSEmployee(String name, String email, String company, String job, String country)
            : base (name, email, company,job)
        {
            this.country = country;
        }
        public override void Print()
        {
            base.Print();
            Console.WriteLine(country);
        }

        public override string GetOccupation()
        {
            return "Works for " + company + " as " + job + " in " + country;
        }
    }
}
