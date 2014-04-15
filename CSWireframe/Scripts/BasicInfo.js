var data = [];

for (var i = 0; i < 10; i++) {
    data.push({
        colOne: '123456789' + i,
        colTwo: 'Bob Dobbs (' + i + ')',
        colThree: '123456789' + i,
        colFour: '123456789' + i,
        colFive: '123456789' + i,
        colSix: '123456789' + i,
        colSeven: '123456789' + i,
        colEight: '123456789' + i
    });
}

var container = $('.table.table-striped')[0];
var model = new TableData(data);
ko.applyBindings(model, container);