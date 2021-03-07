using System;
using static System.Console;
using System.Threading;
using Newtonsoft.Json;
using System.IO;

namespace Console_LookZay
{
    class Main
    {

        static void Main(string[] args)
        {
            Console.Title = "JSON Creator";
            mainmenu();
        }

        public static void headerJsonCreator(ConsoleColor color)
        {
            Console.Clear();
            Console.ForegroundColor = color;
            Console.WriteLine(Json_Gen.json_figlet);
            Console.WriteLine("");
        }

        static void mainmenu()
        {
            headerJsonCreator(ConsoleColor.White);
            Console.WriteLine("[1] Item Creator");
            Console.WriteLine("[2] Block Creator");
            Console.WriteLine("[3] Credits");
            Console.WriteLine("[4] Exit");
            Console.WriteLine("");
            Console.Write("Choose Generator : ");
            string input = Console.ReadLine();

            if (input == "1")
            {
                itemgenerator();
            }
            else if (input == "2")
            {
                blockgenerator();
            }
            else if (input == "3")
            {
                credits(); 
            }
            else if (input == "4")
            {
                exit();
            }
            else
            {
                error_number();
            }
        }

        public static void itemgenerator()
        {
            headerJsonCreator(ConsoleColor.White);
            Console.WriteLine("[1] Is Basic Item");
            Console.WriteLine("[2] Is Tool");
            Console.WriteLine("[3] Home");
            Console.WriteLine("");
            Console.Write("Choose Item Options : ");
            string input = Console.ReadLine();

            if (input == "1")
            {
                itemgenerator_basic();
            }

            if (input == "2")
            {
                itemgenerator_tools();
            }

            if (input == "3")
            {
                mainmenu();
            }

            else
            {
                error_number();
            }
        }

        public static void itemgenerator_basic()
        {
            headerJsonCreator(ConsoleColor.White);
            Console.Write("Texture Name : ");
            string textureName = Console.ReadLine();
            Console.Write("Item Name : ");
            string itemName = Console.ReadLine();

            String path_export = "./export";
            String path_models = "./export/models/";
            String path_item = "./export/models/item/";

            DirectoryInfo di = Directory.CreateDirectory(path_export);
            DirectoryInfo di1 = Directory.CreateDirectory(path_models);
            DirectoryInfo di2 = Directory.CreateDirectory(path_item);

            StreamWriter sw = new StreamWriter(@"./export/models/item/" + itemName + ".json");
            Json_Gen.createJsonItemBasic(sw, textureName);
            successfully_item(itemName, false);
        }


        public static void itemgenerator_tools()
        {
            headerJsonCreator(ConsoleColor.White);
            Console.Write("Texture Name : ");
            string textureName = Console.ReadLine();
            Console.Write("Item Name : ");
            string itemName = Console.ReadLine();

            String path_export = "./export";
            String path_models = "./export/models/";
            String path_item = "./export/models/item/";

            DirectoryInfo di = Directory.CreateDirectory(path_export);
            DirectoryInfo di1 = Directory.CreateDirectory(path_models);
            DirectoryInfo di2 = Directory.CreateDirectory(path_item);

            StreamWriter sw = new StreamWriter(@"./export/models/item/" + itemName + ".json");
            Json_Gen.createJsonItemTools(sw, textureName);
            successfully_item(itemName, true);
        }

        public static void blockgenerator_basic()
        {
            headerJsonCreator(ConsoleColor.White);
            Console.Write("Texture Name : ");
            string textureName = Console.ReadLine();
            Console.Write("Block Name : ");
            string blockName = Console.ReadLine();

            String path_export = "./export";
            String path_blockstates = "./export/blockstates/";
            String path_models = "./export/models/";
            String path_block = "./export/models/block/";

            DirectoryInfo di = Directory.CreateDirectory(path_export);
            DirectoryInfo di1 = Directory.CreateDirectory(path_blockstates);
            DirectoryInfo di2 = Directory.CreateDirectory(path_models);
            DirectoryInfo di3 = Directory.CreateDirectory(path_block);

            StreamWriter sw = new StreamWriter(@"./export/models/block/" + blockName + ".json");
            StreamWriter bw = new StreamWriter(@"./export/blockstates/" + blockName +".json");
            Json_Gen.createJsonBlock(sw, textureName);
            Json_Gen.createJsonBlockStates(bw, blockName);
            successfully_block(blockName);
        }

        public static void successfully_block(String blockName)
        {
            headerJsonCreator(ConsoleColor.Green);
            Console.WriteLine("Block " + blockName + " is successfully created !");
            Console.WriteLine("");
            Console.WriteLine("[1] Home");
            Console.WriteLine("[2] Exit");
            Console.WriteLine("");
            Console.Write("Choose Options : ");
            string input = Console.ReadLine();

            if (input == "1")
            {
                mainmenu();
            }
            else if (input == "2")
            {
                exit();
            }
            else
            {
                error_number();
            }
        }

        public static void successfully_item(String itemName, Boolean isTool)
        {
            headerJsonCreator(ConsoleColor.Green);
            if (isTool == true)
            {
                Console.WriteLine("Item Tool " + itemName + " is successfully created !");
                Console.WriteLine("");
            }
            else
            {
                Console.WriteLine("Item " + itemName + " is successfully created !");
                Console.WriteLine("");
            }
            Console.WriteLine("[1] Home");
            Console.WriteLine("[2] Exit");
            Console.WriteLine("");
            Console.Write("Choose Options : ");
            string input = Console.ReadLine();

            if (input == "1")
            {
                mainmenu();
            }
            else if (input == "2")
            {
                exit();
            }
            else
            {
                error_number();
            }
        }

        public static void error_number()
        {
            headerJsonCreator(ConsoleColor.Red);
            Console.WriteLine("Error, this number is not valid!");
            Console.WriteLine("");
            Console.WriteLine("[1] Home");
            Console.WriteLine("[2] Exit");
            Console.WriteLine("");
            Console.Write("Choose Options : ");
            string input = Console.ReadLine();

            if (input == "1")
            {
                mainmenu();
            }
            else if (input == "2")
            {
                exit();
            }
            else
            {
                error_number();
            }
        }

        public static void soon()
        {
            headerJsonCreator(ConsoleColor.Red);
            Console.WriteLine("Error, It's coming soon !");
            Console.WriteLine("");
            Console.WriteLine("[1] Home");
            Console.WriteLine("[2] Exit");
            Console.WriteLine("");
            Console.Write("Choose Options : ");
            string input = Console.ReadLine();

            if (input == "1")
            {
                mainmenu();
            }
            else if (input == "2")
            {
                exit();
            }
            else
            {
                error_number();
            }
        }


        public static void blockgenerator()
        {
            headerJsonCreator(ConsoleColor.White);
            Console.WriteLine("[1] Is Basic Block");
            Console.WriteLine("[2] S.O.O.N");
            Console.WriteLine("[3] Home");
            Console.WriteLine("");
            Console.Write("Choose Item Options : ");
            string input = Console.ReadLine();

            if (input == "1")
            {
                blockgenerator_basic();
            }

            if (input == "2")
            {
                blockgenerator();
            }

            if (input == "3")
            {
                mainmenu();
            }

            else
            {
                error_number();
            }
        }

        public static void credits()
        {
            headerJsonCreator(ConsoleColor.Blue);
            Console.WriteLine("This Json creator was developed by LookZay");
            Console.WriteLine("");
            Console.WriteLine("My Discord : LookZay#1182");
            Console.WriteLine("My Github : LookZay");
            Console.WriteLine("");
            Console.WriteLine("[1] Home");
            Console.WriteLine("[2] Exit");
            Console.WriteLine("");
            Console.Write("Choose Options : ");
            string input = Console.ReadLine();

            if (input == "1")
            {
                mainmenu();
            }
            else if (input == "2")
            {
                exit();
            }
            else
            {
                error_number();
            }
        }

        public static void exit()
        {
            headerJsonCreator(ConsoleColor.Green);
            Console.WriteLine("Bye !");
            Console.ForegroundColor = ConsoleColor.White;

            Thread.Sleep(1000);
            Environment.Exit(0);
        }
    }
}
