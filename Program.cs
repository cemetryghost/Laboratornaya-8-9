namespace ConsoleApp7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            GenericArray<int> intArray = new GenericArray<int>(3);
            GenericArray<string> stringArray = new GenericArray<string>(2);
            GenericArray<double> floatArray = new GenericArray<double>(2);

            intArray.Add(0, 10);
            intArray.Add(1, 20);
            intArray.Add(2, 30);

            stringArray.Add(0, "Привет");
            stringArray.Add(1, "Мир");

            floatArray.Add(0, 1.12);
            floatArray.Add(1, 2.5);

            Console.WriteLine("Длина int массива: " + intArray.Length());
            Console.WriteLine("Длина string массива: " + stringArray.Length());
            Console.WriteLine("Длина double массива: " + floatArray.Length());

            Console.WriteLine("Элементы int массива: ");
            for (int i = 0; i < intArray.Length(); i++)
            {
                Console.WriteLine(intArray.Get(i));
            }

            intArray.Delete(0);

            Console.WriteLine("Массив после удаления элемента:");
            for (int i = 0; i < intArray.Length(); i++)
            {
                Console.WriteLine(intArray.Get(i));
            }

            LoginArray loginArray = new LoginArray(2);
            loginArray.Add(0, "user1");
            loginArray.Add(1, "user2");

            PasswordArray passwordArray = new PasswordArray(2);
            passwordArray.Add(0, "pass1");
            passwordArray.Add(1, "pass2");

            Console.WriteLine("Зарегистрированные пользователи:");
            for (int i = 0; i < loginArray.Length(); i++)
            {
                Console.WriteLine("Логин " + loginArray.Get(i) + ", Пароль: " + passwordArray.Get(i));
            }
        }
    }

    class GenericArray<T>
    {
        private T[] array;
        private int length;

        public GenericArray(int size)
        {
            array = new T[size];
            length = size;
        }

        public void Add(int index, T value)
        {
            array[index] = value;
        }

        public void Delete(int index)
        {
            for (int i = index; i < length - 1; i++)
            {
                array[i] = array[i + 1];
            }
            length--;
        }

        public T Get(int index)
        {
            return array[index];
        }

        public int Length()
        {
            return length;
        }
    }

    class LoginArray : GenericArray<string>
    {
        public LoginArray(int size) : base(size) { }
    }

    class PasswordArray : GenericArray<string>
    {
        public PasswordArray(int size) : base(size) { }
    }
}