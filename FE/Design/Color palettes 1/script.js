(function () {
  const palettePicker = {
    miles: {
      color1: "#0B0A0D",
      color2: "#1E2026",
      color3: "#B4C4D9",
      color4: "#556573",
      color5: "#D9A59A"
    },
    leah: {
      color1: "#A6A6A6",
      color2: "#737373",
      color3: "#595959",
      color4: "#404040",
      color5: "#262626"
    },
    jon: {
      color1: "#6553A6",
      color2: "#6F6BF2",
      color3: "#040D05",
      color4: "#BF472C",
      color5: "#BF6363"
    },
    jay: {
      color1: "#02733E",
      color2: "#024023",
      color3: "#D98C5F",
      color4: "#40170E",
      color5: "#A63E26"
    }
  }

  const allCovers = document.querySelectorAll(".cover");

  allCovers.forEach(element => {
    const portraitStyle = element.querySelector(".portrait").style;
    const infoStyle = element.querySelector(".info").style;

    portraitStyle.backgroundColor = portraitStyle.borderColor = palettePicker[element.id].color4;
    infoStyle.backgroundColor = palettePicker[element.id].color3;
    infoStyle.color = palettePicker[element.id].color1;
  });
})();