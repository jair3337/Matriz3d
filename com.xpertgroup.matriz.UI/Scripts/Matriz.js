var app = angular.module("myApp", []);

app.controller('myCtrl', ['$scope', 'matrizService', function ($scope, matrizService) {

    $scope.Cases = 0;
    var count = 0;
    var flag = false;

    $scope.RequestQuery =
    {
        X1: 0,
        Y1: 0,
        Z1: 0,
        X2: 0,
        Y2: 0,
        Z2: 0
    };

    $scope.RequestUpdate =
    {
        X: 0,
        Y: 0,
        Z: 0,
        Value: 0
    };

    $scope.TestCases = () => {
        if ($scope.Cases >= 1 && $scope.Cases <= 50) {
        } else {
            alert("T debe estar entre 1 y 50");
        }
    }


    $scope.Init = () => {
        if (!flag) {
            if ($scope.form.N >= 1 && $scope.form.N <= 100)
            {
                flag = true;
            } else
            {
                flag = false;
                alert("N debe estar entre 1 y 100");
            }
            if ($scope.form.M >= 1 && $scope.form.M <= 1000) {
                flag = true;
            } else {
                alert("M debe estar entre 1 y 1000");
                flag = false;
            }
            if (flag) {
                alert("La matriz tipo: " + $scope.form.N + " ha sido generada");
                matrizService.Init($scope.form.N);
            }
        }
    }

    $scope.Query = () => {
        if (validate()) {
            if (ValidateQuery()) {
                matrizService.Query($scope.RequestQuery)
                    .then(function (data) {
                        $scope.Value = data;
                    })
                count++;
            }           
        } else {
            alert("casos Completados");
        }
    }

    function ValidateQuery() {
        if (RequestQuery.X1 > RequestQuery.X2) {
            alert("X1 debe ser menor a X2");
            return false;
        }
        if (RequestQuery.Y1 > RequestQuery.Y2) {
            alert("Y1 debe ser menor a Y2");
            return false;
        }
        if (RequestQuery.Z1 > RequestQuery.Z2) {
            alert("Z1 debe ser menor a Z2");
            return false;
        }
        return true;
    }

    $scope.Update = () => {
        if (validate()) {
            matrizService.Update($scope.RequestUpdate)
                .then(function (data) {
                    $scope.Value = data;
                })
            count++;
        } else {
            alert("casos Completados");
        }
    }

    function validate() {
        if (count >= $scope.form.M) {
            alert("Los casos fueron completados");
            return false;
        }
        return true;
    }

}]);

app.service('matrizService', function ($http) {

    var location = "http://localhost:49377";

    this.Query = function (request) {
        console.log(request);
        return $http.post(location + "/Matriz/Query/", request);
    }
    this.Init = function (n) {
        return $http.get(location + "/Matriz/Init/?n=" + n)
    }
    this.Update = function (request) {
        console.log(request);
        return $http.post(location + "/Matriz/Update", request);
    }
});