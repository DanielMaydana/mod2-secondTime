import React, { useEffect, useState } from 'react'
import PropTypes from 'prop-types'
export default function TodoForm({ onCancel, onSave, value }) {
  const [text, setText] = useState('')
  useEffect(() => setText(value), [value]);
  function handleChange(event) {
    const value = event.target.value;
    setText(value);
  }
  function handleSave() {
    if (!text) return;
    onSave({ name: text });
    setText('')
  }
  function handleKeyDown(event) {
    const ENTER_KEY = 13;
    if (event.keyCode === ENTER_KEY) {
      handleSave();
    }
  }
  return (
    <section className="todoFormCmpt">
      <input type="text" onChange={handleChange} placeholder="write a task" value={text} onKeyDown={handleKeyDown} />
      <div className="actions">
        <button disabled={!text} onClick={handleSave}>SAVE</button>
        <input type="button" onClick={onCancel} value="CANCEL"></input>
      </div>
    </section>
  )
}
TodoForm.propTypes = {
  onCancel: PropTypes.func,
  onSave: PropTypes.func,
}
TodoForm.defaultProps = {
  onCancel: function () { },
  onSave: function () { },
  value: ""
}