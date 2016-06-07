App.directive("paging", ['config', 'util',
    function (config, util) {
        return {
            restrict: 'EA',
            require: ['ngModel'],
            templateUrl: function (elem, attr) {
                var url = config.baseUrl + "Angular/Directives/templates/paging.html";
                return url;
            },
            scope: {
                ngModel: '=',
                count: '=',
                pageSize: '=',
                range: '=?',
                pageNumber: '=?',
                onPageChange: '='
            },

            link: function (scope, element, attrs, ctrl) {
                scope.element = element;
                scope.model = ctrl[0];
                scope.init()
            },

            controller: ['$scope', function ($scope) {
                $scope.setPage = function () {
                    var pages = parseInt($scope.count / $scope.pageSize);
                    $scope.pages = [];
                    $scope.calculateRange();
                    for (var i = $scope.rangeStart+1; i <= $scope.rangeEnd; i++)
                        $scope.pages.push(i);
                    
                    $scope.paging = {
                        count: $scope.count,
                        pageNumber: $scope.pageNumber || 1,
                        pageSize: $scope.pageSize,
                        pages: $scope.pages,
                        range: $scope.range,
                        rangeStart: $scope.rangeStart,
                        rangeEnd: $scope.rangeEnd

                    };
                }

                $scope.init = function () {
                    $scope.range = $scope.range || 10;
                    $scope.pageNumber = $scope.pageNumber || 1;
                    $scope.$watch('count', function (newValue, oldValue) {
                        if (newValue != oldValue)
                            $scope.setPage();
                    });
                }

                $scope.calculateRange = function () {
                    var ranges = $scope.count / $scope.range;
                    $scope.rangeIndex = parseInt($scope.pageNumber / $scope.range);
                    $scope.rangeStart = $scope.rangeIndex * $scope.range;
                    $scope.rangeEnd = $scope.rangeStart + $scope.range;
                }

                $scope.pageChange = function (pageNumber) {

                    $scope.paging.pageNumber = pageNumber;
                    $scope.model.$setViewValue($scope.paging);

                    if ($scope.onPageChange)
                        $scope.onPageChange($scope.model);
                }

            }]
        }
    }])