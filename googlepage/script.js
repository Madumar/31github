function search(event) {
    event.preventDefault();
    
    const searchQuery = document.getElementById('searchInput').value;
    
    const searchResults = [
      "Result 1: Lorem ipsum dolor sit amet",
      "Result 2: Consectetur adipiscing elit",
      "Result 3: Sed do eiusmod tempor incididunt",
      "Result 4: Ut labore et dolore magna aliqua"
    ];
  
    displayResults(searchResults);
  }
  
  function displayResults(results) {
    const searchResultsDiv = document.getElementById('searchResults');
    searchResultsDiv.innerHTML = '';
  
    results.forEach(result => {
      const resultDiv = document.createElement('div');
      resultDiv.textContent = result;
      searchResultsDiv.appendChild(resultDiv);
    });
  }
  