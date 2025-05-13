using Mylinq;

// Create list of students
List<Student> students =
[
    new Student("John", 18, 85),
    new Student("Mary", 20, 65),
    new Student("Tom", 19, 90),
    new Student("Aluko", 30, 75),
    new Student("Josh", 24, 55)
];

// Filter students with score > 70 and sort by score descending
var highScorersFluentStyle = students
    .Where(s => s.Score > 70)
    .OrderByDescending(s => s.Score)
    .ToList();

var highScorersExpressionStyle= from student in students
                                          where student.Score > 70
                                          orderby student.Score descending
                                          select student;

// await DisplayStudentByScoreDesc();

var studentAgeInAsc = students.OrderBy(s => s.Age).ToList();

var sumAgeOfStudentWithHighScore = students
    .Where(s => s.Score > 70)
    .Sum(s => s.Age);

// Console.WriteLine("Sum of ages of students with high score above 70 is {0}", sumAgeOfStudentWithHighScore);

// DisplayStudentByAgeAsc();


// async Task DisplayStudentByScoreDesc()
// {
//     // Display results
//     Console.WriteLine("Students who scored more than 70 (sorted by score descending):");
//     Console.WriteLine("--------------------------------------------------");
//     Console.WriteLine("Name\tAge\tScore");
//     Console.WriteLine("----\t---\t-----");

//     await Task.Delay(3000);

//     foreach (var student in highScorersFluentStyle)
//     {
//         Console.WriteLine($"{student.Name}\t{student.Age}\t{student.Score}");
//     }
// }

// void DisplayStudentByAgeAsc()
// {
//     // Display results
//     Console.WriteLine("Students age (sorted in ascending):");
//     Console.WriteLine("--------------------------------------------------");
//     Console.WriteLine("Name\tAge\tScore");
//     Console.WriteLine("----\t---\t-----");

//     foreach (var student in studentAgeInAsc)
//     {
//         Console.WriteLine($"{student.Name}\t{student.Age}\t{student.Score}");
//     }
// }


//Task and Task<T>
//Desktop\Posting API DB Design.txt
string filePath = @"C:\Users\ABBAS.JODA\Desktop\Posting API DB Design.txt";
string fileContent = await FetchFromFile(filePath);
Console.WriteLine(fileContent);

static async Task<string> FetchFromFile(string filePath)
{
    using StreamReader streamReader = new(filePath);
    return await streamReader.ReadToEndAsync();
}
