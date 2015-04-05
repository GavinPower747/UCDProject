var app = angular.module('Registration', ["ui.bootstrap", "ui.bootstrap.tpls"]);

app.controller('RegisterController', function ($scope, $document) {
    var datepicker = document.getElementById("DOBField");

    $scope.today = function () {
        return new Date();
    };

    $scope.clear = function () {
        $scope.dt = null;
    };

    $scope.dt = $scope.today();

    $scope.dateOptions = {
        formatYear: 'yyyy',
        startingDay: 1
    };

    $scope.toggleMin = function () {
        var date = new Date();
        date.setDate(1);
        date.setMonth(1);
        date.setYear(1900)
        $scope.minDate = $scope.minDate ? null : date;
    };
    $scope.toggleMin();

    $scope.open = function($event) {
        $event.preventDefault();
        $event.stopPropagation();

        $scope.opened = true;
    };

    $scope.formats = [ 'yyyy/MM/dd' ];
    $scope.format = $scope.formats[0];
});