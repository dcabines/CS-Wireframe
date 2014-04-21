app.BasicInfo = function (data) {
    this.active = ko.observableArray(data.active);
    this.canceled = ko.observableArray(data.canceled);
    this.zipCodes = ko.observableArray(data.zipCodes);
    this.video = ko.observable(data.video);
    this.aboutMe = ko.observable(data.aboutMe);
    this.myServices = ko.observable(data.myServices);

    var rows = ko.utils.arrayMap(data.fbPages, function (row) {
        return new app.FBPage(row);
    });

    this.fbPages = ko.observableArray(rows);
};
