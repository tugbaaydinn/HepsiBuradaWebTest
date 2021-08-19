Feature: LoginTest
	Simple calculator for adding two numbers

Scenario: Login and Search
* 'https://www.hepsiburada.com/' sitesine gidilir
* Kullanıcı girişi yapılır
* Arama çubuğundan 'iphone' ürünü aratılır
* Ürün listesinden ürün seçilir
* Arama çubuğundan 'iphone' ürünü aratılır
* Ürün listesinden 'iphone' ürünü için farklı satıcıdan bir ürün seçilir

Scenario: Search Product
* 'https://www.hepsiburada.com/' sitesine gidilir
* Kullanıcı 'Kitap, Müzik, Film, Hobi' alanından, 'Uzaktan Kumandalı Arabalar' sayfasına gider
* Kategori alanından 'Drone Yedek Parçaları' sekmesine tıklanır
* İlgili kategoriden ürün seçilir

Scenario: Teslimat
* 'https://www.hepsiburada.com/' sitesine gidilir
* Kullanıcı girişi yapılır
* Arama çubuğundan 'iphone' ürünü aratılır
* Ürün listesinden ürün seçilir
* Arama çubuğundan 'iphone' ürünü aratılır
* Ürün listesinden 'iphone' ürünü için farklı satıcıdan bir ürün seçilir
* Sepete gidilir
* Alışverişi tamamla butonuna basılır
* Standart teslimat ve Yarın Teslimat seçeneklerinden yalnız biri seçildiği kontrol edilir

Scenario: Teslimat2
* 'https://www.hepsiburada.com/' sitesine gidilir
* Kullanıcı girişi yapılır
* Arama çubuğundan 'iphone' ürünü aratılır
* Ürün listesinden ürün seçilir
* Arama çubuğundan 'iphone' ürünü aratılır
* Ürün listesinden 'iphone' ürünü için farklı satıcıdan bir ürün seçilir
* Sepete gidilir
* Alışverişi tamamla butonuna basılır
* Yarın Teslimat seçeneğinden yalnız saat seçildiği kontrol edilir

Scenario: Teslimat3
* 'https://www.hepsiburada.com/' sitesine gidilir
* Kullanıcı girişi yapılır
* Arama çubuğundan 'iphone' ürünü aratılır
* Ürün listesinden ürün seçilir
* Arama çubuğundan 'iphone' ürünü aratılır
* Ürün listesinden 'iphone' ürünü için farklı satıcıdan bir ürün seçilir
* Sepete gidilir
* Alışverişi tamamla butonuna basılır
* Yarın Teslimat seçeneği seçilmesi durumunda fiyatının artışı izlenir