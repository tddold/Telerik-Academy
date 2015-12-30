var mongoose = require('mongoose'),
    url = 'localhost:27017/students',
    Stusent,
    student,
    studentSchema,
    Course,
    courseSchema,
    db;

mongoose.connect(url);

db = mongoose.connection;

db.once('open', function (err) {
    if (err) {
        console.log(err);
    }
    
    console.log('MongoDB database up and running...')
});

db.on('error', function (err) {
    console.log(err);
});

studentSchema = new mongoose.Schema({
    firstName: { type: String , require: true },
    lastName: String,
    age: { type: Number, min: 0, max: 120, require: true }
});

Student = mongoose.model('Student', studentSchema);

courseSchema = new mongoose.Schema({
    name: String,
    students: [studentSchema]
});

Course = mongoose.model('Course', courseSchema); String
Student.find({}).exec(function (err, result) {
    var peshoStudent = result[3];
    var nodeJsCourse = new Course();
    nodeJsCourse.name = 'End-to-End JS Apps';
    nodeJsCourse.students.push(peshoStudent);
    nodeJsCourse.save(function (err, result) {
        console.log(result); 
    });

    Course.find({ name: 'End-toEnd JS Apps' })
    .exec(function (err, result) {
        console.log(result);
    });
});