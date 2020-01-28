import './style.css'
import React, { useState } from 'react'
import propTypes from 'prop-types'
import SidenavOption from '../SidenavOption'
/**
  Vertical menu to switch between views.
*/
function SideNavbar({ header, children }) {
  const [clicked, setClicked] = useState([])
  function onClick (option) {
    console.log(option)
  }
  const wrappedChildren = React.Children.map(children, (child, index) => {
    return (
      <SidenavOption active={false} onClick={onClick} numeration={`option-${index}`}>
        {child}
      </SidenavOption>
    )
  })
  console.log('wrapped', wrappedChildren)
  
  return (
    <div className='sideNavbarCmpt'>
      <div className='header'>{header}</div>
      {wrappedChildren}
      {/* <div className='actions'>{newOption}</div> */}
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
