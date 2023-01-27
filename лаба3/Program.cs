using System.ComponentModel.DataAnnotations;

internal class Program
{
    private static void Main(string[] args)
    {
        int min = 0;
        int min21 = 0;
        int min3 = 0;
        int min7 = 0;
        Random rnd = new Random();
        int[] array = new int[1000];
        for (int i = 0; i < array.Length; i++)
            array[i] = rnd.Next(1, 10000);
        for (int i = 0; i < array.Length; i++)
        {

            if (array[i] % 21 == 0 && array[i] < min21) min21 = array[i];

            if (array[i] % 3 == 0 && array[i] < min3) min3 = array[i];

            if (array[i] % 7 == 0 && array[i] < min7) min7 = array[i];

            if (array[i] > min) min = array[i];
        }
        if (min21 < min7 && min21 < min3 && min21 < min &&
            min3 < min21 && min3 < min7 && min3 < min &&
            min7 < min21 && min7 < min3 && min7 < min &&
            min < min21 && min < min3 && min < min7)
        {
            Console.WriteLine("есть");
        }
        else
        {
            Console.WriteLine("-1");
        }
    }
}