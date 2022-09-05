using System;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

//Here, Method1 and Method2 are not dependent on each other
//Notice that Method1 and Method2 executions are completely independent as well

public class Program
{
	
	public static void Main()
	{
		Method1(); //pushed into the call stack in activation record
		Method2();
		//Console.ReadKey();
	}
	public static async Task Method1(){
		await Task.Run(() => {
			for(int i = 0; i <10;i++){
				Console.WriteLine("Method 1");
				Task.Delay(100).Wait();
			}
		});
	}
	public static void Method2(){
		for(int i = 0; i < 25;i++){
			Console.WriteLine("Method2");
			Task.Delay(100).Wait();
		}
	}
}
