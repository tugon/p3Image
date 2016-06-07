App.controller("categoryController", ["$scope", "$uibModal", "config", "categoryService", "messageService",
function ($scope, $uibModal, config, categoryService, messageService) {
    $scope.init = function () {
        $scope.getAll();

    }

    $scope.getAll = function () {
        categoryService.getAll()
            .then(
                function (result) {
                    $scope.categoryList = result.data;
                },
                function (error) {
                    messageService.error(error.data);
                }
            );
    }

    $scope.close = function () {
        $scope.modalInstance.close();
    }

    $scope.save = function () {

        categoryService.save($scope.category)
            .then(
                function (result) {
                    if (!$scope.category.Id && $scope.categoryList) {
                        $scope.categoryList.push(result.data);
                    }
                    if ($scope.saveCallBack)
                        $scope.saveCallBack($scope.category);
                    messageService.success("Category saved successfully");
                    $scope.close();
                },
                function (error) {
                    messageService.error(error.data);
                }
            );
    }

    $scope.remove = function (category, index) {
        if (messageService.confirm("Do you really want to remove the Category ")) {
            categoryService.remove(category);
            $scope.categoryList.splice(index, 1);
        }
    };

    $scope.openEdit = function (category) {
        $scope.category = category || {};

        $scope.modalInstance = $uibModal.open({
            animation: true,
            templateUrl: config.baseUrl + "category/Edit",
            scope: $scope,
            size: "lg",
            backdrop: "static"
        });
    }




}]);
