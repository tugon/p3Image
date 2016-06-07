App.factory('config', ['$location', function ($location) {
    return {
        baseUrl: $location.protocol() + '://' + $location.host() + ($location.port() ? ":" + $location.port() : "") + "/",
        fieldTypeList: [
            { Id: 0, Name: "Text" },
            { Id: 1, Name: "CheckBox" },
            { Id: 2, Name: "Radio" },
            { Id: 3, Name: "Select" },
            { Id: 4, Name: "TextArea" }
        ],
        getFieldTypeById:function(id) {
            var enumFielType = Enumerable.From(this.fieldTypeList).Where(function (x) { return x.Id === id; }).FirstOrDefault();
            if (enumFielType)
                return enumFielType.Name;
            return "";
        }
    }
}]);