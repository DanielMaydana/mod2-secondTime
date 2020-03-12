import React from 'react'
import PropTypes from 'prop-types'
import './style.css'

export default function UpDownSelector ({ onUp, onDown, value }) {
  const handleOnUp = () => onUp(value)
  const handleOnDown = () => onDown(value)
  const handleWheel = ({ deltaY }) => {
    if(deltaY < 0) onUp(value)
    if(deltaY > 0) onDown(value)
  }

  return (
    <section className="upDownSelectorCmpt" onWheel={handleWheel}>
      <div className="selector up" onClick={handleOnUp} />
      <div className="value">{value}</div>
      <div className="selector down" onClick={handleOnDown} />
    </section>
  )
}

UpDownSelector.defaultProps = {
  onUp: () => {},
  onDown: () => {},
  value: null
}

UpDownSelector.propTypes = {
  onUp: PropTypes.func,
  onDown: PropTypes.func,
  value: PropTypes.oneOfType([
      PropTypes.number,
      PropTypes.string
    ])
}