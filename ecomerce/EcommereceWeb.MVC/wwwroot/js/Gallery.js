
function GalleryUplodFile(files, folderName) {
    formData = new FormData();
    


    if (files.length == 0) {
        console.log("image is 0");
        return;
    }
    let x = "";
    let output = [];
    var url = "../../BaseMVC/UploadFileToGallery";
;
    for (var i = 0; i < files.length; i++) {
      
        console.log("sssssssssssss    " + files[i].name);
        formData.append("Image", files[i]);
    }

        formData.append("folderName", folderName)
    jQuery.ajax({
        type: 'POST',
        url: url,
        data: formData,
        cache: false,
        contentType: false,
        processData: false,
        beforeSend: function (xhr) {

            xhr.setRequestHeader("XSRF-TOKEN",
                $('input:hidden[name="__RequestVerificationToken"]').val());
            $("#Image_Percent").width('0%');
            $("#Image_Percent").html('يتم الرفع');
            $("#Image_Image").attr("src", "");
        },
        success: function (repo) {
            let i = 0;
            repo.map(img => {
                var imgUrl = " ../../Upload/" + folderName + "/" + img.image;
                document.getElementById("Image_Image").style.backgroundImage = "url(" + imgUrl + ")";

                //   output.append("#galaryImage[]", repo.image);
                output.push(img.image);
                i++;
                
                $('[name="Image1[]"]').val(output);
                console.log("wwwwwwwwwwwwwww    " + i);
            /*    x += repo.image;*/
                $("#galaryImage").val(img.image);
                $('#preview').append('<div class="col-6 "><img src="' + imgUrl + '"  class="galary" ></div>');
                document.querySelector('.errorUplod').innerHTML = "";
            });
            
            
        },
    


        error: function (ex) {

            document.querySelector('.errorUplod').innerHTML = ex.responseText;
            console.log(ex.responseText);

        }
    });


}
