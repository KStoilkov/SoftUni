app.factory('videoData', function() {
    var videos = [];

    function getVideos(){
        return videos;
    }

    function addVideo(video){
        videos.push(video);
    }

    addVideo({
        title: 'Course introduction',
        pictureUrl: 'http://a1.mzstatic.com/us/r30/Music/v4/ef/0b/0a/ef0b0a7a-bdab-99bf-b7de-eed15313695b/cover170x170.jpeg',
        length: '3:32',
        category: 'IT',
        subscribers: 3,
        date: new Date(2014, 12, 15),
        haveSubtitles: false,
        comments: [
            {
                username: 'Pesho Peshev',
                content: 'Congratulations Nakov',
                date: new Date(2014, 12, 15, 12, 30, 0),
                likes: 3,
                websiteUrl: 'https://fbcdn-profile-a.akamaihd.net/hprofile-ak-xap1/v/t1.0-1/c85.44.550.550/s160x160/72216_1200174661816_5334799_n.jpg?oh=6266afb2d9f5e6e4f291c64d7c46e6b0&oe=56061BB2&__gda__=1443598724_9bfc20843aacc7140d06e2c9633afdf4'
            }
        ]
    });

    addVideo({
        title: 'KungFuu Panda',
        pictureUrl: 'http://www.worldculturepictorial.com/images/content/kung-fu-panda_dreamworks_animated_film.jpg',
        length: '2:32',
        category: 'Comedy',
        subscribers :123,
        date: new Date(2004, 02, 05),
        haveSubtitles: true,
        comments: [
            {
                username: 'Minka Pesheva',
                content: 'Congratulations Panda',
                date: new Date(2014, 12, 15, 12, 30, 0),
                likes: 3,
                websiteUrl: 'http://foz.mu-sofia.bg/system/files/Image/katedri/Prof.%20d-r%20Anjelika%20Velkova_2,%20dmn.jpg'
            },
            {
                username: 'Toshko Gaitanski',
                content: 'I Love you Panda!',
                date: new Date(2004, 02, 11, 12, 30, 0),
                likes: 3,
                websiteUrl: 'http://img.bg.sof.cmestatic.com/media/images/640x/Feb2013/496584.JPG'
            }
        ]
    });

    addVideo({
        title: 'Cool',
        pictureUrl: 'http://i.ytimg.com/vi/ReF6iQ7M5_A/maxresdefault.jpg',
        length: '6:32',
        category: 'Horror',
        subscribers :1232,
        date: new Date(1894, 03, 09),
        haveSubtitles: true,
        comments: []
    });

    return {
        getVideos : getVideos,
        addVideoToData: addVideo
    }
});