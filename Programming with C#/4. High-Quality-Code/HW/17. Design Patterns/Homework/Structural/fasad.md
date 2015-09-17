В модела фасада,  фасада е обект, който предвижда опростена интерфейс за по-голямо обединение на код, като например библиотека клас. A фасада може да:

направи софтуерна библиотека лесна за използване, разбират и тестове, тъй като фасадата има удобни методи за общи задачи;
прави библиотеката по-разбираеми, по същата причина;
намаляване на зависимостта на границата код на вътрешната изработки на библиотека, тъй като повечето код използва фасадата, което позволява по-голяма гъвкавост в разработването на системата;
увийте лошо проектирани колекция от APIs с едно добре проектирана API.
Дизайн модел на фасадата се използва често, когато една система е много сложна или трудна за разбиране, защото системата има голям брой взаимосвързани класове или изходен код не е на разположение. Този модел се крие сложността на по-голяма система и осигурява по-опростен интерфейс на клиента. Това обикновено включва един-единствен лист клас, който съдържа набор от членовете се изисква от клиента. Тези членове имат достъп до системата от името на клиента фасада и крият подробностите по изпълнението.

### Моделът на фасадата обикновено се използва, когато:

-   прост интерфейс се изисква за достъп до сложна система;
-   абстракциите и приложения на подсистема са тясно свързани;
-   нужда от входна точка към всяко ниво на пластова софтуер; или
-   система е много сложна или трудна за разбиране.

### Структура
Пример за дизайн Фасада модел в UML.png

Пример
This is an abstract example of how a client ("you") interacts with a facade (the "computer") to a complex system (internal computer parts, like CPU and HardDrive).

# C Sharp

namespace IVSR.Designpattern.Facade
{
    class SubsystemA
    {
        public string OperationA1()
        {
            return "Subsystem A, Method A1\n";
        }
        public string OperationA2()
        {
            return "Subsystem A, Method A2\n";
        }
    }

    class SubsystemB
    {
        public string OperationB1()
        {
            return "Subsystem B, Method B1\n";
        }

        public string OperationB2()
        {
            return "Subsystem B, Method B2\n";
        }
    }

    class SubsystemC
    {
        public string OperationC1()
        {
            return "Subsystem C, Method C1\n";
        }

        public string OperationC2()
        {
            return "Subsystem C, Method C2\n";
        }
    }

    public class Facade
    {
        private SubsystemA a = new SubsystemA();
        private SubsystemB b = new SubsystemB();
        private SubsystemC c = new SubsystemC();
        public void Operation1()
        {
            Console.WriteLine("Operation 1\n" +
            a.OperationA1() +
            a.OperationA2() +
            b.OperationB1());
        }
        public void Operation2()
        {
            Console.WriteLine("Operation 2\n" +
            b.OperationB2() +
            c.OperationC1() +
            c.OperationC2());
        }
    }
}
