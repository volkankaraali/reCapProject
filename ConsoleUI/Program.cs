using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Abstract;
using Entities.Concrete;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            

            CarManager carManager = new CarManager(new InMemoryCarDal());
            Console.WriteLine("*****Tüm veriler********");
            foreach (var car in carManager.GetAll())
            { 
                Console.WriteLine("id:{0} --- aciklama:{1}",car.Id,car.Description);
            }

            Car car1 = new Car() {Id=9,BrandId=2,ColorId=3,DailyPrice=1234567,ModelYear=2009,Description="none"};
            carManager.Add(car1);

            Console.WriteLine("\n***** Add metodu ile eklenen veri GetById ile çekildi*******");
            foreach (var i in carManager.GetById(9))
            {
                Console.WriteLine("id:{0}\nmarkaId:{1}\nrenkId:{2}\nfiyati:{3}\nmodeli:{4}\naciklamasi:{5}",i.Id,i.BrandId,i.ColorId,i.DailyPrice,i.ModelYear,i.Description);
            }

            Console.WriteLine("\n***** Update metodu ile güncellenen veri******");
            Console.WriteLine("önceki veri;");
            foreach (var i in carManager.GetById(9))
            {
                Console.WriteLine("id:{0}\nmarkaId:{1}\nrenkId:{2}\nfiyati:{3}\nmodeli:{4}\naciklamasi:{5}", i.Id, i.BrandId, i.ColorId, i.DailyPrice, i.ModelYear, i.Description);
            }

            Car carReNew = new Car();
            carReNew.Id = 9;
            carReNew.BrandId = 2;
            carReNew.ColorId = 3;
            carReNew.DailyPrice = 1234567;
            carReNew.ModelYear = 2009;
            carReNew.Description = "Fiat-Doblo";

            carManager.Update(carReNew);
            Console.WriteLine("\ngüncellenmiş veri;");
            foreach (var i in carManager.GetById(9))
            {
                Console.WriteLine("id:{0}\nmarkaId:{1}\nrenkId:{2}\nfiyati:{3}\nmodeli:{4}\naciklamasi:{5}", i.Id, i.BrandId, i.ColorId, i.DailyPrice, i.ModelYear, i.Description);
            }

            Console.WriteLine("\n******Delete metodu ile silinen id=1 olan veri silindi sonraki veriler*******");
            carManager.Delete(new Car() {Id=1 });
            foreach (var car in carManager.GetAll())
            {
                Console.WriteLine("id:{0} --- aciklama:{1}", car.Id, car.Description);
            }
            */

            CarManager carManager = new CarManager(new EfCarDal());
            Car car1 = new Car() { CarId = 1, BrandId = 1, ColorId = 1, DailyPrice = 0, Description = "a",ModelYear=2000 };
            //carManager.Add(car1);  kaydetmez.
            Car car2 = new Car() { CarId = 2, BrandId = 1, ColorId = 1, DailyPrice = 3242352, Description = "sıfır", ModelYear = 2021 };
            Car car3 = new Car() { CarId = 5, BrandId = 2, ColorId = 3, DailyPrice = 2314343, Description = "2.el", ModelYear = 2018 };
            Car car4 = new Car() { CarId = 6, BrandId = 1, ColorId = 2, DailyPrice = 32454362, Description = "son model araba", ModelYear = 2020 };
            //carManager.Add(car2);
            //carManager.Add(car3);
            carManager.Add(car4);
            Console.WriteLine("***EF Database'de olan arabalar***");
            foreach (var car in carManager.GetAll())
            {
                
                Console.WriteLine("id={0} - {1} marka, {2} renk, aciklama: {3}",car.CarId,car.BrandId,car.ColorId,car.Description);
            }

            Console.WriteLine("***BrandId'a göre ve ColorId'ye göre getirme****");
            foreach (var car in carManager.GetCarsByBrandId(1))
            {
                Console.WriteLine("Brand'ı {0} olan araba verisinin fiyati: {1} ve aciklama: {2}",car.BrandId,car.DailyPrice,car.Description);
            }



            BrandManager brandManager = new BrandManager(new EfBrandDal());
            //Brand brand1 = new Brand() { Id = 1, Name = "Audi" };
            //Brand brand2 = new Brand() { Id = 2, Name = "BMW" };
            //Brand brand3 = new Brand() { Id = 3, Name = "Mercedes" };
            //brandManager.Add(brand1);
            //brandManager.Add(brand2);
            //brandManager.Add(brand3);
            Console.WriteLine("***Marka Listesi***");
            foreach (var brand in brandManager.GetAll())
            {
                Console.WriteLine(brand.BrandName);
            }

            ColorManager colorManager = new ColorManager(new EfColorDal());
            //Color color1 = new Color() {Id=1,Name="Siyah" };
            //Color color2 = new Color() { Id = 2, Name = "Beyaz" };
            //Color color3 = new Color() { Id = 3, Name = "Sarı" };
            //colorManager.Add(color1);
            //colorManager.Add(color2);
            //colorManager.Add(color3);
            Console.WriteLine("***Renk Listesi***");
            foreach (var color in colorManager.GetAll())
            {
                Console.WriteLine(color.ColorName);
            }


        }
    }
}
