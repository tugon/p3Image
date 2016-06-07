App.directive("p3Field", ["config", "categoryService",
    function (config, categoryService) {
        return {
            restrict: "EA",
            require: ["ngModel"],
            templateUrl: function () {
                var url = config.baseUrl + "Angular/Directives/templates/p3Field.html";
                return url;
            },
            scope: {
                ngModel: "=",
                cssClass: "@",
                label: "@"
            },

            link: function (scope, element, attrs, ctrl) {
                if (attrs.loadOnStart && attrs.loadOnStart !== "true")
                    scope.loadOnStart = false;
                scope.element = element;
                scope.model = ctrl[0];

                scope.$watch('model.$viewValue', function (newValue, oldValue) {

                    scope.inputModel = newValue;
                });
            },

            controller: ["$scope", function ($scope) {


                $scope.init = function () {

                }


            }]
        }
    }])