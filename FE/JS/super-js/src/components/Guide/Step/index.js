import React from 'react'
import Message from '../Message'
import MessageBackground from '../MessageBackground'
export default function Step({ targetInfo, stepInfo, ...props }) {
  const MESSAGE_WIDTH = 240
  const MESSAGE_HEIGHT = 118
  const WINDOW_WIDTH = window.innerWidth
  const WINDOW_HEIGHT = window.innerHeight
  const { top, left, width, height } = targetInfo
  const { index, max } = stepInfo
  function adjustPosition() {
    let messageLeft = (left + width + MESSAGE_WIDTH) < WINDOW_WIDTH ?
      (left + width) : (left - MESSAGE_WIDTH)
    let messageTop = (top + MESSAGE_HEIGHT) < WINDOW_HEIGHT ?
      top : (top + height - MESSAGE_HEIGHT)
    if (messageLeft < 0) {
      messageLeft = 0
      messageTop = top - MESSAGE_HEIGHT
    }
    if (top === 0 && WINDOW_WIDTH <= width) {
      messageTop = height
    }
    return { top: `${messageTop}px`, left: `${messageLeft}px` }
  }
  return (
    <>
      <Message
        position={adjustPosition()}
        isFirst={index === 0}
        isLast={(index > 0) && (index === (max - 1))}
        {...props.message}
      />
      <MessageBackground
        targetInfo={targetInfo}
        windowInfo={{
          winHeight: WINDOW_HEIGHT,
          winWidth: WINDOW_WIDTH
        }}
      />
    </>
  )
}