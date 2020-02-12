import './style.css'
import React, { useState, useEffect } from 'react'
import propTypes from 'prop-types'
/**
  Vertical menu to switch between views.
*/
function SideNavbar({ header, footer, children }) {
  const [highlight, setHighlight] = useState([])
  useEffect(() => {
    highlightOptions(0)
  }, []);
  function handleSelection(selectedId) {
    highlightOptions(selectedId)
  }
  function highlightOptions(selectionId) {
    const mapped = React.Children.map(children, (node, index) => {
      const isSelected = selectionId === index ? true : false
      return { node, isSelected }
    })
    setHighlight(mapped)
  }
  function wrapOptions() {
    return highlight.map((elem, index) => {
      return (
        <section className={`menuOption ${elem.isSelected ? 'selected' : ''}`} onClick={() => handleSelection(index)}>
          {elem.node}
        </section>
      )
    })
  }
  return (
    <div className='sideNavbarCmpt'>
      <div className='header'>{header}</div>
      <div className='body'>{wrapOptions()}</div>
      <div className='footer'>{footer}</div>
    </div>
  );
}
SideNavbar.defaultProps = {
  header: null,
  children: null,
  footer: null
}
SideNavbar.propTypes = {
  header: propTypes.node,
  children: propTypes.node,
  footer: propTypes.node
}
export default SideNavbar;
