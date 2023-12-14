function startAnimation() {
    const elements = document.querySelectorAll('.box, .circle');
    elements.forEach(element => {
      element.classList.toggle('animate');
    });
  }
  