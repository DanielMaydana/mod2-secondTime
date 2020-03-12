import React from 'react'
import './style.css'

export default function ColourMatrix () {
  
  const columnQty = 250
  const rowQty = 120

  function generateRow (rowQty) {
    let row = []
    for(let i = 0; i < rowQty; i++ ) {
      row.push(
        <div
          className='cell'
          style={{ backgroundColor: getRandomColor() }}>
        </div>
      )
    }
    return row
  }

  function getRandomColor() {
    const letters = '0123456789ABCDEF'
    let color = '#'
    for (var i = 0; i < 6; i++) {
      color += letters[Math.floor(Math.random() * 16)]
    }
    return color
  }

  return (
    <section className="colorMatrixCmpt">
      <div className="row1">{generateRow(rowQty)}</div>
    </section>
  )
}