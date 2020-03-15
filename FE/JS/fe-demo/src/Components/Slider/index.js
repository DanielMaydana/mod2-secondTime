import React, { useState, Component } from 'react'
import './style.css'

export default function Slider () {

  const [activeSlide, setActiveSlide] = useState(0)

  function generateSlides (qty) {
    const slides = (new Array(qty)).fill(0)
    return slides.map((current, index) => {
      const isActive = activeSlide === index
      const className = isActive ? 'active' : 'inactive'
      return <div className={`slide ${className}`} key={index}></div>
    })
  }

  return (
    <section className="sliderCmpt">
      <section className="viewer">
        {generateSlides(3)}
      </section>
    </section>
  )
}  