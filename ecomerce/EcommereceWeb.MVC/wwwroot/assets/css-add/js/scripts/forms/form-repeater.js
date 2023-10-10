/*=========================================================================================
    File Name: Form-Repeater.js
    Description: form repeater page specific js
    ----------------------------------------------------------------------------------------
    Item Name: Frest HTML Admin Template
    Version: 1.0
    Author: PIXINVENT
    Author URL: http://www.themeforest.net/user/pixinvent
==========================================================================================*/

$(document).ready(function () {
  // form repeater jquery
  $('.file-repeater, .contact-repeater, .repeater-default').repeater({
    show: function () {
      $(this).slideDown();
    },
    hide: function (deleteElement) {
      if (confirm('هل انت متأكد من الحذف ؟!!')) {
        $(this).slideUp(deleteElement);
      }
    }
  });

});
