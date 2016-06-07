App.directive("comboCategory", ["config", "categoryService",
    function (config, categoryService) {
        return {
            restrict: "EA",
            require: ["ngModel"],
            templateUrl: function () {
                var url = config.baseUrl + "Angular/Directives/templates/comboCategory.html";
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

                    if (!$scope.loadOnStart)
                        return;

                    categoryService.getAll()
                        .then(
                            function (result) {
                                $scope.categoryList = result.data;
                                var selectedValue = $scope.model.$viewValue;

                                if (selectedValue) {
                                    var res = Enumerable.From(result.data)
                                        .Where(function (x) { return x.Id === selectedValue.Id })
                                        .SingleOrDefault();
                                    $scope.category = res;
                                }
                            },
                            function (error) {
                                alert(error);
                            }
                        );
                }

                $scope.change = function (category) {
                    $scope.model.$setViewValue(category);
                    if ($scope.onChange) {
                        $scope.onChange(category, $scope.logProcess || null);
                    }
                }

            }]
        }
    }])