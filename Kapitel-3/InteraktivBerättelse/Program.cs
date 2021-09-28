using System.Linq.Expressions;
using System;

namespace InteraktivBerättelse
{
    class Program
    {
        static void Main(string[] args)
        {
            // frågar om dom vill spela spelet
            Console.WriteLine("Hej vill du spela spelet? ja eller nej");
            string spela = Console.ReadLine().ToLower();

            // Om dom säger Ja så fortsätter spelet annars avslutar det
            if (spela == "ja") 
            {
                Console.WriteLine("Vad bra forsätt då!");

                // Frågar om vilket håll dom vill gå och gör om det till små bokstäver,
                Console.WriteLine("Vill du gå höger, vänster eller framåt? (Skriv höger,vänster eller framåt)");
                string direction = Console.ReadLine().ToLower();
                
                // Vilket håll dom går bästemer vad som händer sen
                if (direction == "höger")
                {
                    Console.WriteLine("Du svänger höger och börjar gå men ramlar i ett hål och dör av falet.");
                    Console.WriteLine("GAME OVER!");

                } else if (direction == "vänster")
                {
                    Console.WriteLine("Du svänger vänster och börja gå framåt. Du ser en hamburgare på marken.");
                    Console.WriteLine("Vill du ta upp och äta den eller forsätta framåt? (Skriv Ät eller Gå)");
                    string hamburgare = Console.ReadLine().ToLower();
                    
                    if (hamburgare == "ät")
                    {
                        Console.WriteLine("Du äter hamburgaren men börjar få ont i magen.");
                        Console.WriteLine("Du går en bit till sen faller över och dör.");
                        Console.WriteLine("GAME OVER!");
                    }
                    else
                    {
                        Console.WriteLine("Du går förbi hamburgaren.");
                        Console.WriteLine("Du kommer till ett hus. Det ser övergivet ut.");
                        Console.WriteLine("Vill du försöka öppna framdörren eller gå runt huset först? (Skriv Dörren eller Gå)");
                        //huset 1 för första valet vid huset
                        string huset1 = Console.ReadLine().ToLower();

                        if (huset1 == "dörren")
                        {
                            Console.WriteLine("Du öppnar fram dörren och blir skutten av ett givär rakt i huvud.");
                            Console.WriteLine("Personen ville inte ha några gäster");
                            Console.WriteLine("GAME OVER!");
                        }
                        else
                        {
                            Console.WriteLine("Du tar ett var runt huset men du ser inget. Det är mörkt i alla fönster. Fast du ser en bakdörr.");
                            Console.WriteLine("Vill du ta bakdörren eller vill du testa framdörren? (Skriv Fram eller Bak) ");
                            string huset2 = Console.ReadLine().ToLower();
                            
                            if (huset2 == "fram")
                            {
                            Console.WriteLine("Du öppnar framdörren och blir skutten av ett givär rakt i huvud.");
                            Console.WriteLine("Personen ville inte ha några gäster");
                            Console.WriteLine("GAME OVER!");
                            }
                            else
                            {
                                Console.WriteLine("Du öppnar bakdörren och får en kniv i halsen. ");
                                Console.WriteLine("Personen ville inte ha några gäster");
                                Console.WriteLine("GAME OVER!");
                            }
                        }
                         
                    }
   
                } else if (direction =="framåt")
                {
                    Console.WriteLine("Du börjar gå framåt. Du ser vad ser ut som en person ligga mot ett träd vid väggen.");
                    Console.WriteLine("Vill du gå förbi eller stanna och inspektera saken? (Skriv Gå eller Inspektera)");
                    string kroppen = Console.ReadLine().ToLower();
                    
                    if (kroppen == "gå")
                    {
                        Console.WriteLine("Du börjar gå förbi saken men så känner du ett slag i bakhuvdet.");
                        Console.WriteLine("Det var en människa.");
                        Console.WriteLine("GAME OVER!");
                    }
                    else
                    {
                        Console.WriteLine("Du närmar dig formen som du nu ser är en människa. När du är tillräckligt nära känner du ett stick i foten. Du kollar ner och ser en spruta sitta i din fot. Det börjar snurra i ditt huvudt och du faller till marken medans allt blir mörkare. Det sista du ser är människan som ställer sig upp.");
                        Console.WriteLine("GAME OVER!");
                    }
                }
                //Om dom inte skriver nån av vallen så slutar programet med den texten. 
                else 
                {
                    Console.WriteLine("Så kan du inte göra!");
                }

                
            } else 
            {

                Console.WriteLine("Synd varför startade du ens programet men okej.");
                
            }
            
            
            //väntar på ett input så inte fönstre stängs ner
            Console.WriteLine("Tryck på valfri kanpp för att stänga programet!");
            Console.ReadKey();
            
            
        }
    }
}
