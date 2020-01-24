import React, { useEffect, useState } from 'react'
import './style.css'

export default function Timer() {

  const [seconds, setSeconds] = useState(0);
  const [stop, setStop] = useState(true);
  const [timer, setTimer] = useState(null);

  useEffect(() => {
    setStop(true);
    setSeconds(0);
    console.log("once")
    return () => { }
  }, []);

  useEffect(() => {
    if (!stop) {
      console.log()
      let auxTimer = setInterval(() => setSeconds(s => s + 1), 1000)
      setTimer(auxTimer);
    }
  }, [stop]);

  function handlePause() {
    clearInterval(timer);
    setTimer(null);
    setStop(true);
  }

  function handlePlay() {
    setStop(false);
  }

  return (
    <div className="timerCmpt">
      <div className="timer">{seconds}</div>
      <div className="controls">
        <button onClick={handlePlay}>PLAY</button>
        <button onClick={handlePause}>PAUSE</button>
      </div>
    </div>
  )
}