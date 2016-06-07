

App.factory('fieldOptionService', ['config', 'httpService', '$q',
function (config, httpService, $q) {
    return {
        save: function (entity) {
            return httpService.post('api/fieldOption/save', entity);
        },
        getAll: function () {
            return httpService.get('api/fieldOption/getAll');
        },
        getById: function (id) {
            return httpService.get('api/fieldOption/getById', { id: id });
        },
        remove: function (entity) {
            return httpService.post('api/fieldOption/remove', entity);
        }
    }
}]);

