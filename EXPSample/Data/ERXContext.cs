using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EXPSample.Data
{
    public class ERXContext : DbContext
    {
        public DbSet<PersonalInfo> PersonalInfos { get; set; }
        public DbSet<BusinessType> BusinessTypes { get; set; }
        public DbSet<CountryInTheWorld> CountryInTheWorlds { get; set; }
        public DbSet<Title> Titles { get; set; }
        public DbSet<Occupation> Occupations { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionBuilder)
        {
            optionBuilder.UseSqlServer("Data Source = (localdb)\\MSSQLLocalDB; Initial Catalog = ERXContext");
        }
    }
}
