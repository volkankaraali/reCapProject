# reCapProject
Engin Demiroğ'un (kodlama.io) Yazılım Geliştirici Yetiştirme Kampı dahilinde verdiği eğitimin 7.gün için verdiği ödevin kaynak kodlarını içermektedir. That repo include homework's source code given by Engin Demiroğ(kodlama.io)

#Odev 7

Entities, DataAccess, Business ve Console katmanları oluşturuldu.
InMemory'de GetById, GetAll, Add, Update, Delete fonksiyonları yazıldı.

#Odev 8

mssql ile datebase oluşturulup EntityFramework ile altyapısı yazıldı.

#Odev 9

projeye Core katmanı dahil edildi.
dto(data transformation object) ile CarDetailsDto oluşturularak Color ve Brand tablolarındaki Name'lere ulaşılarak yeni bir gösterim ekranı yazıldı.

#Odev 10/1

projeye Core/Utilities/Results eklendi ve Business katmanında refaktör yapıldı.

#Odev 10/4

projeye Users, Customers ve Rentals tablosu eklendi. bu tablolar için CRUD operasyonları eklendi. kiralama (Rental/Add) işlemi yapabilmesi için koşul olarak,oluşturulan rental nesnesinin customer idsi eğer rentals tablosunda customer id eşleşiyorsa (yani daha önce o müşteri kiralama yapmış) kiralama yapamaması koyuldu. ödeve ek olarak RentalDetailsDto eklendi.

#Odev 11/1

projeye WebAPI eklendi. Business'deki tüm servisler için api yazıldı.
