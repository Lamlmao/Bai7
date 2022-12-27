using bai7;
internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Nhap so hoc sinh: ");
        int n = int.Parse(Console.ReadLine());
        Student[] students = new Student[n];
        for(int i = 0; i < n; i++)
        {
            students[i] = new Student();
            Console.WriteLine("Name: ");
            string name = Console.ReadLine();
            Console.WriteLine("Gender: ");
            string gender = Console.ReadLine();
            Console.WriteLine("Address: ");
            string address = Console.ReadLine();
            Console.WriteLine("Birth: ");
            int year = int.Parse(Console.ReadLine());
            int month = int.Parse(Console.ReadLine()); 
            int day = int.Parse(Console.ReadLine()); 
            DateTime birth = new DateTime(year , month , day);
            Console.WriteLine("Id: ");
            string id = Console.ReadLine();
            Console.WriteLine("Point: ");
            float point = float.Parse(Console.ReadLine());
            Console.Write("Email: ");
            string email = Console.ReadLine(); 
        }
        for(int i = 0; i < n; i++)
        {
            students[i].OutputStudent();
            students[i].CheckHoBo();
        }
    }
}