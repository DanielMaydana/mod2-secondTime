import React, { useEffect, useState } from 'react'
import Task from '../Task'
import './style.css'

export default function List({ entries, onDelete, onEdit }) {

  const allEntries = entries.map((element, index) => {
    console.log(element, 'element');
    return (
      <Task key={index} name={element.name} onDelete={onDelete} onEdit={onEdit}></Task>
    )
  });

  return (
    <section className="listCmpt" id="something">
      {allEntries}
    </section>
  )
}