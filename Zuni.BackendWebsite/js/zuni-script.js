

$(document).ready(function(){

    /* scroll top bar show hide */

    $(window).bind('scroll', function () {
        if ($(window).scrollTop() > 0) {
            $('.admin-top-bar').addClass('nav-fixed');
        } else {
            $('.admin-top-bar').removeClass('nav-fixed');
        }
    });
     
     /*	Main Nav Tab	*/
     
     $("ul.nav-list li").click(function(){
         $('ul.nav-list li').removeClass('active-nav');
         $(this).closest('li').addClass('active-nav');
     });

    /* Nave Toggle */

     $(".nav-toggle").click(function(){
        $(".zuni-contant").toggleClass("contant-resize");
        $(".zuni-nav").toggleClass("nav-resize");
        $(".nav-toggle").toggleClass("fa-angle-right");
    });

    $(".menu-btn, .nav-close").click(function(){
        $(".zuni-nav").toggle();
    });

    $(window).resize(function() {      
        var w = $(window).width();
		if (w > 767 && $(".zuni-nav").is(':hidden')) {
			$(".zuni-nav").removeAttr('style');
		}	
    });
    
    /* */

    $('.head .head-btn').click(function(){
        $(this).parent().next('.body').slideToggle('250');
        $(this).parent().next().next('.foot').slideToggle('250');
	});

});	