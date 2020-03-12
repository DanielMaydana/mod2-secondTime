/** @function generateTimeRange - Generates an array containing periodic divisons of time.
 *  @param {number} min - The starting time.
 *  @param {number} max - The finishing time.
 *  @param {number} step - The time period.
 *  @returns {array} - The periods of time in array format.
*/
export function generateTimeRange({ min, max, step }) {
  const timeRange = []
  let time
  for(time = min; time <= max; time += step)
  {
    timeRange.push( time < 10 ? `0${time}` : `${time}`)
  }
  return timeRange
}

/** @function getUpdatedTime - Gets the newest current time.
 *  @param {number} index - The index of the current time.
 *  @param {number} change - The time increment, could be positive or negative.
 *  @param {array} timeArray - The periods of time in array format.
 *  @returns {object} - The new current time.
*/
export function getUpdatedTime({ index, change }, timeArray) {
  const newIndex = adjustIndex(index, change, timeArray)
  const newTime = timeArray[newIndex]
  return { symbol: newTime, index: newIndex }
}

/** @function adjustIndex - Controls that the index never goes out of range.
 *  @param {number} index - The index of the current time.
 *  @param {number} change - The time increment, could be positive or negative.
 *  @param {number} array - The periods of time in array format.
 *  @returns {object} - The adjusted index.
*/
function adjustIndex (index, change, array) {
  const isOutOfLowerLimit = index + change < 0
  const isOutOfUpperLimit = index + change > array.length - 1
  if(isOutOfLowerLimit)
    return array.length - 1
  else if(isOutOfUpperLimit)
    return 0
  else
    return index + change
}