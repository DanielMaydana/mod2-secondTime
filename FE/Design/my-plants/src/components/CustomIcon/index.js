import React from 'react';
import PropTypes from 'prop-types';
import Icon from '@material-ui/core/Icon';
import './style.css'

function CustomIcon({ name, size }) {

    const ICONS_PATH = "/images/icons/"

    const CUSTOM_ICONS = {
        battery0: "battery-0.svg",
        battery1: "battery-1.svg",
        battery2: "battery-2.svg",
        battery3: "battery-3.svg"
    }

    const GetIcon = function (name) {

        if (CUSTOM_ICONS.hasOwnProperty(name)) {

            return <object type="image/svg+xml" data={`${ICONS_PATH}${CUSTOM_ICONS[name]}`}> </object>;
        }
        else {

            return <Icon>{name}</Icon>;
        }
    }

    return (
        <div className={`customIcon ${size}`} >
            {GetIcon(name)}
        </div >
    )
}

export default CustomIcon;

CustomIcon.propTypes = {
    name: PropTypes.string,
    size: PropTypes.string
};

CustomIcon.defaultProps = {
    name: "",
    size: "small"
}