app.controller('VideoSystemController', ['$scope', 'videoData',
    function($scope, videoData) {

        $scope.videos = videoData.getVideos();
        $scope.order = {
            type : ''
        };
        $scope.filter = {
            type: ''
        };
}]);