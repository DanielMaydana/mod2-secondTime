// import './style.css'
// import React from 'react';
// export default function SidenavOption({ children, active, onClick, numeration }) {
//   function handleClick() {
//     onClick(numeration)
//   }
//   return (
//     <div className={`sidenavOption ${active ? 'active' : 'inactive' }`} onClick={handleClick}>
//       {children}
//     </div>
//   )
// }
// SidenavOption.defaultProps = {
//   active: false
// }
import './style.css'
import React, { useState, useEffect } from 'react'
import propTypes from 'prop-types'
function SideNavbar ({ children, header }) {
  const [active, setActive] = useState(null)
  const [options, setOptions] = useState(null)
  // function handleState (optionSelected, index) {
  //   children.forEach(child => {
  //     child === optionSelected ? setActive(true) : setActive(false)
  //   })
  // }
  useEffect (() => {
    setOptions(wrapOptions(children))
  }, [])
  function wrapOptions (children) {
    return React.Children.map(children, (element, index) => {
      return (
        <div className='sidenavOption' onClick={() => console.log('wrapper')} >
          {element}
        </div>
      )}
    )
  }
  return (
    <div className='sideNavBarCmpt'>
      <div className='header'>{header}</div>
      <div className='actions'>{ 0 | options }</div>
    </div >
  );
}
SideNavbar.defaultProps = {
  header: '',
  children: null
}
SideNavbar.propTypes = {
  header: propTypes.string,
  children: propTypes.node
}
export default SideNavbar;