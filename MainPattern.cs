Class Pattern
{
	int b;
	public Pattern(int x);
	{
		b=x;
		for(int i=1;i<=b;i++)
		{
			System.Console.WriteLine();
			for(int j=1;j<=i;j++)
			{
				System.Console.Write(i);
			}
		}
		
	}
}
				
Class MainPattern
{
	public static void Main(string[] args)
	{
		Pattern obj = new Pattern(5);
	}
}
	