using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ASP.NET_DesignStudio.Models
{
    public class DesignDbContext : DbContext
    {
        public DbSet<Service> Services { get; set; }

        public DbSet<Master> Masters { get; set; }
    }

    //public class DbInialize : DropCreateDatabaseAlways<DesignDbContext>
    //{
    //    protected override void Seed(DesignDbContext db)
    //    {
    //        Master master1 = new Master { Name = "Ольга", Age = 25, YearsOfWork = 5 };
    //        Master master2 = new Master { Name = "Андрей", Age = 30, YearsOfWork = 8 };
    //        Master master3 = new Master { Name = "Евгений", Age = 32, YearsOfWork = 9 };

    //        db.Masters.Add(master1);
    //        db.Masters.Add(master2);
    //        db.Masters.Add(master3);
    //        db.SaveChanges();

    //        Service service1 = new Service { Name = "Разработка идеи", Description = "3D визуализация", Price = 1000, MasterId = master1.Id };
    //        Service service2 = new Service { Name = "Рабочий проект дизайна", Description = "Для строительных работ", Price = 700, MasterId = master2.Id };
    //        Service service3 = new Service { Name = "Авторское сопровождение", Description = "Выезд на обьект для контроля строительных работ", Price = 500, MasterId = master3.Id };
    //        Service service4 = new Service { Name = "Ремонтно-строительные работы", Description = "Реализация задуманого дизайна", Price = 1200, MasterId = master2.Id };

    //        db.Services.Add(service1);
    //        db.Services.Add(service2);
    //        db.Services.Add(service3);
    //        db.Services.Add(service4);
    //        db.SaveChanges();


    //        base.Seed(db);
    //    }
    //}
}