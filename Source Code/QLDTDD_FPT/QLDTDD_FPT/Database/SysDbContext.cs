using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLDTDD_FPT.Database
{
    public class SysDbContext : DbContext
    {
        //singleton
        private static SysDbContext _instance;
        public static SysDbContext Instance
        {
            get
            {
                return _instance ?? (_instance = new SysDbContext());
            }
        }

        //static string path = new DirectoryInfo(Environment.CurrentDirectory).Parent.Parent.FullName + @"\Database";
        static string path = new DirectoryInfo(Environment.CurrentDirectory).FullName;
        static string connectionString = @"Data Source=(LocalDB)\v11.0;AttachDbFilename=" + path + @"\QLShop_DTDD.mdf;Integrated Security=True;";

        public SysDbContext()
            : base(connectionString)
            //: base("name=SysDbContext")
        {
            Database.CreateIfNotExists();
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
       

        }

        public DbSet<Phone> LstPhone { get; set; } // list Phones
        public DbSet<Asset> LstAsset { get; set; }
        
        public DbSet<Color> LstColor { get; set; }
        public DbSet<Distributor> LstDistr { get; set; }
        public DbSet<OperatingSystem> LstOs { get; set; }
        public DbSet<Manufacturer> LstManu { get; set; }
        public DbSet<Import> LstImports { get; set; }
        public DbSet<Export> LstExports { get; set; }
        public DbSet<Staff> LstStaffs { get; set; }
        public DbSet<TimeBook> LstTimeBooks { get; set; }
        public DbSet<Order> LstOrders { get; set; }
    }
}
