using System.Linq;
using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace WarehouseControl.Models
{
    public class SeedData
    {
        public static void EnsurePopulated(IApplicationBuilder app)
        {
            ApplicationDbContext context = app.ApplicationServices
                .GetRequiredService<ApplicationDbContext>();
            context.Database.Migrate();
            if (!context.Shops.Any())
            {
                context.Shops.AddRange(
                    new Shop
                    {
                        Name = "Рокоссовского",
                        Code = "ГМ1",
                        Address = "г.Минск, пр-т Рокоссовского,2"
                    },
                    new Shop
                    {
                        Name = "Гомель",
                        Code = "ГМ3",
                        Address = "г.Гомель, ул.Косарева,18"
                    },
                    new Shop
                    {
                        Name = "Могилев",
                        Code = "ГМ2",
                        Address = "г.Могилев, ул.Мовчанского,6"
                    },
                    new Shop
                    {
                        Name = "Горецкого",
                        Code = "ГМ4",
                        Address = "г.Минск, ул.Горецкого,2"
                    },
                    new Shop
                    {
                        Name = "Боровая",
                        Code = "БОР",
                        Address = "Минский р-н, д.Боровая"
                    },
                    new Shop
                    {
                        Name = "Сухаревская",
                        Code = "СУХ",
                        Address = "г.Минск, ул.Сухаревская, 31"
                    },
                    new Shop
                    {
                        Name = "Жуковского",
                        Code = "ЖК",
                        Address = "г.Минск, ул. Жуковского, 3"
                    },
                    new Shop
                    {
                        Name = "Червякова",
                        Code = "КМ1",
                        Address = "г.Минск, ул. Червякова, 57"
                    },
                    new Shop
                    {
                        Name = "Городецкая",
                        Code = "ГМ5",
                        Address = "г.Минск, ул.Городецкая,30"
                    },
                    new Shop
                    {
                        Name = "Игуменский",
                        Code = "ГМ6",
                        Address = "г.Минск, Игуменский тракт, 30"
                    },
                    new Shop
                    {
                        Name = "Партизанский",
                        Code = "ГМ8",
                        Address = "г.Минск, пр-т Партизанский, 150А"
                    },
                    new Shop
                    {
                        Name = "Диамант",
                        Code = "ГМ9",
                        Address = "Минский район, Щомыслицкий сельский совет, дом 32/4"
                    },
                    new Shop
                    {
                        Name = "ТЛК \"Прилесье\"",
                        Code = "11808023",
                        Address = "Минская обл., Минский р-н, Луговослободской с/с, 4"
                    }
                );
                context.Products.AddRange(
                    new Product
                    {
                        Name = "Test",
                        BarCode = "ttt",
                        Category = "SomeCat",
                        Code = "T",
                        Height = 1,
                        Length = 2,
                        Measure = "kg",
                        TradeSurcharge = 111,
                        VAT = 88,
                        Weight = 1,
                        Width = 1
                    }
                );
                context.SaveChanges();
            }
        }
    }
}
