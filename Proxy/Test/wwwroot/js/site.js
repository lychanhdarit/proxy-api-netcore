 
const ACCESS_TOKEN = "Bearer XXXXXXXXXXX";
const proxy = "http://cloud.bestsales.vn/proxy/";


function getData() {
    let endpoint = "https://abc.com/63155dddc253b3aa3770a8a0/rest/seltec/house/getroomlist/0";
    let URL = proxy + endpoint;
    $.ajax({
        url: URL,
        type: 'GET',
        dataType: 'json',
        headers: {
            'Authorization': `${ACCESS_TOKEN}`
        },
        contentType: 'application/json; charset=utf-8',
        success: function (response) {
            console.log(response);
        },
        error: function (error) { }
    });
}
//---

getData();