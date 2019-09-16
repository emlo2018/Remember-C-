using System;

namespace RememberC
{
    class Program
    {
        static void Main(string[] args)
        {
            //Programmet är inte menat att köras. Detta är bara för att komma ihåg baskunskap.
            Console.Write("Mata in ditt förnamn:"); string fornamn = Console.ReadLine(); Console.Write("Mata in ditt efternamn:"); string efternamn = Console.ReadLine();
            Console.Write("Du heter:" + efternamn + "," + fornamn);
            Console.ReadLine();
            

            Console.Write("Mata in tal1:"); int tal1 = int.Parse(Console.ReadLine());
            Console.Write("Mata in tal2:"); int tal2 = int.Parse(Console.ReadLine());
            int summa = tal1 + tal2;
            Console.Write("Summan av tal1 och tal2 är:" + summa);
            Console.ReadLine();


            Console.Write("Mata in ditt födelseår:"); int fodelseAr = int.Parse(Console.ReadLine());

            int alder = DateTime.Now.Year - fodelseAr;
            Console.Write("Din ålder är:" + alder);
            Console.ReadLine();

            Console.Write("Mata in tal1:"); int talet1 = int.Parse(Console.ReadLine());

            Console.Write("Mata in tal2:"); int talet2 = int.Parse(Console.ReadLine());
            int sum = tal1 + tal2; int differens = tal1 - tal2; int medel = (tal1 + tal2) / 2;

            Console.Write("Summan är:" + sum + "medel är:" + medel + "differensen är:" + differens);
            Console.ReadLine();

            /*
             10. Console.Write("Mata in antal minuter:");  int minuter = int.Parse (Console.ReadLine()); int timmar = minuter / 60; 
int restminuter = minuter – (timmar*60); 
 
Console.Write("Detta är:" + timmar + " och " + restminuter); 
Console.ReadLine(); 
 
 
 
 	 
IF-satser 
1.	Console.WriteLine("Mata in ett tal"); int retur = int.Parse(Console.ReadLine()); 
 
if (retur > 10) 
{ 
Console.WriteLine("Talet är större än 10"); 
} else 
{ 
    Console.WriteLine("Talet är mindre än 10"); 
} 
Console.ReadLine(); 
 
 
2.	Console.WriteLine("Mata in hur många paket mjölk som finns kvar");             int literMjolk = int.Parse(Console.ReadLine()); 
 
            if (literMjolk < 10) 
            { 
                Console.WriteLine("Beställ 30 paket"); 
            } 
            else if (literMjolk >= 10 && literMjolk <= 20) 
            { 
                Console.WriteLine("Beställ 20 paket"); 
            }             else 
            { 
                Console.WriteLine("Du behöver inte beställa någon mjölk"); 
            } 
          Console.ReadLine(); 
 
 
3.        Console.Write("Mata temperaturen:");       string retur = Console.ReadLine(); 
 
     //Om användaren matar in felaktigt decimaltal  
     //ersätts punkt med kommatecken      retur = retur.Replace(".", "."); 
      float temperatur = float.Parse(retur); 
 
     if (temperatur > 37.8 && temperatur <= 39.5) 
     { 
        Console.WriteLine("Du har feber"); 
     } 
     else if (temperatur > 39.5) 
     { 
        Console.WriteLine("Du bör uppsöka läkare"); 
     }      else 
     { 
        Console.WriteLine("Du har inte feber"); 
     } 
     Console.ReadLine(); 
 
4. Console.Write("Mata in din ålder:");             int alder = int.Parse(Console.ReadLine()); 
             if (alder < 18) 
            { 
                Console.WriteLine("Du är inte myndig"); 
            } 
            else if (alder >= 18 && alder < 65) 
            { 
                Console.WriteLine("Du är myndig men ej pensionär"); 
            }             else  
            { 
                Console.WriteLine("Du är pensionär"); 
            } 
             
            Console.ReadLine(); 
 
 
5. Console.Write("Ange kategori(vuxen, pensionär, student):");             string kategori = Console.ReadLine();  
             
            if (kategori == "vuxen") 
            { 
                Console.WriteLine("Resan kostar 30 kr"); 
            } 
            else if (kategori == "pensionär" || kategori == "student") 
            { 
                Console.WriteLine("Resan kostar 20 kr"); 
            }             else  
            { 
                Console.WriteLine("Du har angivit en felaktig kategori"); 
            } 
             
            Console.ReadLine(); 
 
 
6. Console.Write("Mata in ditt födelseår:");             int fodelsear = int.Parse( Console.ReadLine()); 
  
            if (fodelsear >= 1980 && fodelsear <1990) 
            { 
                Console.WriteLine("Du är född på 80-talet"); 
            } 
            else if (fodelsear >= 1990 && fodelsear < 2000) 
            { 
                Console.WriteLine("Du är född på 90-talet"); 
            }             else  
            { 
                Console.WriteLine("Du är inte född på 1990 eller 1980-talen"); 
            } 
             
            Console.ReadLine(); 
 	 
7. const string giltigtAnvandarNamn = "abc123"; const string giltigtLosenord = "password";  
Console.Write("Ange användarnamn:"); string anvandarNamn = Console.ReadLine();  
Console.Write("Ange lösenord:"); string losenord = Console.ReadLine(); 
  if (anvandarNamn == giltigtAnvandarNamn && losenord == giltigtLosenord) 
{ 
     Console.WriteLine("Du är inloggad"); 
} else if (anvandarNamn != giltigtAnvandarNamn) 
{ 
     Console.WriteLine("Du har matat in fel användarnamn"); 
} else if (losenord != giltigtLosenord) 
{ 
    Console.WriteLine("Du har matat in fel lösenord"); } 
Console.ReadLine(); 
 
8.	Console.Write("Mata in namnet på det land du bor i:");             string land = Console.ReadLine(); 
             if (land == "Sverige" || land == "Danmark" || land == "Norge") 
            { 
                Console.WriteLine("Du bor i Skandinavien"); 
            }             else  
            { 
                Console.WriteLine("Du bor inte i Skandinavien"); 
            } 
            
            Console.ReadLine(); 
 
9.	Console.Write("Mata in ett bilmärke:");  string bilMarke = Console.ReadLine(); 
  if (bilMarke != "Volvo") 
 {   	if (bilMarke == "Volkswagen" || bilMarke == "BMW" || bilMarke == "Audi") 
	  	{ 
	       	Console.WriteLine("Bilen är tysk"); 
	  	} 
     else if (bilMarke == "Renault" || bilMarke == "Peugeot"  ||bilMarke == "Citroen") 
     { 
          Console.WriteLine("Bilen är fransk"); 
     }      else  
     { 
          Console.WriteLine("Bilen är inte svensk, franske eller tysk");      } 
} 
            
Console.ReadLine(); 
10. Console.Write("Mata in hur mycket pengar du har:");      int summa = int.Parse(Console.ReadLine()); 
 
      Console.Write("Har du rabatt(J/N):");       string retur = Console.ReadLine();       bool rabatt = false; 
       if (retur == "J") 
      { 
         rabatt = true; 
      } 
            
       if (summa >= 15 && summa <= 25 && rabatt == false) 
      { 
           Console.WriteLine("Du kan köpa en liten hamburgare"); 
      } 
      else if (summa >= 15 && summa <= 25 && rabatt == true) 
      { 
           Console.WriteLine("Du kan köpa en liten hamburgare och en pommes frites"); 
      } 
      else if (summa > 25 && summa <= 50 && rabatt == false) 
      { 
           Console.WriteLine(" Du kan köpa en stor hamburgare"); 
      } 
      else if (summa > 25 && summa <= 50 && rabatt == true) 
      { 
           Console.WriteLine("Du kan köpa en stor hamburgare och pommes frites");          
      } 
      else if (summa > 60 || (summa > 50 && summa <= 60 && rabatt == true)) 
{ 
    Console.WriteLine("Du kan köpa ett meal med dryck"); 
} 
Console.ReadLine(); 
 	 
11. Console.Write("Mata in ett antal minuter:"); 
int minuter = int.Parse(Console.ReadLine()); 
 int timmar = 0; int dygn = 0; int restmin = 0; 
 if (minuter < 60) 
{ 
   Console.WriteLine("Antal minuter:" + minuter); 
} 
else if (minuter >= 60 && minuter < (24*60)) 
{   timmar = minuter / 60; 
  restmin = minuter - (timmar * 60); 
 
 Console.WriteLine("Antal timmar:" + timmar + " Antal minuter:" + restmin); 
}    else 
{        dygn = minuter / (24*60);    restmin = minuter - (dygn * (24 * 60));    timmar = restmin / 60; 
   restmin = restmin - (timmar * 60); 
  Console.WriteLine("Antal dygn:" + dygn + " Antal timmar:" + timmar + "      Antal minuter:" + restmin); 
} 
             
Console.ReadLine(); 
 
         12.  Console.Write("Mata in en summa i antal kronor:"); 
            int kronor = int.Parse(Console.ReadLine()); 
 
            int femhundraLappar = 0;             int hundraLappar = 0;             int restKronor = 0; 
             if (kronor < 100) 
            { 
                Console.WriteLine("Antal minuter:" + kronor); 
            } 
            else if (kronor >= 100 && kronor < 500) 
            { 
                hundraLappar = kronor / 100; 
                restKronor = kronor - (hundraLappar * 100); 
 
                Console.WriteLine("Antal hundralappar:" + hundraLappar       + " Antal kronor:" + restKronor);             } 
  
            else             { 
                femhundraLappar = kronor / 500;                 restKronor = kronor - (femhundraLappar * 500);                 hundraLappar = restKronor/100; 
                restKronor = restKronor - (hundraLappar * 100);  
                Console.WriteLine("Antal femhundralappar:" + femhundraLappar                      + " Antal hundralappar:" + hundraLappar  
                    + " Antal kronor:" + restKronor); 
            } 
             
            Console.ReadLine(); 
  
 
 
 	  
Loopar 
1.  
for (int raknare = 0; raknare <=10; raknare++) 
      { 
          Console.WriteLine(raknare); 
      } 
 
2.  
Console.WriteLine("Mata in det första talet");       int tal1 = int.Parse(Console.ReadLine());       Console.WriteLine("Mata in det andra talet");       int tal2 = int.Parse(Console.ReadLine()); 
       for (int raknare = tal1 + 1; raknare <tal2; raknare++) 
      { 
          Console.WriteLine(raknare); 
      } 
 
 
3.  
            bool continueLoop = true;             int summa= 0; 
             while (continueLoop == true) 
            { 
                Console.WriteLine("Mata in det första talet");                 int tal1 = int.Parse(Console.ReadLine());                 Console.WriteLine("Mata in det andra talet");                 int tal2 = int.Parse(Console.ReadLine()); 
 
                summa = tal1 + tal2; 
                Console.WriteLine("Summan är:" + summa + ". Vill du fortsätta(J/N)?");                 string svar = Console.ReadLine(); 
                 if (svar == "N") 
                {                     break; 
                } 
            } 
 
4.  
int summa= 0; 
 for(int raknare=0; raknare <10; raknare++) 
{ 
   Console.WriteLine("Mata in ett tal");    int tal1 = int.Parse(Console.ReadLine());    summa = summa + tal1; 
}  
Console.WriteLine("Summan av talen är:" + summa ); Console.ReadLine(); 
 
5.  
  Console.WriteLine("Mata in ett tal");             int tal = int.Parse(Console.ReadLine()); 
             int raknare = 1; 
 
            while ( raknare < tal) 
            { 
                Console.WriteLine(raknare);                 raknare++;             } 
            Console.ReadLine(); 
 
 
 	Console.WriteLine("Mata in ett tal"); 
            int tal = int.Parse(Console.ReadLine()); 
             int raknare = 0; 
             do             {                 raknare++; 
                Console.WriteLine(raknare); 
                 
            } while (raknare < tal) ; 
 
            Console.ReadLine(); 
 
 	  
6.  
bool continueLoop = true; 
             
            while (continueLoop) 
            { 
                Console.WriteLine("Mata in ett tal");                 int retur = int.Parse(Console.ReadLine());                 if (retur == 10) 
                { 
                    Console.WriteLine("Du har matat in rätt tal");                     break;                 }                 else                 { 
                    if (retur < 10) 
                    { 
                        Console.WriteLine("Värdet är för lågt"); 
                    } 
                    else if (retur > 10) 
                    { 
                        Console.WriteLine("Värdet är för högt"); 
                    } 
                     
                } 
 
            } 
 
 
 
7.  
    for (int raknare = 1; raknare <= 100;raknare++) 
            { 
                if (raknare % 2 != 0) 
                { 
                    Console.WriteLine(raknare); 
                } 
            } 
 
            Console.ReadLine(); 
 
8.  
  string retur;             int result;             int tal; 
 
            Console.WriteLine("Mata in ett tal mindre än 30");             retur = Console.ReadLine(); 
             if (int.TryParse(retur,out result) == false) 
            { 
                Console.WriteLine("Du har matat in ett ogiltigt tal"); 
            }             else             { 
                tal = int.Parse(retur); 
                if (tal >= 30) 
                { 
                    Console.WriteLine("Du har matat in ett felaktigt tal"); 
                }                 else 
                { 
                     for (int raknare = tal + 1; raknare <= 30; raknare++)                     { 
                        Console.WriteLine(raknare); 
                    } 
                } 
            } 
 
            Console.ReadLine(); 
 	  
9.  
       bool continueLoop = true;        string namn = "";        string gatuadress = "";        string postnummer = "";        string postort = ""; 
        while (continueLoop == true) 
       { 
           if (namn == "") 
           { 
               Console.WriteLine("Mata in namn");                namn = Console.ReadLine(); 
            } 
            if (gatuadress == "") 
            { 
               Console.WriteLine("Mata in gatuadress");                gatuadress = Console.ReadLine(); 
            } 
            if (postnummer == "") 
            { 
                Console.WriteLine("Mata in postnummer");                 postnummer = Console.ReadLine(); 
            } 
            if (postort == "") 
            { 
                Console.WriteLine("Mata in postort");                 postort = Console.ReadLine(); 
            } 
            if(namn != "" && gatuadress != "" && postnummer != "" && postort != "") 
            {                 break; 
            } 
       } 
 
       Console.ReadLine(); 
 
10.  
                const string giltigtAnvnamn = "abc123";           const string giltigtLosenord = "password";           bool continueLoop = true;           string anvnamn;           string losenord; 
           while (continueLoop == true) 
          { 
              Console.WriteLine("Mata in användarnamn");               anvnamn = Console.ReadLine();  
              Console.WriteLine("Mata in lösenord");               losenord = Console.ReadLine(); 
               if (anvnamn == giltigtAnvnamn && losenord == giltigtLosenord) 
              { 
                  Console.WriteLine("Du är inloggad");                   break; 
              } 
              else               { 
                  string svar = ""; 
                   if (anvnamn != giltigtAnvnamn) 
                  { 
Console.WriteLine("Du har angivit felaktigt användarnamn. Vill du försöka igen(J/N)"); 
                         svar = Console.ReadLine(); 
                  } 
                  else if (losenord != giltigtLosenord) 
                  { 
Console.WriteLine("Du har angivit felaktigt lösenord.Vill du försöka igen(J/N)"); 
                         svar = Console.ReadLine(); 
                  } 
                   if (svar == "N") 
                  {                       break; 
                  } 
               } 
            } 
 
            Console.ReadLine(); 
 	  
 
11.  
   int antalDelbara = 0;    for (int i = 1; i <= 1000; i++)       if (i % 17 == 0)          antalDelbara++; 
            // svaret är 58 


            12.
     int summa = 0;
            for (int i = 266; i <= 290; i++)
            {
                if (i % 2 == 0)
                {
                    summa += i;
                }
            }
            int medelVarde = summa / (290 - 266);


            Arrayer
1.
            string[] personuppgifter = new string[5];

            Console.Write("Mata in ditt förnamn "); personuppgifter[0] = Console.ReadLine(); Console.Write("Mata in ditt efternamn "); personuppgifter[1] = Console.ReadLine(); Console.Write("Mata in din adress "); personuppgifter[2] = Console.ReadLine(); Console.Write("Mata in din postort "); personuppgifter[3] = Console.ReadLine(); Console.Write("Mata in din telefon "); personuppgifter[4] = Console.ReadLine();

            Console.WriteLine("Du har matat in följande uppgifter ");
            Console.WriteLine(personuppgifter[0]);
            Console.WriteLine(personuppgifter[1]);
            Console.WriteLine(personuppgifter[2]);
            Console.WriteLine(personuppgifter[3]);
            Console.WriteLine(personuppgifter[4]); Console.WriteLine("Stämmer det?");

            Console.ReadLine();

            2.


      int[] allaTal = new int[4];
            for (int i = 0; i < 4; i++)
            {
                Console.Write("Mata in ett tal "); allaTal[i] = int.Parse(Console.ReadLine());
            }

            int maxTal = 0;

            for (int i2 = 0; i2 < allaTal.Length; i2++)
            {
                if (allaTal[i2] > maxTal)
                {
                    maxTal = allaTal[i2];
                }

            }

            Console.WriteLine("Största värdet är " + maxTal); Console.ReadLine();

            3.

            Console.Write("Hur många tal vill du mata in?");
            int antalTal = int.Parse(Console.ReadLine());

            int[] allaTal = new int[antalTal];
            for (int i = 0; i < antalTal; i++)
            {
                Console.Write("Mata in ett tal "); allaTal[i] = int.Parse(Console.ReadLine());
            }

            int maxTal = 0;

            for (int i2 = 1; i2 < allaTal.Length; i2++)
            {

                if (allaTal[i2] > maxTal)
                {
                    maxTal = allaTal[i2];
                }

            }

            Console.WriteLine("Största värdet är " + maxTal); Console.ReadLine();

            4.
            int[] allaTal = new int[5]; int returVarde;

            //Loopar igenom och om inmatat tal är udda ändras det till 0, annars  
            //lagras talet 
            for (int i = 0; i < 5; i++)
            {
                Console.Write("Mata in ett heltal ");
                returVarde = int.Parse(Console.ReadLine());
                if (returVarde % 2 != 0)
                {
                    allaTal[i] = returVarde;
                }
                else
                {
                    allaTal[i] = 0;
                }
            }
            //Skriver ut resultatet till skärmen 
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(allaTal[i]);
            }

            Console.ReadLine();


            5.
                        Console.Write("Ange hur många mätningar du vill göra:"); int antal = Convert.ToInt32(Console.ReadLine());
            double[] matningar = new double[antal];

            double maxvarde = 0; int raknare = 0; double medelvarde = 0; double summa = 0;

            while (raknare < antal)
            {
                Console.Write("Mata in tempmätning:");
                matningar[raknare] = Convert.ToDouble(Console.ReadLine());
                if (matningar[raknare] > maxvarde)
                {
                    maxvarde = matningar[raknare];
                }

                summa = (matningar[raknare] + summa); raknare++;
            }

            medelvarde = (summa / antal);

            Console.WriteLine("Det högst mätta temperaturen är: " + maxvarde + ", och         
            medelvärdet på samtliga temperaturer är: " + medelvarde);             Console.ReadLine(); 
            

            6.
            Console.Write("Ange hur många mätningar du vill göra:"); int antal = Convert.ToInt32(Console.ReadLine());
            double[,] matningar = new double[antal, 2]; double maxvarde = 0; int raknare = 0; double medelvarde = 0; double summa = 0;
            //Tar emot alla värden while (raknare < antal) 
            {
                Console.Write("Mata in tempmätning:");
                matningar[raknare, 0] = double.Parse(Console.ReadLine());

                Console.Write("Mata in datum:");
                matningar[raknare, 1] = double.Parse(Console.ReadLine());

                //Jämför aktuellt värde med maxvärde hittills      if (matningar[raknare, 0] > maxvarde) 
                {
                    maxvarde = matningar[raknare, 0];
                }
                summa = (matningar[raknare, 0] + summa); raknare++;
            }

            medelvarde = (summa / antal);
            //Skriver ut värdena på skärmen 
            for (raknare = 0; raknare < antal; raknare++)
            {
                Console.WriteLine("Temperatur: " + matningar[raknare, 0] + ", Datum:" + matningar[raknare, 1]);
            }

            Console.WriteLine("Det högst mätta temperaturen är: " + maxvarde + ", och 
            medelvärdet på samtliga temperaturer är: " + medelvarde) Console.ReadLine(); 
            

            7.
            Console.Write("Ange hur många varor vill du mata in:"); int antal = Convert.ToInt32(Console.ReadLine()); string[,] varor = new string[antal, 3]; int raknare = 0;
            while (raknare < antal)
            {
                Console.Write("Vilken vara:"); varor[raknare, 0] = Console.ReadLine(); Console.Write("Vilket pris:"); varor[raknare, 1] = Console.ReadLine(); Console.Write("Vilket produktnummer:"); varor[raknare, 2] = Console.ReadLine();
                raknare++;
            }

            Console.WriteLine("");
            //Skriver ut värdena på skärmen 
            for (raknare = 0; raknare < varor.GetUpperBound(1); raknare++)
            {
                Console.WriteLine("Vara: " + varor[raknare, 0] + " Pris:" + varor[raknare, 1] + " prodnr:" + varor[raknare, 2]);
            }

            Console.ReadLine();


            8.   string[,] personArray = new string[5, 4];
            int raknare = 0;

            while (raknare < 5)
            {

                Console.Write("Mata in namn:");
                personArray[raknare, 0] = Console.ReadLine();

                Console.Write("Mata in gatuadress:"); personArray[raknare, 1] = Console.ReadLine();

                Console.Write("Mata in postnummer:"); personArray[raknare, 2] = Console.ReadLine();
                Console.Write("Mata in postort:");
                personArray[raknare, 3] = Console.ReadLine();

                Console.Write("Vill du mata in en ny person(J/N)"); string fortsatta = Console.ReadLine();
                if (fortsatta == "N")
                {
                    break;
                }

                raknare++;

            }


            Console.WriteLine("");
            for (raknare = 0; raknare < personArray.GetLength(0); raknare++)
            {
                //Om det inte är en tom rad i arrayen                 if (personArray[raknare, 0] != null)                 { 
                Console.WriteLine("Person: " + personArray[raknare, 0] + " adress:" + personArray[raknare, 1] + " postnummer:" + personArray[raknare, 2] + " postort:" + personArray[raknare, 3]);
            }
        }

        Console.ReadLine(); 
 
 
9.   string talRetur; int[] talArray = new int[10]; int raknare = 0; bool isTal; int result;             while (raknare< 10) 
{ 
      Console.Write("Mata in ett tal under 30:");       talRetur = Console.ReadLine(); 
 
 	//Kontroll om det är ett giltigt(felaktigt) tal          isTal = int.TryParse(talRetur, out result); 
      if (isTal == true) 
     {           if (int.Parse(talRetur) < 30) 
         { 
              talArray[raknare] = int.Parse(talRetur); raknare++; 
         }          else 
         { 
Console.WriteLine("Du har matat in ett tal som inte är mindre än  30. Försök igen."); 
         } 
                     
    }     else 
    { 
         Console.Write("Du har matat in ett felaktigt tal:"); 
    } 
                 
} 
 
Console.WriteLine(""); 
 
//Skriver ut värdena på skärmen 
for (raknare = 0; raknare<talArray.Length; raknare++) 
{ 
    Console.WriteLine("Tal: " + talArray[raknare]);                 
} 
          
Console.ReadLine(); 
 
10.  
string[] ordArray = new string[5]; string langstaOrd = ""; 
 for (int i = 0; i< 5; i++) 
{ 
    Console.WriteLine("Mata in ett ord");     ordArray[i] = Console.ReadLine(); 
}  
for (int i = 0; i<ordArray.Length; i++) 
{ 
   if (ordArray[i].Length >= langstaOrd.Length) 
   { 
       langstaOrd = ordArray[i]; 
   } 
} 
Console.WriteLine("Längsta ordet är :" + langstaOrd); 
 
11.      bool continueLoop = true;
int[] talArray = new int[1]; int raknare = 0;             while (continueLoop) 
            { 
                Console.WriteLine("Mata in ett tal");                 int retur = int.Parse(Console.ReadLine());                 if (retur == 10) 
                { 
                    Console.WriteLine("Du har matat in rätt tal"); 
                }                 else                 { 
                    if (retur< 10) 
                    { 
                        Console.WriteLine("Värdet är för lågt"); 
                    } 
                    else if (retur > 10) 
                    { 
                        Console.WriteLine("Värdet är för högt"); 
                    } 
                    talArray[raknare] = retur; 
                    Array.Resize(ref talArray, talArray.Length + 1);                     raknare++; 
                } 
 
            } 
 	 
	 	//Skriver ut värdena på skärmen 
            for (raknare = 0; raknare<talArray.Length; raknare++) 
            { 
                Console.WriteLine(talArray[raknare]); 
            } 
 
 
        } 
 	  
 
Stränghantering 
1.   
string[] strangArray = new string[3]; string totalStrang = ""; 
 for (int i = 0; i<strangArray.Length; i++) 
{ 
   Console.WriteLine("Mata in ett textsträng");    totalStrang += Console.ReadLine() ; 
} 
 
Console.WriteLine(totalStrang); 
 
2.   
string minText = "Hello world"; int position = minText.IndexOf('w'); string varde = minText.Substring(position, 1); 
 
3.  
            string b = "I am a C# hacker.";
//A-B 
int posLast = b.LastIndexOf("a"); int positionC = b.IndexOf("C");
//C 
string[] strangArray = b.Split(' '); 
             for (int i = 0; i<strangArray.Length; i++) 
            { 
                Console.WriteLine(strangArray[i]); 
            } 
 
            ///D 
            string subString = "hacker"; int positionStart = b.IndexOf(subString);
string uttagenStrang = b.Substring(positionStart, subString.Length);
//E 
b = b.Replace("I", "i");             b=  b.Replace("a", "A");             b= b.Replace("k", "K"); 
               b= b.Replace("r", "R"); 
 	 
 
4.  
            string namn = "kurt andersson"; namn = namn.Replace("kurt", "Kurt");             namn = namn.Replace("andersson", "Andersson");  
            //eller 
            int posEfternamn = namn.IndexOf(" ");
posEfternamn = posEfternamn+ 2;  //För att få rätta positionen 
            int langdEfternamn = namn.Length - posEfternamn;
string efternamn = "A" + namn.Substring(posEfternamn, langdEfternamn); string fornamn = "K" + namn.Substring(1, (posEfternamn - 2));
namn = fornamn + " " + efternamn; 
  namn = namn.ToLower(); //Bara små bokstäver   namn = namn.ToUpper(); //Bara stora bokstäver 
 
 
5.  
 string strang = "Detta är en sträng som du skall ändra";

strang = strang.Replace(" ", "*");   int antalStjarnor = strang.Split('*').Length - 1; 
 
 
6.  
string tal = "ett,två,tre,fyra,fem,sex,sju"; string[] strangArray = tal.Split(','); 
 
7.  
Console.WriteLine("Skriv en mailadress:"); string angivenAdress = Console.ReadLine(); int angivenAdressLangd = angivenAdress.Length; 
  if (angivenAdress.Contains("@")) 
{ 
    if (angivenAdress.LastIndexOf(".") == (angivenAdressLangd - 4) || angivenAdress.LastIndexOf(".") == (angivenAdressLangd - 3)) 
    { 
         Console.WriteLine("Riktig mailadress:"); 
    }     else 
    { 
        Console.WriteLine("Felaktig mailadress:");     } } else 
{ 
    Console.WriteLine("Felaktig mailadress:"); 
} 
 
 
 
8.  
 
string sortedString = SortString("231596874");

private string SortString(string stringToSort)
{
    string newString = "";
    char[] sortArray = stringToSort.ToArray();

    Array.Sort<char>(sortArray); foreach (var character in sortArray)
    {
        newString += character.ToString();
    }
    return newString;
} 
 
9.  
Console.WriteLine("Mata in en mening med flera ord:");  string strang = Console.ReadLine(); int antalOrd = strang.Split(' ').Length; 
 
10.  
  string inmatatOrd;
string inmatatBaklanges = "";
Console.WriteLine("Mata in ett ord");             inmatatOrd = Console.ReadLine(); 
             for (int i = inmatatOrd.Length - 1; i >= 0; i--)  
            { 
                inmatatBaklanges += inmatatOrd[i].ToString();             } 
 
            if (inmatatBaklanges == inmatatOrd)  
            { 
 Console.WriteLine("Ordet är en palindrom. Inmatat ord {0} och samma ord   baklänges {1}", inmatatOrd, inmatatBaklanges); 
            }             else 
            { 
 Console.WriteLine("Ordet är inte en palindrom. Inmatat ord {0} och samma ord baklänges {1}", inmatatOrd, inmatatBaklanges);             } 
   
  Console.ReadKey(); 



             */


        }
    }
}
