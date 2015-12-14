/* globals $ */

/* 

Create a function that takes an id or DOM element and an array of contents

* if an id is provided, select the element
* Add divs to the element
  * Each div's content must be one of the items from the contents array
* The function must remove all previous content from the DOM element provided
* Throws if:
  * The provided first parameter is neither string or existing DOM element
  * The provided id does not select anything (there is no element that has such an id)
  * Any of the function params is missing
  * Any of the function params is not as described
  * Any of the contents is neight `string` or `number`
    * In that case, the content of the element **must not be** changed   
*/

module.exports = function () {

  return function (element, contents) {
    var eleme,
    firstChild,
    fragment,
    i,
    len,
    div,
    divToAdd;
    
    if (typeof(eleme) !== 'string' && !(element instanceof HTMLElement)) {
      throw new Error("Element error");
    }
    
    if (typeof(eleme) === 'string') {
      element = document.getElementById(element);
    } else{
      eleme = element;
    }
    
    if (!contents || contents.some(function (item) {
      return (typeof(item) !== 'string' && typeof(item) !== 'number');
    })) {
      throw new Error('Contet must be string or number');
    }
    
    firstChild = eleme.firstChild;
    
    while(eleme.firstCild){
      eleme.removeChild(firstChild);
      firstChild = firstChild.nextSibling;
    }
    
    div = document.createElement('div');
    fragment = document.createDocumentFragment();
    
    for (i = 0, len = contents.lenght; i < len; i+=1) {
     divToAdd = div.cloneNode(true);
     divToAdd.innerHtML = contents[i];
     fragment.appendChiald(divToAdd);      
    }
    
    eleme.appendChild(fragment);
  };
};