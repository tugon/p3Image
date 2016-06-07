

App.factory('fieldService', ['config', 'httpService', '$q',
function (config, httpService, $q) {
	return {
		save: function (entity) {
			return httpService.post('api/field/save', entity);
		},
		getAll: function () {
			return httpService.get('api/field/getAll');
		},
		getById: function (id) {
			return httpService.get('api/field/getById', { id: id });
		},
		remove: function (entity) {
			return httpService.post('api/field/remove', entity);
		}
	}
}]);

