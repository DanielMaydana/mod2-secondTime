import './style.css'
import { BrowserRouter, Route, Switch, Link } from 'react-router-dom'
import React from 'react'

export default function PortalLayout({ views }) {
  const { menuNodes, viewNodes } = views.reduce((acc, elem, index) => {
    arrayGenerator(acc, 'menuNodes', generateMenuEntry(elem, index))
    arrayGenerator(acc, 'viewNodes', generateSwitchRoute(elem, index))
    return acc
  }, {})
  function arrayGenerator(acc, arrayName, newElement) {
    acc[arrayName] = !acc.hasOwnProperty(arrayName) ? [newElement] : [...acc[arrayName], newElement]
  }
  function generateMenuEntry(element, index) {
    return (
      <div className="entry" key={index}>
        <Link to={element.path} >{element.title}</Link>
      </div>
    )
  }
  function generateSwitchRoute(element, index) {
    return <Route exact path={element.path} render={() => element.component()} key={index} />
  }
  return (
    <div className="PortalLayout">
      <React.Fragment>
        <BrowserRouter>
          <div className="menu"> {menuNodes} </div>
          <div className="viewDisplay">
            <Switch> {viewNodes} </Switch>
          </div>
        </BrowserRouter>
      </React.Fragment>
    </div>
  )
}