using System;
using static System.Console;
using System.Threading;
using Newtonsoft.Json;
using System.IO;

namespace Console_LookZay
{
    class Json_Gen
    {

        public const String json_figlet = @"      _  _____  ____  _   _  _____ ______ _   _ ______ _____         _______ ____  _____  
     | |/ ____|/ __ \| \ | |/ ____|  ____| \ | |  ____|  __ \     /\|__   __/ __ \|  __ \ 
     | | (___ | |  | |  \| | |  __| |__  |  \| | |__  | |__) |   /  \  | | | |  | | |__) |
 _   | |\___ \| |  | | . ` | | |_ |  __| | . ` |  __| |  _  /   / /\ \ | | | |  | |  _  / 
| |__| |____) | |__| | |\  | |__| | |____| |\  | |____| | \ \  / ____ \| | | |__| | | \ \ 
 \____/|_____/ \____/|_| \_|\_____|______|_| \_|______|_|  \_\/_/    \_\_|  \____/|_|  \_\";

        public static void createJsonItemBasic(StreamWriter sw, String textureName)
        {
            sw.WriteLine("{");
            sw.WriteLine("    \"parent\": \"builtin/generated\",");
            sw.WriteLine("    \"textures\": {");
            sw.WriteLine("        \"layer0\": \"items/" + textureName + "\"");
            sw.WriteLine("    },");
            sw.WriteLine("    \"display\": {");
            sw.WriteLine("        \"thirdperson\": {");
            sw.WriteLine("            \"rotation\": [ -90, 0, 0 ],");
            sw.WriteLine("            \"translation\": [ 0, 1, -3 ],");
            sw.WriteLine("            \"scale\": [ 0.55, 0.55, 0.55 ]");
            sw.WriteLine("        },");
            sw.WriteLine("        \"firstperson\": {");
            sw.WriteLine("            \"rotation\": [ 0, -135, 25 ],");
            sw.WriteLine("            \"translation\": [ 0, 4, 2 ],");
            sw.WriteLine("            \"scale\": [ 1.7, 1.7, 1.7 ]");
            sw.WriteLine("        }");
            sw.WriteLine("    }");
            sw.WriteLine("}");
            sw.Close();
        }
        public static void createJsonItemTools(StreamWriter sw, String textureName)
        {
            sw.WriteLine("{");
            sw.WriteLine("    \"parent\": \"builtin/generated\",");
            sw.WriteLine("    \"textures\": {");
            sw.WriteLine("        \"layer0\": \"items/" + textureName + "\"");
            sw.WriteLine("    },");
            sw.WriteLine("    \"display\": {");
            sw.WriteLine("        \"thirdperson\": {");
            sw.WriteLine("            \"rotation\": [ 0, 90, -35 ],");
            sw.WriteLine("            \"translation\": [ 0, 1.25, -3.5 ],");
            sw.WriteLine("            \"scale\": [ 0.85, 0.85, 0.85 ]");
            sw.WriteLine("        },");
            sw.WriteLine("        \"firstperson\": {");
            sw.WriteLine("            \"rotation\": [ 0, -135, 25 ],");
            sw.WriteLine("            \"translation\": [ 0, 4, 2 ],");
            sw.WriteLine("            \"scale\": [ 1.7, 1.7, 1.7 ]");
            sw.WriteLine("        }");
            sw.WriteLine("    }");
            sw.WriteLine("}");
            sw.Close();
        }

        public static void createJsonBlockStates(StreamWriter sw, String blockName)
        {
            sw.WriteLine("{");
            sw.WriteLine("    \"variants\": {");
            sw.WriteLine("        \"normal\": { \"model\": \"" + blockName + "\" }");
            sw.WriteLine("}");
            sw.Close();
        }

        public static void createJsonBlock(StreamWriter sw, String textureName)
        {
            sw.WriteLine("{");
            sw.WriteLine("    \"parent\": \"block/cube_all\",");
            sw.WriteLine("    \"textures\": {");
            sw.WriteLine("        \"all\": \"block/" + textureName + "\"");
            sw.WriteLine("    }");
            sw.WriteLine("}");
            sw.Close();
        }
    }
}
