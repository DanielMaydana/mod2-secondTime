import React, { useEffect, useState } from 'react'
import './style.css'

export default function Card({ user }) {

  return (
    <section className="cardCmpt">
      <section className="userInfo">
        <img className="avatar" src={user.img} />
        <div>
          <section className="name">{user.name}</section>
          <section className="mail">{user.mail}</section>
        </div>
      </section>
      <section className="teamInfo">
        <h5 className="groups">{`TEAMS (${user.teams})`}</h5>
      </section>
    </section>
  )
}

Card.defaultProps = {
  user: {}
}