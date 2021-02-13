using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Constants
{
    public static class Messages
    {
        //car için mesajlar
        public static string CarAddedSuccess = "Araba Eklendi.";
        public static string CarAddedError = "Aciklama en az 2 karakter ve günlük fiyat 0'dan büyük olmali.";

        public static string CarDeletedSuccess = "Araba Silindi.";

        public static string CarUptadedSuccess = "Araba Güncellendi.";

        public static string CarGetAllSuccess = "Arabalar Listelendi.";

        public static string CarGetByBrand = "Markaya göre araba listelendi.";
        public static string CarGetByColor = "Renge göre araba listelendi.";

        //brand için mesajlar
        public static string BrandAddedSuccess = "Marka Eklendi.";
        public static string BrandDeletedSuccess = "Marka Silindi.";
        public static string BrandGetAllSuccess = "Marka Listelendi.";
        public static string BrandUpdatedSuccess = "Marka güncellendi.";

        //color için mesajlar
        public static string ColorAddedSuccess = "Renk Eklendi.";
        public static string ColorDeletedSuccess = "Renk Silindi.";
        public static string ColorGetAllSuccess = "Renk Listelendi.";
        public static string ColorUpdatedSuccess = "Renk güncellendi.";

        //user için mesajlar
        public static string UserAddedSuccess = "Kullanıcı Eklendi.";
        public static string UserDeletedSuccess = "Kullanıcı Silindi.";
        public static string UserGetAllSuccess = "Kullanıcı Listelendi.";
        public static string UserUpdatedSuccess = "Kullanıcı güncellendi.";
        
        //customer için mesajlar
        public static string CustomerAddedSuccess = "Müşteri Eklendi.";
        public static string CustomerDeletedSuccess = "Müşteri Silindi.";
        public static string CustomerGetAllSuccess = "Müşteri Listelendi.";
        public static string CustomerUpdatedSuccess = "Müşteri güncellendi.";

        //rental için mesajlar
        public static string RentalAddedSuccess = "Kiralama Eklendi.";
        public static string RentalDeletedSuccess = "Kiralama Silindi.";
        public static string RentalGetAllSuccess = "Kiralama Listelendi.";
        public static string RentalUpdatedSuccess = "Kiralama güncellendi.";

        public static string RentalAddedError = "Teslim etmedğiniz araba bulunmaktadır bu nedenle kiralama yapamazsınız.";

    }
}

