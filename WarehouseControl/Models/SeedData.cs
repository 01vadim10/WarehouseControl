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
                        BarCode = 4453232,
                        Category = "SomeCat",
                        Code = 345435,
                        Height = 1,
                        Length = 2,
                        Measure = "kg",
                        TradeSurcharge = 111,
                        VAT = 88,
                        Weight = 1,
                        Width = 1
                    },
                    new Product
                    {
                        Name = "Чай",
                        BarCode = 12343234512,
                        Category = "Чай",
                        Code = 113254534,
                        Height = 164,
                        Length = 164,
                        Measure = "ШТ",
                        TradeSurcharge = 33,
                        VAT = 20,
                        Weight = 0.1,
                        Width = 55
                    },
                    new Product
                    {
                        Name = "Tea Tess",
                        BarCode = 1111111111222,
                        Category = "Tea",
                        Code = 523423,
                        Height = 0,
                        Length = 0,
                        Measure = "ШТ",
                        TradeSurcharge = 2,
                        VAT = 20,
                        Weight = 0.04,
                        Width = 0
                    },
                    new Product
                    {
                        Name = "Tea Tess Lime",
                        BarCode = 30303030038,
                        Category = "Tea",
                        Code = 8383832,
                        Height = 175,
                        Length = 80,
                        Measure = "ШТ",
                        TradeSurcharge = 7,
                        VAT = 20,
                        Weight = 0.15,
                        Width = 175
                    },
                    new Product
                    {
                        Name = "Tea Tipson",
                        BarCode = 488484848,
                        Category = "Tea",
                        Code = 3202934029,
                        Height = 100,
                        Length = 75,
                        Measure = "ШТ",
                        TradeSurcharge = 8,
                        VAT = 20,
                        Weight = 0.1,
                        Width = 85
                    },
                    new Product
                    {
                        Name = "Tea AHMAD",
                        BarCode = 8788979277,
                        Category = "Tea",
                        Code = 9920390,
                        Height = 88,
                        Length = 292,
                        Measure = "ШТ",
                        TradeSurcharge = 7,
                        VAT = 20,
                        Weight = 0.8,
                        Width = 40
                    }
                );
                context.SaveChanges();
            }
        }
    }
}
