App.directive("comboFieldOption", ["config", "fieldOptionService",
    function (config, fieldOptionService) {
        return {
            restrict: "EA",
            require: ["ngModel"],
            templateUrl: function () {
                var url = config.baseUrl + "Angular/Directives/templates/comboFieldOption.html";
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
                scope.getAll();
            },

            controller: ["$scope", function ($scope) {


                $scope.init = function () {

                }

                $scope.getAll = function () {

                    if (!$scope.stateId && !$scope.loadOnStart)
                        return;

                    fieldOptionService.getAll()
                        .then(
                            function (result) {
                                $scope.fieldOptionList = result.data;
                                var selectedValue = $scope.model.$viewValue;

                                if (selectedValue) {
                                    var res = Enumerable.From(result.data)
                                        .Where(function (x) { return x.Id === selectedValue.Id })
                                        .SingleOrDefault();
                                    $scope.fieldOption = res;
                                }
                            },
                            function (error) {
                                alert(error);
                            }
                        );
                }

                $scope.change = function (fieldOption) {
                    $scope.model.$setViewValue(fieldOption);
                    if ($scope.onChange) {
                        $scope.onChange(fieldOption, $scope.logProcess || null);
                    }
                }

            }]
        }
    }])