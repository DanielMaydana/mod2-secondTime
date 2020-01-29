import './style.css'
import React from 'react'
import Guide from '../../components/Guide';
import { tutorial } from '../../components/Guide/tutorial';
export default function GuideView() {
 return (
   <section className="guideView">
    <Guide steps={tutorial} open={true} >
      <section className="header">THESE ARE SOME BUTTONS</section>
      <section className="allButtons">
        <button id="btn1">SELECT</button>
        <button id="btn2">VALIDATE</button>
        <button id="btn3">SEND</button>
      </section>
    </Guide>
  </section>
 )
}