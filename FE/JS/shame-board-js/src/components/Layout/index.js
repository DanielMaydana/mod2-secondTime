import './style.css'
import React, { useState } from 'react'
import MaterialIcon from 'material-icons-react'
import Dropdown from '../Dropdown';
export default function Layout ({ menu, title, toolbarActions }) {
  const [open, setOpen] = useState(false);
  const actions = toolbarActions.map((elem, index) => {
    const iconAction = 
      <section className="toolbar-icon" key={index}>
        <MaterialIcon icon={elem.icon} />
      </section>
    return (
      iconAction
    )
  })

  // <Dropdown onChange={handleChange} value={value} options={options} isOpen={open}>
  //   <div className="icon" onClick={()=>setOpen((op)=>!op)}>OPEN</div>
  // </Dropdown>

  console.log(open)
  function handleMenuClick () {
    setOpen(open => !open)
  }
  return (
    <section className="layoutCmpt">
      <section className="layout-toolbar">
          <section className="sandwich" >
            <MaterialIcon icon={'menu'} onClick={handleMenuClick}/>
          </section>
          <section className="title">{title}</section>
          <section className="actions">{actions}</section>
        </section>
      <section className="layout-content">
        <section className={`overlay ${open ? 'open' : ''}`}>
          <section className="menu"></section>
          <section className="background" onClick={handleMenuClick} />
        </section>
        <section className="display"></section>
      </section>
    </section>
  )
}
