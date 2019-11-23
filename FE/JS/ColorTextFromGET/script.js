(function () {

    const mockResponse = {

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
                row: 1,
                col: 6
            },
            {
                row: 1,
                col: 15
            },
            {
                row: 3,
                col: 1
            },
            {
                row: 3,
                col: 10
            },
            {
                row: 5,
                col: 1
            }
        ]
    }

    const GenerateMatchSummary = function (results) {

        return results.reduce((acc, current) => {

            if (!acc[current.row])
                acc[current.row] = [current.col]
            else
                acc[current.row] = [...acc[current.row], current.col]

            return acc;
        }, {});
    }

    const IsolateMatchAndMismatch = function (line, length, current, index, array) {

        const startTagged = current - 1;
        const finishTagged = startTagged + length;
        const startMismatch = finishTagged;
        const finishMismatch = array[index + 1] - 1;
        const lineEnd = line.length;

        const match = line.slice(startTagged, finishTagged);
        const mismatch = finishMismatch ? line.slice(startMismatch, finishMismatch) : line.slice(startMismatch, lineEnd);

        return { match, mismatch };
    }

    const CreateElement = function (textContent, className) {

        if (!textContent) return null;

        const element = document.createElement('div');
        element.textContent = textContent;
        element.classList.add(className);

        return element;
    }

    const CreateLineElement = function (elementArray) {

        const lineElement = document.createElement('div');
        lineElement.classList.add('line');
        elementArray.forEach(current => lineElement.appendChild(current))

        return lineElement;
    }

    const FormatLine = function (line, matchesArray, length) {

        const lineStart = line.slice(0, matchesArray[0] - 1);

        const firstElement = CreateElement(lineStart, "mismatch");

        const preProcessedMatches = matchesArray.reduce((acc, current, index, array) => {

            const splitted = IsolateMatchAndMismatch(line, length, current, index, array);

            const matchedElement = CreateElement(splitted.match, "match");

            const codaElement = CreateElement(splitted.mismatch, "mismatch");

            if (!codaElement)
                acc = [...acc, matchedElement]
            else
                acc = [...acc, matchedElement, codaElement];

            return acc;

        }, []);

        if (firstElement) preProcessedMatches.unshift(firstElement);

        return CreateLineElement(preProcessedMatches)
    }

    const matches = GenerateMatchSummary(mockResponse.results);
    const wordLength = mockResponse.word.length;

    const formattedText = mockResponse.text.map((line, index) => {

        const nextRow = index + 1;
        let formattedLine = null;

        if (matches[nextRow]) {

            formattedLine = FormatLine(line, matches[nextRow], wordLength);
        }
        else {

            const lineMismatch = CreateElement(line, 'mismatch');
            formattedLine = CreateLineElement([lineMismatch]);
        }

        return formattedLine;
    });

    const textArea = document.querySelector(".text-area");

    formattedText.forEach(formattedLine => textArea.appendChild(formattedLine));
})();