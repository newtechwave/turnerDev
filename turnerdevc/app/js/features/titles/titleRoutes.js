"use strict";

(function () {
    angular.module("title").config([
        "$stateProvider", "$urlRouterProvider",
        function ($stateProvider, $urlRouterProvider) {

            $urlRouterProvider.otherwise("/search");
            $stateProvider
                .state("search",
                {
                    url: "/search",
                    views: {
                        "title": {
                            templateUrl: "app/js/features/titles/views/titleView.html"
                        },
                        "search@search": {
                            templateUrl: "app/js/features/titles/views/searchView.html"
                        },
                       
                    }
                })  .state("details",
                {
                    url: "/details?titleId",
                    views: {
                        "title": {
                            templateUrl: "app/js/features/titles/views/titleView.html"
                        },
                        "details@details": {
                            templateUrl: "app/js/features/titles/views/detailsView.html"
                        },
                       
                    }
                })
            
            ;


        }]);
})();
