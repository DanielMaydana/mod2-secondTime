const CreateCustomError = function (message) {
  const _err = new Error()
  _err.message = message
  return _err
}
module.exports = CreateCustomError