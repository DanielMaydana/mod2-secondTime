import './style.css'
import React from 'react'
import SideNavbar from '../SideNavbar'
import { BrowserRouter, Route, Switch, Link } from 'react-router-dom'

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
      <Link to={element.path} key={index}>{element.title}</Link>
    )
  }
  function generateSwitchRoute(element, index) {

    return <Route exact path={element.path} render={() => element.component()} key={index} />
    // return <PrRoute exact path={element.path} render={() => element.component()} key={index} />
  }
  console.log('menuNodes', menuNodes)
  return (
    <section className="portalLayoutCmpt">
      <React.Fragment>
        <BrowserRouter>
          <section className="menu">
            <SideNavbar>{menuNodes}</ SideNavbar>
          </section>
          <section className="display">
            <Switch> {viewNodes} </Switch>
          </section>
        </BrowserRouter>
      </React.Fragment>
    </section>
  )
}
