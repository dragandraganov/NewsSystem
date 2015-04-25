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
        visible: 6,
        mousePause: 1,
    });

    $(document).on('click', '.btn-add-news', function () {
        $.ajax({
            url: '/News/AddOrUpdate',
            method: 'GET',
            success: function (data) {
                var exisitingId = $(data).attr('id');
                var exisitingItem = $('#' + exisitingId + '.news-item');
                if (exisitingItem !== undefined) {
                    exisitingItem.remove();
                }
                $('.vticker ul').append(data);
            }
        })
    })
})