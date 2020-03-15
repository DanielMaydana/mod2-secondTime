import React from 'react'
import './style.css'

export default function ListEntry ({ text, user, upvotes }) {

  const [first, last] = user.split(' ')
  const initials = `${first[0]}${last[0]}`
  
  return(
    <div className="entry">
      <div className="avatar">
        <div className="circle">{initials}</div>
      </div>
      <div className="description">{text}</div>
      <div className="upvotes">{upvotes}</div>
    </div>
  )
}
