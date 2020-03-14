import './style.css'
import React from 'react'
import ListEntry from '../List/ListEntry'

export default function List ({ values, title, type }) {

  const ORDER_TYPE = {
    popularity: sortByPopularity,
    username: sortByUsername,
    regular: noSort,
    custom: inputFilter 
  }

  function noSort (array) {
    return array
  }

  function inputFilter (array) {
    return array
  }

  function sortByPopularity(array) {
    return [...array].sort((itemA, itemB) => {
      const isMorePopular = itemA.upvotes < itemB.upvotes
      return isMorePopular ? -1 : 1
    })
  }

  function sortByUsername(array) {
    return [...array].sort((userA, userB) => {
      const hasUserA = Boolean(userA.user)
      const hasUserB = Boolean(userB.user)
      if(hasUserA && hasUserB) {
        const hasHigherLetter = userA.user.name.first < userB.user.name.first
        return hasHigherLetter ? 1 : -1
      }
      return 1
    })
  }

  const sorted = ORDER_TYPE[type](values)

  function generateEntries (array) {
    return array.map((catInfo, index) => {
      const hasUser = Boolean(catInfo.user)
      const hasName = hasUser && catInfo.user.name
      const user = hasUser && hasName ? `${catInfo.user.name.first} ${catInfo.user.name.last}` : 'Not Found'
      // console.log(catInfo.user.name.first)
      const { text, upvotes } = catInfo
      return <ListEntry
        key={catInfo._id || index}
        text={text}
        user={user}
        upvotes={upvotes}
      />
    })
  }

  return (
    <div className="listCmpt">
      <div className="title">{title}</div>
      <div className="entries">{generateEntries(sorted)}</div>
    </div>
  )
}