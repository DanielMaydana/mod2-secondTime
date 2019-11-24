import createTask from './createTask.js';
import mock from './mock.js';

export default function okButtonHandler(event) {

    event.preventDefault();

    const textArea = document.querySelector('.text-area');
    const popUp = document.querySelector('.pop-up');
    const list = document.querySelector('.list');

    const newTask = createTask(mock.src, textArea.value);

    textArea.value = '';
    popUp.style.display = 'none';

    list.appendChild(newTask);
}