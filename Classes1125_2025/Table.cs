// классы располагаются в пространствах имен
namespace TestNamespace
{
    public class Table
    {
        private string title;

        // короткая запись свойства 
        // для случаев, когда нет смысла проверять 
        // назначаемое значение или вычислять возращаемое
        public string Title {
            get => title;
            set
            {
                title = value;
                // вызов события с передачей аргументов
                // this - ссылка на текущий объект
                // this.title - новое значение
                // ?.Invoke - запуск события 
                // с проверкой на наличие подписчиков
                // если их нет, то событие не произойдет
                TitleChanged?.Invoke(this, this.title);
            }
        }
        public int Height { get; set; }
        public int Width { get; set; }
        public string Color { get; set; }

        // деструктор
        ~Table()
        {
            Console.WriteLine("Сработал деструктор объекта Table");
            Console.WriteLine(Title);
        }

        // объявление события
        // на событие подписываются объекты извне (также как на делегаты)
        // но вызвать событие может только класс
        // внутри которого оно объявляено (в отличие от делегата)
        public event EventHandler<string> TitleChanged;
    }
}