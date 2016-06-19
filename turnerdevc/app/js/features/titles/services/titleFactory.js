(function () {
    "use strict";
    angular.module("title").service("titleFactory",
                    ["$http", "$q",
            function ($http, $q) {
                var currentTitle = {titleId:0, title:""};


                return {
                	searchTitles: function (callback, searchInfo) {               	 
                         return $q(function (resolve, reject) {
                            $http.get("/api/search/searchfortitle/", {
                                params: {
                                    "searchInfo": searchInfo
                                }
                            }).success(function (data) {
                                resolve(callback(data));
                            }).error(function () {
                                reject("There was an error");
                            });
                        });   
                	},
                	getTitleParticipants: function (callback, titleId) {
                         return $q(function (resolve, reject) {
                            $http.get("/api/titledetails/titleparticipants/", {
                                params: {
                                    "titleId": titleId
                                }
                            }).success(function (data) {
                                resolve(callback(data));
                            }).error(function () {
                                reject("There was an error");
                            });
                        });   
                	},
                	getTitleGenres: function (callback, titleId) {
                         return $q(function (resolve, reject) {
                            $http.get("/api/titledetails/titlegenres/", {
                                params: {
                                    "titleId": titleId
                                }
                            }).success(function (data) {
                                resolve(callback(data));
                            }).error(function () {
                                reject("There was an error");
                            });
                        });   
                	},
                	getTitleAwards: function (callback, titleId) {
                         return $q(function (resolve, reject) {
                            $http.get("/api/titledetails/titleawards/", {
                                params: {
                                    "titleId": titleId
                                }
                            }).success(function (data) {
                                resolve(callback(data));
                            }).error(function () {
                                reject("There was an error");
                            });
                        });   
                	},
                	getTitleStory: function (callback, titleId) {
                         return $q(function (resolve, reject) {
                            $http.get("/api/titledetails/titlestory/", {
                                params: {
                                    "titleId": titleId
                                }
                            }).success(function (data) {
                                resolve(callback(data));
                            }).error(function () {
                                reject("There was an error");
                            });
                        });   
                	},
                    setTitle: function(titleId, title) {
                        currentTitle.titleId = titleId;
                        currentTitle.title = title;
                    },
                    getTitle: function() {
                        return currentTitle;
                    }

                }

            }]);

}());