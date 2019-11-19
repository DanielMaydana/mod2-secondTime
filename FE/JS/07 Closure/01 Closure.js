function getCallbacks() {
    let callbacks = []

    for (let i = 0; i < 6; i++) {
        callbacks.push(function () { console.log(i) });
    }

    return callbacks;
}

getCallbacks().forEach(elem => elem())