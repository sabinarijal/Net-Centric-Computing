using System;

class Students
{
    private string[] names = new string[5];

    public string this[int index]
    {
        get { return names[index]; }
        set { names[index] = value; }
    }
}

class Program
{
    static void Main(string[] args)
    {
        Students students = new Students();
        students[0] = "Sabina";
        students[1] = "Divya";
        students[2] = "Asmita";
        students[3] = "Krisha";
        students[4] = "Sapana";

        Console.WriteLine("Student 2: " + students[1]);
    }
}
