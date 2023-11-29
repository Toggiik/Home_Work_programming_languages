﻿namespace Task_01 {
public class Task_02 {
		public static void Main (string [] arg){
			int size = 10;	
			int [] array = new int [size];
			Random rand = new Random(); 
			int count = 0;
			for (int i = 0; i < size; i++ ){ 
				array[i] = rand.Next(0,20);
			}
			foreach (int item in array){ 
				System.Console.Write (item + " ");
			}
            System.Console.WriteLine();
			for (int i = 0; i < size; i++ ){ 
				if (array [i]%2==0) count++; 
			}
			System.Console.Write (count);
		}
	}
}    