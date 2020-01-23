import './style.css'
import React from 'react'
import LetterToNumericGrade from '../utils/letterToNumericGrade'
export default function GradePill({ title, grade }) {
  return (
    <section className="gradePillCmpt">
      <section className="title">{title}</section>
      <section className={`grade ${LetterToNumericGrade(grade)}`}>{grade}</section>
    </section>
  )
}