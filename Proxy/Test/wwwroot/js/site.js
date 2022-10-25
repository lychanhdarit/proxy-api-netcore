const BASIC_TOKEN = "Basic 7CcWEwMi5saWVtMUBzZWx0ZWMuaW86U2VsdGVj";
const ACCESS_TOKEN = "Bearer eyJ0eXAiOiJKV1QiLCJhbGciOiJIUzI1NiJ9.eyJJc0FkbWluIjp0cnVlLCJBY2NvdW50SUQiOjE3LCJBY2NvdW50Tm8iOiJBMTAwMDAwMDE3IiwiaXNzIjoiU2VsVGVjIiwiSG91c2VJRCI6MSwiQ2xhc3NJRCI6MSwiVHlwZUxpc3RJRCI6MSwiQXV0aFNlc3Npb25JRCI6MTE0MiwiQWNjb3VudFR5cGVJRCI6MSwiVXVpZCI6ImQ4YWMyY2QyLTczMGUtNDg2NC1hMTAwLTdlYzYzMjY4ODJlNCIsIkxhbmd1YWdlIjoiZW4iLCJSZWdpb25JRCI6MSwiZXhwIjoxNjY2ODU5MzIyfQ.ibA2mFVm-u3kp21pQV17cQwXorCn00envzYygJbMpMw";
const proxy = "https://localhost:7082/proxy/";

function getHouse() {
    let endpoint = "https://cloud.seltec.io/aurahomelist";
    let URL = proxy + endpoint;
    $.ajax({
        url: URL,
        type: 'GET',
        headers: {
            'Authorization': `${BASIC_TOKEN}`
        },
        contentType: 'application/json; charset=utf-8',
        success: function (response) {
            console.log(response);
        },
        error: function (error) { }
    });
}

function getData() {
    let endpoint = "http://dev.seltec.io:11080/rest/seltec/house/getroomlist/0";
    let URL = proxy + endpoint;
    $.ajax({
        url: URL,
        type: 'GET',
        dataType: 'json',
        headers: {
            'Authorization': `${BASIC_TOKEN}, ${ACCESS_TOKEN}`
        },
        contentType: 'application/json; charset=utf-8',
        success: function (response) {
            console.log(response);
        },
        error: function (error) { }
    });
}
//---

getHouse();