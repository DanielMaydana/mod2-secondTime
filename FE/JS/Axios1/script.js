const axios = require('axios')

apiGH = "https://api.github.com/users";
apiDCEO = "https://dog.ceo/api/breeds/list/all";

var getResponse = async () => {

    try {
        const response = await axios({
            url: apiGH,
            method: 'get'
        })

        console.log(response);
    }
    catch (e) {
        console.log(e);
    }

}

for (var i = 0; i < 50; i++) {
    getResponse();
}