function startAnimations() {
    const squares = document.querySelectorAll(".square");
    const circles = document.querySelectorAll(".circle");
  
    squares.forEach((square, index) => {
      square.style.animation = `moveSquare${index + 1} 2s ease-in-out infinite alternate`;
    });
  
    setTimeout(() => {
      circles.forEach((circle, index) => {
        setTimeout(() => {
          circle.style.opacity = 1;
          circle.style.animation = `fadeCircle${index + 1} 2s ease-in-out infinite alternate`;
        }, (index + 1) * 500);
      });
    }, 1000); 
  }
  
 