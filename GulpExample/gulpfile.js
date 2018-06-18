var gulp = require("gulp");

/*
gulp.task -> Define tasks
gulp.src -> points to files to use
gulp.dest -> points to folder to output
gulp.watch -> watch files and folders for changes
**/

//Logs Message
gulp.task('message', function() {
    return console.log("Gulp is running");
});

//Copy all html files 
gulp.task('copyHtml', function() {
    gulp.src('src/*.html')
    .pipe(gulp.dest('dist'));
});