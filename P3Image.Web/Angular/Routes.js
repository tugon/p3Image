
App.config(["$routeProvider", "$locationProvider", "$httpProvider", function ($routeProvider, $locationProvider, $httpProvider) {


    var defaultRoute = {
        templateUrl: "/Category",
        controller: "categoryController"
    }

    $routeProvider
        .when("/app/slug/:slugCategory/:slugSubCategory",
        {
            templateUrl: "/Home/Slug",
            controller: "slugController"
        })
        .when("", defaultRoute)
        .when("/", defaultRoute)
        .when("/app", defaultRoute)
        .when("/app/", defaultRoute)
        .when("/app/Home", defaultRoute)
        .when("/app/Category",
        {
            templateUrl: "/Category",
            controller: "categoryController"
        })
        .when("/app/SubCategory",
        {
            templateUrl: "/SubCategory",
            controller: "subCategoryController"
        })
        .when("/app/Field",
        {
            templateUrl: "/Field",
            controller: "fieldController"
        })
        .when("/app/FieldOption",
        {
            templateUrl: "/FieldOption",
            controller: "fieldOptionController"
        });
        
    //.otherwise(defaultRoute);

    $httpProvider.interceptors.push(["$q", "$location", "$window", "$cookieStore", "config", "util", function ($q, $location, $window, $cookieStore, config, util) {
        return {
            "request": function request(req) {
                var token = util.getToken(config.tokenKey);

                var headers = {};
                if (token) {
                    headers = angular.copy(req.headers);
                    headers.Authorization = "Bearer " + token;
                }
                if (token) {
                    req.headers = headers;
                }
                return req;
            },
            "response": function (response) {
                if (response.status === 302) {
                    $window.location.href = config.baseUrl + "/login/login";
                }
                return response;
            },
            "responseError": function (rejection) {
                if (rejection.status === 302) {
                    $window.location.href = config.baseUrl + "/login/login";
                }
                if (rejection.status === 401) {
                    $window.location.href = config.baseUrl + "/login/login";
                }
                return $q.reject(rejection);
            },
            getToken: function () {


                return null;
            }
        };
    }]);

    $locationProvider.html5Mode({
        enabled: true,
        requireBase: false
    }).hashPrefix("/");
}]);