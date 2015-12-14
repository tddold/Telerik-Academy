function Solve() {
    var module = (function () {
        var item,
            book,
            catalog,
            media,
            bookCatalog,
            mediaCatalog,
            validator,
            CONSTANTS = {
                TEXT_MIN_LENGTH: 2,
                TEXT_MAX_LENGTH: 40,
                ISBN_MIN_LENGTH: 10,
                ISBN_MAX_LENGHT: 13,
                GENRE_MIN_LENGTH: 2,
                GENRE_MAX_LENGHT: 20,
                DIGITS: '1234567890',
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
            validateString: function (type, val, name) {
                name = name || 'Value';
                this.validateIfUndefined(val, name);

                if (typeof val !== 'string') {
                    throw new Error(name + ' must be a string')
                }

                if (type === 'name') {
                    if (val.length < CONSTANTS.TEXT_MIN_LENGTH || CONSTANTS.TEXT_MAX_LENGTH < val.length) {
                        throw new Error(name + ' must be between ' +
                            CONSTANTS.TEXT_MIN_LENGTH + ' and ' + CONSTANTS.TEXT_MAX_LENGTH + 'symbols');
                    }
                } else if (type === 'isbn') {
                    if (val.length < CONSTANTS.ISBN_MIN_LENGTH || CONSTANTS.ISBN_MAX_LENGHT < val.length) {
                        throw new Error(name + ' must be between ' +
                            CONSTANTS.ISBN_MIN_LENGTH + ' and ' + CONSTANTS.ISBN_MAX_LENGHT + 'symbols');
                    }
                } else if (type === 'genre') {
                    if (val.length < CONSTANTS.GENRE_MIN_LENGTH || CONSTANTS.GENRE_MAX_LENGHT < val.length) {
                        throw new Error(name + ' must be between ' +
                            CONSTANTS.GENRE_MIN_LENGTH + ' and ' + CONSTANTS.GENRE_MAX_LENGHT + 'symbols');
                    }
                }


            },
            validateDigits: function (val, name) {
                var result = val.split('').every(function (ch) {
                    return CONSTANTS.DIGITS.indexOf(ch) >= 0;
                });

                if (!result) {
                    throw  new Error(name + ' mast be only digits.')
                }
            },
            validatePositiveNumber: function (val, name) {
                name = name || 'Value';
                this.validateIfUndefined(val, name);
                this.validateIfNumber(val, name);

                if (val < 0) {
                    throw  new Error(name + ' must be positive number and greater than 0');
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
            validateItem: function (id) {
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

        item = (function () {
            var currIndex = 0,
                item = Object.create({});

            Object.defineProperty(item, 'init', {
                value: function (name, description) {
                    this.name = name;
                    this._id = currIndex += 1;
                    this.description = description;
                    return this;
                }
            });

            Object.defineProperty(item, 'id', {
                get: function () {
                    return this._id;
                }
            });

            Object.defineProperty(item, 'name', {
                get: function () {
                    return this._name;
                },
                set: function (value) {
                    validator.validateString('name', value, 'Item name');
                    this._name = value;
                }
            });

            Object.defineProperty(item, 'description', {
                get: function () {
                    return this._description;
                },
                set: function (value) {
                    validator.validateIfUndefined(value, 'Item description');

                    if (typeof value !== 'string' || value === '') {
                        throw new Error('Item description must be a string')
                    }
                    this._description = value;
                }
            });

            return item;
        }());

        book = (function (parent) {
            var book = Object.create(parent);

            Object.defineProperty(book, 'init', {
                value: function (name, discription, isbn, genre) {
                    parent.init.call(this, name, discription);
                    this.isbn = isbn;
                    this.gener = genre;
                    return this;
                }
            });

            Object.defineProperty(book, 'isbn', {
                get: function () {
                    return this._isbn;
                },
                set: function (value) {
                    validator.validateString('isbn', value, 'ISBN');
                    validator.validateDigits(value, 'ISBN digits');
                    this._isbn = value;
                }
            });

            Object.defineProperty(book, 'genre', {
                get: function () {
                    return this._genre;
                },
                set: function (value) {
                    validator.validateString('genre', value, 'ISBN');
                    this._genre = value;
                }
            });

            return book;
        }(item));

        media = (function (parent) {
            var media = Object.create(parent);

            Object.defineProperty(media, 'init', {
                value: function (name, description, duration, rating) {
                    parent.init.call(tis, name, description);
                    this.duration = duration;
                    this.rating = rating;
                    return this;
                }
            });

            Object.defineProperty(media, 'duration', {
                get: function () {
                    return this._duration;
                },
                set: function (value) {
                    validator.validatePositiveNumber(value, 'Duration');
                    this._duration = value;
                }
            });

            Object.defineProperty(media, 'rating', {
                get: function () {
                    return this._rating;
                },
                set: function (value) {
                    validator.validatePositiveNumber(value, 'Rating');
                    if (value < 1 || value > 5) {
                        throw new Error('Rating must be between 1 and 5');
                    }

                    this._rating = value;
                }
            });

            return media;
        }(item));

        catalog = (function () {
            var currIndex = 0,
                catalog = Object.create({});

            Object.defineProperty(catalog, 'init', {
                value: function (name) {
                    this.name = name;
                    this._id = currIndex += 1;
                    this._items = [];
                    return this;
                }
            });

            Object.defineProperty(catalog, 'id', {
                get: function () {
                    return this._id;
                }
            });

            Object.defineProperty(catalog, 'name', {
                get: function () {
                    return this._name;
                },
                set: function (value) {
                    validator.validateString('name', value, 'Catalog name');
                    return this._name = value;
                }
            });

            Object.defineProperty(catalog, 'add', {
                value: function (item) {
                    validator.validateIfUndefined(item, 'Catalog add item parameter');
                    //item = validator.validateId(item);
                   //
                   /* if (item.id === undefined) {
                        throw new Error('Catalog add item parameter must have id');
                    }*/

                    this._items.push(item);
                    return this;
                }
            });

            Object.defineProperty(catalog, 'find', {
                value: function (id) {
                    validator.validateIfUndefined(id, 'Find item by id');
                    validator.validateIfNumber(id, 'Find item by id'
                    );

                    var foundIndex = indexOfElementWithIdInCollection(this._items, id);
                    if (foundIndex < 0) {
                        return null;
                    }

                    return this._items[foundIndex];
                }
            });

            Object.defineProperty(catalog, 'search', {
                value: function (pattern) {
                    validator.validateString(pattern, 'Search pattern');

                    return this._items
                        .filter(function (item) {
                            return item
                                .find()
                                .some(function (item) {
                                    return item
                                            .name
                                            .toLowerCase()
                                            .indexOf(pattern.toLowerCase()) >= 0 ||
                                        item.
                                            description
                                            .toLowerCase()
                                            .indexOf(pattern.toLowerCase()) >= 0;
                                });
                        })
                        .map(function (item) {
                            return {
                                name: item.name,
                                description: item.description
                            }
                        });
                }
            });

            return catalog;
        }());

        bookCatalog = (function (parent) {
            var bookCatalog = Object.create(parent);

            Object.defineProperty(bookCatalog, 'init', {
                value: function (name) {
                    parent.init.call(this, name)
                }
            });

            Object.defineProperty(bookCatalog, 'add', {
                value: function (book) {
                    validator.validateIfUndefined(book, 'Catalog add item parameter');
                    //book = validator.validateId(book);

                    this._items.push(book);
                    return this;
                }
            });

            Object.defineProperty(bookCatalog, 'getGenres', {
                value: function () {
                    return this._items.filter(function (item) {
                        var foundIndex = indexOfElementWithIdInCollection(this._items, item);
                        if (foundIndex < 0) {
                            return null;
                        }

                        return this._items[foundIndex];
                    }).map(function (item) {
                        return item.toLowerCase();
                    });
                }
            });

            Object.defineProperty(bookCatalog, 'find', {
                value: function () {
                    var baseResult = parent.find.call(this)
                    result;
                    result = baseResult + this.gener;
                    return result;

                }
            });

            return bookCatalog;
        }(catalog));

        mediaCatalog = (function (parent) {
            var mediaCatalog = Object.create(parent);

            Object.defineProperty(mediaCatalog, 'init', {
                value: function (name) {
                    parent.init.call(this, name)
                }
            });

            Object.defineProperty(mediaCatalog, 'add', {
                value: function (media) {
                    validator.validateIfUndefined(media, 'Book add item parameter');
                    //book = validator.validateId(media);


                    this._items.push(media);
                    return this;
                }
            });

            Object.defineProperty(mediaCatalog, 'getTop', {
                value: function (count) {
                    // TO DO
                }
            });

            Object.defineProperty(mediaCatalog, 'getSortedByDuration', {
                value: function () {
                    // TO DO
                }
            });

            return mediaCatalog;
        }(catalog));


        return {
            getBook: function (name, isbn, genre, description) {
                return Object.create(book)
                    .init(name,description,  isbn, genre );
                //return a book instance
            },
            getMedia: function (name, rating, duration, description) {
                return Object.create(media)
                    .init(name,description, rating, duration );
                //return a media instance
            },
            getBookCatalog: function (name) {
                return Object.create(bookCatalog)
                    .init(name);
                //return a book catalog instance
            },
            getMediaCatalog: function (name) {
                return Object.create(mediaCatalog)
                    .init(name);
                //return a media catalog instance
            }
        }
    }());

    return module;
}

var module = Solve();
var catalog = module.getBookCatalog('John\'s catalog');

var book1 = module.getBook('The secrets of the JavaScript Ninja', '1234567890', 'IT', 'A book about JavaScript');
var book2 = module.getBook('JavaScript: The Good Parts', '0123456789', 'IT', 'A good book about JS');

console.log(book.getBookCatalog(book1));
catalog.add(book1);
catalog.add(book2);

console.log(catalog.find(book1.id));
//returns book1

console.log(catalog.find({id: book2.id, genre: 'IT'}));
//returns book2

console.log(catalog.search('js'));
// returns book2

console.log(catalog.search('javascript'));
//returns book1 and book2

console.log(catalog.search('Te sa zeleni'))
//returns []
