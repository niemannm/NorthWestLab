using NorthWestOrderSystem.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace NorthWestOrderSystem.DAL
{
    public class IntexContext : DbContext
    {
        public IntexContext() : base("IntexContext")
        {
            //Database.Connection.ConnectionString = Database.Connection.ConnectionString.Replace("Blueberry1", "Password");
            //Database.Connection.ConnectionString = @"TheConnectionStringYOU ARE USING";
        }

        public DbSet<TestType_Material_Rel> TestType_Material_Rels { get; set; }
        public DbSet<AssayType_TestType_Rel> AssayType_TestType_Rels { get; set; }
        public DbSet<AssayOrder> AssayOrders { get; set; }
        public DbSet<AssayOrder_AssayType_Rel> AssayOrder_AssayType_Rels { get; set; }
        public DbSet<AssayType> AssayTypes { get; set; }
        public DbSet<Compound> Compounds { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Employee_Test_Rel> Employee_Test_Rels { get; set; }
        public DbSet<Material> Materials { get; set; }
        public DbSet<PaymentInfo> PaymentInfos { get; set; }
        public DbSet<Sample> Samples { get; set; }
        public DbSet<Status> Statuses { get; set; }
        public DbSet<Test> Tests { get; set; }
        public DbSet<Test_Sample_Rel> Test_Sample_Rels { get; set; }
        public DbSet<TestType> TestTypes { get; set; }
        //public DbSet<User> Users { get; set; }
        public DbSet<Wage> Wages { get; set; }
    }
}