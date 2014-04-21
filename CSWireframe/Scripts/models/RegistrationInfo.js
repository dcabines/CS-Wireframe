app.RegistrationInfo = function (data) {
    this.name = ko.observable(data.name);
    this.avatar = ko.observable(data.avatar);
    this.id = ko.observable(data.id);
    this.phone = ko.observable(data.phone);
    this.email = ko.observable(data.email);
    this.profile = ko.observable(data.profile);
    this.installDate = ko.observable(data.installDate);
    this.brokerage = ko.observable(data.brokerage);
    this.broker = ko.observable(data.broker);
    this.association = ko.observable(data.association);
    this.readScore = ko.observable(data.readScore);
    this.brokerageLogo = ko.observable(data.brokerageLogo);
    this.aboutMe = ko.observable(data.aboutMe);

    this.isEditing = ko.observable(false);

    this.isNotEditing = ko.computed(function () {
        return !this.isEditing();
    }, this);

    // click handlers
    this.toggleEditing = this.toggleEditing.bind(this);
};

app.RegistrationInfo.prototype.toggleEditing = function () {
    var oldValue = this.isEditing();
    this.isEditing(!oldValue);
};