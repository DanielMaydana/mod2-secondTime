import './style.css'
import React from 'react'
import MaterialIcon from 'material-icons-react'
export default function Layout ({ menu, title, toolbarActions }) {
  const actions = toolbarActions.map(elem => {
    return (
      <section className="toolbar-icon">
        <MaterialIcon icon={elem.icon} />
      </section>
    )
  })
  return (
    <section className="layoutCmpt">
      <section className="layout-toolbar">
          <section className="sandwich">
            <MaterialIcon icon={'menu'}/>
          </section>
          <section className="title">{title}</section>
          <section className="actions">{actions}</section>
        </section>
      <section className="layout-content">
        <section className="content menu"></section>
        <section className="content display"></section>
      </section>
    </section>
  )
}
