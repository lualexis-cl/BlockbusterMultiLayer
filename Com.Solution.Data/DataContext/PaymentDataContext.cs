using Com.Solution.Data.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Com.Solution.Data.DataContext
{
    public class PaymentDataContext : DbContext
    {
        public PaymentDataContext(DbContextOptions<PaymentDataContext> options)
            : base(options)
        {
        }
        public DbSet<PaymentDetail> PaymentDetail { get; set; }

        public static OptionBuild option = new OptionBuild();
        public class OptionBuild
        {
            public OptionBuild()
            {
                this.AppConfiguration = new AppConfiguration();
                this.OptionBuilder = new DbContextOptionsBuilder<PaymentDataContext>();
                this.OptionBuilder.UseSqlServer(this.AppConfiguration.ConnectionString);
                this.DbContextOptions = this.OptionBuilder.Options;
            }

            public DbContextOptionsBuilder<PaymentDataContext> OptionBuilder { get; set; }

            public DbContextOptions<PaymentDataContext> DbContextOptions { get; set; }
            private AppConfiguration AppConfiguration { get; set; }
        }
    }
}
