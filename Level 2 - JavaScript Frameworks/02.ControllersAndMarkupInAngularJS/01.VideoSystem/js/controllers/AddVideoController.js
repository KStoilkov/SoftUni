app.controller('AddVideo', ['$scope', 'videoData', function($scope, videoData) {
    $scope.newVideo = {};

    $scope.newVideoHolder = {};

    $scope.addVideo = function (video){
        video.haveSubtitles = false;
        video.comments = [];

        $scope.newVideo = angular.copy(video);
        videoData.addVideoToData($scope.newVideo);
        $scope.newVideoHolder = {};
    };
}]);