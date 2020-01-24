import './style.css'
import React, { useEffect, useState } from 'react';
import Card from '../../components/Card'
import Spinner from '../../components/Spinner'
import UsersService from '../../services/TeamViewService'

export default function TeamView() {

  const [name, setName] = useState();
  const [mail, setMail] = useState();
  const [avatar, setAvatar] = useState();
  const [cards, setCards] = useState(null);
  const [loading, setLoading] = useState(false)

  useEffect(() => {
    const response = UsersService.getAllUsers();
    response.then(res => {
      const usersArray = res.data.data;
      const aux = usersArray.map((single, index) => {
        const obj = {
          img: single.avatar,
          name: single.name,
          mail: single.email,
          teams: single.teams.length
        }
        return <Card user={obj} key={index}></Card>
      })
      setCards(aux);
    });
    return () => { }
  }, [])

  function handleNameChange(event) {
    console.log(event)
  }

  function handleSave() {

  }

  return (
    <section className="teamView">

      <Spinner isVisible={loading} />
      <h3 className="header" >DEV29 TEAMS</h3>
      <section className="content">
        <section className="members">
          {cards}
        </section>
        <section className="form">
          <div>
            <div className="textInputs">
              <div>
                <label for="#name"><h5>Name</h5></label>
                <input id="name" type="text" /* onChange={handleNameChange} value={inputText} */ />
              </div>
              <div>
                <label for="#mail"><h5>Mail</h5></label>
                <input id="mail" type="text" /* onChange={handleChange} value={inputText} */ />
              </div>
              <div>
                <label for="#avatar"><h5>Avatar</h5></label>
                <input id="avatar" type="text" /* onChange={handleChange} value={inputText} */ />
              </div>
            </div>
            <div className="buttons">
              <section className="btn" /* onClick={handleSave} */>CANCEL</section>
              <section className="btn" onClick={handleSave}>SAVE</section>
            </div>
          </div>
        </section>
      </section>
    </section>
  )
}
