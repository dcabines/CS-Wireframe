app.ViewModel = function (data) {
    this.registrationInfo = new app.RegistrationInfo(data.registrationInfo);
    this.basicInfo = new app.BasicInfo(data.basicInfo);
};