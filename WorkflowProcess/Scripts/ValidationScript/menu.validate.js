﻿
$('#MenuName').blur(function () {
    if ($("#MenuName").val() !== "") {
        var url = "/MenuMasters/CheckMenuName";
        $.getJSON(url, { menuName: $("#MenuName").val() }, function (data) {
            if (data)
            {
                alert('MenuName already Exists');
                $("#MenuName").val('');
            }
        });
    }
});