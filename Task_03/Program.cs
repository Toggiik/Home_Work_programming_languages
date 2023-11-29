namespace Home_Work { 
public class Task_03 {
		public static void Main (string [] arg){
			int size = 10;	
			double result; 
			double [] array = new double [size];
			Random rand = new Random(); 
			for (int i = 0; i < size; i++ ){ 
				array[i] = rand.NextDouble()+ rand.Next(0,20);
			}
			foreach (double item in array){ 
				System.Console.Write (item + " ");
			}
            System.Console.WriteLine();
			result  = MaxArray (array) - MinArray(array);
			System.Console.WriteLine(result);
		}
		public static double MinArray (double [] array){
			double min = array[0];
			for (int i = 0; i < array.Length; i++){
				if (min > array [i]) min = array [i];
			}
			return min;
		}
		public static double MaxArray (double [] array){
			double max= array[0];
			for (int i = 0; i < array.Length; i++){
				if (max < array [i]) max= array [i];
			}
			return max;	
		}
	}
}