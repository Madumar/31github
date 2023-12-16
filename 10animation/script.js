function startAnimations() {
    document.getElementById("animation1").style.animation = "moveBox 2s ease-in-out infinite alternate";
    document.getElementById("animation2").style.animation = "moveCircle 2s ease-in-out infinite alternate";
    document.getElementById("animation3").style.animation = "moveTriangle 2s ease-in-out infinite alternate";
    
    const textElements = document.querySelectorAll(".text-animation, .image-animation, .fade-in, .rotate, .scale, .skew, .translate");
    textElements.forEach(element => {
      element.style.opacity = 1;
    });
  }
  
  
  