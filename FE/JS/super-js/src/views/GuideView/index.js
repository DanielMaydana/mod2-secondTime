import './style.css'
import React from 'react'
import Guide from '../../components/Guide';
import { tutorial } from '../../components/Guide/tutorial';
export default function GuideView() {
  return (
    <section className="guideView">
      <Guide steps={tutorial} open={true} />
      <section  className="sidenavMenuCmpt">
        <section className="header">Header</section>
        <button id="btn1">CLICK</button>
      </section>
      <section className="display">
        <button id="btn2">CLICK</button>
        <button id="btn3">CLICK</button>
        <button id="btn4">+</button>
      </section>  
    </section>
  )
}