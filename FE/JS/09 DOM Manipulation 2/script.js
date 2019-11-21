import Message from "./Message.js";

(function () {

    const UpdateMessageCounter = function (messageQty) {

        messageCounter.innerHTML = `Comments (${messageQty})`;
    }

    const CreateNewMessage = function (text) {

        const toAppend = Message(text, 'purple')
        messageContainer.appendChild(toAppend);

        UpdateMessageCounter(messageContainer.querySelectorAll(".message").length);

        messageContainer.scrollTop = messageContainer.scrollHeight;
    }

    const HandleKeyCode = function (event) {

        if (event.keyCode === 13) {

            if (event.target.value != "") CreateNewMessage(event.target.value);
            event.target.value = "";
        }
    }

    const HandleKeyDown = function (event) {

        HandleKeyCode(event);
    }

    const messageContainer = document.querySelector(".feed");
    const messageInput = document.querySelector(".message-input");
    const messageCounter = document.querySelector("h4");

    messageInput.addEventListener("keydown", HandleKeyDown);
})();