var data = [];

for (var i = 0; i < 10; i++) {
    data.push({
        colOne: '123456789' + i,
        colTwo: 'Bob Dobbs (' + i + ')',
        colThree: 'Yes',
        colFour: 'Yes',
        colFive: 'No',
        colSix: 'Yes',
        colSeven: 'Yes',
        colEight: '123456789' + i
    });
}

data.aboutMe = 'Lorem ipsum dolor sit amet, consectetur adipiscing elit. Quisque iaculis nisl magna, vel consequat erat cursus in. Donec laoreet, urna pretium pretium commodo, neque elit venenatis ligula, quis egestas lectus tellus a tellus. Nam sed arcu tempor, vulputate orci sit amet, suscipit quam. Donec malesuada felis lobortis dapibus vestibulum. Duis ornare lacus sed nisi consectetur consectetur. Cras hendrerit magna dolor, vel bibendum nisi feugiat sed. Suspendisse pretium, ipsum ut ultricies sagittis, sapien massa feugiat nibh, et sodales tortor eros in justo. Suspendisse quis condimentum ante. Pellentesque est urna, pretium ac neque sit amet, pulvinar lacinia ligula. Sed ut hendrerit sem. Donec tempor tellus tortor, et porttitor est tempus et. Nulla ut metus enim. Integer tortor augue, tincidunt et rhoncus eu, porta non dui. Suspendisse vitae est in nunc iaculis dignissim ut a purus. Cras tempus sollicitudin nisl, sed dignissim sapien imperdiet ut. Nunc lobortis augue vitae rhoncus consequat.';
data.myServices = 'Lorem ipsum dolor sit amet, consectetur adipiscing elit. Quisque iaculis nisl magna, vel consequat erat cursus in. Donec laoreet, urna pretium pretium commodo, neque elit venenatis ligula, quis egestas lectus tellus a tellus. Nam sed arcu tempor, vulputate orci sit amet, suscipit quam. Donec malesuada felis lobortis dapibus vestibulum. Duis ornare lacus sed nisi consectetur consectetur. Cras hendrerit magna dolor, vel bibendum nisi feugiat sed. Suspendisse pretium, ipsum ut ultricies sagittis, sapien massa feugiat nibh, et sodales tortor eros in justo. Suspendisse quis condimentum ante. Pellentesque est urna, pretium ac neque sit amet, pulvinar lacinia ligula. Sed ut hendrerit sem. Donec tempor tellus tortor, et porttitor est tempus et. Nulla ut metus enim. Integer tortor augue, tincidunt et rhoncus eu, porta non dui. Suspendisse vitae est in nunc iaculis dignissim ut a purus. Cras tempus sollicitudin nisl, sed dignissim sapien imperdiet ut. Nunc lobortis augue vitae rhoncus consequat.';

var container = $('#basic')[0];
var model = new TableData(data);
ko.applyBindings(model, container);