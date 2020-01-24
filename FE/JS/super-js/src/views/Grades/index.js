import './style.css'
import React from 'react';
import GradeCard from '../../components/GradeCard'

export default function Grades({ subjectGrades }) {

  const generateCards = function (subjectGrades) {
    return subjectGrades.map((element, index) =>
      <GradeCard generalInfo={element.generalInfo} monthlyGrades={element.monthlyGrades} key={index} />
    )
  }

  return (
    <section className="gradesView">
      <section className="toolbar">YACHAQ</section>
      <section className="content">
        <section className="sidenavbar">
          <section className="entry">Info</section>
          <section className="entry">Tasks</section>
          <section className="entry active">Grades</section>
          <section className="entry">Schedule</section>
        </section>
        <section className="display">
          {generateCards(subjectGrades)}
        </section>
      </section>
    </section>
  )
}
