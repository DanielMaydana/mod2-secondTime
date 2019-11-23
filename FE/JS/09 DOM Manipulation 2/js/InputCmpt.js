export default function InputCpmt(id, onChange, onCreateMessage) {

  function handleKeyCode(event) {
    if(event.keyCode === 13) {
      onCreateMessage(event.target.value)
      event.target.value = '';
    }
  }

  function handleKeyDown(event) {
    handleKeyCode(event);
  }

  return {
    node: null,
    init() {
      this.node = document.querySelector(id);
      this.node.addEventListener('keydown', handleKeyDown);
    },

  }
}