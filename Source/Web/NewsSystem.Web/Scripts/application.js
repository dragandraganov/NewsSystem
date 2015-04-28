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

    setInterval(function () {
        getXmlData();
    }, 1000);
})

function getXmlData() {
            $.ajax({
                url: '/News/AddOrUpdate',
                method: 'GET',
                success: function (data) {
                    console.log(data);
                    var exisitingId = $(data).attr('id');
                    var exisitingItem = $('#' + exisitingId + '.news-item');
                    if (exisitingItem.length === 0) {
                        $('.vticker ul').append(data);
                    }
                }
            })
        }