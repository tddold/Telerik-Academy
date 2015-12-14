// file-1.js
var mod = mod || {};
(function(scope){
    scope.x = 'file-1';
}(mod));

// file-2.js
var mod = mod || {};
(function(scope){
    scope.y='file-2';
}(mod));

console.log(mod.x);
console.log(mod.y);