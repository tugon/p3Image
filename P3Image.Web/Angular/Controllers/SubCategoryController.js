
App.controller("subCategoryController", ["$scope", "$rootScope", "$uibModal", "config", "subCategoryService", "messageService", "fieldService",
function ($scope, $rootScope, $uibModal, config, subCategoryService, messageService, fieldService) {
    $scope.init = function () {
        $scope.getAll();

    }

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

    $scope.close = function () {
        $scope.modalInstance.close();
    }

    $scope.closeAddField = function () {
        $scope.modalAddFieldInstance.close();
    }

    $scope.save = function () {
        var result = subCategoryService.validateSave($scope.subCategory);
        if (result.length > 0) {
            messageService.error(result.join("\n"));
            return false;
        }

        subCategoryService.save($scope.subCategory)
            .then(
                function (result) {
                    if (!$scope.subCategory.Id) {
                        $scope.subCategoryList.push(result.data);
                    }
                    messageService.success("Sub Category saved successfully");
                    $rootScope.$broadcast('subCategoryChanged');
                    $scope.close();
                },
                function (error) {
                    messageService.error(error.data);
                    //$scope.close();
                }
            );
    }

    $scope.remove = function (subCategory, index) {
        if (messageService.confirm("Do you really want to remove the Sub Category ")) {
            subCategoryService.remove({ Id: subCategory.Id });
            $scope.subCategoryList.splice(index, 1);
            $rootScope.$broadcast('subCategoryChanged');
        }
    };

    $scope.removeField = function (field, index) {
        if (messageService.confirm("Do you really want to remove the Field ")) {
            fieldService.remove({ Id: field.Id });
            $scope.Fields.splice(index, 1);
        }
    };

    $scope.saveField = function (field) {
        if ($scope.subCategory && $scope.subCategory.Id) {
            if (field && field.Id) {
                subCategoryService.editField($scope.field)
                    .then(
                        function (result) {
                            field.FieldTypeDescription = config.getFieldTypeById(field.FieldType);
                            $scope.closeAddField();
                        });

            } else {
                subCategoryService.addField($scope.field)
                    .then(
                        function (result) {
                            $scope.field.FieldTypeDescription = config.getFieldTypeById($scope.field.FieldType);
                            $scope.subCategory.Fields.push($scope.field);
                            $scope.closeAddField();
                        });
            }
        } else {
            if (!$scope.subCategory.Fields)
                $scope.subCategory.Fields = [];
            $scope.field.FieldTypeDescription = config.getFieldTypeById($scope.field.FieldType);
            $scope.subCategory.Fields.push($scope.field);
            $scope.closeAddField();
        }
    }

    $scope.fieldTypeChanged = function (fieldType) {
        alert(fieldType);
    }

    $scope.openAddField = function (subCategory, field) {
        $scope.subCategory = subCategory || { Id: 0 };
        var order = 1;
        if ($scope.subCategory.Fields && $scope.subCategory.Fields.length > 0)
            order = Enumerable.From($scope.subCategory.Fields).Max(function (x) { return x.Order + 1 });
        if (field)
            $scope.field = field;
        else
            $scope.field = { SubCategoryId: $scope.subCategory.Id, Order: order };


        $scope.modalAddFieldInstance = $uibModal.open({
            animation: true,
            templateUrl: config.baseUrl + "subCategory/AddField",
            scope: $scope,
            size: "lg",
            backdrop: "static"
        });
    }

    $scope.openEdit = function (subCategory) {
        $scope.subCategory = subCategory || {};

        $scope.getFields();


    }

    $scope.getFields = function () {
        $scope.Fields = $scope.subCategory.Fields;
        if ($scope.Fields) {
            $.each($scope.Fields,
                function (index, obj) {
                    obj.FieldTypeDescription = config.getFieldTypeById(obj.FieldType);
                });
        }
        $scope.modalInstance = $uibModal.open({
            animation: true,
            templateUrl: config.baseUrl + "subCategory/Edit",
            scope: $scope,
            size: "lg",
            backdrop: "static"
        });
    }


}]);

