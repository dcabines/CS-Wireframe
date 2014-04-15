var TableRow = function (data) {
    this.colOne = ko.observable(data.colOne);
    this.colTwo = ko.observable(data.colTwo);
    this.colThree = ko.observable(data.colThree);
    this.colFour = ko.observable(data.colFour);
    this.colFive = ko.observable(data.colFive);
    this.colSix = ko.observable(data.colSix);
    this.colSeven = ko.observable(data.colSeven);
    this.colEight = ko.observable(data.colEight);
};

var TableData = function (data) {
    this.tableData = ko.utils.arrayMap(data, function (row) {
        return new TableRow(row);
    });
};