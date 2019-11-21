export default function Message(text, color) {

    const message = document.createElement('div');
    message.textContent = text;
    message.style.color = color;
    message.classList.add('message');

    return message;
}