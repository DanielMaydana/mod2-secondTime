import highlightMatches from './highlightMatches.js'

(function () {

  const mockData = {

    word: "jealous",

    text: [
      "I am Jealous, jealous again",
      "Thought it time that I let you in",
      "Jealous, jealous again",
      "Got no time to let you in",
      "Jealous"
    ],

    results: [
      {
        Row: 1,
        Col: 6
      },
      {
        Row: 1,
        Col: 15
      },
      {
        Row: 3,
        Col: 1
      },
      {
        Row: 3,
        Col: 10
      },
      {
        Row: 5,
        Col: 1
      }
    ]
  }

  const textArea = document.querySelector(".text-area");

  highlightMatches(textArea, mockData.word, mockData.results, mockData.text);

})();