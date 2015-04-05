var app = angular.module("MainPage", []);

app.controller("MainController", function ($scope, $rootScope, $document, NewsFactory) {
    $scope.currentUser = ""
    $scope.NewsPosts = [];

    $scope.setCurrentUser = function (user) {
        $scope.currentUser = user;
    }

    $document.ready(function () {
        NewsFactory.GetAllNews().success(function (result) {
            if(result.length > 0)
                angular.forEach(result, function (key, value) {
                    $scope.NewsPosts.push(new NewsPost(value.NewsID, value.NewsAuthor, value.NewsContent, value.LogDate));
                });
            else
            {
                $scope.NewsPosts.push(new NewsPost(0, "No news posts", "I'm sure there will be some soon!", new Date().toISOString().split("T")[0]));
            }
        });
    });
});

app.factory("NewsFactory", function ($http) {
    return {
        GetAllNews: function() {
            var apiURL = window.location.origin + "/api/News/Get"
            var get = $http.get(apiURL, {
                params: {
                        callback: "JSON_CALLBACK"
                }
            });

            return get;
        }
    }
});