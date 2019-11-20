// const axios = require('axios')

// apiGH = "https://api.github.com/users/DanielMaydana";
// apiDCEO = "https://dog.ceo/api/breeds/list/all";
// apiTest = "http://10.28.111.49:80/api/user";

// var getResponse = async (index = 0) => {

//     try {
//         const response = await axios({
//             url: apiTest,
//             method: 'GET'
//         })

//         console.log(response.data);
//     }
//     catch (e) {
//         console.log(e);
//     }
// }

// getResponse();

(function () {

    const mockResponse = {

        word: "jealous",

        text: [
            "Jealous, jealous again",
            "Thought it time that I let you in",
            "Jealous, jealous again",
            "Got no time to let you in"
        ],

        results: [
            {
                row: 1,
                col: 1
            },
            {
                row: 1,
                col: 10
            },
            {
                row: 3,
                col: 1
            },
            {
                row: 3,
                col: 10
            },
        ]
    }

    const openingTag = "<div class=\"highlight\">";
    const closingTag = "<\\div>";
    const tagLength = openingTag.length + closingTag.length;

    console.log(matchesPerRow, "matchesPerRow");

    map()

    const modifiedText = mockResponse.text.map((line, row) => {

        let col = 0;
        
        addTagsToLine(line, )
    });

    document.querySelector(".textArea").innerHTML = modifiedText;


})();