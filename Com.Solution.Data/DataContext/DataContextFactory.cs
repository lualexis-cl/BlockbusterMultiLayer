using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using System;
using System.Collections.Generic;
using System.Text;

namespace Com.Solution.Data.DataContext
{
    public class DataContextFactory : IDesignTimeDbContextFactory<PaymentDataContext>
    {
        public PaymentDataContext CreateDbContext(string[] args)
        {
            var appConfiguration = new AppConfiguration();
            var optionBuilder = new DbContextOptionsBuilder<PaymentDataContext>();
            optionBuilder.UseSqlServer(appConfiguration.ConnectionString);
            return new PaymentDataContext(optionBuilder.Options);
        }
    }
}
