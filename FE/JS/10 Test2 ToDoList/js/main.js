
import addButtonHandler from './addButtonHandler.js';

(function app() {

    const addButton = document.querySelector('.add.button');
    const cancelButton = document.querySelector('.cancel.button');
    const okButton = document.querySelector('.ok.button');

    addButton.addEventListener('click', addButtonHandler);

})()