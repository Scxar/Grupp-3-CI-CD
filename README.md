# Grupp-3-CI-CD


.NET Console App - School Assignment
Beskrivning

Detta projekt är en .NET Console App skapat som en del av en skoluppgift. Applikationen har tre grundläggande funktioner, varje med sina motsvarande xUnit-tester.

    Funktion 1: tar in en string och kontrollera om den string innehåller rätt andra siffror.
    Funktion 2: tar in ett int värde(person nummer) och kontrollera om det är rätt värde (person nummer)
    Funktion 3: tar in ett int värde (person nummer) och konfigurerat om det är till en kvinna eller män.

xUnit Tester

För att säkerställa korrekt funktionalitet har tre xUnit-tester skapats för de tre funktionerna.

    Tester för Funktion 1: 
    Tester för Funktion 2: 
    Tester för Funktion 3: 

Git Actions Workflow
För xunit breanch : 
Jobb 1: Kör xUnit Tester

    Beskrivning: Detta jobb körs vid varje push till huvudgrenen.
	
För main breanch : 
vi hade två jobs : 
Jobb 1: Kör xUnit Tester

    Beskrivning: Detta jobb körs vid varje push till huvudgrenen.

Jobb 2: Bygg och Publicera till Docker Hub

    Beskrivning: Detta jobb körs endast om xUnit-testerna är framgångsrika och triggar en push till huvudgrenen.

vi försökte att injekta Docker hub credential med hjälp av Github secrets.