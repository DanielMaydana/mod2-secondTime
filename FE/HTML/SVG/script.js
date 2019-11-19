(
    function () {

        var XMLHttpRequest = require("xmlhttprequest").XMLHttpRequest;

        var xhr = new XMLHttpRequest();

        xhr.open('GET', 'http://localhost/api/user', false)

        xhr.onload = function () {

            console.log(this.response)

            // var data = JSON.parse(this.response)

            // if (xhr.status >= 200 && xhr.status < 400) {

            //     console.log(data)

            // } else {

            //     console.log("Error")
            // }
        }

        xhr.send()
    }
)();