
App.controller("slugController", ["$scope", "$routeParams", "$uibModal", "config", "subCategoryService", "messageService",
    function ($scope, $routeParams, $uibModal, config, subCategoryService, messageService) {
        $scope.init = function () {

            if ($routeParams.slugCategory)
                $scope.category = $routeParams.slugCategory;
            if ($routeParams.slugSubCategory)
                $scope.subCategory = $routeParams.slugSubCategory;
            $scope.getBySlug($scope.category, $scope.subCategory);

        }
        $scope.$on("subCategoryChanged",
            function () {
                $scope.getAll();
            });
        $scope.getAll = function () {
            subCategoryService.getAll()
                .then(
                    function (result) {
                        $scope.subCategoryList = result.data;
                    },
                    function (error) {
                        messageService.error(error.data);
                    }
                );
        }

        $scope.getBySlug = function (slugCategory, slugSubCategory) {
            subCategoryService.getBySlug(slugCategory, slugSubCategory)
                .then(
                    function (result) {
                        $scope.subCategory = result.data;
                    },
                    function (error) {
                        messageService.error(error.data);
                    }
                );
        }


    }]);

