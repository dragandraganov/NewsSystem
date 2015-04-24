$(document).ready(function () {
    $('body').on('focus', ".datetimepicker", function () {
        $(this).datetimepicker({
            format: 'MM/DD/YYYY'
        })
    });
})