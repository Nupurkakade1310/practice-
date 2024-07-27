class Ex
{
	public void Fun( )
	{
		System.Console.WriteLine("Select your choice");
		System.Console.WriteLine("London");
		System.Console.WriteLine("Bombay");
		System.Console.WriteLine("Paris");
		System.Console.WriteLine("Type-0 your choice");
		String name = Console.ReadLine( );

		switch (name)
		{
			case "Bombay":
			      System.Console.WriteLine("Bombay:Guide 5");
			      break;
			case "London":
			      System.Console.WriteLine("London:Guide 10");
			      break;	
		         case "Bombay":
			      System.Console.WriteLine("Paris:Guide 15");
			      break;	
			 default:
			      System.Console.WriteLine ("Invalid choice");
		}
         }
}
class CityGuide
{
	public static void main( )
	{
		Ex obj=new Ex();
		obj.Fun();
	}
}
	
	
		
		
		