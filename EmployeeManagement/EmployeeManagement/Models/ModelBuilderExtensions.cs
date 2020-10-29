﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManagement.Models
{
    public static class ModelBuilderExtensions
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Employee>().HasData(
                    new Employee
                    {
                        Id = 1,
                        Name = "Hrayr",
                        Department = Dept.UI,
                        Email = "hrayr@utaxi.am"
                    },
                     new Employee
                     {
                         Id = 2,
                         Name = "Anan",
                         Department = Dept.UI,
                         Email = "anan@utaxi.am"
                     }
                    );
        }
    }
}
