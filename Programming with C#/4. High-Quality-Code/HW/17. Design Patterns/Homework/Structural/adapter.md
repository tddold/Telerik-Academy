# Adapter

1.	Цел на шаблона:
 - преобразува интерфейса на даден клас, така че да може да бъде използван от клиента.
 * Позволява на класове с несъвместими интерфейси да работят заедно.


2.	Структура:



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


This is [on GitHub](https://github.com/tddold/Telerik-Academy/blob/master/Programming%20with%20C%23/4.%20High-Quality-Code/HW/17.%20Design%20Patterns/Homework/Structural/adapter.md).