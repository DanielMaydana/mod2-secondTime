import CreateMessage from "./CreateMessage.js";
import AppendWithTransition from "./AppendWithTransition.js";

(function app() {

    const input = document.querySelector('.input');
    const display = document.querySelector('.display');
    const counter = document.querySelector('.counter');

    const KeyHandler = function (event) {

        if (event.keyCode === 13) {

            const newMessage = CreateMessage(event.target.value);

            event.target.value = '';

            AppendWithTransition(display, newMessage, 'leftToRight');

            display.scrollTop = display.scrollHeight;

            const count = document.querySelectorAll('.message').length;
            counter.innerHTML = `Comments(${count})`;

        }
    }

    input.addEventListener('keydown', KeyHandler)

})();