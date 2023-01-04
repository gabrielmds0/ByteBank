using System;
using System.Text;
using System.Text.Json;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace ByteBank
{
    public class Utils
    {
        public static void WriteJSON(List<Conta> contas)
        {
            string filePath = @"C:\Users\gabri\Documents\contas.json";
            string jsonStringConta = JsonSerializer.Serialize(contas, new JsonSerializerOptions() { WriteIndented = true });
            using (StreamWriter outputFile = new StreamWriter(filePath))
                outputFile.WriteLine(jsonStringConta);
        }
        public static void ReadJson(List<Conta> contas) 
        {
            string filePath = @"C:\Users\gabri\Documents\contas.json";
            if(File.Exists(filePath))
            {
                using (StreamReader inputFile = new StreamReader(filePath))
                {
                    string json = inputFile.ReadToEnd();
                    contas = JsonSerializer.Deserialize<List<Conta>>(json);
                }
            }

        }


    }
}