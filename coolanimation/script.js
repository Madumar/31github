function startAnimations() {
    document.getElementById("animation1").style.animation = "moveBox 2s ease-in-out infinite alternate";
    document.getElementById("animation2").style.animation = "moveCircle 2s ease-in-out infinite alternate";
    document.getElementById("animation3").style.animation = "moveTriangle 2s ease-in-out infinite alternate";
    
    const textElement = document.getElementById("animation4");
    textElement.style.opacity = 1;
    
    const imageElement = document.getElementById("animation5");
    imageElement.style.opacity = 1;
  }
  

 
  