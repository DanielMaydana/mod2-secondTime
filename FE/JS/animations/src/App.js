import React from "react"
import HourPickerHover from './components/HourPickerScroll'
import ColourMatrix from './components/ColourMatrix'
import HourPickerScroll from './components/HourPickerScroll'
import UpDownSelector from './components/HourPickerScroll/UpDownSelector'
import "./App.css"
function App () {

  const [time, setTime] = React.useState({
    hour: { symbol: '00', index: 0 },
    minute: { symbol: '00', index: 0 }
  })
  const HOURS_RANGE = { min : 0, max : 24, step : 1 }
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
      <HourPickerScroll value={time} onChange={onChange}/>
    </div>
  )
}

function generateTimeRange({ min, max, step }) {
  const timeRange = []
  let time
  for(time = min; time <= max; time += step)
  {
    timeRange.push( time < 10 ? `0${time}` : `${time}`)
  }
  return timeRange
}

function getUpdatedTime(update, timeArray) {
  const newIndex = adjustIndex(update.index, update.change, timeArray)
  const newTime = timeArray[newIndex]
  return { symbol: newTime, index: newIndex }
}

function adjustIndex (index, change, array) {
  const isOutOfLowerLimit = index + change < 0
  const isOutOfUpperLimit = index + change > array.length - 1
  if(isOutOfLowerLimit)
    return array.length - 1
  else if(isOutOfUpperLimit)
    return 0
  else
    return index + change
}

export default App
