
App.factory("subCategoryService", ["config", "httpService", "$q",
    function (config, httpService, $q) {
    	return {
    		save: function (entity) {
    			return httpService.post("api/subCategory/save", entity);
    		},
    		getAll: function () {
    			return httpService.get("api/subCategory/getAll");
    		},
    		getById: function (id) {
    			return httpService.get("api/subCategory/getById", { id: id });
    		},
    		getBySlug: function (slugCategory, slugSubCategory) {
    			return httpService.get("api/subCategory/getBySlug", {slugCategory: slugCategory, slugSubCategory: slugSubCategory
    		});
    				},
    		remove: function (entity) {
    			return httpService.post("api/subCategory/remove", entity);
    			},
    		addField: function (entity) {
    			return httpService.post("api/subCategory/addField", entity);
    			},
    		editField: function (entity) {
    			return httpService.post("api/subCategory/editField", entity);
    			},
    		removeField: function (entity) {
    			return httpService.post("api/subCategory/removeField", entity);
    			},
    		getFields: function (entity) {
    			return httpService.post("api/subCategory/getFields", entity);
    			},
    		validateSave: function (entity) {
    			var messages = [];
    			if (!entity.Category.Id) {
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
    	}
    ]);

