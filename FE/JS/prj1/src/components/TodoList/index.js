import './style.css'
import React, { useState, useContext } from 'react'
import List from '../List'
import TodoForm from '../TodoForm'
import GlobalContext from '../../context/global';
export default function TodoList() {
  const [showForm, setShowForm] = useState(false);
  const [state, dispatch, actions] = useContext(GlobalContext);
  const { tasks } = state;
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