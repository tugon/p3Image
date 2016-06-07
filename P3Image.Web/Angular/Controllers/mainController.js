App.controller('mainController', ['$scope', '$rootScope',
function ($scope, $rootScope) {
    $scope.init = function () { }
    $scope.nav = function () {
        Utility.animateContent();
    }

    $scope.pageChange = function (name) {
        $scope.pageName = name;
    }

    $scope.pageName = $rootScope.pageName;
}]);