// using System;
// using System.Runtime.Serialization;
// using System.Runtime.Serialization.Formatters.Binary;
// using System.Text;
// using System.IO;

// namespace serializationSession
// {

//     [Serializable]
//     class DigitalMarketing
//     {
//         public string customers;
//         public string socialNetwork;
//         static void Main(String[] args)
//         {
//             DigitalMarketing dm = new DigitalMarketing();
//             dm.customers = "Mark";
//             dm.socialNetwork = "Facebook";

//             IFormatter formatter = new BinaryFormatter();
//             Stream stream = new FileStream("/Users/debashisdas/dadebash/Tutorial/MckBootcamp/serializationSession/ExampleNew.txt", FileMode.Create, FileAccess.Write);
//             formatter.Serialize(stream, dm);
//             stream.Close();

//             /* stream = new FileStream("/Users/debashisdas/dadebash/Tutorial/MckBootcamp/serializationSession/ExampleNew.txt", FileMode.Open, FileAccess.Read);
//             DigitalMarketing dmnewObj = (DigitalMarketing)formatter.Deserialize(stream);
//             Console.WriteLine(dmnewObj.customers);
//             Console.WriteLine(dmnewObj.socialNetwork);
//             Console.ReadKey();
//         } */
//     }


// }
// }