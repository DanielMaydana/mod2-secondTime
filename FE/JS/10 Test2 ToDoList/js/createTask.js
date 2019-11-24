export default function createTask(srcToAdd, titleToAdd) {

    let creationTime = new Date();
    creationTime = creationTime.toLocaleTimeString();

    const timeElement = CreateElement('time', creationTime);
    const imageElement = CreateElement('avatar', srcToAdd, 'img');
    const titleElement = CreateElement('title', titleToAdd);

    const taskElement = CreateElement('task');

    const dataSection = CreateElement('data');
    dataSection.appendChild(titleElement);
    dataSection.appendChild(timeElement);

    taskElement.appendChild(imageElement);
    taskElement.appendChild(dataSection);

    return taskElement;
}

function CreateElement(className, content = null, type = 'div') {

    const element = document.createElement(type);
    element.classList.add(className);

    switch (type) {
        case 'img': element.src = content;
        case 'div': element.innerText = content;
        default: break;
    }

    return element;
}