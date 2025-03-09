# Orta İrtifa Roket Arayüzü - Yedek Aviyonik

Bir roketin aviyonik sisteminden gelen verileri yer bilgisayarında karşılamak için hazırlanmış bir program. 

Karşılayabileceği veriler kısıtlıdır. 


## Karşılanan veriler

- Konum verileri
- Jiroskop sensör verileri
- 2 görev göstergesi
- Tam ekran modu

  
## Ortam Değişkenleri

Programda seçilen COM Port üzerinden gelmesi gereken veri aşağıdadır her bir satırda bu formattan farklı bir veri gelmemelidir.

N21,103M32,024V15,320I40,8401U31,1512RTD

`N21,203` | Jiroskop - X

`M32,024` | Jiroskop - Y

`V15,320` | Jiroskop - Z

`I40,8401` | Enlem
 
`U31,1512` | Boylam

`R` | Görev 1 Sonu

`T` | Görev 2 Sonu

`D` | GPS Sensöründen Hata gelmesi durumu
  
## Ekran Görüntüleri

![Uygulama Ekran Görüntüsü](https://github.com/yasirsharp/Orta-Irtifa-Roket-Arayuzu-Yedek_Aviyonik/blob/master/Orta_Irtifa_Asel10000_YedekAviyonik.png)

  
