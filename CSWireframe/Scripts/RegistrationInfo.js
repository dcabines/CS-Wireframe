var data = {
    name: 'Henry Wadsworth Longfellow',
    avatar: 'http://placehold.it/200x200',
    id: '123456',
    phone: '(123) 456-7890',
    email: 'bdobbs@gmail.com',
    profile: 'http://google.com',
    mhs: '4/14/2014',
    brokerage: 'Bob\'s Realestate',
    broker: 'bdobbs@gmail.com',
    association: 'Horry County Association of Realtors'
};

var $container = $('.registration-info');
var model = new RegistrationInfoModel(data);
ko.applyBindings(model, $container[0]);
$container.fadeIn();
$(document).attr('title', 'CS Wireframe - ' + data.name);
var customerName = $('.customer-name')[0];
ko.applyBindingsToNode(customerName, { text: model.name });