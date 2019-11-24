import okButtonHandler from './okButtonHandler.js';
import cancelButtonHandler from './cancelButtonHandler.js'

export default function addButtonHandler(event) {

    event.stopPropagation();

    const popUp = document.querySelector('.pop-up');
    const okButton = document.querySelector('.ok.button');
    const cancelButton = document.querySelector('.cancel.button');

    okButton.addEventListener('click', okButtonHandler);
    cancelButton.addEventListener('click', cancelButtonHandler);

    popUp.style.display = 'block';
}