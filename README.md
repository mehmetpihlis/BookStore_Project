<h1>Setup İşlemleri</h1>
<p>
Proje dosyasının içindeki "Pihlis_BookStore\Debug\Pihlis_BookStore.msi" dosyası ile kurulum yapılır. 
</p>  

<br>

<h1>Database Aktarma İşlemleri</h1>
<p>
  Setup'ın yapıldığı bilgisayarın Hizmetler kısmından SQL ile ilgili bütün hizmetleri durdurun. Daha sonra proje klasöründeki "Database" klasörü içindeki .mdf ve .ldf
  uzantılı iki dosyayı kendi mevcut bilgisayarın <sup>C:\ProgramFiles\MicrosoftSQLServer\MSSQL16.MSSQLSERVER\MSSQL\DATA</sup> dizinine atın veya kopyalayın (belirtilen dizin
  deki bazı isimler farklı olabilir.). Ardından SQL hizmetlerini açın ve veri tabanı yönetim sisteminizden aşağıdaki görselde de görülen "Attach" işlemini gerçekleştirin.
  Attach kısmına tıkladıktan sonra açılan form ekranında "add" kısmına tıklayıp projenin veri tabanını seçip ekleyin ardından okey basıp refresh yapın. Eğer Databaseler
  arasında görünüyorsa işlem tamamdır. <br>
  <img src="https://www.emreozanmemis.com/wp-content/uploads/2019/04/040919_1644_MSSQLDataba8.png" width="800" height="500">
</p>  

<br>

<h1>Database Bağlantısını Gerçekleştirme</h1>
<p>
  Projenin içindeki <sup>adress.txt</sup> dosyasına veri tabanı bağlantı adresinin yazılması gereklidir. Sıfırdan yapma aşamaları şu şekildedir:<br><br>
  
  1)Microsoft SQL Server Management Studio'dan (Çalıştırılacak bilgisayarda MSSQL olması gereklidir.) aşağıdaki birinci görseldeki işaretli yerde görünen priz butonuna 
  yani "Connect Object Explorer" kısmına tıklanmalıdır. Ekranda aşağıdaki ikinci görseldeki gibi bir form ekranı açılacaktır. Açılan ekrandaki "Server Name kopyalanmalıdır.<br>
  <img src="https://learn.microsoft.com/en-us/sql/ssms/media/connect-to-server/connect-db-engine.png?view=sql-server-ver16" width="400" height="400">
  <img src="https://i.stack.imgur.com/OzjXp.png" width="400" height="400">
  
  <br>
  
  2)Daha sonra Visual Studio açılmalı ve "Proje" kısmından "Yeni veri kaynağı ekle..."ye tıklanmalıdır. Tıklandıktan sonra ekrana aşağıdaki gibir bir form ekranı
  çıkacaktır. Mevcut formda aynı görseldeki gibi "database'i işaretleyip "ileri"ye tıklayın. Daha sonra "Veri Kümesi"ni seçin ve yine ilerleyin ve "Yeni Bağlantı"
  kısmına tıklayın. ekrana aşağıdaki ikinci resimdeki gibi bir form ekranı gelecektir. Çıkan ekrandaki yere kopyaladığınız server name'i yapıştırın ve alttaki combobox
  tan veri tabanını seçin ve tamama tıklayıp o pencereyi kapatın. Kalan form ekranında "uygulamada kaydedilecek bağlantı dizesini gösterin" checkbox'ına basın ve 
  görünen dizeyi kopyalayın ve <sup>adress.txt</sup>'ye yapıştırın. <br>
  <img src="https://docs.actian.com/zen/v15/adonet/images/chap6_DataSourceConnecWiz.png" width="400" height="400">
  <img src="https://learn.microsoft.com/tr-tr/visualstudio/data-tools/media/add-new-connection-dialog.png?view=vs-2022" width="400" height="400">
</p>  

<br>

<h1>Ufak Bir Sınıf Ayarı...</h1>
<p>
  Projeyi Visual Studio'da çalıması ve içindeki Baglanti.cs sınıf dosyasındaki <sup>adress.txt</sup> dosyasını okuma işlemini, proje kendi bilgisayarınızda hangi
  dizindeyse ona göre uyarlanması, değiştirilmesi gereklidir.
</p>  

<br>


  
