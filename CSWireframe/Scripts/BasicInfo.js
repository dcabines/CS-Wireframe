var data = [];

for (var i = 0; i < 10; i++) {
    data.push({
        colOne: 'Data',
        colTwo: 'Data',
        colThree: 'Data',
        colFour: 'Data',
        colFive: 'Data'
    });
}

var container = $('.table.table-striped')[0];
var model = new TableData(data);
ko.applyBindings(model, container);