  Kargo Takip Sistemi
  
Bu proje, Windows Forms ile geliştirilen bir kargo takip uygulamasıdır. Kullanıcılar yeni gönderiler oluşturabilir, gönderi durumlarını güncelleyebilir ve gönderileri takip edebilir.


🔧Temel Yapı

  Gonderi sınıfı, tüm gönderilerin ortak özelliklerini tutar.

 Yurtici ve Yurtdisi sınıfları, Gonderi sınıfından kalıtım alır.

 Durum enum yapısı ile gönderilerin durumu üç seçenekle tanımlanır:
 Bekliyor, Yolda, TeslimEdildi.

 ITakipEdilebilir arayüzü, takip numarası ve gönderi durumu gibi ortak davranışları tanımlar ve Gonderi sınıfı tarafından implement edilir.




 
📍Özellikler

 Gönderi oluşturma (yurtiçi veya yurtdışı)

 Gönderi durumunu değiştirme (enum üzerinden)

 Takip numarasıyla sorgulama

 Dosyaya veri kaydetme ve okuma (veriler.txt)

 Modern görünümlü arayüz (DataGridView tabanlı listeleme)



📌 Genel Görünüm:

Uygulama açıldığında kullanıcıyı sade ve işlevsel bir arayüz karşılar. Formun sağ tarafında, sisteme eklenmiş olan gönderiler tablo (DataGridView) şeklinde listelenir. Sol tarafta ise yeni gönderi ekleme, gönderi tipi seçimi ve takip işlemleri için giriş alanları yer alır.





<img width="756" alt="Ekran Resmi 2025-06-12 13 12 23" src="https://github.com/user-attachments/assets/4eaedb29-0159-4ba7-a649-6cdeebbf3066" />






Gönderi Durumunu Seçme:



<img width="756" alt="Ekran Resmi 2025-06-12 13 12 37" src="https://github.com/user-attachments/assets/2d049b33-6596-4d49-9930-2c7d13d5c283" />




Gönderi Tipini Seçme:



<img width="756" alt="Ekran Resmi 2025-06-12 13 13 04" src="https://github.com/user-attachments/assets/bb42342d-67f3-4496-be02-11b88f957ee5" />



Gönderi Sorgulama:



<img width="782" alt="Ekran Resmi 2025-06-12 13 13 32" src="https://github.com/user-attachments/assets/72fa84a3-73c5-4862-a19a-e96647a5b360" />




