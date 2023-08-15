using DAL.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Data
{
    public class InitializeDataSeeder
    {
        private readonly ModelBuilder _modelBuilder;

        public InitializeDataSeeder(ModelBuilder modelBuilder) {
            _modelBuilder = modelBuilder;
        }
        public void InsertData()
        {
            var car1 = new List<Car>()
            {
              new Car(){ ModelName="BMW2020",ModelType="Typep1",ModelYear=DateTime.Now,Power="1cc"}
             ,new Car(){  ModelName="MBW2023",ModelType="Typep2",ModelYear=DateTime.Now,Power="2cc"}

            };
            var casr2 = new List<Car>()
            {
             new Car(){ ModelName="NISSAN2020",ModelType="Typep1",ModelYear=DateTime.Now,Power="1cc"}

            };
            var brands = new List<Brand>()
            {
               new Brand(){
                   
                   Name="BMW",
                  // Cars=car1
               },
               
                 new Brand(){
                    
                    Name="Nissan",
                   // Cars=casr2
               }
            };
           
          _modelBuilder.Entity<Brand>().HasData(brands);
        }
    }
}
