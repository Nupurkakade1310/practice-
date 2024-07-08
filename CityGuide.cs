class CityGuide
{
	public static void main( )
	{
		Console.WriteLine("Select your choice");
		Console.WriteLine("London");
		Console.WriteLine("Bombay");
		Console.WriteLine("Paris");
		Console.WriteLine("Type-0 your choice");
		String name = Console.ReadLine( );

		switch (name)
		{
			case "Bombay":
			      Console.WriteLine("Bombay:Guide 5");
			      break;
			case "London":
			      Console.WriteLine("London:Guide 10");
			      break;	
		         case "Bombay":
			      Console.WriteLine("Paris:Guide 15");
			      break;	
			 default:
			      Console.WriteLine ("Invalid choice");
		}
         }
	
		
		
		