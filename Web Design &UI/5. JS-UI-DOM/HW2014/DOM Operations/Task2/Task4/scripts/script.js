/*Create a tag cloud:
Visualize a string of tags (strings) in a given container
By given minFontSize and maxFontSize, generate the tags with different font-size, depending on the number of occurrences
*/


var tags,
    tagCloud;

tags = ["cms", "javascript", "js", "ASP.NET MVC", ".net", ".net", "css", "wordpress", "xaml", "js", "http", "web", "asp.net", "asp.net MVC", "ASP.NET MVC", "wp", "javascript", "js", "cms", "html", "javascript", "http", "http", "CMS"]

tagCloud = generateTagCloud(tags, 17, 42);

function generateTagCloud(tags, miniFontSize, maxFontSize) {
    var dictionary,
        frag;

    dictionary = makeDictionary(tags);
    frag = document.createDocumentFragment();

    document.body.appendChild(frag);
}

function makeDictionary(collections) {
    var i,
        len,
        currentTag,
        dictionary = {};

    len = collections.length;

    for (i = 0; i < len; i += 1) {
        currentTag = collections[i];

        if (!dictionary[currentTag]) {
            dictionary[currentTag] = 0;
        }

        dictionary[currentTag] += 1;
    }

    return dictionary;
}
