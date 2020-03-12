(function(){

  function isAscending(items) {
    return items.reduce((eval, current, index, array) => {
      const next = array[index + 1]
      const isAscending = next !== undefined ? current < next : true
      return eval && isAscending
    }, true)
  }

  // console.log(isAscending([-5, 10, 99, 123456]), true)
  // console.log(isAscending([99]), true)
  // console.log(isAscending([4, 5, 6, 7, 3, 7, 9]), false)
  // console.log(isAscending([]), true)
  // console.log(isAscending([1, 1, 1, 1]), false)
  console.log(isAscending([1, 0, 1]), false)
})()