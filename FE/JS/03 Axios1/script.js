const axios = require('axios')

apiGH = "https://api.github.com/users/DanielMaydana";
apiDCEO = "https://dog.ceo/api/breeds/list/all";
apiTest = "http://10.28.111.49:80/api/user";

var getResponse = async (index = 0) => {

    try {
        const response = await axios({
            url: apiTest,
            method: 'GET'
        })

        console.log(response.data);
    }
    catch (e) {
        console.log(e);
    }
}

getResponse();


// for (var i = 0; i < 10; i++) {

//     printWaiting(i);
// }

// function printWaiting(i) {
//     setTimeout(() => console.log(i), 2000);
// }

// applicationCache.getUser(id)

// const user = await ExtensionScriptApis.getUsers();

// const userId = users.map(user => user.id);

// const completeUsers = await getUsersInfo(userIds);

// function getUserInfo(/* USERS ARRAY userIds */) {
//     // ???
//     // Promise.all NOT await
// }

