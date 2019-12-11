import React, { useEffect, useState } from 'react'

export default function TodoForm(props) {

  const [text, setText] = useState('');
  const [disabledSaveBtn, setDisabledSaveBtn] = useState(false);
  const { onCancel, onSave } = props;


  function handleChange(event) {
    const value = event.target.value;
    setText(value);

    if (value == '') console.log("empty")/* setDisabledSaveBtn(true); */
    else console.log("not empty") /* setDisabledSaveBtn(false); */
  }

  function handleSave(event) {
    onSave({ name: text })
  }

  return (
    <section className="todoFormCmpt">
      <input type="text" onChange={handleChange} placeholder="write a task"></input>
      <div className="actions">
        {/* <input type="button" enabled={false} onClick={handleSave} value="SAVE"></input> */}
        <button type="button" enabled={false} onClick={handleSave}>SAVE</button>
        <input type="button" onClick={onCancel} value="CANCEL"></input>
      </div>
    </section>
  )
}