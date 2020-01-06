import React from 'react';
import './style.css'

export default function TeamView({ isVisible }) {

  return (
    <div className={`loader ${isVisible ? "" : "invisible"}`}>
      <div className="spinner"></div>
    </div>
  )
}