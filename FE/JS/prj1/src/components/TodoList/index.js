import './style.css'
import React, { useEffect, useState, useContext } from 'react'
import TodoForm from '../TodoForm'
import List from '../List'
import GlobalContext from '../../context/global';

export default function TodoList() {

  const [state, dispatch, actions] = useContext(GlobalContext);
  const { tasks } = state;
  const [showForm, setShowForm] = useState(false);

  function handleSave(task) {
    dispatch(actions.CREATE(task));
  }

  function handleDelete(name) {
    dispatch(actions.DELETE(name));
  }

  function handleEdit(name, task) {
    dispatch(actions.UPDATE({ name, task }))
  }

  function handleAdd() {
    setShowForm(true);
  }

  function handleCancel() {
    setShowForm(false);
  }

  return (
    <section className="todoListCmpt">
      <button onClick={handleAdd}>Add task</button>
      {showForm && <TodoForm onCancel={handleCancel} onSave={handleSave} />}
      <List entries={tasks} onDelete={handleDelete} onEdit={handleEdit} />
    </section>
  )
}