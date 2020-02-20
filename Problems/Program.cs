using System;

namespace Problems
{
    public class Program
    {
        static void Main(string[] args)
        {
			Console.WriteLine("Input message:   ");
			string userinput = Console.ReadLine();
			string x = Prefix(userinput);
			Console.WriteLine(x);
			Console.ReadLine();
        }
		static string Prefix (string input){
			int counter = 0;
			if (input == null) return null;
			
			for (int i = 0; i < input.Length; i++){
				if (input[i] == ' ' || i == (input.Length -1)){
					counter++;
				}
			}
			
			
			/*StringBuilder str = new StringBuilder();
			str.append(str(input.Length));
			str.append(",");
			str.append(str(counter));
			str.append(":");
			str.append(input); */
			
			//return str.toString();
			return ("" + input.Length + "," + counter + ":" + input);
			
		}
		
    }
}
