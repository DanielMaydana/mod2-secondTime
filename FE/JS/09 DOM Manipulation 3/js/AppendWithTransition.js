export default function AppendWithTransition(container, message, transition) {

    if (!message) return null;

    message.classList.add(transition);
    container.appendChild(message);
    setTimeout(() => {
        message.classList.remove(transition);
    });
}
