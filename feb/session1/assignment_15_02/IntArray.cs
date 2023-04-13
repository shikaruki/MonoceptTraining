class IntArray{
	static void Main(){
	int size;
	System.Console.Write("Enter the size of Array : ");
	size = System.Convert.ToInt32(System.Console.ReadLine());

	int[] arr = new int[size];
	System.Console.WriteLine("Enter the element in array");	

	for(int i=0;i<size;i++)
	arr[i] = System.Convert.ToInt32(System.Console.ReadLine());
	for(int i=0;i<size;i++)
		System.Console.WriteLine("Element of Array at index {0} is {1}",i,arr[i]);
	}
}