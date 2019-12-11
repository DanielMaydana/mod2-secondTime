import React, { useEffect, useState } from 'react'

export default function List({ entries }) {

  const allEntries = entries.map((element, index) => {
    return (
      <div>{index} {element.name}</div>
    )
  });

  console.log("LIST")

  return (
    <section className="listCmpt" id="somthing">
      {allEntries}
    </section>
  )
}