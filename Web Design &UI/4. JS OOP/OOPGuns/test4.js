function checkIfBrowserIsMozilla() {
    var myWindows = window,
        currentBrowser = myWindows.navigator.appCodeName,
        isMozilla = currentBrowser == 'Mozilla';
    if (isMozilla) {
        alert('Yes');
    } else {
        alert('No');
    }
}