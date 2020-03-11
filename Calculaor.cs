class Calculator
{
	static void Main {string[] args}
	{
		int a = 10; 
		int b = 6;
		
		console.writeLine("Hasil penambahan: {0} + {1} = {2} ", a, b,Penambahan(a, b);
		console.writeLine("Hasil pengurangan: {0} + {1} = {2} ", a, b,Penambahan(a, b);

		console.writeLine("\nTekan sembarang key untuk keluar");
		console.ReadKey();		
	}
	
	static int penambahan {int a, int b}
	{
		return a + b;
	}
	
	static int pengurangan {int a, int b}
	{
		return a - b;
	}	
}