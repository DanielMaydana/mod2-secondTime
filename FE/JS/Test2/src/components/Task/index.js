import React from 'react'
import TodoForm from '../TodoForm';
import './style.css'

function Task({ name, onDelete, onEdit }) {

  const [showForm, setShowForm] = React.useState(false);

  function handleDelete() {
    onDelete(name);
  }

  function handleCancel() {
    setShowForm(false)
  }

  function handleSave(task) {
    onEdit(name, task);
    setShowForm(false)
  }

  function handleClickEdit() {
    setShowForm(true);
  }

  return (
    <section className="taskCmpt">
      {!showForm &&
        <>
          <section className="taskName">{name}</section>
          <section className="buttons">
            <button className="deleteTask" onClick={handleDelete}>Delete</button>
            <button className="editTask" onClick={handleClickEdit}>Edit</button>
          </section>
        </>
      }
      {showForm && <TodoForm value={name} onSave={handleSave} onCancel={handleCancel} />}
    </section>
  )
}

export default Task 