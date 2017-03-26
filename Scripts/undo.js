$(document).ready(function () {
    //para que funcione los modal
	$('[data-toggle=modal]').click(function(event) {
        $($(this).attr('data-target')).toggleClass('hide');
    });
    //para que funcione los tabs
    $('[data-toggle=tab]').click(function (event) {
        let tab = $(this);
        var xx = $('.nav-tabs').children();
        for (var y = 0; y < xx.length; y++) {
            xx[y].className = 'tab';
        }
        tab[0].className = 'tab active';

        let pane = $(tab.attr('data-target'));
        let paneParent = pane.parent()[0];
        for (var i = paneParent.children.length - 1; i >= 0; i--) {
            paneParent.children[i].className = 'tab-pane';
        }
        pane[0].className = 'tab-pane active';
    });
});