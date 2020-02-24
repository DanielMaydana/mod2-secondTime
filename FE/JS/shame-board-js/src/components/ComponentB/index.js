import React from 'react'
import underscore from 'underscore'
import './style.css'
function ComponentB({ data, onClick }) {
  console.log('Rendering B:', data)
  return (
    <section className="componentB">
      ComponentB
      <button onClick={onClick} >Click</button>
    </section>
  )
}

function checkProps( currentProps, newProps) {

  const aux = Object.keys(currentProps).reduce((acc, key) => {
    console.log('oldProp: ', currentProps[key])
    console.log('newProp: ', newProps[key])
    return underscore.isEqual(currentProps[key], newProps[key]) && acc
  }, true)

  console.log('aux', aux)

  console.log(currentProps, newProps)
  console.log(underscore.isEqual(currentProps, newProps))
  return underscore.isEqual(currentProps, newProps)
}

function DeepCompareObjects (objectA, objectB) {

}

export default React.memo(ComponentB, checkProps)
