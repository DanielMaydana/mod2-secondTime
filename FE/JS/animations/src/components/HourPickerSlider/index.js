import './style.css'
import React from 'react'
import Draggable from 'react-draggable'
export default function HourPickerSlider () {
  const MORNING_RANGE = ['06:00', '07:00', '08:00', '09:00', '10:00', '11:00', '12:00']
  const AFTERNOON_RANGE = ['12:00', '13:00', '14:00', '15:00', '16:00', '17:00', '18:00']
  const EVENING_RANGE = ['18:00', '19:00', '20:00', '21:00', '22:00', '23:00', '24:00']
  const MINUTES_RANGE = ['00', '15', '30', '45']

  const [position, setPosition] = React.useState({ x: 0, y: 0})
  const [time, setTime] = React.useState(MORNING_RANGE[0])
  const RANGE_MAX = 600
  const RANGE_STEPS_QTY = 6
  const SUBRANGE_MAX = RANGE_MAX / RANGE_STEPS_QTY
  const SUBRANGE_STEPS_QTY = 4

  function handleDrag (event, position) {
    const posX = position.x
    setPosition(oldPosition => { return { ...oldPosition, posX } })
    setTime(getSelectedTime(
      posX,
      RANGE_MAX,
      RANGE_STEPS_QTY,
      SUBRANGE_MAX,
      SUBRANGE_STEPS_QTY,
      MORNING_RANGE,
      MINUTES_RANGE
    ))
  }

  function getSelectedTime (xPosition, hoursRange, hoursStep, minsRange, minsStep, hoursArray, minsArray) {
    const hourStep = Math.floor((xPosition / hoursRange) * hoursStep)
    const minutesinRange = xPosition - hourStep * minsRange
    const minuteStep = Math.floor((minutesinRange / minsRange) * minsStep)
    return hoursArray[hourStep].replace(/(?<=:)[0-9]*/g, minsArray[minuteStep])
  }

  function handleStop () {
    console.log(time)
  }

  function generateHourMarks (hourSteps) {
    return hourSteps.map((hour, index) => 
      <section className="hour-mark" key={index}>
        {hour}
      </section>
    )
  }

  return (
    <section className="hourPickerCmpt">
      <section className="hour-picking">
        <Draggable
          // grid={[25, 0]}
          position={position}
          onDrag={handleDrag}
          onStop={handleStop}
          bounds="parent"
          axis="x">
            <section className="drag-wrapper">
              <section className="slider">
                <section className="hourValue">{time}</section>
              </section>
            </section>
        </Draggable>
        <section className="time-axis">
          <section className="timeline"/>
          <section className="legends">
            {generateHourMarks(MORNING_RANGE)}
          </section>
        </section>
      </section>
      <section className="timeofday-picking">
        <div className="timeofday morning">Morning</div>
        <div className="timeofday afternoon">Afternoon</div>
        <div className="timeofday evening">Evening</div>
      </section>
    </section>
  )
}