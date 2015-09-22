
#Facade
1.	Цел на шаблона  - предоставяне на интерфейс за достъп до сложна системата от класове.
2.	Структура:
 
![alt text](https://raw.githubusercontent.com/tddold/Telerik-Academy/master/Programming%20with%20C%23/4.%20High-Quality-Code/HW/17.%20Design%20Patterns/Homework/Structural/Picture/Facade.png)

3.	Приложения: 
 -  Уеб услугите (web services) могат да се разглеждат като реализация на фасада, когато нямат собствена бизнес логика, а са дефинирани за предоставяне на достъп до дадена система.
 - Чрез прост интерфейс се достъпва до сложна система;
 - Абстракциите и приложения на подсистема са тясно свързани;
 - Нужда от входна точка към всяко ниво на много пластова софтуер;
 - Система е много сложна или трудна за разбиране.
4.	Свързани шаблони – “Abstract Factory” и “Sigleton”

Примерен код:
```
namespace Facade.Example
{
    using System;

    /// <summary>
    /// MainApp startup
    /// Facade Design Pattern.
    /// </summary>
    public class MainApp
    {
        /// <summary>
        /// Entry point into console application.
        /// </summary>
        public static void Main()
        {
            // Facade
            Mortgage mortgage = new Mortgage();

            // Evaluate mortgage eligibility for customer
            Customer customer = new Customer("Pesho");

            bool eligible = mortgage.IsEligible(customer, 125000);

            Console.WriteLine();
            Console.WriteLine("{0} has been {1}", customer.Name, eligible ? "Approved" : "Rejected");
        }
    }
    
    /// <summary>
    /// Subsystem A
    /// </summary>
    internal class Loan
    {
        public bool HasNoBadLoans(Customer c)
        {
            Console.WriteLine("Check loans for {0}", c.Name);

            return true;
        }
    }
    
    /// <summary>
    /// Subsystem B
    /// </summary>
    internal class Credit
    {
        public bool HasGoodCredit(Customer c)
        {
            Console.WriteLine("Check credit for {0}", c.Name);

            return true;
        }
    }
    
    /// <summary>
    /// Subsystem C
    /// </summary>
    internal class Bank
    {
        public bool HasSufficientSavings(Customer c, int amount)
        {
            Console.WriteLine("Check bank for " + c.Name);

            return true;
        }
    }
    
    /// <summary>
    /// Out customer class
    /// </summary>
    public class Customer
    {
        private string name;

        // Constructor
        public Customer(string name)
        {
            this.name = name;
        }

        // Gets the name
        public string Name
        {
            get
            {
                return this.name;
            }
        }
    }
    
    /// <summary>
    /// Our Facade class
    /// </summary>
    public class Mortgage
    {
        private Bank bank = new Bank();

        private Loan loan = new Loan();

        private Credit credit = new Credit();

        public bool IsEligible(Customer cust, int amount)
        {
            Console.WriteLine(
                "{0} applies for {1:C} loan\n",
                cust.Name, 
                amount);

            bool eligible = true;

            // Check creditworthyness of applicant
            if (!this.bank.HasSufficientSavings(cust, amount))
            {
                eligible = false;
            }
            else if (!this.loan.HasNoBadLoans(cust))
            {
                eligible = false;
            }
            else if (!this.credit.HasGoodCredit(cust))
            {
                eligible = false;
            }

            return eligible;
        }
    }
}

```


## Composite method pattern

### Мотивация
* Позволява да се обединяват различни типове обекти в дървовидни структури.
* Дава възможност да се третират еднакво отделни обекти или групи от обекти.
* Улеснява добавянето на нови видове компоненти.

### Цел
* При работата с различни обекти, когато има нужда разликите между тях да бъдат игнорирани и да бъдат третирани еднакво.
* При представяне на йерархия от съставни обекти.

### Имплементация 

###### UIControl (Component)

```c#
public abstract class UIControl
    {
        public UIControl()
        { 
            
        }
        public string Name { get; set; }
        public int Width { get; set; }
        public ConsoleColor Color { get; set; }

        public abstract void Display(int depth);
    }
```

###### TextArea (Composite)

```c#
 public class TextArea : UIControl
    {
        private readonly ICollection<UIControl> controls;

        public TextArea()
            : base()
        {
            this.controls = new List<UIControl>();
            this.Name = " Text Area ";
            this.Width = 40;
        }

        public TextArea(string text, ConsoleColor color)
            : this()
        {
            this.Text = text;
            this.Color = color;
        }

        public string Text { get; set; }

        public void Add(UIControl control)
        {
            this.controls.Add(control);
        }


        public override void Display(int depth)
        {
           // Do something. (Probably ugly if you want to draw over the console.. like in the demo provided)
        }
    }
```

###### Button (Leaf)

```c#
  public class Button : UIControl
    {
        public Button()
        {
            this.Name = " Click me! ";
        }

        public Button(ConsoleColor color)
            : this()
        {
            this.Color = color;
        }

        public override void Display(int depth)
        {
            var space = new string(' ', depth);
            var line = new string('-', this.Name.Length + 2);

            Console.ForegroundColor = this.Color;
            Console.WriteLine($"{space}{line}");
            Console.WriteLine($"{space}{"|"}{this.Name}{"|"}");
            Console.WriteLine($"{space}{line}");
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
```
###### Usage
```c#
class Client
    {
        static void Main()
        {
            var mainContent = new TextArea("Hello world!", ConsoleColor.Cyan);
            var innerContent = new TextArea("I'm inner!", ConsoleColor.Green);
            var button = new Button(ConsoleColor.Blue);           

            innerContent.Add(button);
            mainContent.Add(innerContent);
            mainContent.Add(button);

            mainContent.Display(1);       
        }
    }
```
### Структура
![Composite](https://raw.githubusercontent.com/atanas-georgiev/High-Quality-Code-Homeworks/master/17.%20Design%20Patterns/Structural/images/Composite.png)

#Flyweight 
Flyweight е структурен шаблон за дизайн, неговата цел е намаляване на използваната памет от обекти сходни по между си. Той се състой от две части, част която е споделена между сходните обекти и е една за всички тях и част която е отличителна за всеки от тях. За създаване на обекти този шаблон използва Factory(Creational Design Pattern). 
![alt text](https://raw.githubusercontent.com/iovigi/Telerik-Academy/master/High-Quality-Code-master/17.%20Design%20Patterns/StructuralDesignPatternHomework/Flyweight/uml.gif)

#Proxy
1.	Цел на шаблона - предоставяне на заместник или контейнер за даден реален обект, позволявайки контролиран достъп до него.
2.	Структура:

![alt text](https://raw.githubusercontent.com/tddold/Telerik-Academy/master/Programming%20with%20C%23/4.%20High-Quality-Code/HW/17.%20Design%20Patterns/Homework/Structural/Picture/Proxy.png)

3.	Приложения: 
	-	има множество приложения – примерно: 
		- Aspect - Oriented Programming – AOP
		- Java RMI и т.н.

4.	Свързани шаблони – „Adaptor” и “Decorator”

Примерен код:

```

	namespace Proxy.Example
	{
	    using System;
	
	    /// <summary>
	    /// MainApp startup class
	    /// Proxy Design Pattern.
	    /// </summary>
	    public class MainApp
	    {
	        /// <summary>
	        /// Entry point into console application.
	        /// </summary>
	        public static void Main()
	        {
	            // Create math proxy
	            MathProxy proxy = new MathProxy();
	
	            // Do the math
	            Console.WriteLine("4 + 2 = {0}", proxy.Add(4, 2));
	
	            Console.WriteLine("4 - 2 = {0}", proxy.Sub(4, 2));
	
	            Console.WriteLine("4 * 2 = {0}", proxy.Mul(4, 2));
	
	            Console.WriteLine("4 / 2 = {0}", proxy.Div(4, 2));
	        }
	    }

		/// <summary>
	    /// The 'Subject interface
	    /// </summary>
	    public interface IMath
	    {
	        double Add(double x, double y);
	
	        double Sub(double x, double y);
	
	        double Mul(double x, double y);
	
	        double Div(double x, double y);
	    }
	
		/// <summary>
	    /// The 'RealSubject' class
	    /// </summary>
	    public class Math : IMath
	    {
	        public double Add(double x, double y)
	        {
	            return x + y;
	        }
	
	        public double Sub(double x, double y)
	        {
	            return x - y;
	        }
	
	        public double Mul(double x, double y)
	        {
	            return x * y;
	        }
	
	        public double Div(double x, double y)
	        {
	            return x / y;
	        }
	    }
	
		/// <summary>
	    /// The 'Proxy Object' class
	    /// </summary>
	    public class MathProxy : IMath
	    {
	        private Math math = new Math();
	
	        public double Add(double x, double y)
	        {
	            return this.math.Add(x, y);
	        }
	
	        public double Sub(double x, double y)
	        {
	            return this.math.Sub(x, y);
	        }
	
	        public double Mul(double x, double y)
	        {
	            return this.math.Mul(x, y);
	        }
	
	        public double Div(double x, double y)
	        {
	            return this.math.Div(x, y);
	        }
	    }
	}


```


## Decorator pattern

### Мотивация

* Позволява да добавяме функционалност към съществуващ обект по време на изпълнение на порграмата.
* Пази референция към оригиналния обект, към който се добавя функционалността на декоратора.
* Обекта, към който се добавя функционалността не знае за нея
* Спазва Open/Closed принципа

### Цел
При проблем с експоненциално нарастване на наследяване.

### Имплементация 

###### Pancake (Component)

```c#
public abstract class Pancake
    {
        protected string Description { get; set; }
        protected double Calories { get; set; }

        public abstract double CalculateCalories();
        public abstract string GetDescription();
        public  void Display()
        {
              Console.WriteLine($"{this.GetDescription()}{Environment.NewLine}Calories: {this.CalculateCalories()}");
        }
    }
```

###### WholeGrainPancake (ConcreteComponent)

```c#
public class WholeGrainPancake : Pancake
    {

        public WholeGrainPancake()
        {
            this.Calories = 50;
            this.Description = "Healthy whole grain pancake!";
        }

        public override double CalculateCalories()
        {
            return this.Calories;
        }

        public override string GetDescription()
        {
            return this.Description;
        }

       
    }
```

###### GlutenFreePancake (ConcreteComponent)

```c#
 public class GlutenFreePancake : Pancake
    {
        public GlutenFreePancake()
        {
            this.Calories = 40;
            this.Description = "Gluten-free pancake!";
        }

        public override double CalculateCalories()
        {
            return this.Calories;
        }

        public override string GetDescription()
        {
            return this.Description;
        }
    }
```

###### PancakeDecorator (Decorator)

```c#
public abstract class PancakeDecorator : Pancake
    {
        public PancakeDecorator(Pancake pancake)
        {
            this.Pancake = pancake;
        }

        protected Pancake Pancake { get; set; }
    } 
```

###### ChocolateDecorator (ConcreteDecorator)
```c#
 public class ChocolateDecorator : PancakeDecorator
    {
        public ChocolateDecorator(Pancake pancake)
            : base(pancake)
        {
        }

        public override double CalculateCalories()
        {
            return this.Pancake.CalculateCalories() + 55.50;
        }

        public override string GetDescription()
        {
            return this.Pancake.GetDescription() + "\n\t + chocolate;";
        }
    }
```

###### BananaDecorator (ConcreteDecorator)
```c#
public class BananaDecorator : PancakeDecorator
    {
        public BananaDecorator(Pancake pancake)
            : base(pancake)
        {
        }

        public override double CalculateCalories()
        {
            return this.Pancake.CalculateCalories() + 33.30;
        }

        public override string GetDescription()
        {
            return this.Pancake.GetDescription() + "\n\t + banana;";
        }
    }
```
###### AgaveDecorator (ConcreteDecorator)
```c#
public class AgaveDecorator : PancakeDecorator
    {
        public AgaveDecorator(Pancake pancake)
            : base(pancake)
        {
        }

        public override double CalculateCalories()
        {
            return this.Pancake.CalculateCalories() + 20.6;
        }

        public override string GetDescription()
        {
            return this.Pancake.GetDescription() + "\n\t + agave syrup;";
        }
    }
```


###### Usage
```c#
public class Client
    {
        static void Main()
        {
            var pancake = new WholeGrainPancake();
            var pancakeWithChocolate = new ChocolateDecorator(pancake);
            var pancakeWithChocolateAndBanana = new BananaDecorator(pancakeWithChocolate);

            pancakeWithChocolateAndBanana.Display();

            Console.WriteLine(new string('=', 40));

            var glutenFreePancake = new GlutenFreePancake();
            var glutenFreePancakeWithBanana = new BananaDecorator(glutenFreePancake);
            var glutenFreePancakeWithBananaAndAgave = new AgaveDecorator(glutenFreePancakeWithBanana);

            glutenFreePancakeWithBananaAndAgave.Display();
        }
    }
```	

### Структура
![Decorator](https://raw.githubusercontent.com/atanas-georgiev/High-Quality-Code-Homeworks/master/17.%20Design%20Patterns/Structural/images/Decorator.png)

# Adapter

1.	Цел на шаблона:
 - преобразува интерфейса на даден клас, така че да може да бъде използван от клиента.
 * Позволява на класове с несъвместими интерфейси да работят заедно.


2.	Структура:

<p align="center"><a href="https://github.com/tddold/Telerik-Academy/blob/master/Programming%20with%20C%23/4.%20High-Quality-Code/HW/17.%20Design%20Patterns/Homework/Structural/Picture/adapter.gif"><img src="https://github.com/tddold/Telerik-Academy/blob/master/Programming%20with%20C%23/4.%20High-Quality-Code/HW/17.%20Design%20Patterns/Homework/Structural/Picture/adapter.gif" /></a></p>
![alt text](https://raw.githubusercontent.com/tddold/Telerik-Academy/master/Programming%20with%20C%23/4.%20High-Quality-Code/HW/17.%20Design%20Patterns/Homework/Structural/Picture/adapter.gif)

3.	Приложения: 
 	
	- налага при наличието на несъвместими интерфейси. 
 
В зависимост от употребата на адаптера, шаблонът е наричан още wrapper и translator.

Компоненти:

 * *__Target:__* Дефинира специфичния интерфейс, който клиентът използва.
 * *__Adapter:__* Приспособява интерфейса *Adaptee* към интерфейса *Target*.
 * *__Adaptee:__* Дефинира съществуващ интерфейс, който се нуждае от адаптиране.
 * *__Client:__* Работи с обекти, подчиняващи се на интерфейса *Target*.

Примерен код:


```

	namespace Adapter
	{
	    using System;
	
	    internal class Program
	    {
	        internal static void Main(string[] args)
	        {
	            ICompound water = new RichCompound("Water");
	            water.Display();
	
	            ICompound benzene = new RichCompound("Benzene");
	            benzene.Display();
	
	            ICompound ethanol = new RichCompound("Ethanol");
	            ethanol.Display();
	        }
	    }
	
		/// <summary>
	    /// The 'Target' class
	    /// </summary>
	    internal interface ICompound
	    {
	        void Display();
	    }
	
		/// <summary>
	    /// The 'Adapter' class
	    /// </summary>
	    internal class RichCompound : ICompound
	    {
	        private readonly string chemical;
	        private readonly ChemicalDatabank bank;
	
	        private readonly float boilingPoint;
	        private readonly float meltingPoint;
	        private readonly double molecularWeight;
	        private readonly string molecularFormula;
	
	        public RichCompound(string chemical)
	        {
	            this.chemical = chemical;
	            this.bank = new ChemicalDatabank();
	
	            this.boilingPoint = this.bank.GetCriticalPoint(this.chemical, "B");
	            this.meltingPoint = this.bank.GetCriticalPoint(chemical, "M");
	            this.molecularWeight = this.bank.GetMolecularWeight(chemical);
	            this.molecularFormula = this.bank.GetMolecularStructure(chemical);
	        }
	
	        public void Display()
	        {
	            Console.WriteLine("Compound: {0} ------ ", this.chemical);
	            Console.WriteLine(" Formula: {0}", this.molecularFormula);
	            Console.WriteLine(" Weight : {0}", this.molecularWeight);
	            Console.WriteLine(" Melting Pt: {0}", this.meltingPoint);
	            Console.WriteLine(" Boiling Pt: {0}", this.boilingPoint);
	            Console.WriteLine();
	        }
	    }
	
		/// <summary>
	    /// The 'Adaptee' class
	    /// </summary>
	    internal class ChemicalDatabank
	    {
	        // The databank 'legacy API'
	        public float GetCriticalPoint(string compound, string point)
	        {
	            if (point == "M")
	            {
	                // Melting Point
	                switch (compound.ToLower())
	                {
	                    case "water":
	                        return 0.0f;
	                    case "benzene":
	                        return 5.5f;
	                    case "ethanol":
	                        return -114.1f;
	                    default:
	                        return 0f;
	                }
	            }
	            else
	            {
	                // Boiling Point
	                switch (compound.ToLower())
	                {
	                    case "water":
	                        return 100.0f;
	                    case "benzene":
	                        return 80.1f;
	                    case "ethanol":
	                        return 78.3f;
	                    default:
	                        return 0f;
	                }
	            }
	        }
	
	        public string GetMolecularStructure(string compound)
	        {
	            switch (compound.ToLower())
	            {
	                case "water":
	                    return "H20";
	                case "benzene":
	                    return "C6H6";
	                case "ethanol":
	                    return "C2H5OH";
	                default:
	                    return string.Empty;
	            }
	        }
	
	        public double GetMolecularWeight(string compound)
	        {
	            switch (compound.ToLower())
	            {
	                case "water":
	                    return 18.015;
	                case "benzene":
	                    return 78.1134;
	                case "ethanol":
	                    return 46.0688;
	                default:
	                    return 0d;
	            }
	        }
	    }
	}


```


## Bridge pattern

### Мотивация

Предоставя възможност за елиминиране на наследяването и заменянето му с композиция (спазвайки принципа "Favor composition over inheritance").

### Цел

* Отделя абстракцията от нейната имплементация, така че двете могат да бъдат променяни независимо.
* Създава "Has-A" връзка между абстракцията и имплементацията.

### Имплементация 

###### IRenderer (Implementor)

```
c#
public interface IRenderer
    {
        string Render(string key, string value);
    }

```

###### HtmlRenderer (ConcreteImplementor)

```c#
public class HtmlRenderer : IRenderer
    {
        public string Render(string key, string value)
        {
            return string.Format($"<div id=\"{key.ToLower()}\">\n\t{value}\n</div>");
        }
    }
```

###### ConsoleRenderer (ConcreteImplementor)

```c#
 public class ConsoleRenderer : IRenderer
    {
        public string Render(string key, string value)
        {
            return $"{key,10} : {value}";
        }
    }
```

###### InfoShopItem (Abstraction)

```c#
 public abstract class InfoShopItem
    {
        protected readonly IRenderer renderer;

        public InfoShopItem(IRenderer renderer)
        {
            this.renderer = renderer;
        }

        public abstract void Display();

    }
```

###### Book (RefinedAbstraction)
```c#
 public class Book : InfoShopItem
    {
        public Book(IRenderer renderer)
            :base(renderer)
        {

        }

        public string Title { get; set; }
        public string Author { get; set; }
        public int Pages { get; set; }

        public override void Display()
        {            
            Console.WriteLine(this.renderer.Render("Title", this.Title));
            Console.WriteLine(this.renderer.Render("Author", this.Author));
            Console.WriteLine(this.renderer.Render("Pages", this.Pages.ToString()));
        }
    }
```

###### Movie (RefinedAbstraction)
```c#
public class Movie : InfoShopItem
    {
        public Movie(IRenderer renderer)
            : base(renderer)
        {
        }

        public string Title { get; set; }
        public string Director { get; set; }
        public string Topic { get; set; }
        public int Duration { get; set; }

        public override void Display()
        {
            Console.WriteLine(this.renderer.Render("Title", this.Title));
            Console.WriteLine(this.renderer.Render("Director", this.Director));
            Console.WriteLine(this.renderer.Render("Topic", this.Topic));
            Console.WriteLine(this.renderer.Render("Duration", $"{this.Duration} min"));
        }
    }
```
###### Usage
```c#
public class Client
    {
        static void Main(string[] args)
        {
            var separator = new string('=', 40);

            Console.WriteLine($"{separator}   Books:");

            var htmlRenderer = new HtmlRenderer();
            var book = new Book(htmlRenderer);
            book.Title = "Mutual Aid: A Factor of Evolution";
            book.Author = "Peter Kropotkin";
            book.Pages = 236;
            book.Display();

            Console.WriteLine(separator);

            var consoleRenderer = new ConsoleRenderer();
            var book2 = new Book(consoleRenderer);
            book2.Title = "Crack Capitalism ";
            book2.Author = "John Holloway";
            book2.Pages = 320;
            book2.Display();

            Console.WriteLine($"{separator}    Movies:");

            var movie = new Movie(htmlRenderer);
            movie.Title = "La educación prohibida";
            movie.Director = "German Doin";
            movie.Duration = 121;
            movie.Topic = "Alternative education";
            movie.Display();

            Console.WriteLine(separator);

            var movie2 = new Movie(consoleRenderer);
            movie2.Title = "Cowspiracy: The Sustainability Secret";
            movie2.Director = "Kip Andersen";
            movie2.Duration = 85;
            movie2.Topic = "Animal rights, Ecology, Sustainability";
            movie2.Display();
        }
    }
```	

### Употреба
* При експоненциално нарастване на наследяване.
* Когато даден клас и дейностите, които той извършва се променят често.

### Структура
![Bridge](https://raw.githubusercontent.com/atanas-georgiev/High-Quality-Code-Homeworks/master/17.%20Design%20Patterns/Structural/images/Bridge.png)


