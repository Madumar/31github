function startAnimations() {
    const squares = document.querySelectorAll(".square");
    let delay = 0;
  
    squares.forEach((square, index) => {
      setTimeout(() => {
        square.style.animationDelay = `${index * 100}ms`;
      }, delay);
      delay += 100;
    });
  }
  