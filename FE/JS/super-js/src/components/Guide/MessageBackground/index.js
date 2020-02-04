import './style.css'
import React from 'react'
export default function MessageBackground({ targetInfo, windowInfo }) {
  const { top, left, width, height } = targetInfo
  const { winHeight, winWidth } = windowInfo
  function getRightStyle() {
    return pixelizeStyle({
      top: 0,
      left: 0,
      width: left,
      height: winHeight
    })
  }
  function getTopStyle() {
    return pixelizeStyle({
      top: 0,
      left: left,
      width: (winWidth - left),
      height: top
    })
  }
  function getLeftStyle() {
    return pixelizeStyle({
      top: top,
      left: (left + width),
      width: (winWidth - (left + width)),
      height: (winHeight - top)
    })
  }
  function getBottomStyle() {
    return pixelizeStyle({
      top: (top + height),
      left: left,
      width: width,
      height: (winHeight - (top + height))
    })
  }
  function pixelizeStyle(style) {
    return Object.keys(style).reduce((acc, key) => {
      acc[key] = `${style[key]}px`
      return acc
    }, {})
  }
  return (
    <>
      <section className="background right" style={getRightStyle()} />
      <section className="background top" style={getTopStyle()} />
      <section className="background left" style={getLeftStyle()} />
      <section className="background bottom" style={getBottomStyle()} />
    </>
  )
}