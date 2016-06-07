App.directive("comboFieldType", ["config",
    function (config) {
        return {
            restrict: "EA",
            require: ["ngModel"],
            templateUrl: function () {
                var url = config.baseUrl + "Angular/Directives/templates/comboFieldType.html";
                return url;
            },
            scope: {
                ngModel: "=",
                loadOnStart: "=",
                onChange: "=",
                logProcess: "=",
                cssClass: "@",
                label: "@"
            },

            link: function (scope, element, attrs, ctrl) {
                if (attrs.loadOnStart && attrs.loadOnStart !== "true")
                    scope.loadOnStart = false;
                scope.element = element;
                scope.model = ctrl[0];
                scope.$watch('model.$viewValue', function (newValue, oldValue) {

                    scope.getAll();
                });
            },

            controller: ["$scope", function ($scope) {


                $scope.init = function () {

                }

                $scope.getAll = function () {

                    if (!$scope.loadOnStart)
                        return;

                    $scope.fieldTypeList = config.fieldTypeList;
                    $scope.fieldType  = parseInt($scope.model.$viewValue);
                }

                $scope.change = function (fieldType) {
                    $scope.model.$setViewValue(fieldType);
                    if ($scope.onChange) {
                        $scope.onChange(fieldType);
                    }
                }

            }]
        }
    }])