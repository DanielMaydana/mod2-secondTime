export default function Message(text, color) {
  const message = document.createElement('div');
  message.classList.add('messageCmpt');
  message.textContent = text;
  message.style.color = color;
  return message;
};