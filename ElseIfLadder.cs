Class ElseIfLadder
{
	public static void Main()
	{

		int[] roll Number = { 111, 222, 333, 444 }; 
		int[] marks = { 81, 75, 43, 58 };

		for (int i = 0; i < roll Number. Length;  i++)
		{

		   if (marks[i] > 79) 
		     Console. WriteLine(roll Number[i]  + " Honours");

		   else if (marks[i] > 59) 
			  Console. WriteLine(roll Number[i] + " I Division");
 
			else if (marks[i] > 49) 
			       Console. WriteLine(roll Number[i] + " II Division");

			     else Console. WriteLine(roll Number[i] + " FAIL");

		}

	}

}