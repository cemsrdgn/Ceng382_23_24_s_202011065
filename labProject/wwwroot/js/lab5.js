function hideElements() {
    var hideAllImages = document.querySelectorAll('img');
    var hideCardDescription = document.querySelectorAll('.card-text');
    var hideSvgImages = document.querySelectorAll('svg');
    var hideExplanation = document.querySelectorAll('.lead');

    hideAllImages.forEach(function(element) {
      element.style.display = 'none';
    });
    hideCardDescription.forEach(function(element) {
      element.style.display = 'none';
    });
    hideExplanation.forEach(function(element) {
      element.style.display = 'none';
    });
    hideSvgImages.forEach(function(element) {
      element.style.display = 'none';
    });

    var button = document.getElementById('toggleButton');
    var showButtonText = "Show hidden elements";
    button.innerHTML = showButtonText;
    button.setAttribute('onclick', 'showElements()'); 
  }
//-------------------------------------------------------------------------------------------------------------------------------------
  function showElements() {
    var showAllImages = document.querySelectorAll('img');
    var showCardDescription = document.querySelectorAll('.card-text');
    var showSvgImages = document.querySelectorAll('svg');
    var showExplanation = document.querySelectorAll('.lead');

    showAllImages.forEach(function(element) {
      element.style.display = 'block';
    });
    showCardDescription.forEach(function(element) {
      element.style.display = 'block';
    });
    showExplanation.forEach(function(element) {
      element.style.display = 'block';
    });
    showSvgImages.forEach(function(element) {
      element.style.display = 'block';
    });

    var button = document.getElementById('toggleButton');
    var hideButtonText = "Click for hide elements";
    button.innerHTML = hideButtonText;
    button.setAttribute('onclick', 'hideElements()'); 
  }
//-------------------------------------------------------------------------------------------------------------------------------------
  function hideAdditionForm(){

    var  hideAdditionForm = document.getElementById('aform');
    hideAdditionForm.style.display = 'none'

    var realSum = document.getElementById('answer');
    realSum.style.display = 'none';

    var button = document.getElementById('formButton');
    var showFormButtonText = "Show hidden form";
    button.innerHTML = showFormButtonText;
    button.setAttribute('onclick', 'showAdditionForm()'); 
  }
//-------------------------------------------------------------------------------------------------------------------------------------

    function showAdditionForm(){

    var  showAdditionForm = document.getElementById('aform');
    showAdditionForm.style.display = 'block'

    var button = document.getElementById('formButton');
    var hideFormButtonText = "Hide Addition Form";
    button.innerHTML = hideFormButtonText;
    button.setAttribute('onclick', 'hideAdditionForm()'); 
    }
//-------------------------------------------------------------------------------------------------------------------------------------
    function calculateSum(){

        var firstNumber = parseInt(document.getElementById('firstNumberAdditionForm').value);
        var secondNumber = parseInt(document.getElementById('secondNumberAdditionForm').value);

        var sum= firstNumber+secondNumber;

        var realSum = document.getElementById('answer');
        realSum.style.display = 'block';
        document.getElementById('answer').innerHTML = "The sum of "+firstNumber+" and "+secondNumber+" is: "+sum;
    }