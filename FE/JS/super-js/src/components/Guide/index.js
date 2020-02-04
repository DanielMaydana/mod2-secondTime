import './style.css'
import React, { useState, useEffect } from 'react'
import Step from './Step'
export default function Guide({ steps, open }) {
  const [index, setIndex] = useState(0)
  const [isOpen, setIsOpen] = useState(open)
  const [targetInfo, setTargetInfo] = useState({ top: 0, left: 0, width: 0, height: 0 })
  useEffect(() => {
    updateTarget()
  }, [])
  useEffect(() => {
    updateTarget()
  }, [index]);
  function updateTarget() {
    const element = document.querySelector(steps[index].selector)
    const { top, left, width, height } = element.getBoundingClientRect()
    setTargetInfo({ top, left, width, height })
  }
  function onPrev() { setIndex(i => i - 1) }
  function onNext() { setIndex(i => i + 1) }
  function onClose() { setIsOpen(false) }
  return (
    <section className={'guideCmpt'}>
      {
        isOpen &&
        <Step
          message={{
            content: steps[index].content,
            navigation: {
              onClose,
              onPrev,
              onNext
            }
          }}
          targetInfo={targetInfo}
          stepInfo={{
            index,
            max: steps.length,
          }}
        />
      }
    </section>
  )
}
