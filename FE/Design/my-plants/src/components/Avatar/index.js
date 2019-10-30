import React from 'react';
import PropTypes from 'prop-types';
import './style.css'

function Avatar({ source, size }) {

    const GetImage = function (source) {

        const checkedSource = (source === "") ? "/images/default-plant.png" : source;

        return <img src={checkedSource} alt={""} />
    }

    const GetSize = function (size) {

        const SIZES = {
            small: "small",
            medium: "medium",
            large: "large"
        }

        return SIZES.hasOwnProperty(size) ? SIZES[size] : SIZES["medium"];

    }

    const image = GetImage(source);

    const sizeSelection = GetSize(size);

    return (
        <div className={`avatar ${sizeSelection}`}>
            {image}
        </div>
    )
}

export default Avatar;

Avatar.propTypes = {
    source: PropTypes.string,
    size: PropTypes.string
};

Avatar.defaultProps = {
    source: "/images/default-plant.png",
    size: "medium"
}