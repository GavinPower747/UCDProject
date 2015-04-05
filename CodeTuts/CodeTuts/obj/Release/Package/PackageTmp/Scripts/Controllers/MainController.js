var app = angular.module("MainPage", []);

app.controller("MainController", function ($scope, $rootScope, $document, NewsFactory) {
    $scope.currentUser = ""
    $scope.news = [];

    $scope.setCurrentUser = function (user) {
        $scope.currentUser = user;
    }

    $document.ready(function () {
        NewsFactory.GetAllNews().success(function (result) {
            angular.forEach(result, function (key, value) {
                $scope.news.push(new NewsPost(value.NewsAuthor, value.NewsContent));
            });
        });
    });
});

app.factory("NewsFactory", function ($http) {
    return {
        GetAllNews: function() {
            var apiURL = window.location.origin + "/News/Get"
            var get = $http.get(apiURL, {
                params: {
                        callback: "JSON_CALLBACK"
                }
            });

            return get;
        }
    }
});