/*
 function solve() {


 var CONSTS = {
 PLAYER: {
 MIN_LENGTH: 3,
 MAX_LENGTH: 25
 }
 },
 Players,
 PlayList,
 Playable,
 Audio,
 Video,
 validNameCharacters = 'qwertyuiopasdfghjklzxcvbnm' +
 'qwertyuiopasdfghjklzxcvbnm'.toUpperCase() +
 ' \'"-_.,1234567890!*';

 function isNameValid(name, min, max) {
 var result = typeof(name) === 'string' &&
 min <= name.length &&
 max >= name.length &&
 name.split('').every(function (ch) {
 return validNameCharacters.indexOf(ch) >= 0;
 });

 return result;
 }


 Players = (function () {
 var Player = {
 init: function (name) {
 if (isNameValid(name, CONSTS.PLAYER.MIN_LENGTH, CONSTS.PLAYER.MAX_LENGTH)) {
 throw{
 name: 'InvalidPlayerName',
 message: 'Name mast be between: ' +
 CONSTS.PLAYER.MIN_LENGTH + ' and ' +
 CONSTS.PLAYER.MAX_LENGTH + '.'
 }
 }
 this.name = name;
 return this;
 },
 getPlayer: function (name) {
 return Player.map(function (item) {
 return{
 name:item.name
 }
 }).slice();

 /!*return Object.create(Player)
 .init(name);*!/
 },
 addPlaylist: function (playlistToAdd) {
 if (!playlistToAdd.isPrototypeOf(PlayList)) {
 {
 throw new Error('playlistToAdd is not istance of PlayList')
 }
 }

 this.PlayList.push(playlistToAdd);
 return this;
 }

 ,
 getPlaylistById: function (id) {

 }
 ,
 removePlaylist: function (id) {

 }
 ,
 removePlaylist: function (playlist) {

 }
 ,
 listPlaylists: function (page, size) {

 }
 ,
 get PlayList() {
 if (typeof(this._PlayList) === 'undefined') {
 this._PlayList = [];
 }

 return this._PlayList;
 }

 };

 return {
 get: function (name) {
 return Object.create(Player)
 .init(name);
 }
 };
 }());

 PlayList = (function () {
 var playList = {
 init: function (id, name) {
 this.id = id;
 this.name = name;
 return this;
 },
 addPlayable: function (playable) {

 },
 getPlayableById: function (id) {

 },
 removePlayable: function (id) {

 },
 removePlayable: function (playable) {

 },
 listPlaylables: function (page, size) {

 }
 };

 return {
 get: function (id, name) {
 return Object.create(PlayList)
 .init(id, name);
 }
 }
 }());

 Playable = (function () {
 var ID = 1,
 Playable = {
 get id() {
 if (this.id === 'undefined') {
 this.id = ID;
 ID += 1;
 }

 return this._id;
 },
 set id(value) {
 this._id = value;
 },
 get title() {
 return this._title;
 },
 set title(value) {
 this._title = value;
 },
 get author() {
 return this._author;
 },
 set author(value) {
 this._author = value;
 },
 init: function (id, title, author) {
 if (isNameValid(title, CONSTS.PLAYER.MIN_LENGTH, CONSTS.PLAYER.MAX_LENGTH)) {
 throw{
 name: 'InvalidTaitle',
 message: 'Title mast be between: ' +
 CONSTS.PLAYER.MIN_LENGTH + ' and ' +
 CONSTS.PLAYER.MAX_LENGTH + '.'
 }
 }

 if (isNameValid(author, CONSTS.PLAYER.MIN_LENGTH, CONSTS.PLAYER.MAX_LENGTH)) {
 throw{
 name: 'InvalidAuthor',
 message: 'Author mast be between: ' +
 CONSTS.PLAYER.MIN_LENGTH + ' and ' +
 CONSTS.PLAYER.MAX_LENGTH + '.'
 }
 }

 this.id = id;
 this.title = title;
 this.author = author;
 return this;
 },
 play: function () {
 return '[' + this.id + ']. [' + this.title + '] - [' + this.author + ']';
 }
 };

 return Playable;
 }());

 Audio = (function (parent) {
 var Audio = Object.create(parent, {
 length: {
 get: function () {
 return this._length;
 },
 set: function (value) {
 this._length = value;
 },
 enumerable: true,
 configurable: true
 },
 init: {
 value: function (id, title, author, length) {
 parent.init.call(this, id, title, author);
 this.length = length;
 return this;
 },
 enumerable: true,
 configurable: true,
 writable: true
 },


 play: {
 value: function () {
 var baseResult = parent.play.call(this);
 return baseResult + ' - [' + this.length + ']';
 },
 enumerable: true,
 configurable: true,
 writable: true
 }
 });

 return Audio;
 }(Playable));

 Video = (function (parent) {
 var Video = Object.create(parent, {
 imdbRating: {
 get: function () {
 return this._imdbRating;
 },
 set: function (value) {
 this._imdbRating = value;
 },
 enumerable: true,
 configurable: true
 },
 init: {
 value: function (id, title, author, imdbRating) {
 parent.init.call(this, id, title, author);
 this.imdbRating = imdbRating;
 return this;
 },
 enumerable: true,
 configurable: true,
 writable: true
 },


 play: {
 value: function () {
 var baseResult = parent.play.call(this);
 return baseResult + ' - [' + this.imdbRating + ']';
 },
 enumerable: true,
 configurable: true,
 writable: true
 }
 });

 return Video;
 }(Playable));

 var module=(function(){
 return {
 getPlayer: function (name) {
 return Object.create(Players)
 .init(name);
 },
 getPlaylist: function (name) {
 return Object.create(PlayList)
 .init(name); //returns a new playlist instance with the provided name
 },
 getAudio: function (title, author, length) {
 return Object.create(Audio)
 .init(name);  //returns a new audio instance with the provided title, author and length
 },
 getVideo: function (title, author, imdbRating) {
 return Object.create(Video)
 .init(name); //returns a new video instance with the provided title, author and imdbRating
 }
 }
 }());



 return {
 player: Players,
 Playlist: PlayList,
 Playeble: Playable,
 Audio: Audio,
 Video: Video,
 getPlayer:Players.getPlayer
 }

 };


 module.exports = solve;


 var result = require('../tasks/task-1')();
 console.log(result);
 //console.log(result.Player.get());*/


function solve() {
    var module = (function () {
        var player,
            playlist,
            playable,
            audio,
            video,
            validator,
            CONSTANTS = {
                TEXT_MIN_LENGTH: 3,
                TEXT_MAX_LENGTH: 25,
                IMDB_MIN_LENGTH: 1,
                IMDB_MAX_LENGHT: 5,
                MAX_NUMBER: 9007199254740991
            };

        function indexOfElementWithIdInCollection(collection, id) {
            var i,
                len;
            for (i = 0, len = collection.length; i < len; i += 1) {
                if (collection[i].id === id) {
                    return i;
                }
            }

            return -1;
        }

        function getSortingFunction(firstParameter, secondParameter) {
            return function (first, second) {
                if (first[firstParameter] < second[firstParameter]) {
                    return -1;
                } else if (first[firstParameter] > second[firstParameter]) {
                    return 1;
                }

                if (first[secondParameter] < second[secondParameter]) {
                    return -1;
                } else if (first[secondParameter] > second[secondParameter]) {
                    return 1;
                } else {
                    return 0;
                }
            }
        }

        validator = {
            validateIfUndefined: function (val, name) {
                name = name || 'Value';
                if (val === undefined) {
                    throw new Error(name + ' cannot be undefined')
                }
            },
            validateIfNumber: function (val, name) {
                name = name || 'Value';
                if (typeof val !== 'number') {
                    throw new Error(name + ' must be a number');
                }
            },
            validateIfObject: function (val, name) {
                name = name || 'Value';
                if (typeof val !== 'object') {
                    throw new Error(name + ' must be object');
                }
            },
            validateString: function (val, name) {
                name = name || 'Value';
                this.validateIfUndefined(val, name);

                if (typeof val !== 'string') {
                    throw new Error(name + ' must be a string')
                }

                if (val.length < CONSTANTS.TEXT_MIN_LENGTH || CONSTANTS.TEXT_MAX_LENGTH < val.length) {
                    throw new Error(name + ' must be between ' +
                        CONSTANTS.TEXT_MIN_LENGTH + ' and ' + CONSTANTS.TEXT_MAX_LENGTH + 'symbols');
                }
            },
            validatePositiveNumber: function (val, name) {
                name = name || 'Value';
                this.validateIfUndefined(val, name);
                this.validateIfNumber(val, name);

                if (val <= 0) {
                    throw  new Error(name + ' must be positive number');
                }
            },
            validateimdbRating: function (val, name) {
                name = name || 'Value';
                this.validateIfUndefined(val, name);
                this.validateIfNumber(val, name);

                if (val < CONSTANTS.IMDB_MIN_LENGTH || val > CONSTANTS.IMDB_MAX_LENGHT) {
                    throw new Error(name + ' must be between ' +
                        CONSTANTS.IMDB_MIN_LENGTH + ' and ' +
                        CONSTANTS.IMDB_MAX_LENGHT + ' number')
                }
            },
            validateId: function (id) {
                this.validateIfUndefined(id, 'Object id');
                if (typeof id !== 'number') {
                    id = id.id;
                }

                this.validateIfUndefined(id, 'Object mast have id');
                return id;
            },
            validatePageAndSize: function (page, size, maxElements) {
                this.validateIfUndefined(page);
                this.validateIfUndefined(size);
                this.validateIfNumber(page);
                this.validateIfNumber(size);

                if (page < 0) {
                    throw new Error('Page must be greater than or equal to 0');
                }

                this.validatePositiveNumber(size, 'Size');

                if (page * size > maxElements) {
                    throw new Error('Page * size will not return any elements from collection');

                }
            }
        };

        player = (function () {
            var currentPlayerId = 0,
                player = Object.create({});

            Object.defineProperty(player, 'init', {
                value: function (name) {
                    this.name = name;
                    this._id = ++currentPlayerId;
                    this._playlists = [];
                    return this;
                }
            });

            Object.defineProperty(player, 'id', {
                get: function () {
                    return this._id;
                }
            });

            Object.defineProperty(player, 'name', {
                get: function () {
                    return this._name;
                },
                set: function (value) {
                    validator.validateString(value, 'Player name');
                    this._name = value;
                }
            });

            Object.defineProperty(player, 'addPlaylist', {
                value: function (playlist) {
                    validator.validateIfUndefined(playlist, 'Player add playlist parameter');
                    if (playlist.id === undefined) {
                        throw new Error('Player add playlist parameter must have id');
                    }

                    this._playlists.push(playlist);
                    return this;
                }
            });

            Object.defineProperty(player, 'getPlaylistById', {
                value: function (id) {
                    validator.validateIfUndefined(id, 'Player get playlist parameter id');
                    validator.validateIfNumber(id, 'Player get playlist parameter id'
                    );

                    var foundIndex = indexOfElementWithIdInCollection(this._playlists, id);
                    if (foundIndex < 0) {
                        return null;
                    }

                    return this._playlists[foundIndex];
                }
            });

            Object.defineProperty(player, 'removePlaylist', {
                value: function (id) {
                    id = validator.validateId(id);
                    validator.validateIfNumber(id, 'Remove playlist in player by id');

                    var foundIndex = indexOfElementWithIdInCollection(this._playlists, id);
                    if (foundIndex < 0) {
                        throw new Error('Playlist with id ' + id + ' was not found in playlist');
                    }

                    this._playlists.splice(foundIndex, 1);
                    return this;
                }
            });

            Object.defineProperty(player, 'listPlaylists', {
                value: function (page, size) {
                    page = page || 0;
                    size = size || CONSTANTS.MAX_NUMBER;
                    validator.validatePageAndSize(page, size, this._playlists.length);

                    return this._playlists
                        .slice()
                        .sort(getSortingFunction('name', 'id'))
                        .splice(page * size, size);
                }
            });

            Object.defineProperty(player, 'contains', {
                value: function (playable, playlist) {
                    validator.validateIfUndefined(playable);
                    validator.validateIfUndefined(playlist);
                    var playableId = validator.validateId(playable.id);
                    var playlistId = validator.validateId(playlist.id);

                    var playlist = this.getPlaylistById(playlistId);
                    if (playlist === null) {
                        return false;
                    }

                    var playable = playlist.getPlaylistById(playableId);
                    if (playable === null) {
                        return false;
                    }

                    return true;
                }
            });

            Object.defineProperty(player, 'search', {
                value: function (pattern) {
                    validator.validateString(pattern, 'Search pattern');

                    return this._playlists
                        .filter(function (playlist) {
                            return playlist
                                .listPlayables()
                                .some(function (playable) {
                                    return playable.length !== undefined
                                        && playable
                                            .title
                                            .toLowerCase()
                                            .indexOf(pattern.toLowerCase()) >= 0;
                                });
                        })
                        .map(function (playlist) {
                            return {
                                id: playlist.id,
                                name: playlist.name
                            }
                        });
                }
            });

            return player;
        }());


        playlist = (function () {
            var currentPlaylistId = 0,
                playlist = Object.create({});

            Object.defineProperty(playlist, 'init', {
                value: function (name) {
                    this.name = name;
                    this._id = ++currentPlaylistId;
                    this._playables = [];
                    return this;
                }
            });

            Object.defineProperty(playlist, 'id', {
                get: function () {
                    return this._id;
                }
            });

            Object.defineProperty(playlist, 'name', {
                get: function () {
                    return this._name;
                },
                set: function (value) {
                    validator.validateString(value, 'Playlist name');
                    this._name = value;
                }
            });

            Object.defineProperty(playlist, 'addPlayable', {
                value: function (playable) {
                    validator.validateIfUndefined(playable, 'Playlist add playable parameter');
                    validator.validateIfObject(playable, 'Playlist add playable parameter');
                    validator.validateIfUndefined(playable.id, 'Playlist add playable parameter');
                    this._playables.push(playable);
                    return this;
                }
            });

            Object.defineProperty(playlist, 'getPlayableById', {
                value: function (id) {
                    validator.validateIfUndefined(id, 'Playlist get playable parameter id');
                    validator.validateIfNumber(id, 'Playlist get playable parameter id');

                    var foundIndex = indexOfElementWithIdInCollection(this._playables, id);
                    if (foundIndex < 0) {
                        return null;
                    }

                    return this._playables[foundIndex];
                }
            });

            Object.defineProperty(playlist, 'removePlayable', {
                value: function (id) {
                    id = validator.validateId(id);
                    var foundIndex = indexOfElementWithIdInCollection(this._playables, id);

                    if (foundIndex < 0) {
                        throw new Error('Playable with id ' + id + ' was not found in playlist');
                    }

                    this._playables.splice(foundIndex, 1);
                    return this;
                }
            });

            Object.defineProperty(playlist, 'listPlayables', {
                value: function (page, size) {
                    page = page || 0;
                    size = size || CONSTANTS.MAX_NUMBER;
                    validator.validatePageAndSize(page, size, this._playables.length);

                    return this
                        ._playables
                        .slice()
                        .sort(getSortingFunction('title', 'id'))
                        .splice(page * size, size);
                }
            });

            return playlist;
        }());

        playable = (function () {
            var currentPlayableId = 0,
                playable = Object.create({});

            Object.defineProperty(playable, 'init', {
                value: function (title, author) {
                    this.title = title;
                    this.author = author;
                    this._id = ++currentPlayableId;
                    return this;
                }
            });

            Object.defineProperty(playable, 'id', {
                get: function () {
                    return this._id;
                }
            });

            Object.defineProperty(playable, 'title', {
                get: function () {
                    return this._title;
                },
                set: function (value) {
                    validator.validateString(value, 'Playable title');
                    this._title = value;
                }
            });

            Object.defineProperty(playable, 'author', {
                get: function () {
                    return this._author;
                },
                set: function (value) {
                    validator.validateString(value, 'Playable author');
                    this._author = value;
                }
            });

            Object.defineProperty(playable, 'play',
                {
                    value: function () {
                        return this.id + '. ' + this.title + ' - ' + this.author;
                    }
                });

            return playable;
        }());

        audio = (function (parent) {
            var audio = Object.create(parent);

            Object.defineProperty(audio, 'init', {
                value: function (title, author, length) {
                    parent.init.call(this, title, author);
                    this.length = length;
                    return this;
                }
            });

            Object.defineProperty(playable, 'length', {
                get: function () {
                    return this._length;
                },
                set: function (value) {
                    validator.validatePositiveNumber(value, 'Audio length');
                    this._length = value;
                }
            });
            Object.defineProperty(audio, 'play', {
                value: function () {
                    var baseResult = parent.play.call(this);
                    return baseResult + ' - ' + this.length;
                }
            });

            return audio;
        }(playable));

        video = (function (parent) {
            var video = Object.create(parent);

            Object.defineProperty(video, 'init', {
                value: function (title, author, imdbRating) {
                    parent.init.call(this, title, author);
                    this.imdbRating = imdbRating;
                    return this;
                }
            });

            Object.defineProperty(video, 'imdbRating', {
                get: function () {
                    return this._imdbRating;
                },
                set: function (value) {
                    validator.validateimdbRating(value, 'IMDB Rating');
                    this._imdbRating = value;
                }
            });

            Object.defineProperty(video, 'play', {
                value: function () {
                    var baseResult = parent.play.call(this);
                    return baseResult + ' - ' + this.imdbRating;
                }
            });

            return video;
        }(playable));

        return {
            getPlayer: function (name) {
                return Object.create(player).init(name);// returns a new player instance with the provided name
            },
            getPlaylist: function (name) {
                return Object.create(playlist).init(name);//returns a new playlist instance; with the provided name
            },
            getAudio: function (title, author, length) {
                return Object.create(audio).init(title, author, length); //returns a new audio instance with the provided title, author and length
            },
            getVideo: function (title, author, imdbRating) {
                return Object.create(video).init(title, author, imdbRating)//returns a new video instance with the provided title, author and imdbRating
            }
        }
    }());

    return module;
}


var module1 = solve();

/*
 var playlist = module1.getPlaylist('My playlist');

 for (var i = 1; i < 10; i += 1) {
 var currentAudio = module1.getAudio('Audio' + i, 'Author' + i, i);
 playlist.addPlayable(currentAudio);
 }

 for (var i = 0; i < 10; i += 1) {
 var currentVideo = module1.getVideo('Video' + i, 'Author' + i, 3.5);
 playlist.addPlayable(currentVideo);
 }

 console.log(playlist.listPlayables(0, 3));
 */

var player = module1.getPlayer('Pesho');
var playlist = module1.getPlaylist('Gosho');
player.addPlaylist(playlist);
var audio = module1.getAudio('Ivan', 'Ivanov', 4);
playlist.addPlayable(audio);

console.log(player.search('van'));

module.exports = solve;