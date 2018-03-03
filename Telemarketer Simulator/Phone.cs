using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Telemarketer_Simulator
{
    class Phone
    {
        int Money = 0;
        int phoneCalls = 0;
        string Call = " ";
        ETC s = new ETC();
        string Boss = "Mr.Langly";
        string userName;

        bool one = false;
        bool two = false;
        bool three = false;
        bool four = false;
        bool five = false;
        bool six = false;
        bool seven = false;
        bool eight = false;

        string CALLED = "";

        public void m()
        {            
            GameTools.WriteColoredParagraph("The clock is ticking! A single work day allows for only 18 total phone calls! Make them count!", ConsoleColor.Black, ConsoleColor.Green);
            s.sp();
            GameTools.WriteColoredParagraph("Call back any person that you haven't made a sale to. REMEMBER TO USE ANY MEANS NECESSARY TO MAKE THE SALE!", ConsoleColor.Black, ConsoleColor.Green);
            s.sp();
            GameTools.WriteColoredParagraph("You have earned $" + Money + " out of the $2500 deadline so far!", ConsoleColor.Black, ConsoleColor.Green);
            s.sp();
            GameTools.WriteColoredParagraph("Phone calls made: " + phoneCalls + "/18", ConsoleColor.Black, ConsoleColor.Green);
            s.sp();
            GameTools.WriteColoredParagraph("Number's I should NOT call back: " + CALLED, ConsoleColor.Black, ConsoleColor.Green);
        }

        public void Play()
        {



            GameTools.WriteColoredParagraph(Boss + " - ....haha! yeah I knew Aaron, he was pretty cool! ... anyways, what did you say your name was again?", ConsoleColor.Yellow, ConsoleColor.Red);
            s.sp();
            string userName = Console.ReadLine();
            s.s();

            GameTools.WriteColoredParagraph(Boss + " - Alright " + userName + ", Welcome to the Deerios sales team! My name is " + Boss + ", I am your new boss! Your new position as Floor Telemarketer begins immediately! I will show you to your desk now...\n", ConsoleColor.Yellow, ConsoleColor.Red);
            s.sp();
            s.ss();

            GameTools.WriteColoredParagraph(userName + " - Thanks for all your help " + Boss + "!", ConsoleColor.Blue, ConsoleColor.Yellow);
            s.sp();
            s.ss();

            GameTools.WriteColoredParagraph(Boss + " - No problem newbie! Your task for today is as follows: Sell atleast $2500 worth of Deerios brand candy. Use any means necessary to make a sale! Not to be harsh, but if you can't make this deadline, you WILL NOT make it in this business... so GOOD LUCK!", ConsoleColor.Yellow, ConsoleColor.Red);
            s.sp();
            s.ss();

            GameTools.WriteColoredParagraph(Boss + " hands you a sheet with a numbered list of some phone numbers to dial...", ConsoleColor.Black, ConsoleColor.White);
            s.sp();
            s.ss();
            Begin();



        }

        public void Begin()
        {
            
            while (phoneCalls >= 18 && Money < 2500)
            {
                s.sp();
                s.s();
                GameTools.WriteColoredParagraph("A rush of cold air hits the back of your neck...", ConsoleColor.Black, ConsoleColor.White);
                s.sp();
                s.ss();
                GameTools.WriteColoredParagraph("You break into a cold sweat as you hear the clock ding 5:00...", ConsoleColor.Black, ConsoleColor.White);
                s.sp();
                s.ss();
                GameTools.WriteColoredParagraph("You feel sick... you begin to panic...", ConsoleColor.Black, ConsoleColor.White);
                s.sp();
                s.ss();
                GameTools.WriteColoredParagraph("You've only accumulated $" + Money + "! You start to think of an excuse....", ConsoleColor.Black, ConsoleColor.White);
                s.sp();
                s.ss();
                GameTools.WriteColoredParagraph("...it is too late, you feel the clammy hand of Mr.Langley touch your shoulder...", ConsoleColor.Black, ConsoleColor.White);
                s.sp();
                s.ss();
                GameTools.WriteColoredParagraph("Mr.Langley - Sorry, But the work day is over... you have not met the quota for today... I'm going to have to let you go...", ConsoleColor.Blue, ConsoleColor.Yellow);
                s.sp();
                s.ss();
                GameTools.WriteColoredParagraph("You collapse onto the floor, motionless...", ConsoleColor.Black, ConsoleColor.White);
                s.sp();
                s.ss();
                GameTools.WriteColoredParagraph("You have blacked out!", ConsoleColor.Black, ConsoleColor.White);
                s.sp();
                s.ss();
                s.sp();
                Console.WriteLine("Would you like to play again?");
                String c = GameTools.GetChoice("y", "n");
                if (c == "y")
                {
                    s.s();
                    one = false;
                    two = false;
                    three = false;
                    four = false;
                    five = false;
                    six = false;
                    seven = false;
                    eight = false;
                    phoneCalls = 0;
                    CALLED = "";
                    Money = 0;
                    Play();
                }
                else if (c == "n")
                {
                    System.Environment.Exit(0);
                }

            }

            while (one == true && two == true && three == true && four == true && five == true && six == true && seven == true && eight == true)
            {
                Done();
            }

            GameTools.WriteColoredParagraph("You gaze at the list...", ConsoleColor.Black, ConsoleColor.White);
            s.sp();
            s.s();
            m();
            s.sp();
            GameTools.WriteColoredParagraph("Which number do you want to try?", ConsoleColor.Black, ConsoleColor.White);
            s.sp();
            Call = GameTools.GetChoice("1", "2", "3", "4", "5", "6", "7", "8");




            while (Call == "1")
            {
                if (one != true)
                {
                    s.s();
                    Freddy();  //business man
                }
                else
                {
                    s.s();
                    GameTools.WriteColoredParagraph("I don't think I should bother this person anymore!", ConsoleColor.Black, ConsoleColor.White);
                    s.sp();
                    s.ss();
                    Begin();

                }
            }
            while (Call == "2")
            {
                if (two != true)
                {
                    s.s();
                    jeremyFisher();  //Retiree
                }
                else
                {
                    s.s();
                    GameTools.WriteColoredParagraph("I don't think I should bother this person anymore!", ConsoleColor.Black, ConsoleColor.White);
                    s.sp();
                    s.ss();
                    Begin();

                }
            }
            while (Call == "3")
            {
                if (three != true)
                {
                    s.s();
                    Jimmy();  //child
                }
                else
                {
                    s.s();
                    GameTools.WriteColoredParagraph("I don't think I should bother this person anymore!", ConsoleColor.Black, ConsoleColor.White);
                    s.sp();
                    s.ss();
                    Begin();

                }

            }
            while (Call == "4")
            {
                if (four != true)
                {
                    s.s();
                    sarahConnor();  //housewife
                }
                else
                {
                    s.s();
                    GameTools.WriteColoredParagraph("I don't think I should bother this person anymore!", ConsoleColor.Black, ConsoleColor.White);
                    s.sp();
                    s.ss();
                    Begin();

                }

            }
            while (Call == "5")
            {
                if (five != true)
                {
                    s.s();
                    Hank();  //Prison inmate
                }
                else
                {
                    s.s();
                    GameTools.WriteColoredParagraph("I don't think I should bother this person anymore!", ConsoleColor.Black, ConsoleColor.White);
                    s.sp();
                    s.ss();
                    Begin();

                }

            }
            while (Call == "6")
            {
                if (six != true)
                {
                    s.s();
                    Henry();  // Upper-class investor
                }
                else
                {
                    s.s();
                    GameTools.WriteColoredParagraph("I don't think I should bother this person anymore!", ConsoleColor.Black, ConsoleColor.White);
                    s.sp();
                    s.ss();
                    Begin();

                }

            }
            while (Call == "7")
            {
                if (seven != true)
                {
                    s.s();
                    Pat();  //Homeless (using pay phone to talk)
                }
                else
                {
                    s.s();
                    GameTools.WriteColoredParagraph("I don't think I should bother this person anymore!", ConsoleColor.Black, ConsoleColor.White);
                    s.sp();
                    s.ss();
                    Begin();

                }

            }
            while (Call == "8")
            {
                if (eight != true)
                {
                    s.s();
                    boss();  //Your own boss, you have to convince him to buy his own products!
                }
                else
                {
                    s.s();
                    GameTools.WriteColoredParagraph("I don't think I should bother this person anymore!", ConsoleColor.Black, ConsoleColor.White);
                    s.sp();
                    s.ss();
                    Begin();

                }

            }

            while (Call == "9")
            {
                s.s();
                Done();
                Play();
                //Begin();
            }

        }



        public void Freddy()
        {
            Console.Write("\n");
            GameTools.WriteColoredParagraph("You dial the number...", ConsoleColor.Black, ConsoleColor.White);
            phoneCalls++;
            s.sp();
            s.ss();
            GameTools.WriteColoredParagraph("A man named Freddy answers! He works for Chompo Corp. a company that specializes in used bike tires!", ConsoleColor.Black, ConsoleColor.White);
            s.sp();
            s.ss();

            GameTools.WriteColoredParagraph("1.) How are you doing today? Are you interested in purchasing some Deerios candy today?", ConsoleColor.Black, ConsoleColor.White);
            s.sp();
            GameTools.WriteColoredParagraph("2.) Hello! You NEED to try our Deerios candy!", ConsoleColor.Black, ConsoleColor.White);
            s.sp();
            GameTools.WriteColoredParagraph("3.) You know what goes great with bike tires? CANDY!", ConsoleColor.Black, ConsoleColor.White);
            s.sp();
            GameTools.WriteColoredParagraph("4.) Hang up", ConsoleColor.Black, ConsoleColor.White);
            s.sp();


            string c = GameTools.GetChoice("1", "2", "3", "4");

            if (c == "1")
            {
                s.sp();
                s.s();
                GameTools.WriteColoredParagraph("Freddy - I am fine, thank you... Not today no...", ConsoleColor.White, ConsoleColor.Black);
                s.sp();
                s.ss();
                GameTools.WriteColoredParagraph("1.) Are your sure? You sound like you could use something tasty!", ConsoleColor.Black, ConsoleColor.White);
                s.sp();
                GameTools.WriteColoredParagraph("2.) I guess your going to miss out on this DELICIOUS CANDY...", ConsoleColor.Black, ConsoleColor.White);
                s.sp();
                string c2 = GameTools.GetChoice("1", "2");
                if (c2 == "1")
                {
                    s.sp();
                    s.s();
                    GameTools.WriteColoredParagraph("Freddy - You know what, just mind your own business okay? I don't want any of your &%@$ candies!", ConsoleColor.White, ConsoleColor.Black);
                    s.sp();
                    s.ss();
                    GameTools.WriteColoredParagraph("Sorry, I didn't mean to offend you sir!", ConsoleColor.Blue, ConsoleColor.Yellow);
                    s.sp();
                    s.ss();
                    GameTools.WriteColoredParagraph("Freddy - It's alright... just having a bad day... my wife filed for divorce last week and i'm just going through a tough time...", ConsoleColor.White, ConsoleColor.Black);
                    s.sp();
                    s.ss();
                    GameTools.WriteColoredParagraph("You know what would make it better? Deerios brand candy!", ConsoleColor.Blue, ConsoleColor.Yellow);
                    s.sp();
                    s.ss();
                    GameTools.WriteColoredParagraph("Freddy - ...", ConsoleColor.White, ConsoleColor.Black);
                    s.sp();
                    s.ss();
                    GameTools.WriteColoredParagraph("*click* - Freddy has hung up!", ConsoleColor.Black, ConsoleColor.White);
                    s.sp();
                    s.ss();
                    Begin();
                }
                else if (c2 == "2")
                {
                    s.sp();
                    s.s();
                    GameTools.WriteColoredParagraph("Freddy - Hmm... well okay, I've heard great things about your company, so I guess I could place an order for maybe $10 worth?", ConsoleColor.White, ConsoleColor.Black);
                    s.sp();
                    s.ss();
                    GameTools.WriteColoredParagraph("1.) Alright I'll put you down for 10$ worth!", ConsoleColor.Black, ConsoleColor.White);
                    s.sp();
                    GameTools.WriteColoredParagraph("2.) How about I put you down for 20$ worth?", ConsoleColor.Black, ConsoleColor.White);
                    s.sp();
                    string c4 = GameTools.GetChoice("1", "2");
                    if (c4 == "1")
                    {
                        s.sp();
                        s.s();
                        GameTools.WriteColoredParagraph("Freddy - Great! Pleasure doing business with you!", ConsoleColor.White, ConsoleColor.Black);
                        s.ss();
                        Money = Money + 10;
                        one = true;
                        CALLED = CALLED + " 1";
                    }
                    else if (c4 == "2")
                    {
                        s.sp();
                        s.s();
                        GameTools.WriteColoredParagraph("Freddy - No, forget it, Thats really pathetic of you to ask that", ConsoleColor.White, ConsoleColor.Black);
                        s.sp();
                        s.ss();
                        GameTools.WriteColoredParagraph("*click* - Freddy has hung up!", ConsoleColor.Black, ConsoleColor.White);
                        s.sp();
                        s.ss();
                        Begin();
                    }
                }

            }
            else if (c == "2")
            {
                s.sp();
                s.s();
                GameTools.WriteColoredParagraph("Freddy - I'm good... I've got to get back to work now...", ConsoleColor.White, ConsoleColor.Black);
                s.sp();
                s.ss();
                GameTools.WriteColoredParagraph("1.) Are your sure? You sound like you could use something tasty!", ConsoleColor.Black, ConsoleColor.White);
                s.sp();
                GameTools.WriteColoredParagraph("2.) I guess your going to miss out on this DELICIOUS CANDY...", ConsoleColor.Black, ConsoleColor.White);
                s.sp();
                string c2 = GameTools.GetChoice("1", "2");
                if (c2 == "1")
                {
                    s.sp();
                    s.s();
                    GameTools.WriteColoredParagraph("Freddy - You know what, just mind your own business okay? I don't want any of your &%@$ candies!", ConsoleColor.White, ConsoleColor.Black);
                    s.sp();
                    s.ss();
                    GameTools.WriteColoredParagraph("Sorry, I didn't mean to offend you sir!", ConsoleColor.Blue, ConsoleColor.Yellow);
                    s.sp();
                    s.ss();
                    GameTools.WriteColoredParagraph("Freddy - It's alright... just having a bad day... my wife filed for divorce last week and i'm just going through a tough time...", ConsoleColor.White, ConsoleColor.Black);
                    s.sp();
                    s.ss();
                    GameTools.WriteColoredParagraph(" You know what would make it better? Deerios brand candy!", ConsoleColor.Blue, ConsoleColor.Yellow);
                    s.sp();
                    s.ss();
                    GameTools.WriteColoredParagraph("Freddy - ...", ConsoleColor.White, ConsoleColor.Black);
                    s.sp();
                    s.ss();
                    GameTools.WriteColoredParagraph("*click* - Freddy has hung up!", ConsoleColor.Black, ConsoleColor.White);
                    s.sp();
                    s.ss();
                    Begin();
                }
                else if (c2 == "2")
                {
                    s.sp();
                    s.s();
                    GameTools.WriteColoredParagraph("Freddy - Hmm... well okay, I've heard great things about your company, so I guess I could place an order for maybe $10 worth?", ConsoleColor.White, ConsoleColor.Black);
                    s.sp();
                    s.ss();
                    GameTools.WriteColoredParagraph("1.) Alright I'll put you down for 10$ worth!", ConsoleColor.Black, ConsoleColor.White);
                    s.sp();
                    GameTools.WriteColoredParagraph("2.) How about I put you down for 20$ worth?", ConsoleColor.Black, ConsoleColor.White);
                    s.sp();
                    string c4 = GameTools.GetChoice("1", "2");
                    if (c4 == "1")
                    {
                        s.sp();
                        s.s();
                        GameTools.WriteColoredParagraph("Freddy - Great! Pleasure doing business with you!", ConsoleColor.White, ConsoleColor.Black);
                        s.ss();
                        Money = Money + 10;
                        one = true;
                        CALLED = CALLED + " 1";
                    }
                    else if (c4 == "2")
                    {
                        s.sp();
                        s.s();
                        GameTools.WriteColoredParagraph("Freddy - No, forget it, Thats really pathetic of you to ask that", ConsoleColor.White, ConsoleColor.Black);
                        s.sp();
                        s.ss();
                        GameTools.WriteColoredParagraph("*click* - Freddy has hung up!", ConsoleColor.Black, ConsoleColor.White);
                        s.sp();
                        s.ss();
                        Begin();
                    }
                }

            }
            else if (c == "3")
            {
                s.sp();
                s.s();
                GameTools.WriteColoredParagraph("Freddy - Very funny, but no thanks...", ConsoleColor.White, ConsoleColor.Black);
                s.sp();
                s.ss();
                GameTools.WriteColoredParagraph("1.) Are your sure? You sound like you could use something tasty!", ConsoleColor.Black, ConsoleColor.White);
                s.sp();
                GameTools.WriteColoredParagraph("2.) I guess your going to miss out on this DELICIOUS CANDY...", ConsoleColor.Black, ConsoleColor.White);
                s.sp();
                string c2 = GameTools.GetChoice("1", "2");
                if (c2 == "1")
                {
                    s.sp();
                    s.s();
                    GameTools.WriteColoredParagraph("Freddy - You know what, just mind your own business okay? I don't want any of your &%@$ candies!", ConsoleColor.White, ConsoleColor.Black);
                    s.sp();
                    s.ss();
                    GameTools.WriteColoredParagraph("Sorry, I didn't mean to offend you sir!", ConsoleColor.Blue, ConsoleColor.Yellow);
                    s.sp();
                    s.ss();
                    GameTools.WriteColoredParagraph("Freddy - It's alright... just having a bad day... my wife filed for divorce last week and i'm just going through a tough time...", ConsoleColor.White, ConsoleColor.Black);
                    s.sp();
                    s.ss();
                    GameTools.WriteColoredParagraph("You know what would make it better? Deerios brand candy!", ConsoleColor.Blue, ConsoleColor.Yellow);
                    s.sp();
                    s.ss();
                    GameTools.WriteColoredParagraph("Freddy - ...", ConsoleColor.White, ConsoleColor.Black);
                    s.sp();
                    s.ss();
                    GameTools.WriteColoredParagraph("*click* - Freddy has hung up!", ConsoleColor.Black, ConsoleColor.White);
                    s.sp();
                    s.ss();
                    Begin();
                }
                else if (c2 == "2")
                {
                    s.sp();
                    s.s();
                    GameTools.WriteColoredParagraph("Freddy - Hmm... well okay, I've heard great things about your company, so I guess I could place an order for maybe $10 worth?", ConsoleColor.White, ConsoleColor.Black);
                    s.sp();
                    s.ss();
                    GameTools.WriteColoredParagraph("1.) Alright I'll put you down for 10$ worth!", ConsoleColor.Black, ConsoleColor.White);
                    s.sp();
                    GameTools.WriteColoredParagraph("2.) How about I put you down for 20$ worth?", ConsoleColor.Black, ConsoleColor.White);
                    s.sp();
                    string c4 = GameTools.GetChoice("1", "2");
                    if (c4 == "1")
                    {
                        s.sp();
                        s.s();
                        GameTools.WriteColoredParagraph("Freddy - Great! Pleasure doing business with you!", ConsoleColor.White, ConsoleColor.Black);
                        s.ss();
                        Money = Money + 10;
                        one = true;
                        CALLED = CALLED + " 1";
                    }
                    else if (c4 == "2")
                    {
                        s.sp();
                        s.s();
                        GameTools.WriteColoredParagraph("Freddy - No, forget it, Thats really pathetic of you to ask that", ConsoleColor.White, ConsoleColor.Black);
                        s.sp();
                        s.ss();
                        GameTools.WriteColoredParagraph("*click* - Freddy has hung up!", ConsoleColor.Black, ConsoleColor.White);
                        s.sp();
                        s.ss();
                        Begin();
                    }
                }

            }
            else if (c == "4")
            {
                s.sp();
                s.s();
                GameTools.WriteColoredParagraph("*click* - You quickly hang up!", ConsoleColor.Black, ConsoleColor.White);
                s.sp();
                s.ss();
                Begin();
            }

        }

        public void jeremyFisher()
        {
            Console.Write("\n");
            GameTools.WriteColoredParagraph("You dial the number...", ConsoleColor.Black, ConsoleColor.White);
            phoneCalls++;
            s.sp();
            s.ss();
            GameTools.WriteColoredParagraph("A man named Jeremy Fisher picks up the phone! You learn that he is a retiree and is currently living in a retirement home!", ConsoleColor.Black, ConsoleColor.White);
            s.sp();
            s.ss();

            GameTools.WriteColoredParagraph("1.) Hello young man! are you interested in some DELICIOUS DEERIOS BRAND CANDY???", ConsoleColor.Black, ConsoleColor.White);
            s.sp();
            GameTools.WriteColoredParagraph("2.) Good afternoon sir! Would you like to purchase some candy?", ConsoleColor.Black, ConsoleColor.White);
            s.sp();
            GameTools.WriteColoredParagraph("3.) Hello, I'm Elvis Presley, I want YOU to buy some of my candy!", ConsoleColor.Black, ConsoleColor.White);
            s.sp();
            GameTools.WriteColoredParagraph("4.) Hang up", ConsoleColor.Black, ConsoleColor.White);
            s.sp();


            string c = GameTools.GetChoice("1", "2", "3", "4");

            if (c == "1")
            {
                s.sp();
                s.s();
                GameTools.WriteColoredParagraph("Jeremy Fisher - uhhhh... what is a Deerios brand candy? And for your information I AM 90 years old sonny, DONT PLAY GAMES WITH ME!", ConsoleColor.White, ConsoleColor.Black);
                s.sp();
                s.ss();
                GameTools.WriteColoredParagraph("1.) Theres NO WAY you are 90 years old! You sound very young for your age!", ConsoleColor.Black, ConsoleColor.White);
                s.sp();
                GameTools.WriteColoredParagraph("2.) Deerios Brand Candy, is a delicious MOUTH WATERING type of candy that will CHANGE YOUR LIFE. Impress your friends or keep it all for yourself!", ConsoleColor.Black, ConsoleColor.White);
                s.sp();
                string c2 = GameTools.GetChoice("1", "2");
                if (c2 == "1")
                {
                    s.sp();
                    s.s();
                    GameTools.WriteColoredParagraph("Jeremy Fisher - Shut your stupid mouth you whipper-snapper! I am so done with you irritating telemarketers! Last time the PRINCE OF NIGERIA NEEDED MY BANK INFORMATION AND I....", ConsoleColor.White, ConsoleColor.Black);
                    s.sp();
                    s.ss();
                    GameTools.WriteColoredParagraph("*click* - Jeremy Fisher seems to have dropped his phone on accident in his fit of rage! The call was ended!", ConsoleColor.Black, ConsoleColor.White);
                    s.sp();
                    s.ss();
                    Begin();

                }
                else if (c2 == "2")
                {
                    s.sp();
                    s.s();
                    GameTools.WriteColoredParagraph("Jeremy Fisher - Ohhh WOW, I haven't tasted anything delicious in over 50 years! Will it really make you gain more friends if i share it?", ConsoleColor.White, ConsoleColor.Black);
                    s.sp();
                    s.ss();
                    GameTools.WriteColoredParagraph("1.) Uhh... Sure... You will definitly become very popular at your... err... retirement home! I guarantee it!", ConsoleColor.Black, ConsoleColor.White);
                    s.sp();
                    GameTools.WriteColoredParagraph("2.) You bet! You will be the BEE'S KNEE'S!", ConsoleColor.Black, ConsoleColor.White);
                    s.sp();
                    string c4 = GameTools.GetChoice("1", "2");
                    if (c4 == "1")
                    {
                        s.sp();
                        s.s();
                        GameTools.WriteColoredParagraph("Jeremy Fisher - I don't know if I can trust you... you really don't sound truthful...", ConsoleColor.White, ConsoleColor.Black);
                        s.sp();
                        s.ss();
                        GameTools.WriteColoredParagraph("*click* - Jeremy Fisher felt uneasy about this purchase and hung up!", ConsoleColor.Black, ConsoleColor.White);
                        s.sp();
                        s.ss();
                        Begin();
                    }
                    else if (c4 == "2")
                    {
                        s.sp();
                        s.s();
                        GameTools.WriteColoredParagraph("Jeremy Fisher - Wow! I can see it now... people wanting to watch MY favorite channel... i'll get roast beef every night... the girls will respect me... PUT ME DOWN FOR 500$ worth of candy!!!", ConsoleColor.White, ConsoleColor.Black);
                        s.sp();
                        s.ss();
                        GameTools.WriteColoredParagraph("You quickly get Jeremy Fisher's credit card information and make the sale!", ConsoleColor.Black, ConsoleColor.White);
                        s.sp();
                        s.ss();
                        two = true;
                        Money = Money + 500;
                        CALLED = CALLED + " 2";
                    }
                }

            }
            else if (c == "2")
            {
                s.sp();
                s.s();
                GameTools.WriteColoredParagraph("Jeremy Fisher - uhhhh... what is a Deerios brand candy?", ConsoleColor.White, ConsoleColor.Black);
                s.sp();
                s.ss();
                GameTools.WriteColoredParagraph("1.) You sound very young for your age!", ConsoleColor.Black, ConsoleColor.White);
                s.sp();
                GameTools.WriteColoredParagraph("2.) Deerios Brand Candy, is a delicious MOUTH WATERING type of candy that will CHANGE YOUR LIFE. Impress your friends or keep it all for yourself!", ConsoleColor.Black, ConsoleColor.White);
                s.sp();
                string c2 = GameTools.GetChoice("1", "2");
                if (c2 == "1")
                {
                    GameTools.WriteColoredParagraph("Jeremy Fisher - Shut your stupid mouth you whipper-snapper! I am so done with you irritating telemarketers! Last time the PRINCE OF NIGERIA NEEDED MY BANK INFORMATION AND I....", ConsoleColor.White, ConsoleColor.Black);
                    s.sp();
                    s.ss();
                    GameTools.WriteColoredParagraph("*click* - Jeremy Fisher seems to have dropped his phone on accident in his fit of rage! The call was ended!", ConsoleColor.Black, ConsoleColor.White);
                    s.sp();
                    s.ss();
                    Begin();

                }
                else if (c2 == "2")
                {
                    s.sp();
                    s.s();
                    GameTools.WriteColoredParagraph("Jeremy Fisher - Ohhh WOW, I haven't tasted anything delicious in over 50 years! Will it really make you gain more friends if i share it?", ConsoleColor.White, ConsoleColor.Black);
                    s.sp();
                    s.ss();
                    GameTools.WriteColoredParagraph("1.) Uhh... Sure... You will definitly become very popular at your... err... retirement home! I guarantee it!", ConsoleColor.Black, ConsoleColor.White);
                    s.sp();
                    GameTools.WriteColoredParagraph("2.) You bet! You will be the BEE'S KNEE'S!", ConsoleColor.Black, ConsoleColor.White);
                    s.sp();
                    string c4 = GameTools.GetChoice("1", "2");
                    if (c4 == "1")
                    {
                        s.sp();
                        s.s();
                        GameTools.WriteColoredParagraph("Jeremy Fisher - I don't know if I can trust you... you really don't sound truthful...", ConsoleColor.White, ConsoleColor.Black);
                        s.sp();
                        s.ss();
                        GameTools.WriteColoredParagraph("*click* - Jeremy Fisher felt uneasy about this purchase and hung up!", ConsoleColor.Black, ConsoleColor.White);
                        s.sp();
                        s.ss();
                        Begin();
                    }
                    else if (c4 == "2")
                    {
                        s.sp();
                        s.s();
                        GameTools.WriteColoredParagraph("Jeremy Fisher - Wow! I can see it now... people wanting to watch MY favorite channel... i'll get roast beef every night... the girls will respect me... PUT ME DOWN FOR 500$ worth of candy!!!", ConsoleColor.White, ConsoleColor.Black);
                        s.sp();
                        s.ss();
                        GameTools.WriteColoredParagraph("You quickly get Jeremy Fisher's credit card information and make the sale!", ConsoleColor.Black, ConsoleColor.White);
                        s.sp();
                        s.ss();
                        two = true;
                        Money = Money + 500;
                        CALLED = CALLED + " 2";
                    }
                }

            }
            else if (c == "3")
            {
                s.sp();
                s.s();
                GameTools.WriteColoredParagraph("Jeremy Fisher - Elvis!!!! OH MY GOD!!! IT'S ELVIS!!!!! EVERYONE COME OVER HERE ELVIS IS TALKING TO ME!!!!!!!", ConsoleColor.White, ConsoleColor.Black);
                s.sp();
                s.ss();
                GameTools.WriteColoredParagraph("The sounds of many differnt voices begin to screech through your phone *OW* You hear fighting in the background", ConsoleColor.Black, ConsoleColor.White);
                s.sp();
                s.ss();
                GameTools.WriteColoredParagraph("*click* - you decide to hang up!", ConsoleColor.Black, ConsoleColor.White);
                s.sp();
                s.ss();
                Begin();


            }
            else if (c == "4")
            {
                s.s();
                GameTools.WriteColoredParagraph("*click* - You quickly hang up!", ConsoleColor.Black, ConsoleColor.White);
                s.sp();
                s.ss();
                Begin();
            }

        }

        public void Jimmy()
        { 
            Console.Write("\n");
            GameTools.WriteColoredParagraph("You dial the number...", ConsoleColor.Black, ConsoleColor.White);
            phoneCalls++;
            s.sp();
            s.ss();
            GameTools.WriteColoredParagraph("You hear a childs voice... You dicover that his name is Jimmy", ConsoleColor.Black, ConsoleColor.White);
            s.sp();
            s.ss();
            GameTools.WriteColoredParagraph("Jimmy - Helo? I'm PLAY WITH ipad!", ConsoleColor.White, ConsoleColor.Black);
            s.sp();
            s.ss();

            GameTools.WriteColoredParagraph("1.) Hey Jimmy! Can you go put your mom on the phone?", ConsoleColor.Black, ConsoleColor.White);
            s.sp();
            GameTools.WriteColoredParagraph("2.) Hey Jimmy, quick go get your mom's credit card! I will give you a TON of candy!", ConsoleColor.Black, ConsoleColor.White);
            s.sp();
            GameTools.WriteColoredParagraph("3.) Do you like Deerios Brand Candy?", ConsoleColor.Black, ConsoleColor.White);
            s.sp();
            GameTools.WriteColoredParagraph("4.) Hang up", ConsoleColor.Black, ConsoleColor.White);
            s.sp();


            string c = GameTools.GetChoice("1", "2", "3", "4");

            if (c == "1")
            {
                s.sp();
                s.s();
                GameTools.WriteColoredParagraph("Jimmy - nooo, mommy said she go to bar tonite! she said i am mistake!", ConsoleColor.White, ConsoleColor.Black);
                s.sp();
                s.ss();
                GameTools.WriteColoredParagraph("1.) Did mommy leave any credit cards laying around?", ConsoleColor.Black, ConsoleColor.White);
                s.sp();
                GameTools.WriteColoredParagraph("2.) How old are you?", ConsoleColor.Black, ConsoleColor.White);
                s.sp();
                string c2 = GameTools.GetChoice("1", "2");
                if (c2 == "1")
                {
                    s.sp();
                    s.s();
                    GameTools.WriteColoredParagraph("Jimmy - ya! she has credit cord info on ipad!", ConsoleColor.White, ConsoleColor.Black);
                    s.sp();
                    s.ss();
                    GameTools.WriteColoredParagraph("Great! Go ahead and give me the information okay?", ConsoleColor.Blue, ConsoleColor.Yellow);
                    s.sp();
                    s.ss();
                    GameTools.WriteColoredParagraph("Jimmy - okay! u will send me candy rite?", ConsoleColor.White, ConsoleColor.Black);
                    s.sp();
                    s.ss();
                    GameTools.WriteColoredParagraph("Of course", ConsoleColor.Blue, ConsoleColor.Yellow);
                    s.sp();
                    s.ss();
                    GameTools.WriteColoredParagraph("You write down the credit card information and hang up *click*! You charge Jimmy's mothers credit card 1300$ for Deerios Brand Candy!", ConsoleColor.Black, ConsoleColor.White);
                    s.sp();
                    s.ss();
                    Money = Money + 1300;
                    three = true;
                    CALLED = CALLED + " 3";
                }
                else if (c2 == "2")
                {
                    s.sp();
                    s.s();
                    GameTools.WriteColoredParagraph("Freddy - I am seben years old!", ConsoleColor.White, ConsoleColor.Black);
                    s.sp();
                    s.s();
                    GameTools.WriteColoredParagraph("Did mommy leave any credit cards laying around?", ConsoleColor.Blue, ConsoleColor.Yellow);
                    s.sp();
                    s.s();
                    GameTools.WriteColoredParagraph("Jimmy - ya! she has credit cord info on ipad!", ConsoleColor.White, ConsoleColor.Black);
                    s.sp();
                    s.ss();
                    GameTools.WriteColoredParagraph("Great! Go ahead and give me the information okay?", ConsoleColor.Blue, ConsoleColor.Yellow);
                    s.sp();
                    s.ss();
                    GameTools.WriteColoredParagraph("Jimmy - okay! u will send me candy rite?", ConsoleColor.White, ConsoleColor.Black);
                    s.sp();
                    s.ss();
                    GameTools.WriteColoredParagraph("Of course", ConsoleColor.Blue, ConsoleColor.Yellow);
                    s.sp();
                    s.ss();
                    GameTools.WriteColoredParagraph("You write down the credit card information and hang up *click*! You charge Jimmy's mothers credit card 1300$ for Deerios Brand Candy!", ConsoleColor.Black, ConsoleColor.White);
                    s.sp();
                    s.ss();
                    Money = Money + 1300;
                    three = true;
                    CALLED = CALLED + " 3";

                }

            }
            else if (c == "2")
            {
                s.sp();
                s.s();
                GameTools.WriteColoredParagraph("Jimmy - Its on ipad rite here!", ConsoleColor.White, ConsoleColor.Black);
                s.sp();
                s.ss();
                GameTools.WriteColoredParagraph("1.) Tell me the number kid!", ConsoleColor.Black, ConsoleColor.White);
                s.sp();
                GameTools.WriteColoredParagraph("2.) May I have the number?", ConsoleColor.Black, ConsoleColor.White);
                s.sp();
                string c2 = GameTools.GetChoice("1", "2");
                if (c2 == "1")
                {
                    s.sp();
                    s.s();
                    GameTools.WriteColoredParagraph("Jimmy - Your scaring me!", ConsoleColor.White, ConsoleColor.Black);
                    s.sp();
                    s.ss();
                    GameTools.WriteColoredParagraph("Give me the number NOW!", ConsoleColor.Blue, ConsoleColor.Yellow);
                    s.sp();
                    s.ss();
                    GameTools.WriteColoredParagraph("Jimmy - STOP!", ConsoleColor.White, ConsoleColor.Black);
                    s.sp();
                    s.ss();
                    GameTools.WriteColoredParagraph("Give me the num....", ConsoleColor.Blue, ConsoleColor.Yellow);
                    s.sp();
                    s.ss();
                    GameTools.WriteColoredParagraph("*click* Jimmy has hung up!", ConsoleColor.Black, ConsoleColor.White);
                    s.sp();
                    s.ss();
                    Begin();
                }
                else if (c2 == "2")
                {
                    s.sp();
                    s.s();
                    GameTools.WriteColoredParagraph("Freddy - Okay", ConsoleColor.White, ConsoleColor.Black);
                    s.sp();
                    s.s();
                    GameTools.WriteColoredParagraph("Great! Go ahead and give me the information okay?", ConsoleColor.Blue, ConsoleColor.Yellow);
                    s.sp();
                    s.ss();
                    GameTools.WriteColoredParagraph("Jimmy - okay! u will send me candy rite?", ConsoleColor.White, ConsoleColor.Black);
                    s.sp();
                    s.ss();
                    GameTools.WriteColoredParagraph("Of course", ConsoleColor.Blue, ConsoleColor.Yellow);
                    s.sp();
                    s.ss();
                    GameTools.WriteColoredParagraph("You write down the credit card information and hang up *click*! You charge Jimmy's mothers credit card 1300$ for Deerios Brand Candy!", ConsoleColor.Black, ConsoleColor.White);
                    s.sp();
                    s.ss();
                    Money = Money + 1300;
                    three = true;
                    CALLED = CALLED + " 3";

                }

            }
            else if (c == "3")
            {
                s.sp();
                s.s();
                GameTools.WriteColoredParagraph("Freddy - ya i liek candy!", ConsoleColor.White, ConsoleColor.Black);
                s.sp();
                s.ss();
                GameTools.WriteColoredParagraph("1.) Whats your address? I can send you some!", ConsoleColor.Black, ConsoleColor.White);
                s.sp();
                GameTools.WriteColoredParagraph("2.) Is your mother home?", ConsoleColor.Black, ConsoleColor.White);
                s.sp();
                string c2 = GameTools.GetChoice("1", "2");
                if (c2 == "1")
                {
                    s.sp();
                    s.s();
                    GameTools.WriteColoredParagraph("Freddy - I not suppose to giv my info to stranger", ConsoleColor.White, ConsoleColor.Black);
                    s.sp();
                    s.ss();
                    GameTools.WriteColoredParagraph("Oh i'm not a stranger! my name is...", ConsoleColor.Blue, ConsoleColor.Yellow);
                    s.sp();
                    s.ss();
                    GameTools.WriteColoredParagraph("*click* - Jimmy was frightened and has hung up!", ConsoleColor.Black, ConsoleColor.White);
                    s.sp();
                    s.ss();
                    Begin();
                }
                else if (c2 == "2")
                {
                    s.sp();
                    s.s();
                    GameTools.WriteColoredParagraph("Jimmy - nooo, mommy said she go to bar tonite! she said i am mistake!", ConsoleColor.White, ConsoleColor.Black);
                    s.sp();
                    s.ss();
                    GameTools.WriteColoredParagraph("1.) Did mommy leave any credit cards laying around?", ConsoleColor.Black, ConsoleColor.White);
                    s.sp();
                    GameTools.WriteColoredParagraph("2.) How old are you?", ConsoleColor.Black, ConsoleColor.White);
                    s.sp();

                    string c3 = GameTools.GetChoice("1", "2");
                    if (c3 == "1")
                    {
                        s.sp();
                        s.s();
                        GameTools.WriteColoredParagraph("Jimmy - ya! she has credit cord info on ipad!", ConsoleColor.White, ConsoleColor.Black);
                        s.sp();
                        s.ss();
                        GameTools.WriteColoredParagraph("Great! Go ahead and give me the information okay?", ConsoleColor.Blue, ConsoleColor.Yellow);
                        s.sp();
                        s.ss();
                        GameTools.WriteColoredParagraph("Jimmy - okay! u will send me candy rite?", ConsoleColor.White, ConsoleColor.Black);
                        s.sp();
                        s.ss();
                        GameTools.WriteColoredParagraph("Of course", ConsoleColor.Blue, ConsoleColor.Yellow);
                        s.sp();
                        s.ss();
                        GameTools.WriteColoredParagraph("You write down the credit card information and hang up *click*! You charge Jimmy's mothers credit card 1300$ for Deerios Brand Candy!", ConsoleColor.Black, ConsoleColor.White);
                        s.sp();
                        s.ss();
                        Money = Money + 1300;
                        three = true;
                        CALLED = CALLED + " 3";
                    }
                    else if (c3 == "2")
                    {
                        s.sp();
                        s.s();
                        GameTools.WriteColoredParagraph("Freddy - I am seben years old!", ConsoleColor.White, ConsoleColor.Black);
                        s.sp();
                        s.s();
                        GameTools.WriteColoredParagraph("Did mommy leave any credit cards laying around?", ConsoleColor.Blue, ConsoleColor.Yellow);
                        s.sp();
                        s.s();
                        GameTools.WriteColoredParagraph("Jimmy - ya! she has credit cord info on ipad!", ConsoleColor.White, ConsoleColor.Black);
                        s.sp();
                        s.ss();
                        GameTools.WriteColoredParagraph("Great! Go ahead and give me the information okay?", ConsoleColor.Blue, ConsoleColor.Yellow);
                        s.sp();
                        s.ss();
                        GameTools.WriteColoredParagraph("Jimmy - okay! u will send me candy rite?", ConsoleColor.White, ConsoleColor.Black);
                        s.sp();
                        s.ss();
                        GameTools.WriteColoredParagraph("Of course", ConsoleColor.Blue, ConsoleColor.Yellow);
                        s.sp();
                        s.ss();
                        GameTools.WriteColoredParagraph("You write down the credit card information and hang up *click*! You charge Jimmy's mothers credit card 1300$ for Deerios Brand Candy!", ConsoleColor.Black, ConsoleColor.White);
                        s.sp();
                        s.ss();
                        Money = Money + 1300;
                        three = true;
                        CALLED = CALLED + " 3";

                    }

                }
                else if (c == "4")
                {
                    s.s();
                    GameTools.WriteColoredParagraph("*click* - You quickly hang up!", ConsoleColor.Black, ConsoleColor.White);
                    s.sp();
                    s.ss();
                    Begin();
                }

            }
        }

        public void sarahConnor()
        {
            Console.Write("\n");
            GameTools.WriteColoredParagraph("You dial the number...", ConsoleColor.Black, ConsoleColor.White);
            phoneCalls++;
            s.sp();
            s.ss();
            GameTools.WriteColoredParagraph("A woman answers the phone, you discover that she is a housewife named Sarah Connor.", ConsoleColor.Black, ConsoleColor.White);
            s.sp();
            s.ss();
            GameTools.WriteColoredParagraph("Sarah Connor - Hello?", ConsoleColor.White, ConsoleColor.Black);
            s.sp();
            s.ss();

            GameTools.WriteColoredParagraph("1.) Hello ma'm! Are you interested in Deerios Brand Candy?", ConsoleColor.Black, ConsoleColor.White);
            s.sp();
            GameTools.WriteColoredParagraph("2.) Hey! Are you bored staying at home all day? Deerios Brand Candy will entertain you greatly!", ConsoleColor.Black, ConsoleColor.White);
            s.sp();
            GameTools.WriteColoredParagraph("3.) Hang up", ConsoleColor.Black, ConsoleColor.White);
            s.sp();

            string c = GameTools.GetChoice("1", "2", "3");

            if (c == "1")
            {
                s.sp();
                s.s();
                GameTools.WriteColoredParagraph("Sarah Connor - No thanks, I'm allergic to your candy...", ConsoleColor.White, ConsoleColor.Black);
                s.sp();
                s.ss();
                GameTools.WriteColoredParagraph("1.) Thats no excuse! Try the candy again I bet you will love it!", ConsoleColor.Black, ConsoleColor.White);
                s.sp();
                GameTools.WriteColoredParagraph("2.) Don't be such a cry baby, its a new recipe!", ConsoleColor.Black, ConsoleColor.White);
                s.sp();
                string c2 = GameTools.GetChoice("1", "2");

                if (c2 == "1")
                {
                    s.sp();
                    s.s();
                    GameTools.WriteColoredParagraph("Sarah Connor - No... I don't want to die...", ConsoleColor.White, ConsoleColor.Black);
                    s.sp();
                    s.ss();
                    GameTools.WriteColoredParagraph("*click* - Sarah Connor has hung up!", ConsoleColor.Black, ConsoleColor.White);
                    s.sp();
                    s.ss();
                    Begin();
                }
                else if (c2 == "2")
                {
                    s.sp();
                    s.s();
                    GameTools.WriteColoredParagraph("Sarah Connor - Oh... I guess I could try it again? Can you promise me I wont get sick, last time I was in a coma for 6 weeks", ConsoleColor.White, ConsoleColor.Black);
                    s.sp();
                    s.ss();
                    GameTools.WriteColoredParagraph("I promise, I'm a very honest person", ConsoleColor.Blue, ConsoleColor.Yellow);
                    s.sp();
                    s.ss();
                    GameTools.WriteColoredParagraph("Sarah Connor gives you her information and allows you to charge her credit card 100$. You laugh to yourself as you hangup the phone, you know that she is going to get sick because the forumla for Deerios Brand Candy has not changed in 20 years!", ConsoleColor.Black, ConsoleColor.White);
                    s.sp();
                    s.ss();
                    four = true;
                    Money = Money + 100;
                    CALLED = CALLED + " 4";

                }

            }
            else if (c == "2")
            {
                s.sp();
                s.s();
                GameTools.WriteColoredParagraph("Sarah Connor - No thanks, I'm very entertained at home! I watch Oproh and Helen Teedeinnerous on tv everyday! Plus I'm allergic to Deerios candy...", ConsoleColor.White, ConsoleColor.Black);
                s.sp();
                s.ss();
                GameTools.WriteColoredParagraph("1.) Thats no excuse! Try the candy again I bet you will love it!", ConsoleColor.Black, ConsoleColor.White);
                s.sp();
                GameTools.WriteColoredParagraph("2.) Don't be such a cry baby, its a new recipe!", ConsoleColor.Black, ConsoleColor.White);
                s.sp();
                string c2 = GameTools.GetChoice("1", "2");

                if (c2 == "1")
                {
                    s.sp();
                    s.s();
                    GameTools.WriteColoredParagraph("Sarah Connor - No... I don't want to die... and Oproh said candy isnt healthy yesterday!", ConsoleColor.White, ConsoleColor.Black);
                    s.sp();
                    s.ss();
                    GameTools.WriteColoredParagraph("*click* - Sarah Connor has hung up!", ConsoleColor.Black, ConsoleColor.White);
                    s.sp();
                    s.ss();
                    Begin();
                }
                else if (c2 == "2")
                {
                    s.sp();
                    s.s();
                    GameTools.WriteColoredParagraph("Sarah Connor - Oh... I guess I could try it again? Can you promise me I wont get sick, last time I was in a coma for 6 weeks", ConsoleColor.White, ConsoleColor.Black);
                    s.sp();
                    s.ss();
                    GameTools.WriteColoredParagraph("I promise, I'm a very honest person", ConsoleColor.Blue, ConsoleColor.Yellow);
                    s.sp();
                    s.ss();
                    GameTools.WriteColoredParagraph("Sarah Connor gives you her information and allows you to charge her credit card 100$. You laugh to yourself as you hangup the phone, you know that she is going to get sick because the forumla for Deerios Brand Candy has not changed in 20 years!", ConsoleColor.Black, ConsoleColor.White);
                    s.sp();
                    s.ss();
                    four = true;
                    Money = Money + 100;
                    CALLED = CALLED + " 4";
                }
            }
            else if (c == "3")
            {
                s.s();
                GameTools.WriteColoredParagraph("*click* - You quickly hang up!", ConsoleColor.Black, ConsoleColor.White);
                s.sp();
                s.ss();
                Begin();
            }

        }

        public void Hank()
        {
            Console.Write("\n");
            GameTools.WriteColoredParagraph("You dial the number...", ConsoleColor.Black, ConsoleColor.White);
            phoneCalls++;
            s.sp();
            s.ss();
            GameTools.WriteColoredParagraph("A scary sounding man answers the phone... You discover that his name is Hank, a prison inmate!", ConsoleColor.Black, ConsoleColor.White);
            s.sp();
            s.ss();
            GameTools.WriteColoredParagraph("Hank - What the hell do you want??!", ConsoleColor.White, ConsoleColor.Black);
            s.sp();
            s.ss();

            GameTools.WriteColoredParagraph("1.) Good afternoon! Are you interested in buying Deerios Brand Candy?", ConsoleColor.Black, ConsoleColor.White);
            s.sp();
            GameTools.WriteColoredParagraph("2.) What're ya in for?", ConsoleColor.Black, ConsoleColor.White);
            s.sp();
            GameTools.WriteColoredParagraph("3.) Hang up", ConsoleColor.Black, ConsoleColor.White);
            s.sp();

            string c = GameTools.GetChoice("1", "2", "3");

            if (c == "1")
            {
                s.sp();
                s.s();
                GameTools.WriteColoredParagraph("Hank - DO I SOUND LIKE I WANT CANDY?", ConsoleColor.White, ConsoleColor.Black);
                s.sp();
                s.ss();
                GameTools.WriteColoredParagraph("1.) No. But you sound like you need candy...", ConsoleColor.Black, ConsoleColor.White);
                s.sp();
                GameTools.WriteColoredParagraph("2.) Sorry, this candy is great though! You should really try it!", ConsoleColor.Black, ConsoleColor.White);
                s.sp();
                string c2 = GameTools.GetChoice("1", "2");
                if (c2 == "1")
                {
                    s.sp();
                    s.s();
                    GameTools.WriteColoredParagraph("Hank - SHUT UP! I REFUSE TO TALK TO AN IDIOT LIKE YOU!", ConsoleColor.White, ConsoleColor.Black);
                    s.sp();
                    s.ss();
                    GameTools.WriteColoredParagraph("You hear a guard yell at Hank in the background... *click* The phone call has ended... I doubt I will be able to re-contact Hank again...", ConsoleColor.Black, ConsoleColor.White);
                    s.sp();
                    s.ss();
                    five = true;
                    CALLED = CALLED + " 5";
                }
                else if (c2 == "2")
                {
                    s.sp();
                    s.s();
                    GameTools.WriteColoredParagraph("Hank - SHUT UP! I REFUSE TO TALK TO AN IDIOT LIKE YOU!", ConsoleColor.White, ConsoleColor.Black);
                    s.sp();
                    s.ss();
                    GameTools.WriteColoredParagraph("You hear a guard yell at Hank in the background... *click* The phone call has ended... I doubt I will be able to re-contact Hank again...", ConsoleColor.Black, ConsoleColor.White);
                    s.sp();
                    s.ss();
                    five = true;
                    CALLED = CALLED + " 5";
                }

            }
            else if (c == "2")
            {
                s.sp();
                s.s();
                GameTools.WriteColoredParagraph("Hank - I was involved in a robbery last month BUT THATS NONE OF YOUR BUSINESS!", ConsoleColor.White, ConsoleColor.Black);
                s.sp();
                s.ss();
                GameTools.WriteColoredParagraph("You hear a guard yell at Hank in the background... *click* The phone call has ended... I doubt I will be able to re-contact Hank again...", ConsoleColor.Black, ConsoleColor.White);
                s.sp();
                s.ss();
                five = true;
                CALLED = CALLED + " 5";
            }
            else if (c == "3")
            {

                s.s();
                GameTools.WriteColoredParagraph("*click* - You quickly hang up!", ConsoleColor.Black, ConsoleColor.White);
                s.sp();
                s.ss();
                Begin();

            }

        }

        public void Henry()
        {
            Console.Write("\n");
            GameTools.WriteColoredParagraph("You dial the number...", ConsoleColor.Black, ConsoleColor.White);
            phoneCalls++;
            s.sp();
            s.ss();
            GameTools.WriteColoredParagraph("An intelligent sounding man answers the phone, you discover that his name is Henry, a weatlthy business investor.", ConsoleColor.Black, ConsoleColor.White);
            s.sp();
            s.ss();
            GameTools.WriteColoredParagraph("Henry - Hello good sir. What are you inquiring about this afternoon?", ConsoleColor.White, ConsoleColor.Black);
            s.sp();
            s.ss();

            GameTools.WriteColoredParagraph("1.) Would you be interested in purchasing some DELICIOUS Deerios Brand Candy?", ConsoleColor.Black, ConsoleColor.White);
            s.sp();
            GameTools.WriteColoredParagraph("2.) Would you like to make a very smart investment in Deerios Brand Candy? The resale value is extremely high!", ConsoleColor.Black, ConsoleColor.White);
            s.sp();
            GameTools.WriteColoredParagraph("3.) Hang up", ConsoleColor.Black, ConsoleColor.White);
            s.sp();

            string c = GameTools.GetChoice("1", "2", "3");

            if (c == "1")
            {
                s.sp();
                s.s();
                GameTools.WriteColoredParagraph("Henry - I am sorry good sir... I lack the taste buds required to properly taste your Deerios Brand Candy.", ConsoleColor.White, ConsoleColor.Black);
                s.sp();
                s.ss();
                GameTools.WriteColoredParagraph("1.) Deerios Brand Candy is so delicious that it will re-activate dead taste buds!", ConsoleColor.Black, ConsoleColor.White);
                s.sp();
                GameTools.WriteColoredParagraph("2.) Well how about investing in our candy instead? The resale value is extremely high!", ConsoleColor.Black, ConsoleColor.White);
                s.sp();
                string c2 = GameTools.GetChoice("1", "2");
                if (c2 == "1")
                {
                    s.sp();
                    s.s();
                    GameTools.WriteColoredParagraph("Henry - I'm sorry, but I will have to decline!", ConsoleColor.White, ConsoleColor.Black);
                    s.sp();
                    s.ss();
                    GameTools.WriteColoredParagraph("*click* - Henry has hung up!", ConsoleColor.Black, ConsoleColor.White);
                    s.sp();
                    s.ss();
                    Begin();
                }
                else if (c2 == "2")
                {
                    s.sp();
                    s.s();
                    GameTools.WriteColoredParagraph("Henry - Hmm... that sounds interesting! I think I will go ahead and purchase 200$ worth of your candy!", ConsoleColor.White, ConsoleColor.Black);
                    s.sp();
                    s.ss();
                    GameTools.WriteColoredParagraph("You collect Henry's credit card information and hang up! You congratulate yourself for how easy this sale was!", ConsoleColor.Black, ConsoleColor.White);
                    s.sp();
                    s.ss();
                    Money = Money + 200;
                    six = true;
                    CALLED = CALLED + " 6";
                }

            }
            else if (c == "2")
            {
                s.sp();
                s.s();
                GameTools.WriteColoredParagraph("Henry - Hmm... that sounds interesting! I think I will go ahead and purchase 200$ worth of your candy!", ConsoleColor.White, ConsoleColor.Black);
                s.sp();
                s.ss();
                GameTools.WriteColoredParagraph("You collect Henry's credit card information and hang up! You congratulate yourself for how easy this sale was!", ConsoleColor.Black, ConsoleColor.White);
                s.sp();
                s.ss();
                Money = Money + 200;
                six = true;
                CALLED = CALLED + " 6";
            }
            else if (c == "3")
            {
                s.s();
                GameTools.WriteColoredParagraph("*click* - You quickly hang up!", ConsoleColor.Black, ConsoleColor.White);
                s.sp();
                s.ss();
                Begin();

            }

        }

        public void Pat()
        {
            Console.Write("\n");
            GameTools.WriteColoredParagraph("You dial the number...", ConsoleColor.Black, ConsoleColor.White);
            phoneCalls++;
            s.sp();
            s.ss();
            GameTools.WriteColoredParagraph("A raspy sounding voice answers, you discover that the mans name is Pat, a homeless man living in South Beach California. The phone number belongs to a pay phone.", ConsoleColor.Black, ConsoleColor.White);
            s.sp();
            s.ss();
            GameTools.WriteColoredParagraph("Pat - ye? wat do u want?", ConsoleColor.White, ConsoleColor.Black);
            s.sp();
            s.ss();

            GameTools.WriteColoredParagraph("1.) Sir, Would you like to get some food?", ConsoleColor.Black, ConsoleColor.White);
            s.sp();
            GameTools.WriteColoredParagraph("2.) Are you a candy lover?", ConsoleColor.Black, ConsoleColor.White);
            s.sp();
            GameTools.WriteColoredParagraph("3.) Hang up", ConsoleColor.Black, ConsoleColor.White);
            s.sp();

            string c = GameTools.GetChoice("1", "2", "3");

            if (c == "1")
            {
                s.sp();
                s.s();
                GameTools.WriteColoredParagraph("Pat - Ye man! Wat do i needa do??", ConsoleColor.White, ConsoleColor.Black);
                s.sp();
                s.ss();
                GameTools.WriteColoredParagraph("1.) Do you have any money?", ConsoleColor.Black, ConsoleColor.White);
                s.sp();
                GameTools.WriteColoredParagraph("2.) I understand your homeless, therefore untrackable. Go find a random person and steal their credit card! I will hook you up with some Deerios Brand Candy!", ConsoleColor.Black, ConsoleColor.White);
                s.sp();
                string c2 = GameTools.GetChoice("1", "2");
                if (c2 == "1")
                {
                    s.sp();
                    s.s();
                    GameTools.WriteColoredParagraph("Pat - Nahh man i aint got no money...", ConsoleColor.White, ConsoleColor.Black);
                    s.sp();
                    s.ss();
                    GameTools.WriteColoredParagraph("*click* Pat depressingly hangs up the phone!", ConsoleColor.Black, ConsoleColor.White);
                    s.sp();
                    s.ss();
                    Begin();

                }
                else if (c2 == "2")
                {
                    s.sp();
                    s.s();
                    GameTools.WriteColoredParagraph("Pat - aight i got you! I'll be rite back", ConsoleColor.White, ConsoleColor.Black);
                    s.sp();
                    s.ss();
                    GameTools.WriteColoredParagraph("1 Minute Passes...", ConsoleColor.Black, ConsoleColor.White);
                    s.sp();
                    s.ss();
                    GameTools.WriteColoredParagraph("another Minute Passes...", ConsoleColor.Black, ConsoleColor.White);
                    s.sp();
                    s.ss();
                    GameTools.WriteColoredParagraph("3 more Minutes Pass...", ConsoleColor.Black, ConsoleColor.White);
                    s.sp();
                    s.ss();
                    GameTools.WriteColoredParagraph("Pat - Bro u there?", ConsoleColor.White, ConsoleColor.Black);
                    s.sp();
                    s.ss();
                    GameTools.WriteColoredParagraph("Yes I'm still here!", ConsoleColor.Blue, ConsoleColor.Yellow);
                    s.sp();
                    s.ss();
                    GameTools.WriteColoredParagraph("Pat - Good, I got the credit card... send the candy to 5213 pinata drive! Thats mah drop off point for fraudulant mail...", ConsoleColor.White, ConsoleColor.Black);
                    s.sp();
                    s.ss();
                    GameTools.WriteColoredParagraph("*click* Pat hangs up. The stolen credit card maxes out at 389$.", ConsoleColor.Black, ConsoleColor.White);
                    s.sp();
                    s.ss();
                    Money = Money + 389;
                    seven = true;
                    CALLED = CALLED + " 7";
                }

            }
            else if (c == "2")
            {
                s.sp();
                s.s();
                GameTools.WriteColoredParagraph("Pat - Ye man I LOVE IT! Wat do i needa do to get sum candy??", ConsoleColor.White, ConsoleColor.Black);
                s.sp();
                s.ss();
                GameTools.WriteColoredParagraph("1.) Do you have any money?", ConsoleColor.Black, ConsoleColor.White);
                s.sp();
                GameTools.WriteColoredParagraph("2.) I understand your homeless therefore untrackable. Go find a random person and steal their credit card! I will hook you up with some Deerios Brand Candy!", ConsoleColor.Black, ConsoleColor.White);
                s.sp();
                string c2 = GameTools.GetChoice("1", "2");
                if (c2 == "1")
                {
                    s.sp();
                    s.s();
                    GameTools.WriteColoredParagraph("Pat - Nahh man i aint got no money...", ConsoleColor.White, ConsoleColor.Black);
                    s.sp();
                    s.ss();
                    GameTools.WriteColoredParagraph("*click* Pat depressingly hangs up the phone!", ConsoleColor.Black, ConsoleColor.White);
                    s.sp();
                    s.ss();
                    Begin();

                }
                else if (c2 == "2")
                {
                    s.sp();
                    s.s();
                    GameTools.WriteColoredParagraph("Pat - aight i got you! I'll be rite back", ConsoleColor.White, ConsoleColor.Black);
                    s.sp();
                    s.ss();
                    GameTools.WriteColoredParagraph("1 Minute Passes...", ConsoleColor.Black, ConsoleColor.White);
                    s.sp();
                    s.ss();
                    GameTools.WriteColoredParagraph("another Minute Passes...", ConsoleColor.Black, ConsoleColor.White);
                    s.sp();
                    s.ss();
                    GameTools.WriteColoredParagraph("3 more Minutes Pass...", ConsoleColor.Black, ConsoleColor.White);
                    s.sp();
                    s.ss();
                    GameTools.WriteColoredParagraph("Pat - Bro u there?", ConsoleColor.White, ConsoleColor.Black);
                    s.sp();
                    s.ss();
                    GameTools.WriteColoredParagraph("Yes I'm still here!", ConsoleColor.Blue, ConsoleColor.Yellow);
                    s.sp();
                    s.ss();
                    GameTools.WriteColoredParagraph("Pat - Good, I got the credit card... send the candy to 5213 pinata drive! Thats mah drop off point for fraudulant mail...", ConsoleColor.White, ConsoleColor.Black);
                    s.sp();
                    s.ss();
                    GameTools.WriteColoredParagraph("*click* Pat hangs up. The stolen credit card maxes out at 389$.", ConsoleColor.Black, ConsoleColor.White);
                    s.sp();
                    s.ss();
                    Money = Money + 389;
                    seven = true;
                    CALLED = CALLED + " 7";
                }

            }
            else if (c == "3")
            {
                s.s();
                GameTools.WriteColoredParagraph("*click* - You quickly hang up!", ConsoleColor.Black, ConsoleColor.White);
                s.sp();
                s.ss();
                Begin();

            }

        }

        public void boss()
        {
            Console.Write("\n");
            GameTools.WriteColoredParagraph("You dial the number...", ConsoleColor.Black, ConsoleColor.White);
            phoneCalls++;
            s.sp();
            s.ss();
            GameTools.WriteColoredParagraph("You realize that Mr.Langley accidently put his number on the list!", ConsoleColor.Black, ConsoleColor.White);
            s.sp();
            s.ss();
            GameTools.WriteColoredParagraph("Mr.Langley - Hello! How may I help you today!", ConsoleColor.White, ConsoleColor.Black);
            s.sp();
            s.ss();

            GameTools.WriteColoredParagraph("1.) [DISGUISE VOICE] - I work for the Dee....Cheerio's Candy Company! Are you interested in purchasing Cheerios Brand Candy?", ConsoleColor.Black, ConsoleColor.White);
            s.sp();
            GameTools.WriteColoredParagraph("2.) Hey Mr.Langley.... do you want to buy any Deerios Brand Candy?", ConsoleColor.Black, ConsoleColor.White);
            s.sp();
            GameTools.WriteColoredParagraph("3.) Hang up", ConsoleColor.Black, ConsoleColor.White);
            s.sp();

            string c = GameTools.GetChoice("1", "2", "3");

            if (c == "1")
            {
                s.sp();
                s.s();
                GameTools.WriteColoredParagraph("Mr.Langley - Ohh! I also work for a candy company myself! It's called Deerios! How weird. Well I might as well see what my competition sells... Go ahead and put me down for a 1$ sample please!", ConsoleColor.White, ConsoleColor.Black);
                s.sp();
                s.ss();
                GameTools.WriteColoredParagraph("1.) Are you sure you only want the 1$ sample? Maybe you should buy more because our candy is TOP of the line!", ConsoleColor.Black, ConsoleColor.White);
                s.sp();
                GameTools.WriteColoredParagraph("2.) Okay sir! I will ship out the 1$ sample to you immediately! Thanks for your business!", ConsoleColor.Black, ConsoleColor.White);
                s.sp();
                string c2 = GameTools.GetChoice("1", "2");
                if (c2 == "2")
                {
                    s.sp();
                    s.s();
                    GameTools.WriteColoredParagraph("You take Mr.Langley's credit card information and charge him 1$. It's not much but atleast you the sale!", ConsoleColor.Black, ConsoleColor.White);
                    s.sp();
                    s.ss();
                    Money = Money + 1;
                    eight = true;
                    CALLED = CALLED + " 8";
                }
                else if (c2 == "1")
                {
                    s.sp();
                    s.s();
                    GameTools.WriteColoredParagraph("Mr.Langley - Look, I don't have to buy a %@$ thing okay? I just want the 1$ sample...", ConsoleColor.White, ConsoleColor.Black);
                    s.sp();
                    s.ss();
                    GameTools.WriteColoredParagraph("1.) Sure I'm sorry for harrassing you about it. I will send out the 1$ sample!", ConsoleColor.Black, ConsoleColor.White);
                    s.sp();
                    GameTools.WriteColoredParagraph("2.) Fine! I don't have to do business with you then!", ConsoleColor.Black, ConsoleColor.White);
                    s.sp();
                    string c3 = GameTools.GetChoice("1", "2");
                    if (c3 == "1")
                    {
                        s.sp();
                        s.s();
                        GameTools.WriteColoredParagraph("You take Mr.Langley's credit card information and charge him 1$. It's not much but atleast you the sale!", ConsoleColor.Black, ConsoleColor.White);
                        s.sp();
                        s.ss();
                        Money = Money + 1;
                        eight = true;
                        CALLED = CALLED + " 8";
                    }
                    else if (c3 == "2")
                    {
                        s.sp();
                        s.s();
                        GameTools.WriteColoredParagraph("*click* You hang up the phone...", ConsoleColor.Black, ConsoleColor.White);
                        s.sp();
                        s.ss();
                        Begin();
                    }
                }
            }
            else if (c == "2")
            {
                s.sp();
                s.s();
                GameTools.WriteColoredParagraph("Mr.Langley laughs and assumes the call was a joke! He tells you to get back to work.", ConsoleColor.Black, ConsoleColor.White);
                s.sp();
                s.ss();
                Begin();

            }
            else if (c == "3")
            {
                s.s();
                GameTools.WriteColoredParagraph("*click* - You quickly hang up!", ConsoleColor.Black, ConsoleColor.White);
                s.sp();
                s.ss();
                Begin();

            }

        }
        public void Done()
        {
            int x = 1;
            while (x++ < 1500)
            {

                GameTools.WriteColoredParagraph(" ", ConsoleColor.White, ConsoleColor.White);
                GameTools.WriteColoredParagraph(" ", ConsoleColor.Blue, ConsoleColor.Blue);
                while (x++ > 1100 && x++ < 1500)
                {
                    GameTools.WriteColoredParagraph(" ", ConsoleColor.Black, ConsoleColor.Black);
                }
                s.sp();
                s.s();
                GameTools.WriteColoredParagraph("You see Mr.Langley walking over to your desk...", ConsoleColor.Black, ConsoleColor.White);
                s.sp();
                s.ss();
                GameTools.WriteColoredParagraph("Mr.Langley - Wow, I'm impressed! It looks like you are definitly cut out for this job! See ya tomorrow!", ConsoleColor.Yellow, ConsoleColor.Red);
                s.sp();
                s.ss();
                GameTools.WriteColoredParagraph("", ConsoleColor.DarkBlue, ConsoleColor.Cyan);
                s.sp();
                GameTools.WriteColoredParagraph("", ConsoleColor.DarkBlue, ConsoleColor.Cyan);
                s.sp();
                GameTools.WriteColoredParagraph("", ConsoleColor.DarkBlue, ConsoleColor.Cyan);
                s.sp();
                GameTools.WriteColoredParagraph("_________________________TELEMARKETER SIMULATOR______________________________", ConsoleColor.DarkBlue, ConsoleColor.Cyan);
                s.sp();
                GameTools.WriteColoredParagraph("_________________________Made by: Aaron Prather_________________________", ConsoleColor.DarkBlue, ConsoleColor.Cyan);
                s.sp();
                GameTools.WriteColoredParagraph(@"_________________________A C# Production!_________________________", ConsoleColor.DarkBlue, ConsoleColor.Cyan);
                s.sp();
                GameTools.WriteColoredParagraph(@"_________________________RESTART?_________________________", ConsoleColor.DarkBlue, ConsoleColor.Cyan);
                s.sp();
                GameTools.WriteColoredParagraph("", ConsoleColor.DarkBlue, ConsoleColor.Cyan);
                s.sp();
                GameTools.WriteColoredParagraph("", ConsoleColor.DarkBlue, ConsoleColor.Cyan);
                s.sp();
                GameTools.WriteColoredParagraph("", ConsoleColor.DarkBlue, ConsoleColor.Cyan);
                s.sp();
                Console.WriteLine("Would you like to play again?");
                String c = GameTools.GetChoice("y", "n");
                if (c == "y")
                {
                    s.s();
                    one = false;
                    two = false;
                    three = false;
                    four = false;
                    five = false;
                    six = false;
                    seven = false;
                    eight = false;
                    Money = 0;
                    phoneCalls = 0;
                    CALLED = "";
                    Play();
                }
                else if (c == "n")
                {
                    System.Environment.Exit(0);
                }


            }

        }
    }
}
