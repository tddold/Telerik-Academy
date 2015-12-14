/**
Problem 1. Reverse string

Write a JavaScript function that reverses a string and returns it.
Example:
input	output
sample  elpmas
 */

function task1() {
    jsConsole.clearConsole();

    document.getElementsByTagName( "h2" )[0].innerHTML = "Problem 1. Reverse string";
    document.getElementsByTagName( "p" )[1].innerHTML = "Problem 1. Reverse string";
    document.getElementsByTagName( "p" )[0].innerHTML = "Write a JavaScript function that reverses a string and returns it.";

    var str = 'simple';

    jsConsole.writeLine( '--------------------------------------' );

    jsConsole.writeLine( 'Reversed string is: ' + reverseString( str ) );
    console.log( 'Reversed string is: ' + reverseString( str ) );

    jsConsole.writeLine();
    jsConsole.writeLine( '--------------------------------------' );

    function reverseString( str ) {
        var i,
            len,
            reversed = '';
        for ( i = 0, len = str.length; i < len; i += 1 ) {
            reversed += str[len - i - 1];
        }
        return reversed;
    }
}

/**
Problem 2. Correct brackets

Write a JavaScript function to check if in a given expression the brackets are put correctly.
Example of correct expression: ((a+b)/5-d). Example of incorrect expression: )(a+b)).
 */

function task2() {
    jsConsole.clearConsole();

    document.getElementsByTagName( "h2" )[0].innerHTML = "Problem 2. Correct brackets";
    document.getElementsByTagName( "p" )[1].innerHTML = "Problem 2. Correct brackets";
    document.getElementsByTagName( "p" )[0].innerHTML = "Write a JavaScript function to check if in a given expression the brackets are put correctly. Example of correct expression: ((a+b)/5-d). Example of incorrect expression: )(a+b)).";

    var str1 = '( ( a + b ) / 5 - d )',
        str2 = ')(a+b))';
    jsConsole.writeLine( '--------------------------------------' );

    jsConsole.writeLine( 'Check expressin is: ' + str1 + ' -> ' + 'Expression is corect: ' + checkExpression( str1 ) );
    console.log( 'Check expressin is: ' + str1 + ' -> ' + 'Expression is corect: ' + checkExpression( str1 ) );

    jsConsole.writeLine( 'Check expressin is: ' + str2 + ' -> ' + 'Expression is corect: ' + checkExpression( str2 ) );
    console.log( 'Check expressin is: ' + str2 + ' -> ' + 'Expression is corect: ' + checkExpression( str2 ) );

    jsConsole.writeLine();
    jsConsole.writeLine( '--------------------------------------' );

    function checkExpression( str ) {
        var i,
            len,
            leftBrackets = 0,
            rightBrackets = 0;
        for ( i = 0, len = str.length; i < len; i += 1 ) {
            if ( str[i] === '(' ) {
                leftBrackets += 1;
            } else if ( str[i] === ')' ) {
                rightBrackets += 1;
            }

            if ( leftBrackets < rightBrackets ) {
                return false;
            }
        }

        if ( leftBrackets > rightBrackets ) {
            return false;
        } else {
            return true;
        }

    }
}

/**
Problem 3. Sub-string in text

Write a JavaScript function that finds how many times a substring is contained in a given text (perform case insensitive search).
Example:
The target sub-string is in
The text is as follows: We are living in an yellow submarine. We don't have anything else. inside the submarine is very tight. So we are drinking all the day. We will move out of it in 5 days.

The result is: 9

 */

function task3() {
    jsConsole.clearConsole();

    document.getElementsByTagName( "h2" )[0].innerHTML = "Problem 3. Sub-string in text";
    document.getElementsByTagName( "p" )[1].innerHTML = "Problem 3. Sub-string in text";
    document.getElementsByTagName( "p" )[0].innerHTML = "Write a JavaScript function that finds how many times a substring is contained in a given text (perform case insensitive search).";

    var subStr = 'in',
        text = 'We are living in an yellow submarine. We don\'t have anything else. inside the submarine is very tight. So we are drinking all the day. We will move out of it in 5 days.';

    jsConsole.writeLine( '--------------------------------------' );

    jsConsole.writeLine( 'Check text is: ' + text );
    console.log( 'Check text is: ' + text );

    jsConsole.writeLine( 'Result is: ' + countSubstringInText( subStr, text ) );
    console.log( 'Result is:' + countSubstringInText( subStr, text ) );


    jsConsole.writeLine();
    jsConsole.writeLine( '--------------------------------------' );

    function countSubstringInText( str, text ) {
        var index,
            count = 0;
        index = text.indexOf( str );
        while ( index >= 0 ) {
            count += 1;
            index = text.indexOf( str, index + 1 );
        }
        return count;
    }
}

/**
Problem 4. Parse tags

You are given a text. Write a function that changes the text in all regions:

<upcase>text</upcase> to uppercase.
<lowcase>text</lowcase> to lowercase
<mixcase>text</mixcase> to mix casing(random)
Example: We are <mixcase>living</mixcase> in a <upcase>yellow submarine</upcase>. We <mixcase>don't</mixcase> have <lowcase>anything</lowcase> else.

The expected result:
We are LiVinG in a YELLOW SUBMARINE. We dOn'T have anything else.

Note: Regions can be nested.
 */

function task4() {
    jsConsole.clearConsole();

    document.getElementsByTagName( "h2" )[0].innerHTML = "Problem 4. Parse tags";
    document.getElementsByTagName( "p" )[1].innerHTML = "Problem 4. Parse tags";
    document.getElementsByTagName( "p" )[0].innerHTML = "You are given a text. Write a function that changes the text in all regions:";

    var randomBoolen,
        text = ' We are <mixcase>living</mixcase> in a <upcase>yellow submarine</upcase>. We <mixcase>don\'t</mixcase> have <lowcase>anything</lowcase> else.';

    jsConsole.writeLine( '--------------------------------------' );

    jsConsole.writeLine( 'Result:' );
    jsConsole.writeLine( parseTags( text ) );
    console.log( 'Result:' );
    console.log( parseTags( text ) );


    jsConsole.writeLine();
    jsConsole.writeLine( '--------------------------------------' );



    function parseTags( text ) {
        var i,
            jump,
            random,
            currentStateArr = [],
            newText = [],
            len = text.length;

        for ( i = 0; i < len; i += 1 ) {
            if ( text[i] === '<' ) {
                switch ( text[i + 1] ) {
                    case 'u':
                        currentStateArr.push( 'u' );
                        jump = text.indexOf( '>', i );
                        i = jump + 1;
                        break;
                    case 'l':
                        currentStateArr.push( 'l' );
                        jump = text.indexOf( '>', i );
                        i = jump + 1;
                        break;
                    case 'm':
                        currentStateArr.push( 'm' );
                        jump = text.indexOf( '>', i );
                        i = jump + 1;
                        break;
                    case '/':
                        currentStateArr.pop();
                        jump = text.indexOf( '>', i );
                        i = jump + 1;
                        break;
                }
            }
            switch ( currentStateArr[currentStateArr.length - 1] ) {
                case undefined:
                    newText.push( text[i] );
                    break;
                case 'u':
                    newText.push( text[i].toUpperCase() );
                    break;
                case 'l':
                    newText.push( text[i].toLowerCase() );
                    break;
                case 'm':
                    random = Math.random();
                    if ( random < 0.5 ) {
                        newText.push( text[i].toLowerCase() );
                        break;
                    } else {
                        newText.push( text[i].toUpperCase() );
                        break;
                    }
            }
        }
        return newText.join( '' );
    }
}

/**
Problem 5. nbsp

Write a function that replaces non breaking white-spaces in a text with &nbsp;
 */

function task5() {
    jsConsole.clearConsole();

    document.getElementsByTagName( "h2" )[0].innerHTML = "Problem 5. nbsp";
    document.getElementsByTagName( "p" )[1].innerHTML = "Problem 5. nbsp";
    document.getElementsByTagName( "p" )[0].innerHTML = "Write a function that replaces non breaking white-spaces in a text with &nbsp";

    var text = 'Write a function that replaces non breaking white-spaces in a text with &nbsp;';



    jsConsole.writeLine( '--------------------------------------' );

    jsConsole.writeLine( 'Result text: ' + replaceWhiteSpaces( text ) );
    console.log( 'Result text: ' + replaceWhiteSpaces( text ) );


    jsConsole.writeLine();
    jsConsole.writeLine( '--------------------------------------' );

    function replaceWhiteSpaces( test ) {
        var i,
            len,
            arr = [],
            resultText = '';

        arr = text.split( '' );

        for ( i = 0, len = arr.length; i < len; i += 1 ) {
            if ( arr[i] === ' ' ) {
                arr[i] = '&amp;nbsp;';
            }

        }
        resultText = arr.join( '' );

        return resultText;
    }
}

/**
Problem 6. Extract text from HTML

Write a function that extracts the content of a html page given as text.
The function should return anything that is in a tag, without the tags.
Example:

<html>
  <head>
    <title>Sample site</title>
  </head>
  <body>
    <div>text
      <div>more text</div>
      and more...
    </div>
    in body
  </body>
</html>
Result: Sample sitetextmore textand more...in body
 */

function task6() {
    jsConsole.clearConsole();

    document.getElementsByTagName( "h2" )[0].innerHTML = "Problem 6. Extract text from HTML";
    document.getElementsByTagName( "p" )[1].innerHTML = "Problem 6. Extract text from HTML";
    document.getElementsByTagName( "p" )[0].innerHTML = "Write a function that extracts the content of a html page given as text. The function should return anything that is in a tag, without the tags.";

    var text = '<html><head><title>Sample site</title></head><body><div>text<div>more text</div>and more...</div>in body</body></html>';

    jsConsole.writeLine( '--------------------------------------' );

    jsConsole.writeLine( 'Result text: ' + extractText( text ) );
    console.log( 'Result text: ' + extractText( text ) );


    jsConsole.writeLine();
    jsConsole.writeLine( '--------------------------------------' );

    function extractText( text ) {
        var i,
            len,
            index,
            arr = [],
            isTrue = true;
        resultText = '';
        arr = text.split( '' );

        for ( i = 0, len = arr.length; i < len; i += 1 ) {
            while ( arr[i] === '<' ) {
                index = arr.indexOf( '>', i );

                if ( index === len - 1 ) {
                    i = index + 1;
                    isTrue = false;
                    break;
                } else {
                    i = index + 1;
                }
            }

            if ( isTrue ) {
                resultText += arr[i];
            }
        }

        return resultText;
    }
}

/**
Problem 7. Parse URL

Write a script that parses an URL address given in the format: [protocol]://[server]/[resource] and extracts from it the [protocol], [server] and [resource] elements.
Return the elements in a JSON object.
Example:

URL	result
http://telerikacademy.com/Courses/Courses/Details/239	{ protocol: http, 
server: telerikacademy.com 
resource: /Courses/Courses/Details/239
 */

function task7() {
    jsConsole.clearConsole();

    document.getElementsByTagName( "h2" )[0].innerHTML = "Problem 7. Parse URL";
    document.getElementsByTagName( "p" )[1].innerHTML = "Problem 7. Parse URL";
    document.getElementsByTagName( "p" )[0].innerHTML = "Write a script that parses an URL address given in the format: [protocol]://[server]/[resource] and extracts from it the [protocol], [server] and [resource] elements. Return the elements in a JSON object.";

    var text = 'http://telerikacademy.com/Courses/Courses/Details/239';

    jsConsole.writeLine( '--------------------------------------' );

    jsConsole.writeLine( 'Parse URL: ' + parseURL( text ) );
    console.log( 'Parse URL: ' + parseURL( text ) );


    jsConsole.writeLine();
    jsConsole.writeLine( '--------------------------------------' );

    function parseURL( text ) {
        var i,
            len,
            index = -1,
            arr = [],
            count = 0,
            startIndex,
            protocol,
            server,
            resource,
            json = {};


        while ( count < 4 ) {
            count += 1;
            startIndex = index;
            index = text.indexOf( '/', index + 1 );

            switch ( count ) {
                case 1:
                    protocol = text.substring( 0, index - 1 );
                    break;
                case 3:
                    server = text.substring( startIndex, index );
                    break;
                case 4:
                    resource = text.substring( startIndex, text.length );
                    break;
                default:
                    index = index + 1;



            }
        }

        json = {
            protocol: protocol,
            server: server,
            resource: resource,
            toString: function () {
                return '[protocol]: ' + this.protocol + ';\n' +
                       '[serer]: ' + this.server + ';\n' +
                       '[resource]: ' + this.resource + ';';
            }
        }

        return json;
    }
}


/**
Problem 8. Replace tags

Write a JavaScript function that replaces in a HTML document given as string all the tags <a href="…">…</a> with corresponding tags [URL=…]…/URL].
Example:

input	
<p>Please visit <a href="http://academy.telerik.com">our site</a> to choose a training course. Also visit <a href="www.devbg.org">our forum</a> to discuss the courses.</p>	

output
<p>Please visit [URL=http://academy.telerik.com]our site[/URL] to choose a training course. Also visit [URL=www.devbg.org]our forum[/URL] to discuss the courses.</p>

 */

function task8() {
    jsConsole.clearConsole();

    document.getElementsByTagName( "h2" )[0].innerHTML = "Problem 8. Replace tags";
    document.getElementsByTagName( "p" )[1].innerHTML = "Problem 8. Replace tags";
    document.getElementsByTagName( "p" )[0].innerHTML = "Write a JavaScript function that replaces in a HTML document given as string all the tags <a href=\"…\">…</a> with corresponding tags [URL=…]…/URL].";

    var i,
        len,
        text1,
        text2,
        find = ['<a href="', '">', '</a>'],
        replace = ['[URL=', ']', '[/URL]'],
        text = '<p>Please visit <a href="http://academy.telerik.com">our site</a> to choose a training course. Also visit <a href="www.devbg.org">our forum</a> to discuss the courses.</p>';

    jsConsole.writeLine( '--------------------------------------' );

    for ( i = 0, len = find.length; i < len; i += 1 ) {
        text = replaceAll( text, find[i], replace[i] );
        //text2 = replaceAllWuthRegex( text, find[i], replace[i] );

    }

    jsConsole.writeLine( ' Replace tags: ' + text );
    console.log( ' Replace tags: ' + text );


    jsConsole.writeLine();
    jsConsole.writeLine( '--------------------------------------' );

    //jsConsole.writeLine( ' Replace tags: ' + text2 );
    //console.log( ' Replace tags: ' + text2 );


    jsConsole.writeLine();
    jsConsole.writeLine( '--------------------------------------' );

    function replaceAll( text, findText, replaceText ) {

        while ( text.indexOf( findText ) > -1 ) {
            text = text.replace( findText, replaceText );
        }

        return text;
    }


    //function replaceAllWuthRegex( text, findText, replaceText ) {


    //    text = text.replace( new RegExp( findText, 'g' ), replaceText );

    //    return text;
    //}
}



/**
Problem 9. Extract e-mails

Write a function for extracting all email addresses from given text.
All sub-strings that match the format @… should be recognized as emails.
Return the emails as array of strings.
 */

function task9() {
    jsConsole.clearConsole();

    document.getElementsByTagName( "h2" )[0].innerHTML = "Problem 9. Extract e-mails";
    document.getElementsByTagName( "p" )[1].innerHTML = "Problem 9. Extract e-mails";
    document.getElementsByTagName( "p" )[0].innerHTML = "Write a function for extracting all email addresses from given text. All sub-strings that match the format @… should be recognized as emails.    Return the emails as array of strings.";

    var text = ' Tincidunt integer eu augue augue nunc elit dolor, luctus placerat scelerisque euismod, pesho@abv.bg, iaculis eu lacus @abv,bg nunc mi elit, vehicula ut laoreet ac, ivan@mail.bg, aliquam sit amet justo nunc tempor, metus vel. gosho@gmail.com, saho11@yahoo.com';

    jsConsole.writeLine( '--------------------------------------' );

    jsConsole.writeLine( 'Parse URL: ' + getEmail( text ).join( ', ' ) );
    console.log( 'Parse URL: ' + getEmail( text ).join( ', ' ) );


    jsConsole.writeLine();
    jsConsole.writeLine( '--------------------------------------' );

    function getEmail( text ) {
        var i,
            len,
            regEx,
            pattern,
            arr = [],
            emailArr = [];

        pattern = '^([a-zA-Z0-9_\.\-])+\@(([a-zA-Z0-9\-])+\.)+([a-zA-Z0-9]{2,4})+$';

        regEx = new RegExp( pattern );
        text = text.replace( /,/gi, '' )
        arr = text.split( ' ' );

        for ( i = 0, len = arr.length; i < len; i += 1 ) {
            if ( arr[i].match( regEx ) ) {
                emailArr.push( arr[i] )
            }
        }

        return emailArr;
    }
}

/**
Problem 10. Find palindromes

Write a program that extracts from a given text all palindromes, e.g. "ABBA", "lamal", "exe".
 */

function task10() {
    jsConsole.clearConsole();

    document.getElementsByTagName( "h2" )[0].innerHTML = "Problem 10. Find palindromes";
    document.getElementsByTagName( "p" )[1].innerHTML = "Problem 10. Find palindromes";
    document.getElementsByTagName( "p" )[0].innerHTML = "Write a program that extracts from a given text all palindromes, e.g. \"ABBA\", \"lamal\", \"exe\".";

    var text = ' Tincidunt ABBA integer eu augue augue nunc elit dolor, luctus placerat scelerisque euismod, ABBA, iaculis eu lacus ABTBA nunc mi elit, vehicula ut laoreet ac, lamal, aliquam sit amet laal justo nunc tempor, metus vel, exe, exxe';

    jsConsole.writeLine( '--------------------------------------' );

    jsConsole.writeLine( 'Parse URL: ' + findPolindromes( text ) );
    console.log( 'Parse URL: ' + findPolindromes( text ) );


    jsConsole.writeLine();
    jsConsole.writeLine( '--------------------------------------' );

    function findPolindromes( text ) {
        var i,
            j,
            len,
            str,
            lenStr,
            strLen,
            arr = [],
            isPolindromes;
        polindromes = [],

    text = text.replace( /,/gi, '' )
        arr = text.split( ' ' );

        for ( i = 0, len = arr.length; i < len; i += 1 ) {
            isPolindromes = true;
            str = arr[i];
            strLen = str.length;
            lenStr = ( strLen / 2 ) | 0;

            for ( j = 0; j < lenStr; j += 1 ) {
                if ( str[j] !== str[strLen - j - 1] ) {
                    isPolindromes = false;
                    break;
                }
            }

            if ( isPolindromes && str !== '' ) {
                polindromes.push( str );
            }
        }

        return polindromes.join( ', ' );
    }
}

/**
Problem 11. String format

Write a function that formats a string using placeholders.
The function should work with up to 30 placeholders and all types.
Examples:

var str = stringFormat('Hello {0}!', 'Peter'); 
//str = 'Hello Peter!';

var frmt = '{0}, {1}, {0} text {2}';
var str = stringFormat(frmt, 1, 'Pesho', 'Gosho');
//str = '1, Pesho, 1 text Gosho'
 */

function task11() {
    jsConsole.clearConsole();

    document.getElementsByTagName( "h2" )[0].innerHTML = "Problem 11. String format";
    document.getElementsByTagName( "p" )[1].innerHTML = "Problem 11. String format";
    document.getElementsByTagName( "p" )[0].innerHTML = "Write a function that formats a string using placeholders. The function should work with up to 30 placeholders and all types.";

    var ivan = { name: 'Ivanov', age: 21, toString: function () { return 'name: ' + this.name + ' / ' + 'age: ' + this.age } };

    jsConsole.writeLine( '--------------------------------------' );

    jsConsole.writeLine( 'String format:' );
    jsConsole.writeLine( stringFormat( '{0}, {1}, {0} text {2}', 1, 'Pesho', 'Gosho' ) );
    jsConsole.writeLine( stringFormat( '{0}, {1}, {0} text {2}', 1, ivan, null ) );
    jsConsole.writeLine( stringFormat( '{0}, {1}, {0} text {2}, {3}', 1, ivan, undefined, null ) );

    console.log( 'String format:' );
    console.log( stringFormat( '{0}, {1}, {0} text {2}', 1, 'Pesho', 'Gosho' ) );
    console.log( stringFormat( '{0}, {1}, {0} text {2}', 1, ivan, null ) );
    console.log( stringFormat( '{0}, {1}, {0} text {2}, {3}', 1, ivan, undefined, null ) );


    jsConsole.writeLine();
    jsConsole.writeLine( '--------------------------------------' );


    function stringFormat() {
        var i,
            len,
            placeholder,
            args = arguments,
            str = args[0];

        for ( i = 1, len = args.length; i < len; i += 1 ) {
            placeholder = '{' + ( i - 1 ) + '}';

            while ( str.indexOf( placeholder ) > -1 ) {
                str = str.replace( placeholder, args[i] );
            }
        }
        return str;
    }
}

/**
Problem 12. Generate list

Write a function that creates a HTML <ul> using a template for every HTML <li>.
The source of the list should be an array of elements.
Replace all placeholders marked with –{…}– with the value of the corresponding property of the object.
Example: HTML:

<div data-type="template" id="list-item">
 <strong>-{name}-</strong> <span>-{age}-</span>
/div>
JavaScript:

var people = [{name: 'Peter', age: 14},…];
var tmpl = document.getElementById('list-item').innerHtml;
var peopleList = generateList(people, template);
//peopleList = '<ul><li><strong>Peter</strong> <span>14</span></li><li>…</li>…</ul>'
 */

function task12() {
    jsConsole.clearConsole();

    document.getElementsByTagName( "h2" )[0].innerHTML = "Problem 12. Generate list";
    document.getElementsByTagName( "p" )[1].innerHTML = "Problem 12. Generate list";
    document.getElementsByTagName( "p" )[0].innerHTML = "Write a function that creates a HTML <ul> using a template for every HTML &lt;li&gt;. The source of the list should be an array of elements. Replace all placeholders marked with -{...}- with the value of the corresponding property of the object.";

    var people = [
        { name: 'Pesho', age: 21 },
        { name: 'Gosho', age: 22 },
        { name: 'Sasho', age: 23 },
        { name: 'Ivan', age: 24 }
    ],
        tmpl = document.getElementById( 'list-item' ).innerHTML;

    jsConsole.writeLine( '--------------------------------------' );

    jsConsole.writeLine( 'Generate list: not display in jsConsole!' );
    console.log( 'Generate list: ' + generateList( people, tmpl ) );


    jsConsole.writeLine();
    jsConsole.writeLine( '--------------------------------------' );

    function generateList( people, tmpl ) {
        var i,
            li,
            ul = document.createElement( 'ul' );

        for ( i in people ) {
            li = document.createElement( 'li' );
            li.innerHTML = format( tmpl, people[i] );
            ul.appendChild( li );
        }
        document.body.appendChild( ul );

    };

    function format( string, person ) {
        return string.replace( /\-{(\w+)\}-/g, function ( match, prop ) {
            return person[prop] || '';
        } );
    }
}


function clearCon() {
    document.getElementsByTagName( "h2" )[0].innerHTML = "";
    document.getElementsByTagName( "p" )[0].innerHTML = "";
    document.getElementsByTagName( "p" )[1].innerHTML = "Strings!";
    jsConsole.clearConsole();

    var nodes = document.getElementsByTagName( "ul" );

    for ( var i = 0, len = nodes.length; i != len; ++i ) {
        nodes[0].parentNode.removeChild( nodes[0] );
    }
}

