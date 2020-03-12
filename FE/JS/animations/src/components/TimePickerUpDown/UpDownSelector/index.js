import React from 'react'
import PropTypes from 'prop-types'
import './style.css'

/** @function UpDownSelector - A single up-down selector.
 *  @param {object} props - Component properties.
 *  @returns {node} - Returns a react element.
*/
export default function UpDownSelector ({ value, onUp, onDown }) {
  const handleOnUp = () => onUp(value)
  const handleOnDown = () => onDown(value)
  const handleWheel = ({ deltaY }) => {
    (deltaY < 0) ? onUp(value) : onDown(value)
  }

  return (
    <section className="upDownSelectorCmpt" onWheel={handleWheel}>
      <div className="arrow up" onClick={handleOnUp} />
      <div className="value">{value}</div>
      <div className="arrow down" onClick={handleOnDown} />
    </section>
  )
}

UpDownSelector.defaultProps = {
  onUp: () => {},
  onDown: () => {},
  value: null
}

UpDownSelector.propTypes = {
  /** The callback to be executed when the up arrow is clicked-on or the wheel button goes up. */
  onUp: PropTypes.func,
  /** The callback to be executed when the down arrow is clicked-on or the wheel button goes down. */
  onDown: PropTypes.func,
  /** The value to display between the arrows. */
  value: PropTypes.oneOfType([
    PropTypes.number,
    PropTypes.string
  ])
}
