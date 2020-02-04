import './style.css'
import React from 'react'
export default function Message({ content, navigation, position, isFirst, isLast }) {
  const { onClose, onNext, onPrev } = navigation
  return (
    <section className={'guideMessage'}>
      <section className={'message'} style={position}>
        <section className="skipAll" onClick={onClose}>Skip all</section>
        <section className="content">
          {content}
        </section>
        <section className="actions">
          <button onClick={onPrev} disabled={isFirst}>&#8678;</button>
          {isLast && <button onClick={onClose}>X</button>}
          <button onClick={onNext} disabled={isLast}>&#8680;</button>
        </section>
      </section>
    </section>
  )
}