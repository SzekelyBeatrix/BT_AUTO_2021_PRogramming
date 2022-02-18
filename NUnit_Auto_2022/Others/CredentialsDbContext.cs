using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace NUnit_Auto_2022.Others
{
    class CredentialsDbContext :DbContext
    {
        public DbSet<DataModels.EFModels.credentialsbt> credentials { get; set; }
        private string connectionString;

        public CredentialsDbContext(DbContextOptions<CredentialsDbContext> options) : base(options)
        {

        }

        public CredentialsDbContext(string connectionString)
        {
            this.connectionString = connectionString;
        }
        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString));
        }
    }
}
