namespace Task_01 {
    public class Programm { 
        public static void Main (string [] arg){
            Console.WriteLine ("Решите задачу:");
            Console.WriteLine ("Задайте одномерный массив из 10 целых чисел от 1 до 100. Найдите количество элементов массива, значения которых лежат в отрезке [20,90].");
            Console.WriteLine ("Решите задачу:");
            Random rand = new Random();
            int [] array = new int [10];
            for (int i = 0; i<10 ; i++)
            { 
                array[i] = rand.Next(1,101);
            }
            foreach (int item in array ) 
            {
                Console.Write (item + " ");
            }
            Console.WriteLine ();
            int result = Recalculation (array);
            Console.WriteLine (result);
            
        }
        public static int Recalculation (int [] array){
            int result = 0;
            for (int i = 0; i<10; i++)
            {
                if (array [i] >= 20 && array [i] <= 90)
                {
                    result = result +1;
                }
            }
            return result;
        }
    }
}