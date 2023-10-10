
function uplodfile(files, folderName) {


    if (files.length == 0) {
        console.log("image is 0");
        return;
    }

    var url = "../../BaseMVC/UploadJobImage";
    formData = new FormData();
    formData.append("Image", files[0]);
    formData.append("folderName", folderName);
   
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

            
            var imgUrl = " ../../Upload/" + folderName + "/" + repo.image;
            document.getElementById("Image_Image").style.backgroundImage = "url(" + imgUrl + ")";
            $("#logoData").val(repo.image);
            if (document.getElementById('errorUplod1') != null) {
                document.getElementById("errorUplod1").innerHTML = "";
            }
            document.querySelector('.errorUplod').innerHTML = "";
         

        },



        error: function (ex) {
            if (document.getElementById('errorUplod1') != null) {
                document.getElementById("errorUplod1").innerHTML = ex.responseText;
            }
         //   document.getElementById("errorUplod1").innerHTML = ex.responseText;
            document.querySelector('.errorUplod').innerHTML = ex.responseText;
           
          

        }
    });


}


function uplodfile_OtherImage(files, folderName) {


    if (files.length == 0) {
        console.log("image is 0");
        return;
    }

    var url = "../../BaseMvc/UploadJobImage";
    formData = new FormData();
    formData.append("Image", files[0]);
    formData.append("folderName", folderName);
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

            var imgUrl = " ../../Upload/" + folderName + "/" + repo.image;
            document.getElementById("Image_OtherImage").style.backgroundImage = "url(" + imgUrl + ")";
            $("#OtherImage").val(repo.image);
            if (document.getElementById('errorUplod3') != null) {
                document.getElementById("errorUplod3").innerHTML = "";
            }
            document.querySelector(".errorUplod").innerHTML = "";
      

        },



        error: function (ex) {
            if (document.getElementById('errorUplod3') != null) {
                document.getElementById("errorUplod3").innerHTML = ex.responseText;
            }
          /*  document.getElementsByClassName(".errorUplod").innerHTML = ex.responseText;*/
            document.querySelector(".errorUplod").innerHTML = ex.responseText;
         
            console.log(ex.responseText);

        }
    });


}



function uploadPdfFile(files, folderName) {

    if (files.length == 0) {
        console.log("image is 0");
        return;
    }


    var url = "../../BaseMvc/UploadPdfFile";
    formData = new FormData();
    formData.append("Image", files[0]);
    formData.append("folderName", folderName);
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


            var imgUrl = " ../../Upload/" + folderName + "/" + repo.image;
            document.getElementById("Image_Image1").style.backgroundImage = "url(" + imgUrl + ")";
            $("#logoData1").val(repo.image);
            document.getElementById("errorImg1").innerHTML = "";
          



        },



        error: function (ex) {
            console.log("eeeeeeeeeeeeeeeeeeeeeeeee");
            document.getElementById("errorImg1").innerHTML = ex.responseText;
    

        }
    });


}


function uplodSponsorLogo(files, folderName) {


    if (files.length == 0) {
        console.log("image is 0");
        return;
    }
 

    var url = "../../BaseMvc/UploadJobImage";
    formData = new FormData();
    formData.append("Image", files[0]);
    formData.append("folderName", folderName);
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
         
         
                var imgUrl = " ../../Upload/" + folderName + "/" + repo.image;
                document.getElementById("Image_Image1").style.backgroundImage = "url(" + imgUrl + ")";
            $("#logoData1").val(repo.image);
            if (document.getElementById('errorUplod2') != null) {
                document.getElementById("errorUplod2").innerHTML = "";
            }
            document.querySelector('.errorUplod').innerHTML = "";
      
              
           

        },



        error: function (ex) {
            if (document.getElementById('errorUplod2') != null) {
                document.getElementById("errorUplod2").innerHTML = ex.responseText;
            }
            document.querySelector('.errorUplod').innerHTML = ex.responseText;

            console.log("11111111111111111111111111111111");
       /*     document.getElementById('errorImg').innerHTML = "file must be pdf";*/
           
                
        }
    });


}       
    
        


    $("#DeletePic").on("click", function () {


 

        if (logoData == "") {
            console.log("logoData is null ");
        } else {

            var logoData = $("#logoData").val();
            var data = { "image": logoData };
            var url = "./DeleteImage";
            jQuery.ajax({
                type: 'get',
                url: url,
                data: data,
                cache: false,

                success: function (repo) {
                    if (repo.result == true) {
                        $("#logoData").val("");
                        var imgUrl = " ../../Upload/" + " ";
                        document.getElementById("Image_Image").style.backgroundImage = "url(" + imgUrl + ")";
                        console.log("image delted  " + repo.result);
                        document.getElementById('errorUplod2').innerHTML = "";
                   //     return true;
                    }



                },

                error: function (ex) {
                    console.log(ex.responseText);

                }, 

            });

        }
    });
