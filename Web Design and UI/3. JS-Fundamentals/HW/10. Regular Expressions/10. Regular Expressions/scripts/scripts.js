/**
Problem 1. Format with placeholders

Write a function that formats a string. The function should have placeholders, as shown in the example
Add the function to the String.prototype
Example:

input	
var options = {name: 'John'};
'Hello, there! Are you #{name}?'.format(options);
output
'Hello, there! Are you John'

input	
var options = {name: 'John', age: 13};
'My name is #{name} and I am #{age}-years-old').format(options);	

output
'My name is John and I am 13-years-old'

 */

function task1() {
    jsConsole.clearConsole();

    document.getElementsByTagName( "h2" )[0].innerHTML = "Problem 1. Format with placeholders";
    document.getElementsByTagName( "p" )[1].innerHTML = "Problem 1. Format with placeholders";
    document.getElementsByTagName( "p" )[0].innerHTML = "Write a function that formats a string. The function should have placeholders, as shown in the example. Add the function to the String.prototype.";

    var result,
        options = [
                   { name: 'John' },
                   { name: 'John', age: 13 }
        ];

    jsConsole.writeLine( '--------------------------------------' );

    jsConsole.writeLine( 'Format with placeholders: ' + strFormat( 'Hello, there! Are you #{name}?', options[0] ) );
    console.log( 'Format with placeholders: ' + strFormat( 'Hello, there! Are you #{name}?', options[0] ) );

    jsConsole.writeLine( 'Format with placeholders: ' + strFormat( 'My name is #{name} and I am #{age}-years-old', options[1] ) );
    console.log( 'Format with placeholders: ' + strFormat( 'My name is #{name} and I am #{age}-years-old', options[1] ) );

    jsConsole.writeLine();
    jsConsole.writeLine( '--------------------------------------' );

    function strFormat( string, person ) {
        var i,
            len,
            args = arguments,
            str = args[0];

        str = str.replace( /\#{(\w+)}/g, function ( match, prop ) {
            return person[prop];
        } );
        return str;
    }

    /*Add the function to the String.prototype*/
    String.prototype.format = function ( options ) {
        var prop,
            regex,
            result = this;

        for ( prop in options ) {
            regex = new RegExp( '#{' + prop + '}', 'g' );
            result = result.replace( regex, options[prop] );
        }

        return result;
    };

    jsConsole.writeLine( '--------------------------------------' );

    jsConsole.writeLine( 'Format with placeholders: ' + 'Hello, there! Are you #{name}?'.format( options[0] ) );
    console.log( 'Format with placeholders: ' + 'Hello, there! Are you #{name}?'.format( options[0] ) );

    jsConsole.writeLine( 'Format with placeholders: ' + 'My name is #{name} and I am #{age}-years-old'.format( options[1] ) );
    console.log( 'Format with placeholders: ' + 'My name is #{name} and I am #{age}-years-old'.format( options[1] ) );

    jsConsole.writeLine();
    jsConsole.writeLine( '--------------------------------------' );

}

/**
Problem 2. HTML binding

Write a function that puts the value of an object into the content/attributes of HTML tags.
Add the function to the String.prototype
Example 1:
input
    var str = '<div data-bind-content="name"></div>';
    str.bind(str, {name: 'Steven'});

output
    <div data-bind-content="name">Steven</div>

Example 2:
input
    var bindingString = '<a data-bind-content="name" data-bind-href="link" data-bind-class="name"></à>'
    str.bind(str, {name: 'Elena', link: 'http://telerikacademy.com'});

output
    <a data-bind-content="name" data-bind-href="link" data-bind-class="name" href="http://telerikacademy.com" class="Elena">Elena</à>
 */

function task2() {
    jsConsole.clearConsole();

    document.getElementsByTagName( "h2" )[0].innerHTML = "Problem 2. HTML binding";
    document.getElementsByTagName( "p" )[1].innerHTML = "Problem 2. HTML binding";
    document.getElementsByTagName( "p" )[0].innerHTML = "Write a function that puts the value of an object into the content/attributes of HTML tags. Add the function to the String.prototype";

    String.prototype.bind = function ( str, params ) {
        var prop,
            regexHref,
            regexClass,
            regexContent
        result = this;

        for ( prop in params ) {
            regexHref = new RegExp( '(<.*?data-bind-href="' + prop + '".*?)>', 'g' );
            regexClass = new RegExp( '(<.*?data-bind-class="(' + prop + ')".*?)>', 'g' );
            regexContent = new RegExp( '(<.*?data-bind-content="' + prop + '".*?>)(.*?)(<\\s*/.*?>)', 'g' );

            result = result.replace( regexContent, function ( element, openingTag, content, closingTag ) {
                return openingTag + params[prop] + closingTag;
            } )
            .replace( regexHref, function ( tag, content ) {
                return content + ' href="' + params[prop] + '">';
            } )
            .replace( regexClass, function ( tag, content ) {
                return content + ' class="' + params[prop] + '">';
            } );
        }

        return result;
    }

    
    jsConsole.writeLine( '--------------------------------------' );

    jsConsole.writeLine( ' HTML binding: Result see in console!' + '<div data-bind-content="name"></div>'.bind( '', {name: 'Steven'}) );
    console.log( ' HTML binding: ' + '<div data-bind-content="name"></div>'.bind( '', { name: 'Steven' } ) );

    jsConsole.writeLine( ' HTML binding: Result see in console!' + '<a data-bind-content="name" data-bind-href="link" data-bind-class="name"></a>'.bind( '', { name: 'Elena', link: 'http://telerikacademy.com' } ) );
    console.log( ' HTML binding: ' + '<a data-bind-content="name" data-bind-href="link" data-bind-class="name"></a>'.bind( '', { name: 'Elena', link: 'http://telerikacademy.com' } ) );

    jsConsole.writeLine();
    jsConsole.writeLine( '--------------------------------------' );

    
}


function clearCon() {
    document.getElementsByTagName( "h2" )[0].innerHTML = "";
    document.getElementsByTagName( "p" )[0].innerHTML = "";
    document.getElementsByTagName( "p" )[1].innerHTML = "Regular Expressions!";
    jsConsole.clearConsole();

    var nodes = document.getElementsByTagName( "ul" );

    for ( var i = 0, len = nodes.length; i != len; ++i ) {
        nodes[0].parentNode.removeChild( nodes[0] );
    }
}

