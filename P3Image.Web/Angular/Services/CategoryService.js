

App.factory('categoryService', ['config', 'httpService', '$q',
function (config, httpService, $q) {
	return {
		save: function (entity) {
			return httpService.post('api/category/save', entity);
		},
		getAll: function () {
			return httpService.get('api/category/getAll');
		},
		getById: function (id) {
			return httpService.get('api/category/getById', { id: id });
		},
		remove: function (entity) {
			return httpService.post('api/category/remove', entity);
		},
		validateSave: function (entity) {
			var messages = [];
			if (!entity.CategoryId) {
				messages.push("Category must be selected");
			}
			if (!entity.Description || entity.Description.trim() === "") {
				messages.push("Description must be filled");
			}
			if (!entity.Slug || entity.Slug.trim() === "") {
				messages.push("Slug must be filled");
			}
			return messages;
		}
	}
}]);

