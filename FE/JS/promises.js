const mypromise = new Promise((resolve, reject) => {
  setTimeout(() => {
    resolve("foo")
  }, 1000);
});

mypromise.then((toPrint) => console.log(toPrint));