namespace Mylinq;

public class Student
{
    public string Name { get; set; }
    public int Age { get; set; }
    public int Score { get; set; }

    public Student(string name, int age, int score)
    {
        Name = name;
        Age = age;
        Score = score;
    }
}
