import './style.css'
import React from 'react'
export default function GradePill({ title, grade }) {
  return (
    <section className="gradePillCmpt">
      <section className="title">{title}</section>
      <section className="grade">{grade}</section>
    </section>
  )
}