using Microsoft.EntityFrameworkCore;
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Menu;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using WilberrriesADM.Models;

namespace WilberrriesADM.Data
{
    public class DataBase: DbContext
    {
        public DbSet<Basket> Baskets { get; set; }
        public DbSet<Seller> Sellers { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<PickupPoint> PickupPoints { get; set; }
        public DbSet<ProductInBasket> ProductsInBaskets { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<ProductInOrder> ProductsInOrders { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<EmployeeInPickupPoint> EmployeesInPickupPoints { get; set; }
        public DbSet<OrderDelivery> OrdersDeliveries { get; set; }

        public DataBase()
        {
            Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=DESKTOP-591T9LE;Initial Catalog=Wilberries;Integrated Security=True;Connect Timeout=30;Encrypt=True;Trust Server Certificate=True;Application Intent=ReadWrite;Multi Subnet Failover=False");
        }
    }
}
