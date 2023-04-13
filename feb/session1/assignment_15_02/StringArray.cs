class StringArray{
	static void Main(){
	int size;
	System.Console.Write("Enter the size of String Array : ");
	size = System.Convert.ToInt32(System.Console.ReadLine());
	string[] StringArray = new string[size];
	System.Console.WriteLine("Enter {0} name in StringArray",size);	
	for(int i=0;i<size;i++)
	StringArray[i] = System.Console.ReadLine();
	for(int i=0;i<size;i++)
		System.Console.WriteLine("Element of Array at index {0} is {1}",i,StringArray[i]);		
	}
}