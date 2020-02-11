import './style.css'
import React from 'react'
import Layout from '../../components/Layout'
export default function LayoutView ({}) {

  // const [value, setValue] = useState('opt1')
  // const [open, setOpen] = useState(true)
  // const options = [
  //   {
  //     id: 'opt1',
  //     text: 'Leon Gieco'
  //   },
  //   {
  //     id: 'opt2',
  //     text: 'Mercedes Sosa'
  //   },
  //   {
  //     id: 'opt3',
  //     text: 'Ariel Ramirez'
  //   }
  // ]
  // function handleChange (selected) {
  //   console.log(selected)
  //   // setValue(event.target.value)
  // }

  const toolbarActions = [
    {
      onClick: () => {console.log('click 1')},
      icon: 'add',
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