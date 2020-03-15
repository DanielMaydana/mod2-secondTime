import './style.css'
import React, { useState } from 'react'
import ListEntry from '../ListEntry'

export default function List ({ values, header, type }) {

  const [scrollQty, setScrollQty] = useState({ step: 1, qty: 5 })
  const SCROLL_QTY = 5

  const ORDER_TYPE = {
    popularity: sortByPopularity,
    username: sortByUsername,
    regular: noSort
  }

  function noSort (array) {
    return array
  }

  function sortByPopularity(array) {
    return [...array].sort((itemA, itemB) => {
      const isMorePopular = itemA.upvotes < itemB.upvotes
      return isMorePopular ? 1 : -1
    })
  }

  function sortByUsername(array) {
    return [...array].sort((userA, userB) => {
      const hasUserA = Boolean(userA.user)
      const hasUserB = Boolean(userB.user)
      if(hasUserA && hasUserB) {
        const hasHigherLetter = userA.user.name.first < userB.user.name.first
        return !hasHigherLetter ? 1 : -1
      }
      return 1
    })
  }
  
  function onScroll({ target }) {
    const { scrollTop, scrollHeight, clientHeight } = target
    const hasReachedBottom = scrollHeight - scrollTop === clientHeight
    if(hasReachedBottom) {
      const nextStep = scrollQty.step + 1
      const nextQty = SCROLL_QTY * nextStep
      setScrollQty({
        step: nextStep,
        qty: nextQty
      })
    }
  }
  
  const sorted = ORDER_TYPE[type](values.slice(0, scrollQty.qty))

  function generateEntries (array) {
    return array.map((catInfo, index) => {
      const hasUser = Boolean(catInfo.user)
      const hasName = hasUser && catInfo.user.name
      const user = hasUser && hasName ? `${catInfo.user.name.first} ${catInfo.user.name.last}` : 'Not Found'
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
      <div className="header">{header}</div>
      <div
        className="entries"
        onScroll={onScroll} >
          {generateEntries(sorted)}
      </div>
    </div>
  )
}

List.defaultProps = {
  values: [],
  header: '',
  type: 'regular'
}