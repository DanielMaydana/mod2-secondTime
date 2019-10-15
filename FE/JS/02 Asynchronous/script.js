function fakeRequest(onSuccess, onFailure) {
    setTimeout(() => {
        onSuccess({ id: '312', name: 'Eli' })
    }, 1000);
}

async function getUser() {
    const getReponse1 = await fakeRequest();
    console.log(getReponse1, '1');
}

getUser();