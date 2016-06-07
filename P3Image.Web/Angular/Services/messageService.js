App.factory('messageService', [
function () {
    return {
        success: function (message, title) {
            alert(message);
        },
        warning: function (message, title) {
            alert(message);
        },
        error: function (message, title) {
            alert(message);
        },
        notify: function (message, title) {
            alert(message);
        },
        confirm: function (message, title) {
            return confirm(message);
        }
    }
}]);