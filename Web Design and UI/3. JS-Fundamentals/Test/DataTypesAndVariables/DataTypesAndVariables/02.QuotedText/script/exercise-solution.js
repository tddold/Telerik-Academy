// 02. Create a string variable with quoted text in it. For example: 'How you doin'?', Joey said.
var jsConsole;
var testButton = document.getElementById('start');

testButton.onclick = sayHi;

var clearButton = document.getElementById('clear');

clearButton.onclick = function () {
    jsConsole.clearConsole();
};

function sayHi() {
    var name = jsConsole.read('#name');
    jsConsole.writeLine('"How you doin\'' + name + '?", Joey said.');
}
