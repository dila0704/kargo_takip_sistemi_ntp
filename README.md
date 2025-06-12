  Kargo Takip Sistemi
 Bu proje, Windows Forms ile geliştirilen bir kargo takip uygulamasıdır. Kullanıcılar yeni gönderiler oluşturabilir, gönderi durumlarını güncelleyebilir ve gönderileri takip edebilir.

 - Temel Yapı
 * Gonderi sınıfı, tüm gönderilerin ortak özelliklerini tutar.

 *Yurtici ve Yurtdisi sınıfları, Gonderi sınıfından kalıtım alır.

 *Durum enum yapısı ile gönderilerin durumu üç seçenekle tanımlanır:
 Bekliyor, Yolda, TeslimEdildi.

 *ITakipEdilebilir arayüzü, takip numarası ve gönderi durumu gibi ortak davranışları tanımlar ve Gonderi sınıfı tarafından implement edilir.


 
 - Özellikler
 *Gönderi oluşturma (yurtiçi veya yurtdışı)

 *Gönderi durumunu değiştirme (enum üzerinden)

 *Takip numarasıyla sorgulama

 *Dosyaya veri kaydetme ve okuma

 *Modern görünümlü arayüz (DataGridView tabanlı listeleme)



📌 Genel Görünüm:
Uygulama açıldığında kullanıcıyı sade ve işlevsel bir arayüz karşılar. Formun sağ tarafında, sisteme eklenmiş olan gönderiler tablo (DataGridView) şeklinde listelenir. Sol tarafta ise yeni gönderi ekleme, gönderi tipi seçimi ve takip işlemleri için giriş alanları yer alır.



<img width="805" alt="Ekran Resmi 2025-06-12 11 49 40" src="https://github.com/user-attachments/assets/6fcb8099-4730-441c-a787-90448cee728f" />




Gönderi Durumunu Seçme:

<img width="780" alt="Ekran Resmi 2025-06-12 11 49 58" src="https://github.com/user-attachments/assets/4d377045-ec58-4366-b5b9-6cea3893edd8" />



Gönderi Tipini Seçme:

<img width="780" alt="Ekran Resmi 2025-06-12 11 50 06" src="https://github.com/user-attachments/assets/c5ed70a6-7f35-48f1-8e5f-74b32df0b177" />



Gönderi Sorgulama:

<img width="780" alt="Ekran Resmi 2025-06-12 11 50 24" src="https://github.com/user-attachments/assets/dbeb9a3a-bc8f-40b3-9379-dc59de418683" />


