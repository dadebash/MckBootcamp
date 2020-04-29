using System;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

namespace student
{

    [Serializable]
    public class student
    {
        public int id;
        public string name;
        //parameterizedconstructor 
        public student(int id, string name)
        {
            this.id = id;
            this.name = name;
            Console.WriteLine(id + "   " + name);

        }
    }
    public class driverclass
    {
        public static void Main(String[] args)
        {
            student s = new student(100, "Deb");
            string filePath = "/Users/debas/dadebash/work/Mck_BootCamp/CsharpSessions/serializationSession/studentFile.txt";
            FileStream stream = new FileStream(filePath, FileMode.OpenOrCreate);
            BinaryFormatter formatter = new BinaryFormatter();
            //Serialization
            // formatter.Serialize(stream,s);
            //Deserialization
            student stu = (student)formatter.Deserialize(stream);
            Console.WriteLine("id " + stu.id);
            Console.WriteLine("name  " + stu.name);
            stream.Close();
        }
    }

}