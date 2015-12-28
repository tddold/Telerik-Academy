var msgPref = 'Message';

function writeOnConsole(msg) {
    console.log(msgPref + msg);
}

module.export = {
    write: writeOnConsole
}