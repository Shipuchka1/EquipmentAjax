$(document).ready(function () {
    $("#equipmentTable tr").css("cursor", "pointer")
    $('#equipmentTable tr').click(function (event) {
        event.preventDefault();
        console.log($(this).attr('data-cl'));
        var clickable = $(this).attr('data-cl');
        if (clickable === 'false') {
            var url = $("#equipmentTable").attr('action');
            var data = "id=" + $(this).attr('data-id').toString();
            var thisCl = this;
            $.post(url, data, function (response) {
                $(thisCl).after(response);
                $(thisCl).attr('data-cl', 'true');
            });
        }
        else {
            $(this).attr('data-cl', 'false');
            $('#resTR' + $(this).attr('data-id')).hide(1000);
           $('#resTR' + $(this).attr('data-id')).remove();

        }
       
    });
});




