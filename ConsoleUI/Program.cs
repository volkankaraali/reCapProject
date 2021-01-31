using Business.Concrete;
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
        }
    }
}
