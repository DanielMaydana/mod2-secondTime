import React from "react"
import HourPickerUpDown from './components/TimePickerUpDown'
import { generateTimeRange, getUpdatedTime } from './components/TimePickerUpDown/helpers'
import "./App.css"
function App () {

  const [time, setTime] = React.useState({
    hour: { symbol: '00', index: 0 },
    minute: { symbol: '00', index: 0 }
  })
  const HOURS_RANGE = { min : 0, max : 23, step : 1 }
  const MINS_RANGE = { min : 0, max : 55, step : 5 }
  const CLOCK_TIME = {
    hours: generateTimeRange({ ...HOURS_RANGE }),
    minutes: generateTimeRange({ ...MINS_RANGE })
  }
  function onChange (event) {
    const { hour, minute } = event
    const newHour = getUpdatedTime(hour, CLOCK_TIME.hours)
    const newMinute = getUpdatedTime(minute, CLOCK_TIME.minutes)

    setTime({
      hour: newHour,
      minute: newMinute
    })
  } 

  return (
    <div className="App">
      <HourPickerUpDown value={time} onChange={onChange}/>
    </div>
  )
}



export default App
