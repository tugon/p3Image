
App.controller("fieldController", ["$scope", "$uibModal", "config", "fieldService", "messageService",
function ($scope, $uibModal, config, fieldService, messageService) {
    $scope.init = function () {
        $scope.getAll();

    }

    $scope.getAll = function () {
        fieldService.getAll()
            .then(
                function(result) {
                    $scope.fieldList = result.data;
                },
                function(error) {
                    messageService.error(error.data);
                }
            );
    }

    $scope.close = function () {
        $scope.modalInstance.close();
    }

    $scope.save = function () {
		var entity = {};
        entity.Id = $scope.field.Id ;
        entity.SubCategoryId = $scope.field.SubCategoryId ;
        entity.Order = $scope.field.Order ;
        entity.Description = $scope.field.Description ;
        entity.FieldType = $scope.field.FieldType ;

        fieldService.save(entity)
            .then(
                function(result) {
                    if (!$scope.field.Id) {
                        $scope.fieldList.push(result.data);
                    }
                    messageService.success("Field saved successfully");
                    $scope.close();
                },
                function(error) {
                    messageService.error(error.data);
                    //$scope.close();
                }
            );
    }

    $scope.remove = function (field, index) {
        if (messageService.confirm("Do you really want to remove the Field ")) {
            fieldService.remove({Id:field.Id});
            $scope.fieldList.splice(index, 1);
        }
    };

    $scope.openEdit = function (field) {
        $scope.field = field;

        $scope.modalInstance = $uibModal.open({
            animation: true,
            templateUrl: config.baseUrl + "field/Edit",
            scope: $scope,
            size: "lg",
            backdrop: "static"
        });
    }




}]);

