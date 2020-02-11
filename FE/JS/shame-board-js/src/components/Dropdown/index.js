import './style.css'
import React from 'react'
import PropTypes from 'prop-types'
export default function Dropdown ({ onChange, value, options, isOpen, children }) {
  const mappedOptions = options.map(opt => {
  return <section 
    className="dropOption"
    key={opt.id}
    onClick={()=> handleOptionClick(opt)}>
      {opt.text}
    </section>
  })
  function handleOptionClick (option) {
    onChange(option)
  }
  return (
    <section className={`dropdownCmpt ${isOpen ? '' : 'hidden'}`} >
      {children}
      {mappedOptions}
    </section>
  )
}

Dropdown.propTypes = {
  onChange: PropTypes.func.isRequired,
  value: PropTypes.shape.isRequired,
  options: PropTypes.array.isRequired,
  isOpen: PropTypes.bool,
  children: PropTypes.node.isRequired,
}

Dropdown.defaultProps = {
  onChange: function () {},
  value: null,
  options: null,
  isOpen: false,
  children: null
}