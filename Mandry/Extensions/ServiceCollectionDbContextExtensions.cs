﻿using Mandry.Data.DbContexts;
using Microsoft.Data.Sql;
using Microsoft.EntityFrameworkCore;

namespace Mandry.Extensions
{
    public static class ServiceCollectionDbContextExtensions
    {
        public static void SetupSqlServerDbContext(this WebApplicationBuilder builder)
        {
            IConfiguration configuration = builder.Configuration;
            string connectionString = configuration.GetConnectionString("SqlServer") ?? throw new Exception("SqlServer connection string is missing");

            builder.Services.AddDbContext<MandryDbContext>(options => options.UseSqlServer(connectionString));
        }

        
    }
}
