using ClassLibrary1;

List<Student<int, string>> li = new List<Student<int, string>>();
Console.WriteLine("Enter Students Number:");
int studentNumber = Convert.ToInt32(Console.ReadLine());
for (int i = 0; i < studentNumber; i++)
{
    try
    {
        var student = new Student<int, string>();
        Console.WriteLine("\n\nEnter Student Name:");
        String name = Console.ReadLine();
        student.setName(in name);
        Console.WriteLine("\nEnter Student Age:");
        int age = Convert.ToInt32(Console.ReadLine());
        student.setAge(in age);
        Console.WriteLine("\nEnter Student Subjects List:");
        int subjectNumber = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("\nSubjects:");
        for (int j = 0; j < subjectNumber; j++)
        {
            string subjectName = Console.ReadLine();
            student.addSubject(in subjectName);
        }
        li.Add(student);
        Console.WriteLine("\n");
        Console.WriteLine("\nStudent Details:\n");
        foreach (var it in li)
        {
            List<string> subjectList = new List<string>(it.getSubject());
            Console.WriteLine($"Student Name:{it.getName} Age:{it.getAge}");
            Console.WriteLine("\nSubject List:");
            foreach (var itr in subjectList)
            {
                Console.WriteLine(itr);
            }
            Console.WriteLine("\n\n");
        }
    }
    catch (myException e)
    {
        Console.WriteLine(e);
    }
}