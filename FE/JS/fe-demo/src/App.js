import React from "react";
// import Slider from "./Components/Slider";
import { Illustration, Shape } from "react-zdog";
import { Motion, spring } from 'react-motion'
import "./App.css";

function App() {

  const elemProps = {
    // element: illoElem,
    // zoom: zoom,
    dragRotate: true,
    // onDragStart: function () {
    //   this.isSpinning = false;
    // },
  }

  return (
    <div className="App">
      {/* <Illustration {...elemProps} /> */}

      <Illustration zoom={8}>
        <Motion defaultStyle={{ stroke: 0 }} style={{ stroke: spring(50) }}>
          {props => <Shape {...props} color="lightblue" />}
        </Motion>
      </Illustration>{" "}
    </div>
  );
}

export default App;
