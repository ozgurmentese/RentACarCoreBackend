using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Business.Constants
{
    public static class Messages
    {
        public static string Listed = "Listelendi";
        public static string Added = "Eklendi";
        public static string Updated = "Güncellendi";
        public static string Deleted = "Silindi";
        public static string ErrorRental = "Araba kiralanamaz";
        public static string LimitExceeded = "Limit Aşıldı";
        public static string Unknown = "Bulunamadı";
        public static string Success = "Başarılı";

        public static string[] ValidImageFileTypes = { ".JPG", ".JPEG", ".PNG", ".TIF", ".TIFF", ".GIF", ".BMP", ".ICO" };

        public static string CarListed = "Arabalar listelendi";
        public static string DataUpdated = "Veri güncellendi";
        public static string DataDeleted = "Veri silindi";
        public static string DailyPriceInvalid = "Günlük fiyatı geçersiz";
        public static string DataAdded = "Veri eklendi";
        public static string MaintenanceTime = "Sitemiz şuanda bakımdadır 01:00 saati ile işleminizi gerçekleştirebilirsiniz.";


        public static string BrandAdded = "Marka eklendi";
        public static string BrandDeleted = "Marka silindi";
        public static string BrandListed = "Marka listelendi";
        public static string BrandUpdate = "Marka güncellendi";


        public static string ColorAdded = "Renk eklendi";
        public static string ColorDeleted = "Renk silindi";
        public static string ColorUpdated = "Renk güncellendi";


        public static string CustomerAdded = "Müşteri eklendi";
        public static string CustomerDeleted = "Müşteri silindi";
        public static string CustomerUpdated = "Müşteri Güncellendi";


        public static string RentalAdded = "Kiralama eklendi";
        public static string RentalDeleted = "Kiralama silindi";
        public static string RentalUpdated = "Kiralama güncellendi";


        public static string UserAdded = "Kullanıcı eklendi";
        public static string UserDeleted = "Kullanıcı silindi";
        public static string UserUpdated = "Kullanıcı güncellendi";


        public static string RentalNotComeBack = "Başka bir araç seçiniz. Bu araç şuan başka müşteride kirada";
        public static string CarIsAtRest = "Bu araç yarın kiralanabilir, şuan bakım ve dinlenmede";
        public static string RentDayCantbePast = "Kiralama işlemi geçmiş tarih olamaz";


        public static string CarImageListed = "Görseller listelendi";
        public static string ImageDeleted = "Görsel silindi";
        public static string ImageAdded = "Görsel eklendi";
        public static string ImageUpdated = "Görsel güncellendi";
        public static string CarHaveNoImage = "Araca ait görsel bulunamadı";
        public static string InvalidImageExtension = "Geçersiz resim uzantısı";
        public static string CarImageMustBeExists = "Araba resmi mevcut olmalı";
        public static string OverLimit = "Bir araca en fazla 4 resim yüklenebilir!";

        public static string AuthorizationDenied = "Bu işlem için yetkiniz bulunmamaktadır";
        public static string UserRegistered = "Kullanıcı kaydı başarılı";
        public static string UserNotFound = "Kullanıcı bulunamadı";
        public static string PasswordError = "Şifre hatalı";
        public static string SuccessfulLogin = "Başarılı giriş";
        public static string UserAlreadyExists = "Kullanıcı zaten var";
        public static string AccessTokenCreated = "Erişim jetonu oluşturuldu";
        public static string SuccessRegister = "Kayıt olundu. Giriş yapın";
        public static string ImageNotFound = "Resim bulunamadı";
        public static string SuccessImageDeleted = "resim silme işlemi başarılı";
        public static string AllImagesDeleted = "Araca ait bütün resimler silindi";
    }
}
