import React from 'react';
import PropTypes from 'prop-types';
import Avatar from '../Avatar';
import Icon from '@material-ui/core/Icon';
import './style.css'

function PlantCard({ cardInfo }) {

    const GetStatSection = function (stats) {

        const statsLayout = stats.map((singleStat, index) => {

            return (
                <div className="plantCard__data" key={index}>
                    <Icon>{singleStat.icon}</Icon>
                    <div className="value">{`${singleStat.value} ${singleStat.unit}`}</div>
                    <div className="name">{singleStat.name}</div>
                </div>
            )
        });

        return (
            <div className="plantCard__stats">
                {statsLayout}
            </div>
        )
    }

    const statSection = GetStatSection(cardInfo.stats)

    return (
        <div className={"plantCard"}>
            <Avatar source={cardInfo.src} size={cardInfo.size} />
            <div className="plantCard__info">
                <div className="plantCard__name">{cardInfo.name}</div>
                {statSection}
            </div>
        </div>
    )
}

export default PlantCard;

PlantCard.propTypes = {
    avatarInfo: PropTypes.objectOf(PropTypes.string),
    cardInfo: PropTypes.shape({
        name: PropTypes.string,
        stats: PropTypes.arrayOf(
            PropTypes.objectOf(PropTypes.string)
        )
    })
};

PlantCard.defaultProps = {
    avatarInfo: {},
    cardInfo: {}
}