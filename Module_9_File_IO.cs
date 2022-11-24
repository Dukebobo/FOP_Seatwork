/*
Project: FOP-Seatwork 1 - Finals
Instructor: Ms.Tan
Submit date: 3PM,Nov.24,2022 
*/
using System;
using System.IO;
using System.Text;

namespace FileIO
{
    class program
     {
        //main method
        static void Main(string[] args)
        {
            //declaring variables filename
            string filename = @"E:\csharpPractice\demo\products.txt";

            Create(filename);
            WriteFile(filename);
            ReadFile(filename);
            Console.ReadLine();
        }
        
        //create  file method
        static void Create(string filename)
        {
    
            // created a data object in E:\csharpPractice\demo\  filemode create, access read and write
            FileStream data = new FileStream(filename,FileMode.Create,FileAccess.ReadWrite);

            //file close
            data.Close();

            //print a message that the file has been created
            Console.WriteLine(@"1 . [File created] File has been careated and the Path is :  E:\\csharpPractice\\demo\\products.txt");

            Console.ReadLine();

        }

        //write file method
        static void WriteFile(string filename)
        {
            //declaring variables content 
            string content = "\n==========\n SKU:20221125\n ITEMNAME: XIAOMI LCD\n PRICE: 350,00 PHP \n QTY: 100 PCS \n==========\n  ";

            // created a data object filemode open, access read and write
            FileStream pd = new FileStream(filename, FileMode.Open, FileAccess.ReadWrite);

            //convert the string content into a byte array and save it in the variable bdata
            byte[] bdata = Encoding.Default.GetBytes(content);

            //write the byte array bdata to the file stream
            pd.Write(bdata, 0, bdata.Length);

            pd.Flush(); //refresh data in filestream

            pd.Close();

            //print a message that the file has been saved
            Console.WriteLine("\n2 . [File writed] Successfully saved file with products data !!");

            Console.ReadLine();

        }
        
        //read file method
        static void ReadFile(string filename)
        {
            //declaring variables readata
            string readdata;

            // created a data object filemode open, access read and write
            FileStream pdSource = new FileStream(filename, FileMode.Open, FileAccess.Read);
            
            //using streamReader class to read file
            using (StreamReader sr = new StreamReader(pdSource))
            { 
                readdata= sr.ReadToEnd();
            }
            
            //file close
            pdSource.Close();

            //print products.txt content
            Console.WriteLine("\n3 . [File read] The content in the txt file is: \n" + readdata);
            Console.WriteLine("\n Thanks !");

            Console.ReadLine();

        }

    }

}
