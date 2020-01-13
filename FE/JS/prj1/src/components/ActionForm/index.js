import './style.css'
import React, { useRef, useEffect, useState } from 'react'

export default function ActionForm({ children, actions, autofocus }) {
  const formRef = useRef(null)
  const [valid, setValid] = useState(false)
  useEffect(() => {
    const firstInput = formRef.current.querySelector('input')
    firstInput.focus()
    return () => { }
  }, [])
  const formChangeHandler = function () {
    const formElement = formRef.current.querySelector('form')
    setValid(formElement.checkValidity())
  }
  const generateActions = function (actions) {
    return actions.map((elem, index) => {
      const validity = valid ? "valid" : "invalid";
      const isPrimary = `${validity} ${elem.primary ? "primary" : "default"}`
      return <section className={`action-btn ${isPrimary}`} key={index}>{elem.title}</section>
    })
  }
  return (
    <section className="actionFormCmpt" ref={formRef} >
      <form onChange={formChangeHandler}>
        {children}
      </form>
      <section className="actions">
        {generateActions(actions)}
      </section>
    </section >
  )
}