import './style.css'
import React, { useState, useEffect, useRef } from 'react'
export default function Guide({ children, steps, open }) {
  const guideRef = useRef()
  const [index, setIndex] = useState(0)
  const [start, setStart] = useState(false)
  useEffect(() => {
    setStart(true);
  }, [])
  function renderGuide() {
    console.log(steps[index])
    const element = guideRef.current.querySelector(steps[index].selector)
    console.log(element);
    return (
      <section className={'guideMessage'}>
      </section>
    )
  }

  
  return (
    <section className={'guideCmpt'} ref={guideRef}>
      {children}
      {(open && start) ? renderGuide() : null}
    </section>
  )
}
