import React from 'react';
import WelcomeCard from '../WelcomeCard';

export default class FirstClassComponent extends React.Component {

  constructor(props) {
    super(props)

    this.state = {
      counter: 0,
      showAvatar: {}
    }
    console.log("constr")
  }

  render() {
    const clickHandler = () => {
      this.setState({
        counter: this.state.counter + 1
      })
    }

    return <>

      <button onClick={clickHandler}> Hola Mundo </button >
      {this.state.showAvatar ? <WelcomeCard /> : <h4>FALSE</h4>}
      <button onClick={() => this.setState({ showAvatar: !this.state.showAvatar })}> {this.props.name} </button >
    </>
  }
}