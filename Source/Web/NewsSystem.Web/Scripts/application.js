$(document).ready(function () {
    $('body').on('focus', ".datetimepicker", function () {
        $(this).datetimepicker({
            format: 'MM/DD/YYYY'
        })
    });

    $('.vticker').easyTicker({
        direction: 'down',
        easing: 'easeInOutBack',
        speed: 'slow',
        interval: 2000,
        height: 'auto',
        visible:6,
        mousePause: 1,
    });
})