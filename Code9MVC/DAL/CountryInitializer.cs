using Code9MVC.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;

namespace Code9MVC.DAL
{
    public class CountryInitializer : DropCreateDatabaseIfModelChanges<CountryContext>
    {
        protected override void Seed(CountryContext context)
        {
            var countries = new List<Country>
            {
                new Country
                {
                    Name = "Serbia",
                    Area = 77474,
                    Currency = "Serbian dinar",
                    ShortName = "RS",
                    FlagImageFilePath = "serbia.jpg",
                    Cities = new List<City>
                    {
                        new City
                        {
                            Name = "Belgrade",
                            PostalCode = "11000"
                        },
                        new City
                        {
                            Name = "Novi Sad",
                            PostalCode = "21000"
                        }
                    }
                },
                new Country
                {
                    Name = "Brasil",
                    Area = 8515767d,
                    Currency = "real",
                    ShortName = "BR",
                    FlagImageFilePath = "brasil.jpg",
                    Cities = new List<City>
                    {
                        new City
                        {
                            Name = "Brasilia",
                            PostalCode = "70000-000"
                        },
                        new City
                        {
                            Name = "Sao Paulo",
                            PostalCode = "01000-000"
                        }
                    }
                },
                new Country
                {
                    Name = "Japan",
                    Area = 377972.28,
                    Currency = "Yen",
                    ShortName = "JP",
                    FlagImageFilePath = "japan.jpg",
                    Cities = new List<City>
                    {
                        new City
                        {
                            Name = "Tokyo",
                            PostalCode = "100-0001"
                        }
                    }
                }
            };
            countries.ForEach(country => context.Countries.Add(country));
            context.SaveChanges();
        }
    }
}