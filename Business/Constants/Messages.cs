using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Constants
{
    class Messages
    {
        //RentalMessages
        public static string RentalAdded = "Kiralama işlemi başarılı";
        public static string RentalAddedError = "Aracın kiraya verilebilmesi için önce teslim alınması gerekir.";
        public static string RentalDeleted = "Kiralama Bilgisi Silindi";
        public static string RentalUpdated = "Kiralama Bilgisi Güncellendi";
        public static string RentalUpdatedReturnDate = "Araç teslim alındı";
        public static string RentalUpdatedReturnDateError = "Araç zaten teslim alınmış";

        //CarMessages
        public static string CarAdded = "Araç kayıt işlemi başarılı";
        public static string CarDeleted = "Araç silme işlemi başarılı";
        public static string CarUpdated = "Araç güncelleme işlemi başarılı";
        public static string CarsListed = "Araçlar listelendi";

        //ColorMessages
        public static string ColorAdded = "Renk kayıt işlemi başarılı";
        public static string ColorDeleted = "Renk silme işlemi başarılı";
        public static string ColorUpdated = "Renk güncelleme işlemi başarılı";
        public static string ColorAddError = "Eklemek istediğiniz renk zaten mevcut.Farklı bir renk giriniz.";

        //CarImage Messages
        public static string CarImageAdded = "Araç resimi eklendi";
        public static string CarImageUpdated = "Araç resimi güncellendi";
        public static string CarImageDeleted = "Araç resimi silindi";
        public static string CarImagesListed = "Araç resimleri listelendi";
        public static string CarImagesLimitExceeded = "En fazla 5 resim yüklenebilir";

        //BrandMessages
        public static string BrandAdded = "Marka kayıt işlemi başarılı";
        public static string BrandDeleted = "Marka silme işlemi başarılı";
        public static string BrandUpdated = "Marka güncelleme işlemi başarılı";
        public static string BrandAddError = "Eklemek istediğiniz marka zaten mevcut.Farklı bir marka giriniz.";
        public static string BrandsListed = "Markalar listelendi";

        //CustomerMessages
        public static string CustomerAdded = "Müşteri kayıt işlemi başarılı";
        public static string CustomerDeleted = "Müşteri silme işlemi başarılı";
        public static string CustomerUpdated = "Müşteri güncelleme işlemi başarılı";

        //UserMessages
        public static string UserAdded = "Kullanıcı kayıt işlemi başarılı";
        public static string UserDeleted = "Kulanıcı silme işlemi başarılı";
        public static string UserUpdated = "Kullanıcı güncelleme işlemi başarılı";

        //Authorization
        public static string AuthorizationDenied = "Yetkiniz yok.";

        //AuthManager 
        public static string UserRegistered = "Kayıt Olundu";
        public static string UserNotFound = "Kullanıcı Bulunamadı";
        public static string PasswordError = "Şifre Hatalı";
        public static string SuccessfulLogin = "Giriş Başarılı";
        public static string UserAlreadyExists = "Kullanıcı zaten mevcut";
        public static string AccessTokenCreated = "Token Oluşturuldu";

        //BankManager
        public static string BankSuccess = "Banka bilgileri başarıyla eklendi";


    }
}
