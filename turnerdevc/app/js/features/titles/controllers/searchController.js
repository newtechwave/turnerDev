"use strict";

(function () {
    angular.module("title")
        .controller("searchController",
        [
            "$scope", "$window", "titleFactory", "$state",
        function ($scope, $window, titleFactory, $state) {
            var vm = this;

            function searchTitlesFinished(data) {
                vm.searchResults = data;
                vm.loading = false;
            }

            $scope.$watch("vm.searchText", function (searchValue) {
                if (searchValue !== null && searchValue !== undefined && searchValue !== "") {
                    vm.loading = true;

                    titleFactory.searchTitles(searchTitlesFinished, searchValue, vm.language);
                } else {
                    vm.loading = false;
                    vm.searchResults = "";
                }
            });

            vm.titleDetails = function (titleId, title) {
                titleFactory.setTitle(titleId, title);
                $state.go("details", { titleId: titleId });
            }

            vm.init = function () {
                vm.loading = false;
                vm.searchResults = "";
                $window.document.title = "search";
            }
        }
        ]);
})();