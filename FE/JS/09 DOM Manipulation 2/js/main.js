import Message from './Message.js';
import appendWithTransition from './appendWithTransition.js';
import InputCmpt from './InputCmpt.js';
(function app() {
  
  const messageInput = InputCmpt('#inputMessage', () => {}, handleSave);
  messageInput.init();

  function handleSave(text) {
    const message = Message(text, 'orange');
    appendWithTransition(MessageContainer, message, 'grow-up');
  }
  const MessageContainer = document.querySelector('#messageContainer');

})()