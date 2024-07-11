const ratingInputs = document.querySelectorAll('.rating input');

ratingInputs.forEach(input => {
  input.addEventListener('change', function() {
    // Тук можете да направите нещо с избраната оценка (this.value)
    console.log('Избрана оценка:', this.value);
  });
});