"use strict";

let phones,
    tablets,
    wearables;

phones = [
    {
        manufacturer: 'Samsung',
        model: 'Galaxy Note 4',
        capacity: '32GB',
        display: '5.7-inch',
        price: 800,
        src:'http://cdn2.gsmarena.com/vv/pics/samsung/samsung-galaxy-note-4-1.jpg'
    }, {
        manufacturer: 'Apple',
        model: 'IPhone 6s',
        capacity: '16GB',
        display: '4.7-inch',
        price: 1300,
        src:'http://cdn2.gsmarena.com/vv/pics/apple/apple-iphone-6s-1.jpg'
    },
    {
        manufacturer: 'Nokia',
        model: 'Lumia 950XL',
        capacity: '32GB',
        display: '5.7-inch',
        price: 1100,
        src:'http://cdn2.gsmarena.com/vv/pics/apple/apple-iphone-6-plus-1.jpg'
    },
    {
        manufacturer: 'Samsung',
        model: 'Galaxy 6s edge+',
        capacity: '32GB',
        display: '5.7-inch',
        price: 1200,
        src:'http://cdn2.gsmarena.com/vv/pics/samsung/samsung-galaxy-s6-edge-plus-5.jpg'
    }
];

tablets = [
    {
        manufacturer: 'Sony',
        model: 'Xperia Z4',
        capacity: '32GB',
        display: '10.1-inch',
        price: 900,
        src:'http://cdn2.gsmarena.com/vv/pics/sony/-sony-xperia-z4-tablet-1.jpg'
    },  {
        manufacturer: 'Apple',
        model: 'iPad Air2',
        capacity: '16GB',
        display: '9.7-inch',
        price: 1100,
        src:'http://cdn2.gsmarena.com/vv/pics/apple/apple-ipad-air-2-1.jpg'
    },{
        manufacturer: 'Samsung',
        model: 'Galaxy Tab S2',
        capacity: '32GB',
        display: '9.7-inch',
        price: 1300,
        src:'http://cdn2.gsmarena.com/vv/pics/samsung/samsung-galaxy-tab-s2-97-1.jpg'
    },{
        manufacturer: 'Microsoft',
        model: 'Surface 2',
        capacity: '32GB',
        display: '10.6-inch',
        price: 1400,
        src:'http://cdn2.gsmarena.com/vv/pics/microsoft/surface-2-00.jpg'
    }
];

wearables = [
    {
        manufacturer: 'Samsung',
        model: 'Gear S2',
        capacity: '4GB',
        display: '1.2-inch',
        price: 300,
        src:'http://cdn2.gsmarena.com/vv/pics/samsung/samsung-gear-s2-0.jpg'
    },{
        manufacturer: 'Sony',
        model: 'SmartWatch 3',
        capacity: '4GB',
        display: '1.6-inch',
        price: 400,
        src:'http://cdn2.gsmarena.com/vv/pics/sony/sony-smartwatch-3-swr50-0.jpg'
    },{
        manufacturer: 'Apple',
        model: 'Watch Edition',
        capacity: '8GB',
        display: '1.65-inch',
        price: 500,
        src:'http://cdn2.gsmarena.com/vv/pics/apple/apple-watch-edition-42mm.jpg'
    },{
        manufacturer: 'LG',
        model: 'G Watch R',
        capacity: '4GB',
        display: '1.3-inch',
        price: 300,
        src:'http://cdn2.gsmarena.com/vv/pics/lg/lg-g-watch-r-w110.jpg'
    }
];


module.exports = {
    phones,
    tablets,
    wearables
};