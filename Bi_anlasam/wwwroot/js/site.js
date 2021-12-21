

    //$("#ilce").attr("disabled", "true");

    ////il select değişikliğe uğrarsa işlemler yapılacak.
    //    $("#sehir").change(function()
    //{
    //    var il = $(this).val();

    //    if(il > 0) {
    //    // il id sıfırdan büyükse, ilce select seçilebilir hale gelecek ve ilçe içindeki seçenekler silinecek.
    //    $("#ilce").removeAttr("disabled");
    //   $("#ilce option").remove();

    //// bu işlemlerden sonra ajax ile ilçe seçimi yapacağız. hatta şöyle yapalım. il id sıfırdan büyük olduğunda ajax çalışsın.
    //// adresleme.php sayfamızı yapalım.
    ///*
    //    adresleme.php sayfasına il idsini post metoduyla gönderiyoruz. Json dökümü alıyoruz.
    //    işlem doğru olursa #ilce select list içerisine gelen ilçeleri yazdıracağız.
    // */
    //url = "/Home/IlceGetir";
    //$.ajax({
    //    type    : "POST",
    //url     : url,
    //dataType: "json",
    //data    : {
    //    il : il
    //            },
    //success : function (response) {
    //                var ilceler = response;

    //for(var IlceAd in Ilce) {
    //    $(Ilce[IlceAd]).each(function (index, deger) {
    //        $("#ilce").append('<option value=' + deger.IlceId + '">' + deger.IlceAd + '</option>');
    //    });
    //                }
    //            },

    //error: function (response) {
    //    console.log("Hata: Adresleme ajax.");
    //console.log(response);
    //            }
    //        });

    //    } else if(il < 1) {
    //    // il id 1 den küçükse yani boşsa ilçe tekrar seçilemez hale gelecek, ilçe içindeki seçenekler tekrar temizlenecek, sadece ilçe seçiniz seçeneği gelecek.
    //    $("#ilce").attr("disabled", "true");
    //$("#ilce option").remove();
    //$("#ilce").append('<option value="">İlçe Seçiniz</option>');
    //    }


    //});

