import React from 'react'
import PropTypes from 'prop-types'
import UpDownSelector from './UpDownSelector'
import './style.css'

export default function HourPickerScroll ({ value, onChange }) {
  
  const { hour, minute } = value

  function getTimeChange ({ current, hourChange, minuteChange }) {
    return {
      hour: { ...current.hour, change: hourChange },
      minute: { ...current.minute, change: minuteChange }
    }
  }

  function handleHoursIncrement () {
    onChange(getTimeChange({ 
      current: value,
      hourChange : 1,
      minuteChange : 0 
    }))
  }

  function handleHoursDecrement () {
    onChange(getTimeChange({
      current: value,
      hourChange : -1,
      minuteChange : 0
    }))
  }

  function handleMinutesIncrement () {
    onChange(getTimeChange({
      current: value,
      hourChange : 0,
      minuteChange : 1
    }))
  }

  function handleMinutesDecrement () {
    onChange(getTimeChange({
      current: value,
      hourChange : 0,
      minuteChange : -1
    }))
  }

  return (
    <section className="timePickerScroll">
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

HourPickerScroll.defaultProps = {
  value: {
    hour: { symbol: '00', index: 0 },
    minute: { symbol: '00', index: 0 }
  },
  onChange: () => {}
}

HourPickerScroll.propTypes = {
  value: PropTypes.shape({
    hour: PropTypes.shape({
      symbol: PropTypes.oneOfType([
        PropTypes.number,
        PropTypes.string
      ]),
      index: PropTypes.number
    }),
    minute: PropTypes.shape({
      symbol: PropTypes.oneOfType([
        PropTypes.number,
        PropTypes.string
      ]),
      index: PropTypes.number
    }),
  }),
  onChange: PropTypes.func
}