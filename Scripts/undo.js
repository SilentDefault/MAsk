var path = window.location.pathname;

moment.locale('es');
$(document).ready(function () {
    //para que funcione los modal
    $('[data-toggle=modal]').click(function (event) {
        $($(this).attr('data-target')).toggleClass('hide');
    });
    $('span').click(function () {
        alert('asas');
    });
    //para que funcione los tabs
    $('[data-toggle=tab]').click(function (event) {
        let tab = $(this);
        let tabs = $('.tab');
        for (var y = 0; y < tabs.length; y++) {
            tabs[y].className = 'tab';
        }
        tab[0].className = 'tab active';

        let pane = $(tab.attr('data-target'));
        let paneParent = pane.parent()[0];
        for (var i = paneParent.children.length - 1; i >= 0; i--) {
            paneParent.children[i].className = 'tab-pane';
        }
        pane[0].className = 'tab-pane active';
    });
    $(function () {
        $(window).scroll(sticky_relocate);
    });
    function sticky_relocate() {
        var window_top = $(window).scrollTop();
        var div_top = $('#sticky-anchor').offset().top;
        if (window_top > div_top) {
            $('#sticky').addClass('stick');
            $('#sticky-anchor').height($('#sticky').outerHeight());
        } else {
            $('#sticky').removeClass('stick');
            $('#sticky-anchor').height(0);
        }
    }
    $('[data-target="#home"]').on('click', function () {
        $('html,body').animate({ scrollTop: $("#header").offset().top }, 'slow');
    });
});
function reload(url) {
    history.pushState(null, null, url);
    path = '/' + url;
    boarlinks.cargarLinks();
    post.Posts();
}