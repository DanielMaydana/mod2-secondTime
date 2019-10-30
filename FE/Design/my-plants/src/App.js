import React from 'react';
import PlantList from './components/PlantList'
import './App.css';

const cardInfo = [
  {
    src: "https://tinyurl.com/yylpykhx",
    name: "Cleopatra",
    stats: [
      {
        name: "Battery",
        value: "63",
        unit: "%",
        icon: "battery_std"
      },
      {
        name: "Light",
        value: "5.3k",
        unit: "lx",
        icon: "wb_sunny"
      },
      {
        name: "Humidity",
        value: "33",
        unit: "%",
        icon: "local_drink"
      }
    ]
  },
  {
    src: "https://tinyurl.com/y2alp4ad",
    name: "Ōdaigahara",
    stats: [
      {
        name: "Battery",
        value: "78",
        unit: "%",
        icon: "battery_std"
      },
      {
        name: "Light",
        value: "5.2k",
        unit: "lx",
        icon: "wb_sunny"
      },
      {
        name: "Humidity",
        value: "35",
        unit: "%",
        icon: "local_drink"
      }
    ]
  },
  {
    src: "https://tinyurl.com/y6b9g2sd",
    name: "Cicero",
    stats: [
      {
        name: "Battery",
        value: "45",
        unit: "%",
        icon: "battery_std"
      },
      {
        name: "Light",
        value: "5.1k",
        unit: "lx",
        icon: "wb_sunny"
      },
      {
        name: "Humidity",
        value: "44",
        unit: "%",
        icon: "local_drink"
      }
    ]
  },
  {
    src: "https://tinyurl.com/y4ba5rj9",
    name: "Cassius",
    stats: [
      {
        name: "Battery",
        value: "35",
        unit: "%",
        icon: "battery_std"
      },
      {
        name: "Light",
        value: "500",
        unit: "lx",
        icon: "wb_sunny"
      },
      {
        name: "Humidity",
        value: "51",
        unit: "%",
        icon: "local_drink"
      }
    ]
  },
  {
    src: "https://tinyurl.com/yycdbq4z",
    name: "Amaryllis",
    stats: [
      {
        name: "Battery",
        value: "45",
        unit: "%",
        icon: "battery_std"
      },
      {
        name: "Light",
        value: "300",
        unit: "lx",
        icon: "wb_sunny"
      },
      {
        name: "Humidity",
        value: "21",
        unit: "%",
        icon: "local_drink"
      }
    ]
  },
  {
    src: "https://tinyurl.com/y5emtq7e",
    name: "Althea",
    stats: [
      {
        name: "Battery",
        value: "23",
        unit: "%",
        icon: "battery_std"
      },
      {
        name: "Light",
        value: "100",
        unit: "lx",
        icon: "wb_sunny"
      },
      {
        name: "Humidity",
        value: "49",
        unit: "%",
        icon: "local_drink"
      }
    ]
  }
]

function App() {

  return (
    <div className="App">
      <PlantList listInfo={cardInfo} />
    </div>
  );
}

export default App;