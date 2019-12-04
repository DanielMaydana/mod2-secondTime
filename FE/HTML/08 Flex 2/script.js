(function () {
  const maxWidth = window.matchMedia("(max-width: 768px)")


  const menuButtonHandler = function (event) {


    const backgroundHandler = function (event) {
      const navbarElement = document.querySelector(".navbar");
      navbarElement.classList.toggle("visible");

    }

    const navbarElement = document.querySelector(".navbar");
    navbarElement.classList.toggle("visible");
    console.log("menu clicked");

    let background = document.querySelector(".navbar.visible::after");
    background.addEventListener('click', backgroundHandler)
  }

  const menuButton = document.querySelector(".option-group .avatar");

  menuButton.addEventListener('click', menuButtonHandler);
})();