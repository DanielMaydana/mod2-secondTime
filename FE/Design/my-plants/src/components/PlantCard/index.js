import React from 'react';
import Ink from 'react-ink';
import PropTypes from 'prop-types';
import Avatar from '../Avatar';
import CustomIcon from '../CustomIcon';
import './style.css'

function PlantCard({ cardInfo }) {

    const BATTERY_LVL = {
        
    }

    const BRIGHTNESS_LVL = {

    }

    const HUMIDITY_LVL = {

    }

    const GetStatusIcon = function (name, value) {

        return;
    }

    const GetStatSection = function (stats) {

        const statsLayout = stats.map((singleStat, index) => {

            return (
                <div className="plantCard__data" key={index}>
                    {/* <Icon>{singleStat.icon}</Icon> */}
                    {GetStatusIcon(singleStat.name, singleStat.value)}
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
        <div className="plantCard ripple" >
            <Avatar source={cardInfo.src} size={cardInfo.size} />
            <div className="plantCard__info">
                <div className="plantCard__name">{cardInfo.name}</div>
                {statSection}
            </div>
            <Ink />
        </div >
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