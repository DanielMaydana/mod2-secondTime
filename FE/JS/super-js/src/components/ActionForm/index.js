import './style.css'
import uuid from '../../utilities/uuid'
import React, { useRef, useEffect, useState } from 'react'
import ActionButton from '../ActionButton'
export default function ActionForm({ children, actions, autofocus }) {
  const [isValid, setValid] = useState(false);
  useEffect(() => {
    if(autofocus) formRef.current.querySelector('input').focus()
  }, [])
  const formRef = useRef();
  console.log(uuid());
  function checkFormValidity() {
    setValid(formRef.current.checkValidity());
  }
  const generateActions = function (actions) {
    console.log(actions);
    return actions.map((elem, index) => {
      const validity = isValid ? "valid" : "invalid"
      console.log(isValid);
      const isPrimary = `${validity} ${elem.primary ? "primary" : "default"}`
      return <ActionButton title={elem.title} isPrimary={isPrimary} />
    })
  }
  return (
    <section className="actionFormCmpt"  >
      <form ref={formRef} onChange={checkFormValidity}>
        {children}
      </form>
      <section className="actions">
        {generateActions(actions)}
      </section>
    </section >
  )
}