app.FBPage = function (data) {
    this.fbid = ko.observable(data.fbid);
    this.name = ko.observable(data.name);
    this.readAssoc = ko.observable(data.readAssoc);
    this.profile = ko.observable(data.profile);
    this.idx = ko.observable(data.idx);
    this.feature = ko.observable(data.feature);
    this.ds = ko.observable(data.ds);
    this.accessToken = ko.observable(data.accessToken);
};