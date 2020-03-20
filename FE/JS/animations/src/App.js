import React from "react"
import "./App.css"
import moment from 'moment'

function App () {

  const originalStart = new Date(2020, 3, 16, 8, 30, 0)
  const originalEnd = new Date(2020, 3, 16, 9, 30, 0)

  const movedStart = new Date(2020, 3, 24, 8, 30, 0)
  const movedEnd = getRescheduleEndDate(originalStart, originalEnd, movedStart)

  console.log(movedEnd)

  function getRescheduleEndDate (originalStart, originalEnd, movedStart) {

    const deltaTime = getTimeDifference(originalStart, originalEnd)

    console.log(deltaTime)

    const momentOriginalStart = moment(originalStart.getTime())
    return momentOriginalStart.format('YYYY MM DD hh:mm')


  }

  function getTimeDifference (start, end) {
    const deltaTime = end - start
    var diffDays = Math.floor(deltaTime / 86400000)
    var diffHrs = Math.floor((deltaTime % 86400000) / 3600000)
    var diffMins = Math.round(((deltaTime % 86400000) % 3600000) / 60000)
    return {
      diffDays,
      diffHrs,
      diffMins
    }
  }

  return (
    <div className="App">
    </div>
  )
}

export default App
