function EditFile(files, folderName) {
   // var url = "../UploadJobImage";
    var url = "../../BaseMVC/UploadJobImage";
    formData = new FormData();
    formData.append("Image", files);
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
            $("#Image_Image").attr("src", "");
        },
        success: function (repo) {

            var imgUrl = " ../../Upload/" + folderName + "/" + repo.image;
            document.getElementById("eImage").style.backgroundImage = "url(" + imgUrl + ")";
            $("#logoData").val(repo.image);
            if (document.getElementById('errorUplod1') != null) {
                document.getElementById("errorUplod1").innerHTML = " ";
            }
         
            document.querySelector('.errorUplod').innerHTML = "";


        },

        error: function (ex) {
            if (document.getElementById('errorUplod1') != null) {
                document.getElementById("errorUplod1").innerHTML = ex.responseText;
            }
       
            document.querySelector('.errorUplod').innerHTML = ex.responseText;
            console.log(ex.responseText);

        }
    });

}



function deleteFile(picdata, folderName, files) {
 
    var data = {
        "image": picdata,
        "folderName": folderName,
        "ext":"jpg",
    };


    var url = "../../BaseMVC/DeleteImage";
  //  var url = "../DeleteImage";
    jQuery.ajax({
        type: 'GET',
        url: url,
        data: data,

        success: function (repo) {
            if (repo.result == true) {
                $("#logoData").val("");
                var imgUrl = " ../../Upload/" + folderName + "/" + " ";
                document.getElementById("eImage").style.backgroundImage = "url(" + imgUrl + ")";

                EditFile(files[0], folderName);
            } else { 
            EditFile(files[0], folderName);}
          
        },

        error: function (ex) {

            console.log(ex.responseText);

        },

    });
   
  
}//
///////////////////////////////////////////////////////////////// pdf file ///////////////////////////
function EditPdfFile(files, folderName) {

    if (files.length == 0) {
        console.log("image is 0");
        return;
    }


    var url = "../../BaseMvc/UploadPdfFile";
    formData = new FormData();
    formData.append("Image", files);
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
            console.log("ddddddddddddddddddddddddddddddddddddddddd");



        },



        error: function (ex) {
            console.log("eeeeeeeeeeeeeeeeeeeeeeeee");
            document.getElementById('errorImg1').innerHTML = "file must be pdf";

        }
    });


}

function deletePdfFile(picdata, folderName, files) {

    var data = {
        "image": picdata,
        "folderName": folderName,
        "ext":"pdf",
    };


    var url = "../../BaseMvc/DeleteImage";
    //  var url = "../DeleteImage";
    jQuery.ajax({
        type: 'GET',
        url: url,
        data: data,

        success: function (repo) {
            if (repo.result == true) {
                $("#logoData1").val("");
                var imgUrl = " ../../Upload/" + folderName + "/" + " ";
                document.getElementById("eImage1").style.backgroundImage = "url(" + imgUrl + ")";

                EditPdfFile(files[0], folderName);
            } EditPdfFile(files[0], folderName);

        },

        error: function (ex) {
            console.log(ex.responseText);

        },

    });


}

//////////////////////////////////////// end Edit Pdf File ///////////////////////////////////////////////

function deleteSponcerLogoFile(picdata, folderName, files) {
 
    var data = {
        "image": picdata,
        "folderName": folderName,
        "ext":"jpg"
    };


    var url = "../../BaseMvc/DeleteImage";
  //  var url = "../DeleteImage";
    jQuery.ajax({
        type: 'GET',
        url: url,
        data: data,

        success: function (repo) {
            if (repo.result == true) {
                $("#logoData1").val("");
                var imgUrl = " ../../Upload/" + folderName + "/" + " ";
                document.getElementById("eImage1").style.backgroundImage = "url(" + imgUrl + ")";

                EditSponcerLogoFile(files[0], folderName);
            }
            EditSponcerLogoFile(files[0], folderName);
        },

        error: function (ex) {
            console.log(ex.responseText);

        },

    });
   
  
}
function deleteOtherImageFile(picdata, folderName, files) {
 
    var data = {
        "image": picdata,
        "folderName": folderName,
        "ext":"jpg"
    };


    var url = "../../BaseMvc/DeleteImage";
  //  var url = "../DeleteImage";
    jQuery.ajax({
        type: 'GET',
        url: url,
        data: data,

        success: function (repo) {
            if (repo.result == true) {
                $("#EOtherImage").val("");
                var imgUrl = " ../../Upload/" + folderName + "/" + " ";
                document.getElementById("EImage_OtherImage").style.backgroundImage = "url(" + imgUrl + ")";

                EditOtherFile(files[0], folderName);
            }
            EditOtherFile(files[0], folderName);
      
            document.querySelector('.errorUplod').innerHTML = " ";
        },

        error: function (ex) {
        
            document.querySelector('.errorUplod').innerHTML = ex.responseText;
            console.log(ex.responseText);
            console.log("565555555");

        },

    });
   
  
}










