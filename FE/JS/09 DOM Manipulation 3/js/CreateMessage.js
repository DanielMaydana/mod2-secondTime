export default function CreateMessage(text) {

    if (!text) return null;

    const timeElement = CreateTimestamp();
    const textElement = CreateText(text);
    const container = CreateContainer();

    container.appendChild(textElement);
    container.appendChild(timeElement);

    return container;
};

function CreateTimestamp() {
    const timeStamp = document.createElement('div');
    let currentTime = new Date();
    currentTime = currentTime.toLocaleTimeString();
    timeStamp.classList.add('timestamp');
    timeStamp.innerText = currentTime;

    return timeStamp;
}

function CreateText(text) {
    const textElement = document.createElement('div');
    textElement.classList.add('text');
    textElement.innerText = text;

    return textElement;
}

function CreateContainer() {
    const container = document.createElement('div');
    container.classList.add('message');

    return container;
}