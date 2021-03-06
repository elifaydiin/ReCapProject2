﻿using Core.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Business.Constans
{
    public static class Messages
    {
        public static string CarAdded = "Araba eklendi";
        public static string CarUptated = "Araba güncellendi";
        public static string CarNameInvalid = "Araba ismi geçersiz";
        public static string MaintenanceTime = "Araba bakımda";
        public static string CarsListed = "Arabalar listelendi";
        public static string RentAdded = "Kiralama başarılı";
        public static string RentError = "Kiralama başarısız";
        public static string RentDeleted = "Kiralama iptal edildi";
        public static string BrandAdded = "Marka eklendi";
        public static string BrandDeleted = "Marka silindi";
        public static string BrandUptated = "Marka güncellendi";
        public static string ColorAdded = "Araba rengi eklendi";
        public static string ColorUptated = "Araba rengi güncellendi";
        public static string ColorDeleted = "Araba rengi silindi";
        public static string UserAdded = "Kullanıcı eklendi";
        public static string UserUptated = "Kullanıcı güncelledi";
        public static string UserDeleted = "Kullanıcı silindi";
        public static string CustomerAdded = "Müşteri eklendi";
        public static string CustomerUptated = "Müşteri güncellendi";
        public static string CustomerDeleted = "Müşteri silindi";
        public static string CarImageLimitExceeded = "Araba resim limitini aştınız";
        public static string AuthorizationDenied = "Yetkiniz yok";
        public static string TokenCreated = "Token oluşturuldu";
        public static string UserNotFound = "Kullanıcı bulunamadı";
        public static string WrongPassword = "Hatalı parola";
        public static string SuccessfulLogin = "Başarılı giriş";
        public static string Registered = "Kayıt başarılı";
        public static string UserAvailable = "Kullanıcı uygun";
    }
}
