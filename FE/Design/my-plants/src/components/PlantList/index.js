import React from 'react';
import PropTypes from 'prop-types';
import PlantCard from '../PlantCard';
import './style.css';

function PlantList({ listInfo }) {

    const GetCards = function (list) {

        return list.map((cardInfo, index) => <PlantCard cardInfo={cardInfo} key={index} />);
    }

    return (
        <div className={"plantsList"}>
            {GetCards(listInfo)}
        </div>
    )
}

export default PlantList;

PlantList.propTypes = {
    listInfo: PropTypes.arrayOf(
        PropTypes.shape({
            avatarInfo: PropTypes.objectOf(PropTypes.string),
            cardInfo: PropTypes.shape({
                name: PropTypes.string,
                stats: PropTypes.arrayOf(
                    PropTypes.objectOf(PropTypes.string)
                )
            })
        })
    )
}

PlantList.defaultProps = {
    listInfo: []
}