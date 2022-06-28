namespace Advanced_Generics
{
    public class Creator<T>
    {
        public T Id { get; set; }
        public static T2[] CreateArray<T2>(int count, T2 item)
        {
            var array = new T2[count];
            for (int i = 0; i < count; i++)
            {
                array[i] = item;
            }
            return array;
        }
        public static int[] CreateArray(int count, int item)
        {
            var array = new int[count];
            for (int i = 0; i < count; i++)
            {
                array[i] = item;
            }
            return array;
        }
    }
}