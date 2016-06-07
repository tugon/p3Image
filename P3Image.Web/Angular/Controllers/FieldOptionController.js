
App.controller("fieldOptionController", ["$scope", "$uibModal", "config", "fieldOptionService", "messageService",
function ($scope, $uibModal, config, fieldOptionService, messageService) {
    $scope.init = function () {
        $scope.getAll();

    }

    $scope.getAll = function () {
        fieldOptionService.getAll()
            .then(
                function(result) {
                    $scope.fieldOptionList = result.data;
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
        entity.Id = $scope.fieldOption.Id ;
        entity.FieldId = $scope.fieldOption.FieldId ;
        entity.Text = $scope.fieldOption.Text ;
        entity.Value = $scope.fieldOption.Value ;

        fieldOptionService.save(entity).then(
            function (result) {
                if (!$scope.fieldOption.Id) {
                    $scope.fieldOptionList.push(result.data);
                }
                messageService.success("Field Option saved successfully");
                $scope.close();
            },
            function (error) {
                messageService.error(error.data);
                //$scope.close();
            }
        )
    }

    $scope.remove = function (fieldOption, index) {
        if (messageService.confirm("Do you really want to remove the Field Option ")) {
            fieldOptionService.remove({Id:fieldOption.Id});
            $scope.fieldOptionList.splice(index, 1)
        }
    };

    $scope.openEdit = function (fieldOption) {
        $scope.fieldOption = fieldOption;

        $scope.modalInstance = $uibModal.open({
            animation: true,
            templateUrl: config.baseUrl + "fieldOption/Edit",
            scope: $scope,
            size: "lg",
            backdrop: "static"
        });
    }




}]);

