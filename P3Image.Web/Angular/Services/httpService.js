App.factory('httpService', ['$http',  'config', 'util',
    function ($http,  config, util) {
        return {
            post: function (url, obj, contentType) {
                if (contentType)
                    return $http.post(config.baseUrl + url, $.param(obj), { headers: { 'Content-Type': contentType } });
                return $http.post(config.baseUrl + url, obj);
            },

            get: function (url, obj) {
                if (obj) {
                    if (typeof (obj) == "object")
                        return $http.get(config.baseUrl + url, { params: obj });
                    return $http.get(config.baseUrl + url + "/" + obj);
                } else
                    return $http.get(config.baseUrl + url);
            },

            http: function (url, method, data, contentType) {
                return $http({
                    url: config.baseUrl + url,
                    method: method,
                    params: data,
                    headers: contentType ? { 'Content-Type': contentType } : { 'Content-Type': 'application/json' }
                });
            },
            postFile: function (urlAction, files, obj) {
                if (!files || (files && files.length <= 0))
                    return false;
                var data = new FormData();
                if (obj) {
                    data.append("model", angular.toJson(obj));
                }
                if (files.length > 0) {

                    for (i = 0; i < files.length; i++) {
                        data.append("file" + i, files[i]);
                    }
                }
                return $http.post(urlAction, data, {
                    transformRequest: angular.identity,
                    headers: { 'Content-Type': undefined }
                });
            }
        };
    }]);


