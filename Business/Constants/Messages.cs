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
    }
}

