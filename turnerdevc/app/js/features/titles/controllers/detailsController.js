"use strict";

(function() {
    angular.module("title")
        .controller("detailsController",
        [
            "$scope", "$window", "titleFactory","$state",
            function($scope, $window, titleFactory, $state) {
                var vm = this;

                function titleStoryFinished(data) {
                    vm.story = data;
                }
                
                function titleAwardsFinished(data) {
                    if (data.length < 1) {
                        data = [{ awardName: "No awards." }];
                    }
                    vm.awards = data;
                }
                
                function titleGenresFinished(data) {
                    if (data.length < 1) {
                        data = [{ name: "No genres." }];
                    }
                    vm.genres = data;
                }
                
                function titleParticipantsFinished(data) {
                    vm.participants = data;
                }

                vm.init = function () {
                    vm.currentTitle = titleFactory.getTitle();
                    if (vm.currentTitle === undefined || vm.currentTitle === null) {
                        vm.currentTitle = {};
                        vm.currentTitle.titleId = $state.params.titleId;
                    }
                    titleFactory.getTitleStory(titleStoryFinished ,vm.currentTitle.titleId);
                    titleFactory.getTitleAwards(titleAwardsFinished ,vm.currentTitle.titleId);
                    titleFactory.getTitleGenres(titleGenresFinished ,vm.currentTitle.titleId);
                    titleFactory.getTitleParticipants(titleParticipantsFinished, vm.currentTitle.titleId);

                    $window.document.title =vm.currentTitle.title +  " Details";
                }
            }
        ]);
})();