using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JuliePro.Models;

namespace ZombieParty.Data
{
    public static class ModelBuilderDataGenerator
    {
        public static void GenerateData(this ModelBuilder builder)
        {

            builder.Entity<Speciality>().HasData(new Speciality() { Id = 1, Name = "Perte de poids" });
            builder.Entity<Speciality>().HasData(new Speciality() { Id = 2, Name = "Course" });
            builder.Entity<Speciality>().HasData(new Speciality() { Id = 3, Name = "Halthérophilie" });
            builder.Entity<Speciality>().HasData(new Speciality() { Id = 4, Name = "Réhabilitation" });
        }
    }
}