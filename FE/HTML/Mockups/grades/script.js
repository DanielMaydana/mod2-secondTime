(function () {
  const expandHandler = function (event) {
    const body = document.querySelector(".card > .body");
    let label = event.target.innerText;
    body.classList.toggle("visible");
    event.target.innerText = label === "EXPAND" ? "COLLAPSE" : "EXPAND";
  }

  const expandBtn = document.querySelector("#expand");
  expandBtn.addEventListener('click', expandHandler);
})();