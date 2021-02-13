using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;
using System.Data.SqlTypes;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            //CarManager carManager = InMemoryTest();

            CarManager carManager = new CarManager(new EfCarDal());

            //CarTest(carManager);

            Console.WriteLine("***EF Database'de olan arabalar CarDetailsDto'ya göre gösterildi***");
            //CarGetAll(carManager);
            Console.WriteLine(carManager.GetAll().Message);

            Console.WriteLine("\n***BrandId'a göre ve ColorId'ye göre getirme****");
            Console.WriteLine("*color'a göre");
            //CarGetByColorId(carManager);
            Console.WriteLine(carManager.GetCarsByColorId(1).Message);
            Console.WriteLine("*brand'a göre");
            //CarGetByBrandId(carManager);
            Console.WriteLine(carManager.GetCarsByBrandId(1).Message);

            BrandManager brandManager = new BrandManager(new EfBrandDal());

            //BrandAddTest(brandManager);

            Console.WriteLine("\n***Marka Listesi***");
            //GetBrands(brandManager);
            Console.WriteLine(brandManager.GetAll().Message);

            ColorManager colorManager = new ColorManager(new EfColorDal());

            //ColorAddTest(colorManager);

            Console.WriteLine("\n***Renk Listesi***");
            //GetColors(colorManager);
            Console.WriteLine(colorManager.GetAll().Message);

            Console.WriteLine("\n***Kullanıcılar Oluşturuldu***");

            UserManager userManager = new UserManager(new EfUserDal());
            //UsersTest(userManager);
            Console.WriteLine(userManager.GetAll().Message);

            Console.WriteLine("\n***Müşteriler Oluşturuldu***");

            CustomerManager customerManager = new CustomerManager(new EfCustomerDal());
            //CustomersTest(customerManager);
            Console.WriteLine(customerManager.GetAll().Message);

            Console.WriteLine("\n***Kiralama Oluşturuldu***");

            RentalManager rentalManager = new RentalManager(new EfRentalDal());
            //RentalsTest(rentalManager);

            foreach (var rental in rentalManager.GetRentDetails().Data)
            {
                Console.WriteLine("rentalid:" + rental.RentalId + " - car description:" + rental.CarDescription + " - company name:" + rental.CampanyName + " - rentdate:" + rental.RentDate + " - returndate:" + rental.ReturnDate);
            }


        }

        private static void RentalsTest(RentalManager rentalManager)
        {
            Rental rental1 = new Rental() { Id = 1, CarId = 2, CustomerId = 1, RentDate = DateTime.Now };
            Rental rental2 = new Rental() { Id = 1, CarId = 2, CustomerId = 1, RentDate = DateTime.Now };
            Rental rental3 = new Rental() { Id = 2, CarId = 3, CustomerId = 1, RentDate = DateTime.Now };
            Rental rental4 = new Rental() { Id = 3, CarId = 3, CustomerId = 1, RentDate = DateTime.Now, ReturnDate = DateTime.Today };
            Rental rental5 = new Rental() { Id = 4, CarId = 6, CustomerId = 2, RentDate = DateTime.Now };
            rentalManager.Add(rental5);
        }

        private static void CustomersTest(CustomerManager customerManager)
        {
            Customer customer1 = new Customer() { Id = 1, UserId = 1, CompanyName = "volkan şirketi" };
            Customer customer2 = new Customer() { Id = 2, UserId = 2, CompanyName = "ali şirketi" };
            customerManager.Add(customer2);
        }

        private static void UsersTest(UserManager userManager)
        {
            User user1 = new User() { Id = 1, Name = "volkan", LastName = "karaali", Email = "mail@mail.com", Password = "v123" };
            User user2 = new User() { Id = 2, Name = "ali", LastName = "veli", Email = "mail1@mail.com", Password = "1234" };
            userManager.Add(user2);
        }

        private static void GetColors(ColorManager colorManager)
        {
            foreach (var color in colorManager.GetAll().Data)
            {
                Console.WriteLine(color.ColorName);
            }
        }

        private static void GetBrands(BrandManager brandManager)
        {
            foreach (var brand in brandManager.GetAll().Data)
            {
                Console.WriteLine(brand.BrandName);
            }
        }

        private static void CarGetAll(CarManager carManager)
        {
            foreach (var car in carManager.GetCarDetails().Data)
            {

                Console.WriteLine("id={0} - {1} marka, {2} renk, aciklama: {3}", car.CarId, car.BrandName, car.ColorName, car.Description);
            }
        }

        private static void CarGetByBrandId(CarManager carManager)
        {
            foreach (var car in carManager.GetCarsByBrandId(1).Data)
            {
                Console.WriteLine("Brand {0} olan araba verisinin fiyati: {1} ve aciklama: {2}", car.BrandId, car.DailyPrice, car.Description);
            }
        }

        private static void CarGetByColorId(CarManager carManager)
        {
            foreach (var car in carManager.GetCarsByColorId(1).Data)
            {
                Console.WriteLine("Color {0} olan araba verisinin fiyati: {1} ve aciklama: {2}", car.ColorId, car.DailyPrice, car.Description);
            }
        }

        /*
private static CarManager InMemoryTest()
{
   CarManager carManager = new CarManager(new InMemoryCarDal());
   Console.WriteLine("*****Tüm veriler********");
   foreach (var car in carManager.GetAll())
   {
       Console.WriteLine("id:{0} --- aciklama:{1}", car.CarId, car.Description);
   }

   Car car1 = new Car() { CarId = 9, BrandId = 2, ColorId = 3, DailyPrice = 1234567, ModelYear = 2009, Description = "none" };
   carManager.Add(car1);

   Console.WriteLine("\n***** Add metodu ile eklenen veri GetById ile çekildi*******");
   //foreach (var i in carManager.GetById(9))
   //{
   //    Console.WriteLine("id:{0}\nmarkaId:{1}\nrenkId:{2}\nfiyati:{3}\nmodeli:{4}\naciklamasi:{5}", i.Id, i.BrandId, i.ColorId, i.DailyPrice, i.ModelYear, i.Description);
   //}

   Console.WriteLine("\n***** Update metodu ile güncellenen veri******");
   Console.WriteLine("önceki veri;");
   //foreach (var i in carManager.GetById(9))
   //{
   //    Console.WriteLine("id:{0}\nmarkaId:{1}\nrenkId:{2}\nfiyati:{3}\nmodeli:{4}\naciklamasi:{5}", i.Id, i.BrandId, i.ColorId, i.DailyPrice, i.ModelYear, i.Description);
   //}

   Car carReNew = new Car();
   carReNew.CarId = 9;
   carReNew.BrandId = 2;
   carReNew.ColorId = 3;
   carReNew.DailyPrice = 1234567;
   carReNew.ModelYear = 2009;
   carReNew.Description = "Fiat-Doblo";

   carManager.Update(carReNew);
   Console.WriteLine("\ngüncellenmiş veri;");
   //foreach (var i in carManager.GetById(9))
   //{
   //    Console.WriteLine("id:{0}\nmarkaId:{1}\nrenkId:{2}\nfiyati:{3}\nmodeli:{4}\naciklamasi:{5}", i.Id, i.BrandId, i.ColorId, i.DailyPrice, i.ModelYear, i.Description);
   //}

   Console.WriteLine("\n******Delete metodu ile silinen id=1 olan veri silindi sonraki veriler*******");
   carManager.Delete(new Car() { CarId = 1 });
   foreach (var car in carManager.GetAll())
   {
       Console.WriteLine("id:{0} --- aciklama:{1}", car.CarId, car.Description);
   }

   return carManager;
}
*/

        //EntityFramework Crud test
        private static void ColorAddTest(ColorManager colorManager)
        {
            Color color1 = new Color() { ColorId = 1, ColorName = "Siyah" };
            Color color2 = new Color() { ColorId = 2, ColorName = "Beyaz" };
            Color color3 = new Color() { ColorId = 3, ColorName = "Sarı" };
            //colorManager.Add(color1);
            //colorManager.Add(color2);
            //colorManager.Add(color3);

            //Color color4 = new Color() { ColorId = 4, ColorName = "Laciverttt" };
            //colorManager.Add(color4);
            Color color4 = new Color() { ColorId = 4, ColorName = "Lacivert" };
            //colorManager.Update(color4);
            //colorManager.Delete(color4);
            
            Color color5 = new Color() { ColorId = 5, ColorName = "Mor" };
            //colorManager.Add(color5);
            
        }

        private static void BrandAddTest(BrandManager brandManager)
        {
            Brand brand1 = new Brand() { BrandId = 1, BrandName = "Audi" };
            Brand brand2 = new Brand() { BrandId = 2, BrandName = "BMW" };
            Brand brand3 = new Brand() { BrandId = 3, BrandName = "Mercedes" };
            
            //brandManager.Add(brand1);
            //brandManager.Add(brand2);
            //brandManager.Add(brand3);

            //Brand brand4 = new Brand() { BrandId = 4, BrandName = "Opelz" };
            //brandManager.Add(brand4);
            Brand brand4 = new Brand() { BrandId = 4, BrandName = "Opel" };
            //brandManager.Update(brand4);

            Brand brand5 = new Brand() { BrandId = 5, BrandName = "Ford" };
            //brandManager.Add(brand5);
            //brandManager.Delete(brand5);

        }

        private static void CarTest(CarManager carManager)
        {
            Car car1 = new Car() { CarId = 1, BrandId = 1, ColorId = 1, DailyPrice = 0, Description = "a", ModelYear = 2000 };
            //carManager.Add(car1);  kaydetmez.
            Car car2 = new Car() { CarId = 2, BrandId = 1, ColorId = 1, DailyPrice = 3242352, Description = "sıfır", ModelYear = 2021 };
            Car car3 = new Car() { CarId = 5, BrandId = 2, ColorId = 3, DailyPrice = 2314343, Description = "2.el", ModelYear = 2018 };
            Car car4 = new Car() { CarId = 6, BrandId = 1, ColorId = 2, DailyPrice = 32454362, Description = "son model araba", ModelYear = 2020 };
            Car car5 = new Car() { CarId = 7, BrandId = 2, ColorId = 2, DailyPrice = 0, Description = "son model araba", ModelYear = 2020 };
            
            //carManager.Add(car2);
            //carManager.Add(car3);
            //carManager.Add(car4);
            //carManager.Add(car5);
            //carManager.Add(car6);
            
            //carManager.Delete(car6);

            //Car car6 = new Car() { CarId = 8, BrandId = 1, ColorId = 3, DailyPrice = 12314686, Description = "spor araba", ModelYear = 2020 };
            Car car6 = new Car() { CarId = 8, BrandId = 1, ColorId = 1, DailyPrice = 12314686, Description = "*updated spor araba", ModelYear = 2020 };
            //carManager.Update(car6);
        }
    }
}
