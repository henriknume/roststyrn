using System;
using System.IO;

public class RwToDisk
{
    // Writing to disk:
    // WriteToBinaryFile<SomeClass>("filename.dat", object1);
    // Path can be included with filename eg. "C:/filename.txt"
    public static void Write<T>(String fileName, T obj)
	{
        using (Stream stream = File.Open(fileName, FileMode.Create))
        {
            var binaryFormatter = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();
            binaryFormatter.Serialize(stream, obj);
        }
    }

    // Read from disk:
    // SomeClass object1 = Read<SomeClass>("filename.dat");
    public static T Read<T>(String fileName)
    {
        using (Stream stream = File.Open(fileName, FileMode.Open))
        {
            var binaryFormatter = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();
            return (T)binaryFormatter.Deserialize(stream);
        }
    }
}
