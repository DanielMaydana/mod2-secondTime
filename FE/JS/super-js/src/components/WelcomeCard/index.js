import React, { useState, useEffect } from 'react';
import useRequest from '../../utilities/useRequest'
import './style.css'

export default function WelcomeCard() {

  const [counter, setCounter] = useState(0);

  useEffect(() => { console.log("I'm updated") }, [counter]); //parameter: a chain func 

  useEffect(() => {
    console.log("I'm mounted");
    return () => console.log("I'm unmounted");
  }, []);

  const clickHandler = function (event) {
    console.log(counter)
    setCounter(counter + 1)
  }

  return (
    <div className="welcomeCard" onClick={clickHandler}>Clicked that many times: {counter}</div>
  )
}