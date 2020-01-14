import './style.css'
import React from 'react'
import GradesSumamry from '../GradesSummary'
import { latestGrades } from './dummy'
export default function Dashboard() {
  return (
    <section className="dashboardView">
      <section className="toolbar">YACHAQ</section>
      <section className="content">
        <section className="sidenavbar">
          <section className="entry"></section>
          <section className="entry active">Dashboard</section>
          <section className="entry">Solicitud de Permiso</section>
          <section className="entry">Solicitud de Tickets</section>
          <section className="entry">Daily Report</section>
        </section>
        <section className="display">
          <section className="header">
            <img src='./leah1.jpg' alt="" />
          </section>
          <section className="body">
            <GradesSumamry latestGrades={latestGrades} />
            <section className="dummy-view" />
            <section className="dummy-view" />
            <section className="dummy-view" />
          </section>
        </section>
      </section>
    </section>
  )
}