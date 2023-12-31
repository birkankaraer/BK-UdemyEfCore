﻿using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UdemyEFCore.DatabaseFirst.DataAccessLayer
{
    
    public class DbContextInitializer
    {
        //Veri tabanımı ilgilendiren kodları yazacağım 
        public static IConfigurationRoot Configuration; //appsettings.json dosyasını okuması için 
        public static DbContextOptionsBuilder<AppDbContext> OptionsBuilder; //veri tabanı ile ilgili optionsları belirteceğim yer

        public static void Build()
        {
            var builder = new ConfigurationBuilder().SetBasePath(Directory.GetCurrentDirectory()).AddJsonFile("appsettings.json", optional: true, reloadOnChange:true);

            Configuration = builder.Build();
            //OptionsBuilder = new DbContextOptionsBuilder<AppDbContext>();
            //OptionsBuilder.UseSqlServer(Configuration.GetConnectionString("SqlCon"));

        }
    }
}
