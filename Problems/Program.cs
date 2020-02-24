using System;

namespace Problems
{
    public class Program
    {
        public static void Main(string[] args)
        {
			bool booltester = true;
			Program randomprogram = new Program();
			while(booltester) {
			Console.WriteLine("Input message(exit with ./false:   ");
			string userinput = Console.ReadLine();
			if(userinput == "./false") break;
			string x = randomprogram.Prefix(userinput);
			Console.WriteLine(x);
			Console.ReadLine();
			}
        }
		public string Prefix (string input){
			int counter = 0;
			
			if (input == null) return null;
			string[] tester = input.Split(' ');
			
			for	(int i = 0; i < tester.Length; i++){
				if (tester[i] == ""){
				
				}
				else{
					counter++;
				}
				
				
			}
			return ("" + input.Length + "," + counter + ":" + input);
			
		}
		
    }
}
