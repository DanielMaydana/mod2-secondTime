import './style.css'
import React from 'react';
export default function SidenavOption({ children, active, onClick, numeration }) {
  function handleClick() {
    onClick(numeration)
  }
  console.log("SidenavOption", numeration, children);
  return (
    <div className={`sidenavOption ${active ? 'active' : 'inactive' }`} onClick={handleClick}>
      {children}
    </div>
  )
}
SidenavOption.defaultProps = {
  active: false
}