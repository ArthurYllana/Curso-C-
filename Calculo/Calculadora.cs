namespace Calculo
{
    public class Calculadora
    {
        public static void Triple (int origin, out int result){
            result = origin * 3;
        }
        //public static void Triple(ref int x){
          //  x = x * 3;
        //}


        /*
        public static int Sum(params int[] numbers){
            int sum = 0;
            for(int i = 0; i < numbers.Length; i++){
                sum += numbers[i];
            }
            return sum;
        }
        */
    }
}