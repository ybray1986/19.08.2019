var app = app || {};
function GetTop5Users(userId) {
    $.ajax({
        type: "GET",
        datatype: "json",
        url: "/Users/GetTop5orders/",
        data: {userId: userId},
        success:
            function (data) {
                console.log("Work with Data");
            },
        error: function(result){
            app.alertDialog('Error', 'Error while getting information')
        }
    })
}