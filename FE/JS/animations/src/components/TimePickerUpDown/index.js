import React from 'react'
import PropTypes from 'prop-types'
import UpDownSelector from './UpDownSelector'
import './style.css'

/** @function TimePickerUpDown - A controlled component that uses up-down selectors to pick hours and minutes.
 *  @param {object} props - Component properties.
 *  @returns {node} - Returns a react element.
*/
export default function TimePickerUpDown ({ value, onChange }) {
  const { hour, minute } = value
  /** @function getTimeChange - Builds an updated time object, using the current time and its increment.
   *  @param {object} current - The current time.
   *  @param {number} hourchange - Increment for the hour.
   *  @param {number} minuteChange - Increment for the minute.
   *  @returns {object} - The updated time object.
  */
  function getTimeChange ({ current, hourChange, minuteChange }) {
    return {
      hour: { ...current.hour, change: hourChange },
      minute: { ...current.minute, change: minuteChange }
    }
  }

  /** @function handleHoursIncrement - Executes the onChange callback to increment the hours.
  */
  function handleHoursIncrement () {
    onChange(getTimeChange({
      current: value,
      hourChange: 1,
      minuteChange: 0
    }))
  }

  /** @function handleHoursIncrement - Executes the onChange callback to decrement the hours.
  */
  function handleHoursDecrement () {
    onChange(getTimeChange({
      current: value,
      hourChange: -1,
      minuteChange: 0
    }))
  }

  /** @function handleHoursIncrement - Executes the onChange callback to increment the minutes.
  */
  function handleMinutesIncrement () {
    onChange(getTimeChange({
      current: value,
      hourChange: 0,
      minuteChange: 1
    }))
  }

  /** @function handleHoursIncrement - Executes the onChange callback to decrement the minutes.
  */
  function handleMinutesDecrement () {
    onChange(getTimeChange({
      current: value,
      hourChange: 0,
      minuteChange: -1
    }))
  }

  return (
    <section className="timePickerUpDown">
      <div className="wrapper">
        <UpDownSelector
          value={hour.symbol}
          onUp={handleHoursIncrement}
          onDown={handleHoursDecrement}/>
        <div className="colon">:</div>
        <UpDownSelector
          value={minute.symbol}
          onUp={handleMinutesIncrement}
          onDown={handleMinutesDecrement}/>
      </div>
    </section>
  )
}

TimePickerUpDown.defaultProps = {
  value: {
    hour: { symbol: '00', index: 0 },
    minute: { symbol: '00', index: 0 }
  },
  onChange: () => {}
}

TimePickerUpDown.propTypes = {
  /** The callback to execute when the hour/minute changes. */
  onChange: PropTypes.func,
  /** An object containing the time information. */
  value: PropTypes.shape({
    /** An object containing the hour information. */
    hour: PropTypes.shape({
      /** The representation of the hour. */
      symbol: PropTypes.oneOfType([
        PropTypes.number,
        PropTypes.string
      ]),
      /** The index of the hour from an array of hours. */
      index: PropTypes.number
    }),
    /** An object containing the minutes information. */
    minute: PropTypes.shape({
      /** The representation of the minutes. */
      symbol: PropTypes.oneOfType([
        PropTypes.number,
        PropTypes.string
      ]),
      /** The index of the minute from an array of minutes. */
      index: PropTypes.number
    })
  })
}
