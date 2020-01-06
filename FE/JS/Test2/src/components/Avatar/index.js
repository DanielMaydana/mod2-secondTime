import React from 'react';

export default class Avatar extends React.Component {

  constructor(props) {
    super(props)
  }

  componentWillUnmount() {
    console.log("did unmount Avatar")
  }

  render() {
    return <div> I'm an avatar </div >
  }
}