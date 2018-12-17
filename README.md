# Teknoizle
Teknoseyir.com videolarını sık kullanılanlara eklemek için bir program.

1. Program için gerekli NuGet paketi:
-        Selenium

2. Program Edge için hazırlanmıştır.
Eğer başka tarayıcılar için derlemek istiyorsanız şu adımları izleyiniz:
Aşağıdaki kodlarda 'Edge' bölümlerini kendi tarayıcınızın adı ile değiştiriniz.
-        using OpenQA.Selenium.Edge;
-        IWebDriver driverts = new EdgeDriver();

Örneğin;
-        using OpenQA.Selenium.Firefox;
-        IWebDriver driverts = new FirefoxDriver();

Kullanımı:
Çalıştırıldığında otomatik olarak http://teknoseyir.com/videolar bağlantısını açmaktadır.
        Programı açtıktan sonra bildirimler ile ilgili uyarıyı geçmek için "Modalı Atla"ya tıklayınız. 
        "Aşağı Kaydır"a basarak istediğiniz kadar aşağı ininiz.
        Alternatif olarak "Otomatik kaydırma" "Açık" iken "Aşağı Kaydır" butonuna her basışta 20 kaydırma yapabilirsiniz.
        Eğer sitede en altta "Daha Fazla Göster" butonu çıkarsa "Daha Fazla Göster" butonuna basarak kaydırmaya devam ediniz.
        İstediğiniz seviyeye geldikten sonra "ListBox'a ekle" butonu ile linkleri ListBox'a ekleyiniz.
        Daha sonra "Dosyaya Kaydet" butonu ile kayıt yerini belirleyip ismini **[isminiz].html** olarak kaydediniz.
        HTML dosyasını kaydettikten sonra tarayıcınızın yer imlerine içe aktar ile ekleyebilirsiniz.
