window.onload = function () {
    'use strict'
    var paper,
        rect,
        circle,
        set,
        scorePaper,
        textTitle,
        textPlayerWithBestResult,
        textScore,
        scoreBoard,
        score,
        textName,
        player;

    paper = new Raphael(document.getElementById('svg-scoreBoard'), 500, 500);

    player = Object.create({});
    player = {
        name: 'Pesho',
        score: 25
    }


    scoreBoard = paper.path("m106.405,450.17001l0,-172.25647l0,0c0,-7.31726 8.44905,-13.24353 18.875,-13.24353l226.5,0c10.42365,0 18.875,5.92627 18.875,13.24353c0,7.32373 -8.45135,13.25647 -18.875,13.25647l-18.875,0l0,172.25c0,7.31726 -8.44885,13.25 -18.875,13.25l-226.5,0l0,0c-10.42365,0 -18.875,-5.93274 -18.875,-13.25c0,-7.31726 8.45135,-13.25 18.875,-13.25l18.875,0zm37.75,-185.5l0,0c10.42365,0 18.875,5.92627 18.875,13.24353c0,7.32373 -8.45135,13.25647 -18.875,13.25647c-5.21182,0 -9.4375,-2.9696 -9.4375,-6.625c0,-3.66187 4.22568,-6.63147 9.4375,-6.63147l18.875,0m188.75,13.25647l-207.625,0m-37.75,159l0,0c5.21182,0 9.4375,2.96313 9.4375,6.625c0,3.6554 -4.22568,6.625 -9.4375,6.625l18.875,0m-18.875,13.25l0,0c10.42365,0 18.875,-5.93274 18.875,-13.25l0,-13.25");
    scoreBoard.attr({
        'opacity': 0.75,
        'stroke-linecap': null,
        'troke-linejoin': null,
        'stroke-width': 5,
        stroke: "#000000",
        fill: "#aaff56"
    })



    textTitle = paper.text(200, 310, 'Air Difence');
    textTitle.attr({
        fill: "#000000",
        stroke: "#000000",
        'xml:space': "preserve",
        opacity: 0.75,
        'font-family': "Cursive",
        'font-size': 30,
        'font-weight': "bold",
        'text-anchor ': "middle",
        'stroke-linecap': "round",
        'stroke-linejoin': "bevel",
        'stroke-dasharray ': 5.5
    })

    textPlayerWithBestResult = paper.text(170, 360, 'Best result:');
    textPlayerWithBestResult.attr({
        fill: "#000000",
        stroke: "#000000",
        'xml:space': "preserve",
        opacity: 0.75,
        'font-family': "Cursive",
        'font-size': 20,
        'font-weight': "bold",
        'text-anchor ': "middle",
        'stroke-linecap': "round",
        'stroke-linejoin': "bevel",
        'stroke-dasharray ': 5.5
    })

    textName = paper.text(260, 360, player.name);
    textName.attr({
        fill: "#000000",
        stroke: "#000000",
        'xml:space': "preserve",
        opacity: 0.75,
        'font-family': "Cursive",
        'font-size': 20,
        'font-weight': "bold",
        'text-anchor ': "middle",
        'stroke-linecap': "round",
        'stroke-linejoin': "bevel",
        'stroke-dasharray ': 5.5
    })

    textScore = paper.text(145, 420, 'Score:');
    textScore.attr({
        fill: "#000000",
        stroke: "#000000",
        'xml:space': "preserve",
        opacity: 0.75,
        'font-family': "Cursive",
        'font-size': 20,
        'font-weight': "bold",
        'text-anchor ': "middle",
        'stroke-linecap': "round",
        'stroke-linejoin': "bevel",
        'stroke-dasharray ': 5.5
    })

    score = paper.text(200, 420, player.score);
    score.attr({
        fill: "#000000",
        stroke: "#000000",
        'xml:space': "preserve",
        opacity: 0.75,
        'font-family': "Cursive",
        'font-size': 20,
        'font-weight': "bold",
        'text-anchor ': "middle",
        'stroke-linecap': "round",
        'stroke-linejoin': "bevel",
        'stroke-dasharray ': 5.5
    })


    var anim = Raphael.animation({ cx: 150, cy: 250 }, 2e3);

    score.animate(anim.delay(500));

    //rect = paper.rect(125, 75, 185, 95);
    //rect.attr({
    //    fill: '#add8e6',
    //    stroke: '#800080',
    //    'stroke-width': 5
    //})

    //circle = paper.circle(80, 80, 80);
    //circle.attr({
    //    fill: '#90ee90',
    //    stroke: '#008000',
    //    'stroke-width': 3
    //})


    //paper.setStart();
    //paper.circle(375, 85, 75);
    //paper.rect(360, 185, 75, 45);
    //paper.text(400, 300, 'This is the text');
    ////set = setFinish();


    //function animFrame() {
    //    rect.rotate(25, 170, 140);


    //    rect.rotate(10, 170, 140);

    //    requestAnimationFrame(animFrame);

    //}

    //animFrame()

    //scorePaper = paper.rect(21, 73, 314, 136);
    //scorePaper.attr({
    //    fill: '#7fff00',
    //    stroke: 'ff00ff',
    //    'stroke-width': 5
    //})

    //<path id="svg_3" d="m106.405,450.17001l0,-172.25647l0,0c0,-7.31726 8.44905,-13.24353 18.875,-13.24353l226.5,0c10.42365,0 18.875,5.92627 18.875,13.24353c0,7.32373 -8.45135,13.25647 -18.875,13.25647l-18.875,0l0,172.25c0,7.31726 -8.44885,13.25 -18.875,13.25l-226.5,0l0,0c-10.42365,0 -18.875,-5.93274 -18.875,-13.25c0,-7.31726 8.45135,-13.25 18.875,-13.25l18.875,0zm37.75,-185.5l0,0c10.42365,0 18.875,5.92627 18.875,13.24353c0,7.32373 -8.45135,13.25647 -18.875,13.25647c-5.21182,0 -9.4375,-2.9696 -9.4375,-6.625c0,-3.66187 4.22568,-6.63147 9.4375,-6.63147l18.875,0m188.75,13.25647l-207.625,0m-37.75,159l0,0c5.21182,0 9.4375,2.96313 9.4375,6.625c0,3.6554 -4.22568,6.625 -9.4375,6.625l18.875,0m-18.875,13.25l0,0c10.42365,0 18.875,-5.93274 18.875,-13.25l0,-13.25" opacity="0.75" stroke-linecap="null" stroke-linejoin="null" stroke-width="5" stroke="#000000" fill="#aaff56"/>


    //  <text font-weight="bold" stroke-dasharray="5,5" xml:space="preserve" text-anchor="middle" font-family="Cursive" font-size="19" id="svg_4" y="325" x="232" opacity="0.75" stroke-linecap="round" stroke-linejoin="bevel" stroke="#000000" fill="#000000">Air Defence</text>
    //<text xml:space="preserve" text-anchor="middle" font-family="Cursive" font-size="19" id="svg_5" y="371" x="158" opacity="0.75" stroke-linecap="null" stroke-linejoin="null" stroke="#000000" fill="#000000">Top player:</text>
    //<text xml:space="preserve" text-anchor="middle" font-family="Cursive" font-size="19" id="svg_6" y="422" x="139" opacity="0.75" stroke-linecap="null" stroke-linejoin="null" stroke="#000000" fill="#000000">Score</text>


    //   <svg width="640" height="480" xmlns="http://www.w3.org/2000/svg">
    //<!-- Created with SVG-edit - http://svg-edit.googlecode.com/ -->
    //    <g>
    //     <title>Layer 1</title>
    //     <rect id="svg_1" height="136" width="314" y="73" x="21" stroke-width="5" stroke="#ff00ff" fill="#7fff00"/>
    //     <text opacity="0.75" transform="matrix(0.5032157980152191,0,0,1.2169772010935416,-1.6422189529534137,-30.733213256200802) " xml:space="preserve" text-anchor="middle" font-family="Cursive" font-size="24" id="svg_2" y="117.91698" x="208.6071" stroke-width="0" stroke="#000000" fill="#000000">The AirDefence Game</text>
    //     <path id="svg_3" d="m106.405,450.17001l0,-172.25647l0,0c0,-7.31726 8.44905,-13.24353 18.875,-13.24353l226.5,0c10.42365,0 18.875,5.92627 18.875,13.24353c0,7.32373 -8.45135,13.25647 -18.875,13.25647l-18.875,0l0,172.25c0,7.31726 -8.44885,13.25 -18.875,13.25l-226.5,0l0,0c-10.42365,0 -18.875,-5.93274 -18.875,-13.25c0,-7.31726 8.45135,-13.25 18.875,-13.25l18.875,0zm37.75,-185.5l0,0c10.42365,0 18.875,5.92627 18.875,13.24353c0,7.32373 -8.45135,13.25647 -18.875,13.25647c-5.21182,0 -9.4375,-2.9696 -9.4375,-6.625c0,-3.66187 4.22568,-6.63147 9.4375,-6.63147l18.875,0m188.75,13.25647l-207.625,0m-37.75,159l0,0c5.21182,0 9.4375,2.96313 9.4375,6.625c0,3.6554 -4.22568,6.625 -9.4375,6.625l18.875,0m-18.875,13.25l0,0c10.42365,0 18.875,-5.93274 18.875,-13.25l0,-13.25" opacity="0.75" stroke-linecap="null" stroke-linejoin="null" stroke-width="5" stroke="#000000" fill="#aaff56"/>
    //     <text font-weight="bold" stroke-dasharray="5,5" xml:space="preserve" text-anchor="middle" font-family="Cursive" font-size="19" id="svg_4" y="325" x="232" opacity="0.75" stroke-linecap="round" stroke-linejoin="bevel" stroke="#000000" fill="#000000">Air Defence</text>
    //     <text xml:space="preserve" text-anchor="middle" font-family="Cursive" font-size="19" id="svg_5" y="371" x="158" opacity="0.75" stroke-linecap="null" stroke-linejoin="null" stroke="#000000" fill="#000000">Top player:</text>
    //     <text xml:space="preserve" text-anchor="middle" font-family="Cursive" font-size="19" id="svg_6" y="422" x="139" opacity="0.75" stroke-linecap="null" stroke-linejoin="null" stroke="#000000" fill="#000000">Score</text>
    //    </g>



    /*
    <svg width="640" height="480" xmlns="http://www.w3.org/2000/svg">
 <!-- Created with SVG-edit - http://svg-edit.googlecode.com/ -->
     <g>
      <title>Layer 1</title>
      <path fill="#aaff56" stroke="#000000" stroke-width="5" stroke-linejoin="null" stroke-linecap="null" opacity="0.75" d="m106.405,450.17001l0,-172.25647l0,0c0,-7.31726 8.44905,-13.24353 18.875,-13.24353l226.5,0c10.42365,0 18.875,5.92627 18.875,13.24353c0,7.32373 -8.45135,13.25647 -18.875,13.25647l-18.875,0l0,172.25c0,7.31726 -8.44885,13.25 -18.875,13.25l-226.5,0l0,0c-10.42365,0 -18.875,-5.93274 -18.875,-13.25c0,-7.31726 8.45135,-13.25 18.875,-13.25l18.875,0zm37.75,-185.5l0,0c10.42365,0 18.875,5.92627 18.875,13.24353c0,7.32373 -8.45135,13.25647 -18.875,13.25647c-5.21182,0 -9.4375,-2.9696 -9.4375,-6.625c0,-3.66187 4.22568,-6.63147 9.4375,-6.63147l18.875,0m188.75,13.25647l-207.625,0m-37.75,159l0,0c5.21182,0 9.4375,2.96313 9.4375,6.625c0,3.6554 -4.22568,6.625 -9.4375,6.625l18.875,0m-18.875,13.25l0,0c10.42365,0 18.875,-5.93274 18.875,-13.25l0,-13.25" id="svg_3"/>
      <text fill="#000000" stroke="#000000" stroke-linejoin="bevel" stroke-linecap="round" opacity="0.75" x="232" y="325" id="svg_4" font-size="19" font-family="Cursive" text-anchor="middle" xml:space="preserve" stroke-dasharray="5,5" font-weight="bold">Air Defence</text>
      <text fill="#000000" stroke="#000000" stroke-linejoin="null" stroke-linecap="null" opacity="0.75" x="158" y="371" id="svg_5" font-size="19" font-family="Cursive" text-anchor="middle" xml:space="preserve">Top player:</text>
      <text fill="#000000" stroke="#000000" stroke-linejoin="null" stroke-linecap="null" opacity="0.75" x="139" y="422" id="svg_6" font-size="19" font-family="Cursive" text-anchor="middle" xml:space="preserve">Score</text>
     </g>
    </svg>
    */

}
