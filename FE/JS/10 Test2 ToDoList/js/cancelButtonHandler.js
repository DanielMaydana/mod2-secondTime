export default function cancelButtonHandler(event) {

    console.log("congregation")

    const textArea = document.querySelector('.text-area');
    const popUp = document.querySelector('.pop-up');

    textArea.value = '';
    popUp.style.display = 'none';
}