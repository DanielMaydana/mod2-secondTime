import React, { useState } from 'react'
import List from '../List'
import './style.css'

export default function FilteredList({ values, header, type }) {

  const [text, setText] = useState('')

  function onChange ({ target }) {
    setText(target.value)
  }

  function filterByText (textToFind, array) {
    return array.filter(current => {
      const  regexFindWord = new RegExp(`${textToFind}`, 'g')
      return regexFindWord.test(current.text)
    })
  }

  const inputHeader =
    <div className="inputHeader">
      <div className="header">{header}</div>
      <input type="text" onChange={onChange} value={text} />
    </div>

  return (
    <div className="filteredListCmpt">
      <List
        values={filterByText(text, values)}
        header={inputHeader}
        type={type} />
    </div>
  )
}