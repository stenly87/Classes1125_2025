// классы располагаются в пространствах имен
namespace TestNamespace
{
    public class Group
    {
        // для простого примера используем массив
        // хотя данные могут храниться как угодно
        string[] students = new string[30];

        public int StudentCount
        {
            get
            {
                return students.Length;
            }
        }
        // пример индексатора
        // индексатор возвращает и получает тип string
        // но можно использовать любые типы, от программиста
        // зависит то, как будет генерироваться ответ
        // и как будет обрабатываться получаемое значение
        public string this[int index]
        {
            get
            {
                if (index < 0 || index >= students.Length)
                    throw new Exception("Неверный индекс");
                return students[index];
            }
            set
            {
                if (index < 0 || index >= students.Length)
                    throw new Exception("Неверный индекс");
                students[index] = value;
            }
        }


    }
}