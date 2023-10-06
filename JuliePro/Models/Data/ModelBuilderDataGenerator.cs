using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JuliePro.Models;

namespace JuliePro.Data
{
    public static class ModelBuilderDataGenerator
    {
        public static void GenerateData(this ModelBuilder builder)
        {

            builder.Entity<Speciality>().HasData(new Speciality() { Id = 1, Name = "Perte de poids" });
            builder.Entity<Speciality>().HasData(new Speciality() { Id = 2, Name = "Course" });
            builder.Entity<Speciality>().HasData(new Speciality() { Id = 3, Name = "Halthérophilie" });
            builder.Entity<Speciality>().HasData(new Speciality() { Id = 4, Name = "Réhabilitation" });

            builder.Entity<Trainer>().HasData(new Trainer() { Id = 1, FirstName = "Chrystal", LastName = "Lapierre", Email = "Chrystal.lapierre@juliepro.ca", SpecialityId = 1, Photo = "Chrystal.png" });
            builder.Entity<Trainer>().HasData(new Trainer() { Id = 2, FirstName = "Félix", LastName = "Trudeau", Email = "Felix.trudeau@juliePro.ca", SpecialityId = 2, Photo = "Felix.png" });
            builder.Entity<Trainer>().HasData(new Trainer() { Id = 3, FirstName = "François", LastName = "Saint-John", Email = "Frank.StJohn@juliepro.ca", SpecialityId = 1, Photo = "Francois.png" });
            builder.Entity<Trainer>().HasData(new Trainer() { Id = 4, FirstName = "Jean-Claude", LastName = "Bastien", Email = "JC.Bastien@juliepro.ca", SpecialityId = 4, Photo = "JeanClaude.png" });
            builder.Entity<Trainer>().HasData(new Trainer() { Id = 5, FirstName = "Jin Lee", LastName = "Godette", Email = "JinLee.godette@juliepro.ca", SpecialityId = 3, Photo = "Jin Lee.png" });
            builder.Entity<Trainer>().HasData(new Trainer() { Id = 6, FirstName = "Karine", LastName = "Lachance", Email = "Karine.Lachance@juliepro.ca", SpecialityId = 2, Photo = "Karine.png" });
            builder.Entity<Trainer>().HasData(new Trainer() { Id = 7, FirstName = "Ramone", LastName = "Esteban", Email = "Ramone.Esteban@juliepro.ca", SpecialityId = 3, Photo = "Ramone.png" });

            builder.Entity<Customer>().HasData(new Customer() { Id = 1, FirstName = "FélixUn", LastName = "TrudeauUn", Email = "Felixun.trudeau@juliePro.ca", BirthDate = new DateTime(2009,09,28), StartWeight = 100, TrainerId=1 });
            builder.Entity<Customer>().HasData(new Customer() { Id = 2, FirstName = "FélixDeux", LastName = "TrudeauDeux", Email = "Felixdeux.trudeau@juliePro.ca", BirthDate = new DateTime(2008,08,27), StartWeight = 200, TrainerId=1});
            builder.Entity<Customer>().HasData(new Customer() { Id = 3, FirstName = "FélixTrois", LastName = "TrudeauTrois", Email = "Felixtrois.trudeau@juliePro.ca", BirthDate = new DateTime(2007,07,26), StartWeight = 300, TrainerId = 1 });

            builder.Entity<Objective>().HasData(new Objective() { Id = 1, Name = "Objective1", LostWeightKg = 2, DistanceKm = 2, CustomerId = 1 });
            builder.Entity<Objective>().HasData(new Objective() { Id = 2, Name = "Objective2", LostWeightKg = 3, DistanceKm = 3, AchievedDate = new DateTime(2020,08,29), CustomerId = 1 });

            builder.Entity<Objective>().HasData(new Objective() { Id = 3, Name = "Objective3", LostWeightKg = 4, DistanceKm = 4, CustomerId = 2 });
            builder.Entity<Objective>().HasData(new Objective() { Id = 4, Name = "Objective4", LostWeightKg = 5, DistanceKm = 5, CustomerId = 2 });

            builder.Entity<Objective>().HasData(new Objective() { Id = 5, Name = "Objective5", LostWeightKg = 6, DistanceKm = 6, AchievedDate = new DateTime(2021,09,28), CustomerId = 3 });
            builder.Entity<Objective>().HasData(new Objective() { Id = 6, Name = "Objective6", LostWeightKg = 7, DistanceKm = 7, AchievedDate = new DateTime(2022,10,27), CustomerId = 3 });
        }
    }
}