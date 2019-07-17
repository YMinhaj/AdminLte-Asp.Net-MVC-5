$(document).ready(function () {
    debugger;
    $("loginForm").submit(function () {
        debugger;
        var btn = $(this).find("input[type=submit]:focus");
        var btnName = btn.attr('name');
        var input = $("<input>")
              .attr("name", "btnName").val(btnName);
        $(this).append(input);
        return true;
    });
   
    $("#submit").click(function (e) {
        alert($("#username").val());
        var data = $("#loginForm").serialize();
        //var returnmsg  = UpdateData("/Examples/LoginAuth", data);
        //alert(returnmsg);
        alert(data);
        $.ajax({
            url: '/Examples/LoginAuth',
            data: data,
            type: 'POST',
            dataType: 'json'
        });
    });

});