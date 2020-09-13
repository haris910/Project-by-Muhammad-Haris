using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Web;

namespace Haris.Models
{
    public class Restaurant
    {
        public int ID { get; set; }
            public string name { get; set; }
        public string location { get; set; }
        public int no_of_rooms { get; set; }
        public int no_of_staff { get; set; }
    }

    public class RestaurantDBContext : DbContext
    {
        public DbSet<Restaurant> Restaurants { get; set; }
    }
}