# HepsiBuradaWebTest
 Testing
Bu projede Hepsiburada tarafından verilen task oluşturulmuş olup senaryoların Page Object Model kullanılarak koşulması sağlanmıştır.

Proje Özellikleri
Webdriver ları projede eklenmiştir. Driver versiyon uyuşmazlığı durumunda aynı isim ile src/test/resources/ altında güncellenmelidir.



Annotasyonlar ve assertionlar için JUnit kütüphanesi kullanılmıştır.

Proje C#dilinde Selenium frameworku ile geliştirilmiştir . Mimaride POM kullanılmıştır.

 1) Kullanıcı girişi yapılarak sepete ürün eklenmesi
• Kullanıcı Hepsiburada.com sitesini ziyaret eder
• Kullanıcı giriş işlemi yapılır
• Kullanıcı, burada satın almak istediği ürün için arama yapacaktır.
• Kullanıcı, Arama sonucunda ekrana gelen ürün listesinden (veya tek bir sonuç da dönmüş
olabilir) ürün seçer.
• Seçilen ürün için 2 tane farklı satıcıdan ürün seçilip sepete eklenir

 2) Kullanıcı girişi yapılmadan belirtilen ürünü sepete ekleme
• Kullanıcı Hepsiburada.com sitesini ziyaret eder
• Kullanıcı, Kitap, Müzik, Film, Hobi kategorisi altında yer alan Uzaktan Kumandalı Arabalar
sekmesinden bir drone yedek parçalarından bir ürün seçip sepete ekler. (Arama
yapılmaksızın belirtilen kategori altından bu ürünün sepete eklenmesi beklenmektedir.) 
