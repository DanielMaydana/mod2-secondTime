import './style.css'
import React, { useRef, useEffect } from 'react';

export default function ActionForm({ children, actions, autofocus }) {
  const formRef = useRef(null);
  useEffect(() => {
    const firstInput = formRef.current.querySelector('input');
    firstInput.focus();
    return () => { };
  }, []);
  const generateActions = function (actions) {
    return actions.map((elem, index) => {
      return <section className={`action-btn ${elem.primary ? "primary" : "default"}`} key={index}>{elem.title}</section>
    })
  }
  return (
    <section className="actionFormCmpt" /* {`actionFormCmpt ${autofocus ? "autofocus" : ""}`} */ ref={formRef} >
      <form>
        {children}
      </form>
      {generateActions(actions)}
    </section >
  )
}

actions: {

}