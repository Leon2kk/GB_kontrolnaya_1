namespace GB
{
    // ["hello", "2", "world", ":-)"] -> ["2", ":-)"]

    class kr_1
    {
        public static void Main()
        {
            Console.Clear();
           
            string[]  mas = new string[] {"hello", "2", "world", ":-)"},
                      res = new string[mas.Length];
            
            int i = 0;
            foreach(string item in mas)
            {
                if (item.Length <= 3)
                {
                    res[i++] = item;
                }
            }
            //удаляем Null элементы
            res = res.Where(item => item != null).ToArray();

            Console.WriteLine("[" +String.Join(", ", mas) +"] -> [" + String.Join(", ", res)+"] \n");
        }
    }
}