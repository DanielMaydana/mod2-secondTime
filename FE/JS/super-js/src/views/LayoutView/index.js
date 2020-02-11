import './style.css'
import React from 'react'
import Card from '../../components/Card'
import Layout from '../../components/Layout'
export default function LayoutView ({}) {
  const toolbarActions = [
    {
      onClick: () => {console.log('click 1')},
      icon: 'add'
    },
    {
      onClick: () => {console.log('click 2')},
      icon: 'archive'
    },
    {
      onClick: () => {console.log('click 2')},
      icon: 'assessment'
    },
    {
      onClick: () => {console.log('click 2')},
      icon: 'local_gas_station'
    },
    {
      onClick: () => {console.log('click 2')},
      icon: 'account_box'
    }
  ]
  // const titleNode = <Card user={'daniel'} />
  const titleNode = null

  return (
    <section className="layoutView">
      <Layout title={titleNode} toolbarActions={toolbarActions}/>
    </section>
  )
}