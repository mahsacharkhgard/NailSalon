jQuery(document).ready(function($){
	var text = $(".newsletter-col .form-desc").html();
	$(".gallery-section .newsletter-title").after("<p class='form-desc'>"+text+"</p>");
	

    $("a[href^='#']").click(function(e) {
        e.preventDefault();
        
        var position = $($(this).attr("href")).offset().top;

        $("body, html").animate({
            scrollTop: position
        }, 1500 );
    });
	$('#mastmenu .menu-item > a').click(function() {
		$('body').removeClass('site-navigation-active');
		$('.main-navigation.active').removeClass('active');
		$('.menu-toggle.active').removeClass('active');
	});
	$(".services-page .service-box").each(function(){
		var imageurl = $(this).find(".entry-featured img").attr('src');
		$(this).parent().css("background-image", "url("+imageurl+")");
	});
	$('.articles-slider').owlCarousel({
        loop:true,
        responsiveClass:true,
        items: 3,
        responsive:{
            0:{
                items:1
            },
            576:{
                items:2
            },
            1200:{
                items:3
            }
        }
    })
	
    $('.product__slider-main').owlCarousel({
        loop:true,
        responsiveClass:true,
        items:1,
        nav: true
    })
})