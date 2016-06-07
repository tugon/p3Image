App.directive("comboSubCategory", ["config", "subCategoryService",
    function (config, subCategoryService) {
        return {
            restrict: "EA",
            require: ["ngModel"],
            templateUrl: function () {
                var url = config.baseUrl + "Angular/Directives/templates/comboSubCategory.html";
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

                    subCategoryService.getAll()
                        .then(
                            function (result) {
                                $scope.subCategoryList = result.data;
                                var selectedValue = $scope.model.$viewValue;

                                if (selectedValue) {
                                    var res = Enumerable.From(result.data)
                                        .Where(function (x) { return x.Id === selectedValue.Id })
                                        .SingleOrDefault();
                                    $scope.subCategory = res;
                                }
                            },
                            function(error) {
                                alert(error);
                            }
                        );
                }

                $scope.change = function (subCategory) {
                    $scope.model.$setViewValue(subCategory);
                    if ($scope.onChange) {
                        $scope.onChange(subCategory, $scope.logProcess || null);
                    }
                }

            }]
        }
    }])