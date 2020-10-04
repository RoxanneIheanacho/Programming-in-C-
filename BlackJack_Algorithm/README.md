OBS! OBS! OBS!
Detta är en obligatorisk och examinerande uppgift som du ska lösa helt på egen hand.
Du måste göra regelbundna "commits" och "pushes" av koden till ditt repo för uppgiften för att kursledningen ska kunna följa ditt arbetet med uppgiften.
Du ska kunna förklara alla konstruktioner och satser som din lösning av uppgiften innehåller.
Introduktion till uppgiften
I denna examinationsuppgift ska du simulera kortspelet Tjugoett enligt givna regler.

Du kommer att ha stor frihet välja hur du vill lösa uppgiften; vilka konstruktioner att använda. Hur representeras lämpligen en kortlek om 52 kort? Behöver data kasplas in så att egenskaper behövs? Hur många klasser behöver skapas? Är arv lämpligt att använda i något sammanhang? Vilka metoder behövs? Ska metoderna vara statiska eller inte? Överskuggning?

Regler
Kort
En vanlig kortlek om 52 kort används. Esset är värt 1 eller 14 poäng (vilket nu som är mest fördelaktigt för den aktuella handen), en kung är värd 13, en dam 12, en knekt 11 och övriga kort sin valör.

Spelet idé
I Tjugoett gäller det att komma till, eller så nära som möjligt, summan 21 på två eller flera kort.

Exempel
Given ger alla spelare ett kort var från draghögen. Given tar inte själv något kort. Spelarna spelar nu mot given en i taget i turordning. När det är en spelares tur begär spelaren ett kort av given. Efter spelarens andra kort kan något av följande inträffa:

Spelaren har fått 21 och vinner.
Spelaren har spruckit, d.v.s. fått en summa större än 21, och förlorar.
Spelaren begär ytterligare kort tills summan är 21, större än 21 eller förklara sig nöjd.
Då en spelare förklarat sig nöjd är det givens tur att försöka straffa spelaren. Given drar kort från draghögen, ett efter ett, och något av följande kan inträffa:

Given får 21 och vinner.
Given spricker och spelaren vinner.
Given förklarar sig nöjd. Spelaren och given jämför sina händers summor och den som har högst vinner. Om summorna är lika vinner given.
Given forsätter sedan att spela mot näste spelare på samma sätt. Tar korten i draghögen slut, det understa kortet används aldrig, tar given alla dittills avverka kort, blandar om dem använder dem som en ny draghög.

Uppgift
Du ska skriva en konsolapplikation i C# som simulerar kortspelet Tjugoett enligt givna regler. Inget hasardmoment, d.v.s. ingen satsning av pengar, behöver förekomma. Det ska kunna vara en eller flera spelare utöver given. Ingen interaktion med användare ska finnas utan både spelare och giv drar kort från draghögen enligt en förutbestämd algoritm utformad enligt ditt eget tycke. Exempelvis kan du välja att en spelare är nöjd då summan uppgår till 15 (eller mer konservativt, och hållbarare i längden, 8). Giv och spelare ska kunna vara nöjda vid olika summor.

Din applikation måste innefatta minst tre egendefinierade klasser eller strukturer, som objekt instansieras av. Samtliga typer ska vara placerade i olika filer. Du väljer själv vad typerna ska representera. Kanske skapar du typer för spelbord, draghög, giv, spelare, hand, spelkort, färg, valör, ...?

Efter varje spelomgång ska resultatet presenteras. Det ska framgå vilka kort spelare och giv dragit, respektive hands summa och vem som vunnit. Nedan hittar du förslag på presentation av resultatet av olika spelomgångar.