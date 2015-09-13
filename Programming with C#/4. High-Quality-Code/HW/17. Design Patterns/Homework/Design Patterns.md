#Singleton:
1.	Цел на шаблона  - да ограничава създаването на инстанция от даден клас до една единствена и да предоставя глобален достъп до нея.
2.	Структура:

 <p align="center"><a href="https://github.com/tddold/Telerik-Academy/blob/master/Programming%20with%20C%23/4.%20High-Quality-Code/HW/17.%20Design%20Patterns/Homework/Picture/Proxy.png"><img src="https://github.com/tddold/Telerik-Academy/blob/master/Programming%20with%20C%23/4.%20High-Quality-Code/HW/17.%20Design%20Patterns/Homework/Picture/Proxy.png" /></a></p>
 
3.	Приложения:
	-	a.	клас управляващ появяването на диалогови прозорци
	-	b.	обекти  използвани за водене на логове
	-	c.	обекти съхраняващи настройки
	-	d.	предпочитания или настройки в регистрите
	-	e.	обекти функциониращи като драйвери за принтери, графични карти, бази данни или сокети.
4.	Свързани шаблони – използва се в множество шаблони – Prototype, Abstract Factory и т.н.

#Facade
1.	Цел на шаблона  - предоставяне на интерфейс за достъп до сложна системата от класове.
2.	Структура:
 
<p align="center"><a href="https://github.com/tddold/Telerik-Academy/blob/master/Programming%20with%20C%23/4.%20High-Quality-Code/HW/17.%20Design%20Patterns/Homework/Picture/Facade.png"><img src="https://github.com/tddold/Telerik-Academy/blob/master/Programming%20with%20C%23/4.%20High-Quality-Code/HW/17.%20Design%20Patterns/Homework/Picture/Facade.png" /></a></p>

3.	Приложения: - Уеб услугите (web services) могат да се разглеждат като реализация на фасада, когато нямат собствена бизнес логика, а са дефинирани за предоставяне на достъп до дадена система.
4.	Свързани шаблони – “Abstract Factory” и “Sigleton”

#Proxy 
1.	Цел на шаблона  - предоставяне на заместник или контейнер за даден реален обект, позволявайки контролиран достъп до него.
2.	Структура:  

 <p align="center"><a href="https://github.com/tddold/Telerik-Academy/blob/master/Programming%20with%20C%23/4.%20High-Quality-Code/HW/17.%20Design%20Patterns/Homework/Picture/Proxy.png"><img src="https://github.com/tddold/Telerik-Academy/blob/master/Programming%20with%20C%23/4.%20High-Quality-Code/HW/17.%20Design%20Patterns/Homework/Picture/Proxy.png" /></a></p>

3.	Приложения: - има множество приложения – примерно: Aspect - Oriented Programming – AOP, Java RMI и т.н.
4.	Свързани шаблони – „Adaptor” и “Decorator”
