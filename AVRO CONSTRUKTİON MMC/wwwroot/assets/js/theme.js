(function ($) {
  "use strict";

  var nav_offset_top = $("header").height() + 50;
  /*-------------------------------------------------------------------------------
	  Navbar Fixed
	-------------------------------------------------------------------------------*/

  function navbarFixed() {
    if ($(".header_area").length) {
      $(window).scroll(function () {
        var scroll = $(window).scrollTop();
        if (scroll >= nav_offset_top) {
          $(".header_area").addClass("navbar_fixed");
        } else {
          $(".header_area").removeClass("navbar_fixed");
        }
      });
    }
  }
  navbarFixed();

  /*-------------------------------------------------------------------------------
	  Menu Click js 
	-------------------------------------------------------------------------------*/
  function Menu_js() {
    if ($(".submenu").length) {
      $(".submenu > .dropdown-toggle").click(function () {
        var location = $(this).attr("href");
        window.location.href = location;
        return false;
      });
    }
  }
  Menu_js();

  $("#countries").msDropdown();

  /*----------------------------------------------------*/
  /*  Main Slider js
    /*----------------------------------------------------*/
  function main_slider1() {
    if ($("#main_slider1").length) {
      $("#main_slider1").revolution({
        sliderType: "standard",
        sliderLayout: "auto",
        delay: 4000,
        disableProgressBar: "on",
        navigation: {
          onHoverStop: "off",
          touch: {
            touchenabled: "on",
          },
          arrows: {
            style: "zeus",
            enable: true,
            hide_onmobile: true,
            hide_under: 992,
            hide_onleave: true,
            hide_delay: 200,
            hide_delay_mobile: 1200,
            tmp:
              '<div class="tp-title-wrap">  	<div class="tp-arr-imgholder"></div> </div>',
            left: {
              h_align: "left",
              v_align: "center",
              h_offset: 50,
              v_offset: 0,
            },
            right: {
              h_align: "right",
              v_align: "center",
              h_offset: 50,
              v_offset: 0,
            },
          },
        },
        responsiveLevels: [4096, 1515, 1199, 992, 767, 480],
        gridwidth: [1170, 1170, 970, 750, 700, 480],
        gridheight: [645, 645, 645, 645, 550, 500],
        lazyType: "smart",
        fallbacks: {
          simplifyAll: "off",
          nextSlideOnWindowFocus: "off",
          disableFocusListener: false,
        },
      });
    }
  }
  main_slider1();
  /*----------------------------------------------------*/
  /*  Main Slider js
    /*----------------------------------------------------*/
  function main_slider2() {
    if ($("#main_slider2").length) {
      $("#main_slider2").revolution({
        sliderType: "standard",
        sliderLayout: "auto",
        delay: 4000,
        disableProgressBar: "on",
        navigation: {
          onHoverStop: "off",
          touch: {
            touchenabled: "on",
          },
          arrows: {
            style: "zeus",
            enable: true,
            hide_onmobile: true,
            hide_under: 992,
            hide_onleave: true,
            hide_delay: 200,
            hide_delay_mobile: 1200,
            tmp:
              '<div class="tp-title-wrap">  	<div class="tp-arr-imgholder"></div> </div>',
            left: {
              h_align: "left",
              v_align: "center",
              h_offset: 50,
              v_offset: 0,
            },
            right: {
              h_align: "right",
              v_align: "center",
              h_offset: 50,
              v_offset: 0,
            },
          },
        },
        responsiveLevels: [4096, 1515, 1199, 992, 767, 480],
        gridwidth: [1170, 1170, 970, 750, 700, 480],
        gridheight: [795, 795, 795, 795, 550, 500],
        lazyType: "smart",
        fallbacks: {
          simplifyAll: "off",
          nextSlideOnWindowFocus: "off",
          disableFocusListener: false,
        },
      });
    }
  }
  main_slider2();

  /*----------------------------------------------------*/
  /*  Main Slider js
    /*----------------------------------------------------*/
  function main_slider3() {
    if ($("#main_slider3").length) {
      $("#main_slider3").revolution({
        sliderType: "standard",
        sliderLayout: "auto",
        delay: 4000,
        disableProgressBar: "on",
        navigation: {
          onHoverStop: "off",
          touch: {
            touchenabled: "on",
          },
          arrows: {
            style: "zeus",
            enable: true,
            hide_onmobile: true,
            hide_under: 992,
            hide_onleave: true,
            hide_delay: 200,
            hide_delay_mobile: 1200,
            tmp:
              '<div class="tp-title-wrap">  	<div class="tp-arr-imgholder"></div> </div>',
            left: {
              h_align: "left",
              v_align: "center",
              h_offset: 50,
              v_offset: 0,
            },
            right: {
              h_align: "right",
              v_align: "center",
              h_offset: 50,
              v_offset: 0,
            },
          },
        },
        responsiveLevels: [4096, 1199, 992, 767, 480],
        gridwidth: [1170, 970, 750, 700, 480],
        gridheight: [732, 732, 732, 550, 500],
        lazyType: "smart",
        fallbacks: {
          simplifyAll: "off",
          nextSlideOnWindowFocus: "off",
          disableFocusListener: false,
        },
      });
    }
  }
  main_slider3();

  /*----------------------------------------------------*/
  /*  Main Slider js
    /*----------------------------------------------------*/
  function main_slider5() {
    if ($("#main_slider5").length) {
      $("#main_slider5").revolution({
        sliderType: "standard",
        sliderLayout: "auto",
        delay: 4000,
        disableProgressBar: "on",
        navigation: {
          onHoverStop: "off",
          touch: {
            touchenabled: "on",
          },
          arrows: {
            style: "zeus",
            enable: true,
            hide_onmobile: true,
            hide_under: 992,
            hide_onleave: true,
            hide_delay: 200,
            hide_delay_mobile: 1200,
            tmp:
              '<div class="tp-title-wrap">  	<div class="tp-arr-imgholder"></div> </div>',
            left: {
              h_align: "left",
              v_align: "center",
              h_offset: 50,
              v_offset: 0,
            },
            right: {
              h_align: "right",
              v_align: "center",
              h_offset: 50,
              v_offset: 0,
            },
          },
        },
        responsiveLevels: [4096, 1199, 992, 767, 480],
        gridwidth: [1170, 970, 750, 700, 480],
        gridheight: [698, 698, 698, 550, 500],
        lazyType: "smart",
        fallbacks: {
          simplifyAll: "off",
          nextSlideOnWindowFocus: "off",
          disableFocusListener: false,
        },
      });
    }
  }
  main_slider5();

  /*----------------------------------------------------*/
  /*  Search Popup js
    /*----------------------------------------------------*/
  function popupAnimation() {
    if ($(".popup-with-zoom-anim").length) {
      $(document).ready(function () {
        $(".popup-with-zoom-anim").magnificPopup({
          type: "inline",

          fixedContentPos: false,
          fixedBgPos: true,

          overflowY: "auto",

          closeBtnInside: true,
          preloader: false,

          midClick: true,
          removalDelay: 300,
          mainClass: "my-mfp-zoom-in",
        });

        $(".popup-with-move-anim").magnificPopup({
          type: "inline",

          fixedContentPos: false,
          fixedBgPos: true,

          overflowY: "auto",

          closeBtnInside: true,
          preloader: false,

          midClick: true,
          removalDelay: 300,
          mainClass: "my-mfp-slide-bottom",
        });
      });
    }
  }
  popupAnimation();

  /*----------------------------------------------------*/
  /*  Testimonials Slider
  /*----------------------------------------------------*/
  function testimonials_slider() {
    if ($(".testi_slider").length) {
      $(".testi_slider").owlCarousel({
        loop: true,
        margin: 30,
        items: 1,
        nav: false,
        autoplay: true,
        smartSpeed: 2000,
        dots: true,
        responsiveClass: true,
      });
    }
  }
  testimonials_slider();

  /*----------------------------------------------------*/
  /*  Clietn Logo Slider
  /*----------------------------------------------------*/
  function client_slider() {
    if ($(".client_logo_slider").length) {
      $(".client_logo_slider").owlCarousel({
        loop: true,
        margin: 30,
        items: 6,
        nav: false,
        autoplay: true,
        smartSpeed: 2000,
        dots: true,
        responsiveClass: true,
        responsive: {
          0: {
            items: 2,
          },
          600: {
            items: 3,
          },
          992: {
            items: 4,
          },
          1200: {
            items: 6,
          },
        },
      });
    }
  }
  client_slider();

  /*----------------------------------------------------*/
  /*  Experience Slider
  /*----------------------------------------------------*/
  function exp_slider() {
    if ($(".exp_slider").length) {
      $(".exp_slider").owlCarousel({
        loop: true,
        margin: 0,
        items: 4,
        nav: false,
        autoplay: true,
        smartSpeed: 2000,
        dots: false,
        navContainerClass: "exp_slider_nav",
        navText: [
          '<i class="fa fa-angle-left" aria-hidden="true"></i>',
          '<i class="fa fa-angle-right" aria-hidden="true"></i>',
        ],
        responsiveClass: true,
        responsive: {
          0: {
            items: 1,
          },
          480: {
            items: 2,
          },
          768: {
            items: 3,
          },
          992: {
            items: 4,
          },
        },
      });
    }
  }
  exp_slider();
  /*----------------------------------------------------*/
  /*  Project Slider
  /*----------------------------------------------------*/
  function projects_slider() {
    if ($(".projects_slider").length) {
      $(".projects_slider").owlCarousel({
        loop: true,
        margin: 30,
        items: 3,
        nav: false,
        autoplay: true,
        smartSpeed: 2000,
        dots: true,
        navContainer: ".our_l_text",
        navText: [
          '<i class="fa fa-angle-left" aria-hidden="true"></i>',
          '<i class="fa fa-angle-right" aria-hidden="true"></i>',
        ],
        responsiveClass: true,
        responsive: {
          0: {
            items: 1,
          },
          480: {
            items: 2,
          },
          768: {
            items: 3,
          },
        },
      });
    }
  }
  projects_slider();

  /*----------------------------------------------------*/
  /*  Feature Projects Slider
  /*----------------------------------------------------*/
  function f_project_slider() {
    if ($(".f_project_slider").length) {
      $(".f_project_slider").owlCarousel({
        loop: true,
        margin: 30,
        items: 4,
        nav: false,
        autoplay: true,
        smartSpeed: 2000,
        dots: false,
        navContainerClass: "f_projects_nav",
        navText: [
          '<i class="fa fa-angle-left" aria-hidden="true"></i>',
          '<i class="fa fa-angle-right" aria-hidden="true"></i>',
        ],
        responsiveClass: true,
        responsive: {
          0: {
            items: 1,
          },
          480: {
            items: 2,
          },
          768: {
            items: 4,
          },
        },
      });
    }
  }
  f_project_slider();

  /*----------------------------------------------------*/
  /*  Home Slick Slider
  /*----------------------------------------------------*/

  if ($(".text_slider").length) {
    $(".text_slider").slick({
      slidesToShow: 1,
      slidesToScroll: 1,
      dots: false,
      fade: false,
      infinite: true,
      autoplay: true,
      autoplaySpeed: 300000,
      fade: true,
      prevArrow: ".left_arrow",
      nextArrow: ".right_arrow",
      asNavFor: ".image_slider",
    });
    $(".image_slider").slick({
      dots: false,
      arrows: false,
      slidesToShow: 1,
      autoplaySpeed: 300000,
      // centerMode: true,
      slidesToScroll: 1,
      focusOnSelect: true,
      asNavFor: ".text_slider",
    });
  }

  /*----------------------------------------------------*/
  /*  Counterup Slider
  /*----------------------------------------------------*/
  function counterup() {
    if ($(".counter").length) {
      $(".counter").counterUp({
        delay: 10,
        time: 1000,
      });
    }
  }
  counterup();

  /*----------------------------------------------------*/
  /*  Gallery One js
  /*----------------------------------------------------*/
  function gallery_isotope() {
    if ($(".our_projects_area").length) {
      // Activate isotope in container
      $(".gallery_inner").imagesLoaded(function () {
        $(".gallery_inner").isotope({
          layoutMode: "masonry",
          percentPosition: true,
          masonry: {
            columnWidth: 1,
          },
        });
      });

      // Add isotope click function
      $(".g_fillter ul li").on("click", function () {
        $(".g_fillter ul li").removeClass("active");
        $(this).addClass("active");

        var selector = $(this).attr("data-filter");
        $(".gallery_inner").isotope({
          filter: selector,
          animationOptions: {
            duration: 450,
            easing: "linear",
            queue: false,
          },
        });
        return false;
      });
    }
  }

  gallery_isotope();

  /*----------------------------------------------------*/
  /*  Simple LightBox js
  /*----------------------------------------------------*/

  function Lightbox() {
    if ($(".light").length) {
      $(".imageGallery1 .light").simpleLightbox();
    }
  }
  Lightbox();

  /*----------------------------------------------------*/
  /*  Nice Selector
  /*----------------------------------------------------*/
  function nice_select() {
    if ($(".nice_select").length) {
      $(".nice_select").niceSelect();
    }
  }
  nice_select();

  /*----------------------------------------------------*/
  /*  Video
  /*----------------------------------------------------*/
  function video_js() {
    if ($(".popup-youtube, .popup-vimeo, .popup-gmaps").length) {
      $(".popup-youtube, .popup-vimeo, .popup-gmaps").magnificPopup({
        disableOn: 700,
        type: "iframe",
        mainClass: "mfp-fade",
        removalDelay: 160,
        preloader: false,
        fixedContentPos: false,
      });
    }
  }
  video_js();

  /*----------------------------------------------------*/
  /*  Background Parallax Slider
  /*----------------------------------------------------*/
  function bg_parallax() {
    if ($(".parallaxie").length) {
      $(".parallaxie").parallaxie();
    }
  }
  bg_parallax();
})(jQuery);
