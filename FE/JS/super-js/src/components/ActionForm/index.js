import './style.css'
import React, { useRef, useEffect, useState } from 'react'

export default function ActionForm({ children, actions, autofocus }) {
  const formRef = useRef(null)
  const isValid = formRef.current && formRef.current.checkValidity()
  useEffect(() => {
    const firstInput = formRef.current.querySelector('input')
    firstInput.focus()
    return () => { }
  }, [])
  const generateActions = function (actions) {
    return actions.map((elem, index) => {
      const validity = isValid ? "valid" : "invalid";
      const isPrimary = `${validity} ${elem.primary ? "primary" : "default"}`
      return <section className={`action-btn ${isPrimary}`} key={index}>{elem.title}</section>
    })
  }
  return (
    <section className="actionFormCmpt"  >
      <form ref={formRef}>
        {children}
      </form>
      <section className="actions">
        {generateActions(actions)}
      </section>
    </section >
  )
}