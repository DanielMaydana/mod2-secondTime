import './style.css'
import React, { useState, useEffect, useRef } from 'react'
import Message from './Message'
export default function Guide({ steps, open }) {
  const [index, setIndex] = useState(0)
  const [position, setPosition] = useState({top: 0, left: 0, width: 0, height: 0})
  useEffect(() => {
    updatePosition()
  }, [])
  useEffect(() => {
    updatePosition()
  }, [index]);
  function updatePosition() {
    const element = document.querySelector(steps[index].selector)
    const { top, left, width, height } = element.getBoundingClientRect()
    setPosition({ top, left, width, height })
  }
  function onPrev() { 
    if( index > 0 ){
      setIndex( i => i - 1 )
    }
  }
  function onNext() {
    if( index < steps.length - 1 ){
      setIndex( i => i + 1 ) }
    }
  return (
    <section className={'guideCmpt'}>
      {
        open &&
        <Message position={position} content={steps[index].content} navigation={{ onPrev, onNext }}/>
      }
    </section>
  )
}
