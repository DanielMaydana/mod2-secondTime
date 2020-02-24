import React from 'react'
import underscore from 'underscore'
import './style.css'
function ComponentA({ data, onClick }) {
  console.log('Rendering A:', data)
  return (
    <section className="componentA">
      ComponentA
      <button onClick={onClick} >Click</button>
    </section>
  )
}

function checkProps( currentProps, newProps) {
  console.log(underscore.isEqual(currentProps, newProps))
  return underscore.isEqual(currentProps, newProps)
}

export default React.memo(ComponentA, checkProps)
