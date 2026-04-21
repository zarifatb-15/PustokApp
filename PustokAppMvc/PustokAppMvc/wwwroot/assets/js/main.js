$(document).ready(function () {
    $(".bookModalIcon").click(function (e) {
        // url:/books/bookmodal/id
        e.preventDefault();
        let url = $(this).attr("href");
        fetch(url)
            .then((response) => response.text())
            .then((data) => {
                
                $("#quickModal .modal-dialog").html(data);

                let firstSlider = {
                    "slidesToShow": 1,
                    "arrows": false,
                    "fade": true,
                    "draggable": false,
                    "swipe": false,
                    "asNavFor": ".product-slider-nav"

                };
                let secondSlider = {
                    "infinite": true,
                    "autoplay": true,
                    "autoplaySpeed": 8000,
                    "slidesToShow": 4,
                    "arrows": true,
                    "prevArrow": '<button class="slick-prev"><i class="fa fa-chevron-left"></i></button>',
                    "nextArrow": '<button class="slick-next"><i class="fa fa-chevron-right"></i></button>',
                    "asNavFor": ".product-details-slider",
                    "focusOnSelect": true
                }
                $(".product-details-slider", $("#quickModal")).slick(firstSlider);
                $(".product-slider-nav", $("#quickModal")).slick(secondSlider);
                $("#quickModal").modal('show');
            });
    });
});