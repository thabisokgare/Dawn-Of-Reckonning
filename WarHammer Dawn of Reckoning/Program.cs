using System;
using System.Collections.Generic;
using System.Security.Policy;
using System.Threading;

namespace Console_game
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DisplayLoadingAnimation();
            DisplayGameTutorial();

            Console.WriteLine(
                "Warhammer: The Dawn of Reckoning\n\n" +
                "In a time long forgotten, when the echoes of ancient battles still whisper through the haunted forests and desolate plains, a new era of conflict emerges. Welcome to the world of Warhammer, where the fate of realms hangs by a thread, and heroes are forged in the crucible of war.\n\n" +
                "Amidst the shadowy ruins of once-mighty cities, factions vie for supremacy. The noble and unyielding Empire, steadfast defenders of humanity, muster their legions to face the encroaching darkness. Meanwhile, the sinister forces of Chaos, driven by the malevolent will of their dark gods, seek to plunge the world into eternal night.\n\n" +
                "Far to the east, the enigmatic High Elves stand as guardians against the tide of evil, their ancient magic a beacon of hope. Yet, even they are beset by treachery from within their own ranks. The savage Orcs and Goblins, driven by primal fury, seek only destruction, leaving a trail of carnage in their wake.\n\n" +
                "As the drums of war echo across the lands, the fates of countless souls are intertwined. Will you lead your army to glory, or will you fall into the abyss of defeat? The choices you make, the alliances you forge, and the battles you wage will determine the destiny of all.\n\n" +
                "Prepare yourself, warrior, for the world of Warhammer awaits. Rally your forces, sharpen your blade, and steel your heart. The Dawn of Reckoning is upon us, and only the strong will prevail.\n"
            );

            List<string> players = new List<string>
            {
                "Aric Thorne",
                "Elara Moonshadow",
                "Gorak Stonefist",
                "Lyria Nightshade",
                "Grimnar Bloodfang"
            };

            Console.WriteLine("Select a Player:");

            for (int i = 0; i < players.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {players[i]}");
            }

            string select = Console.ReadLine();
            DisplayStoryline(select, players);



        }

        static void DisplayLoadingAnimation()
        {
            Console.Clear();
            string[] spinner = new string[] { "/", "-", "\\", "|" };
            int spinnerIndex = 0;

            int windowWidth = Console.WindowWidth;
            int windowHeight = Console.WindowHeight;
            int textPositionX = (windowWidth - 15) / 2; // "Loading... XXX%" is 15 characters long
            int textPositionY = windowHeight / 2;

            for (int i = 0; i <= 100; i += 2)
            {
                Console.SetCursorPosition(textPositionX, textPositionY);
                Console.Write($"{spinner[spinnerIndex]} Loading... {i}%");
                spinnerIndex = (spinnerIndex + 1) % spinner.Length;
                Thread.Sleep(300);
            }

            Console.Clear();
            string welcomeMessage = "Welcome to Warhammer: The Dawn of Reckoning!";
            string asciiArt = @"
 
 __      __                  ___ ___                                            ________                                    _____  __________                 __                   .__                  
/  \    /  \_____  _______  /   |   \ _____     _____    _____    ____ _______  \______ \  _____  __  _  __ ____     ____ _/ ____\ \______   \  ____   ____  |  | __ ____    ____  |__|  ____    ____   
\   \/\/   /\__  \ \_  __ \/    ~    \\__  \   /     \  /     \ _/ __ \\_  __ \  |    |  \ \__  \ \ \/ \/ //    \   /  _ \\   __\   |       _/_/ __ \_/ ___\ |  |/ //  _ \  /    \ |  | /    \  / ___\  
 \        /  / __ \_|  | \/\    Y    / / __ \_|  Y Y  \|  Y Y  \\  ___/ |  | \/  |    `   \ / __ \_\     /|   |  \ (  <_> )|  |     |    |   \\  ___/\  \___ |    <(  <_> )|   |  \|  ||   |  \/ /_/  > 
  \__/\  /  (____  /|__|    \___|_  / (____  /|__|_|  /|__|_|  / \___  >|__|    /_______  /(____  / \/\_/ |___|  /  \____/ |__|     |____|_  / \___  >\___  >|__|_ \\____/ |___|  /|__||___|  /\___  /  
       \/        \/               \/       \/       \/       \/      \/                 \/      \/             \/                          \/      \/     \/      \/            \/          \//_____/   

";

            int artPositionX = (windowWidth - 52) / 2; // Length of the ASCII art line
            int artPositionY = (windowHeight - 10) / 2 - 1; // Centering the art vertically
            int textPosition = (windowWidth - welcomeMessage.Length) / 2;

            Console.SetCursorPosition(artPositionX, artPositionY);
            Console.WriteLine(asciiArt);
            Console.SetCursorPosition(textPosition, artPositionY + 7);
            Console.WriteLine(welcomeMessage);

            Thread.Sleep(2000);
            Console.Clear();
        }

        static void DisplayGameTutorial()
        {
            Console.Clear();
            Console.WriteLine("## How to Play Warhammer: The Dawn of Reckoning\n");

            Console.WriteLine("Embark on an epic journey through a world filled with mystery, magic, and relentless battles. Here’s a quick guide to get you started:\n");

            Console.WriteLine("### Getting Started\n");
            Console.WriteLine("1. **Loading Screen**: Watch the loading animation as the game sets up. Once done, you'll see a welcome message along with some impressive ASCII art.\n");
            Console.WriteLine("2. **Introduction**: The game begins with an introduction to the world of Warhammer, where you'll learn about the factions and the overarching conflict.\n");

            Console.WriteLine("### Selecting Your Character\n");
            Console.WriteLine("3. **Choose Your Hero**: You'll be presented with a list of heroes to choose from. Each hero has a unique backstory and set of skills:\n");
            Console.WriteLine("   - Aric Thorne: A noble warrior.\n   - Elara Moonshadow: A powerful sorceress.\n   - Gorak Stonefist: A master engineer.\n   - Lyria Nightshade: A skilled archer and tracker.\n   - Grimnar Bloodfang: A fierce tribal leader.\n");

            Console.WriteLine("4. **Make Your Choice**: Type the number corresponding to the hero you want to play as and hit Enter.\n");

            Console.WriteLine("### Playing the Game\n");
            Console.WriteLine("5. **Experience the Story**: As you journey through the game, you'll be presented with various scenarios and options. Your choices will determine the direction of the story and the fate of your hero.\n");
            Console.WriteLine("6. **Decision-Making**: Read through the dialogues and descriptions carefully. When prompted, select from the available options by typing your choice and pressing Enter.\n");

            Console.WriteLine("### Tips for Success\n");
            Console.WriteLine("- **Think Strategically**: Every decision you make will impact your journey. Consider the strengths and weaknesses of your hero and choose wisely.\n");
            Console.WriteLine("- **Embrace the Role**: Immerse yourself in the character’s story, make decisions as if you were them, and enjoy the immersive narrative.\n");
            Console.WriteLine("- **Explore & Learn**: Pay attention to the details in the story, as they might provide clues and insights that can help you in your quest.\n");

            Console.WriteLine("### Example Scenario\n");
            Console.WriteLine("*As Aric Thorne stands on the battlements of Altdorf, he sees a shadowy figure in the distance. What should he do?*\n");
            Console.WriteLine("1. Investigate the figure.\n2. Call for reinforcements.\n3. Ignore and continue preparations.\n");
            Console.WriteLine("Type the number of your choice and press Enter to continue the adventure.\n");

            Console.WriteLine("Press Enter to continue...");
            Console.ReadLine();
            Console.Clear();
        }

        static void DisplayStoryline(string select, List<string> players)
        {
            Console.Clear();
            switch (select)
            {

                case "1":
                    DisplayAricThorneStory();
                    break;

                case "2":
                    Console.WriteLine($"Welcome: {players[1]}");
                    Console.WriteLine(
                        "Walking among the towering spires of Ulthuan, my homeland, I felt the ancient magic coursing through me. My silver hair flowed like moonlight, " +
                        "and my eyes, gleaming with centuries of wisdom, saw beyond the present turmoil. For years, I sensed a growing disturbance in the mystical currents, " +
                        "a dark force threatening our world. Determined to restore balance, I embarked on a perilous journey. My deep connection to the arcane arts " +
                        "and the guidance of ancient prophecies led my path. Compassionate yet aloof, I am Elara Moonshadow, a powerful sorceress, ready to unite the forces " +
                        "of light and stand against the tide of darkness."
                    );


                    break;
                case "3":
                    Console.WriteLine($"Welcome: {players[2]}");
                    Console.WriteLine(
                        "The rhythmic clang of my hammer echoed through the caverns as I worked tirelessly in my forge deep beneath the World's Edge Mountains. " +
                        "My long braided beard and piercing blue eyes reflected the flames of my creations. As a master engineer, I crafted intricate machines and powerful explosives, " +
                        "my skills legendary among my kin. But the forces of Chaos threatened even our deepest strongholds. I knew my expertise would be crucial in the battles to come. " +
                        "Gruff and determined, I am Gorak Stonefist, ready to lend my engineering prowess to the war effort and defend my homeland with unyielding resolve."
                    );
                    break;

                case "4":
                    Console.WriteLine($"Welcome: {players[3]}");
                    Console.WriteLine(
                        "Moving silently through the enchanted forests of Athel Loren, I felt a deep connection to the natural world around me. My forest-green eyes keenly observed " +
                        "every movement, and my hair blended seamlessly with the shadows. As a master archer and skilled tracker, I dedicated my life to protecting the balance and my kin. " +
                        "The savage Orcs and Goblins disrupted our tranquility, leaving a trail of destruction. I could not stand idle. With my finely crafted bow in hand, I set out to defend " +
                        "my home. I am Lyria Nightshade, independent and resourceful, ready to strike from the shadows and safeguard the beauty and balance of our world."
                    );
                    break;

                case "5":
                    Console.WriteLine($"Welcome: {players[4]}");
                    Console.WriteLine(
                        "The harsh winds of the frozen wastelands of the North whipped through my wild hair as I led my tribe. Towering and muscular, I stood as a testament to the strength " +
                        "required to survive in this unforgiving land. The whispers of Chaos reached our icy home, threatening the survival of my people. With my massive axe at my side, " +
                        "I prepared to face the darkness head-on. Driven by a fierce sense of honor and the need to protect my tribe, I am Grimnar Bloodfang. Fierce and passionate, I embody the " +
                        "raw strength of the North, ready to fight for my tribe's future and the salvation of our world."
                    );
                    break;

                default:
                    Console.WriteLine("Invalid Player");
                    break;
            }
        }

        static void DisplayAricThorneStory()
        {
            Console.WriteLine("My Name is : Aric Thorne\n");
            Console.WriteLine(
                "As I stood atop the ancient battlements of Altdorf, the first light of dawn breaking over the horizon, I felt a sense of purpose wash over me. " +
                "Clad in my family's gleaming armor, the sword at my side a testament to my noble lineage, I knew my destiny was clear. Born into a family of warriors, " +
                "I trained relentlessly, guided by the tales of valor and sacrifice my father shared. Now, the forces of Chaos threaten the very heart of the Empire. " +
                "With unwavering resolve, I lead my comrades into battle, my sense of duty putting me in the forefront of danger. I am Aric Thorne, a beacon of hope " +
                "for my people, ready to defend humanity against the encroaching darkness. \n\n"
            );
            
            ContinueStoryline();
            
        }


        static void ContinueStoryline()
        {
            // list of decsisons 
            List<string> Decisions = new List<string>
    {
        "Inspect the Defenses (Explore the city and gain insights about its vulnerabilities.)",
        "Rally the Troops (Boost morale among your comrades.)",
        "Meditate with Stormbreaker (Unlock a vision of the coming battle and the shadowy figure.)"
    };

            string asciiArt = @"
 

___________.__               _________.__                               _____     _____  .__   __      .___             _____ 
\__    ___/|  |__   ____    /   _____/|__| ____   ____   ____     _____/ ____\   /  _  \ |  |_/  |_  __| _/____________/ ____\
  |    |   |  |  \_/ __ \   \_____  \ |  |/ __ \ / ___\_/ __ \   /  _ \   __\   /  /_\  \|  |\   __\/ __ |/  _ \_  __ \   __\ 
  |    |   |   Y  \  ___/   /        \|  \  ___// /_/  >  ___/  (  <_> )  |    /    |    \  |_|  | / /_/ (  <_> )  | \/|  |   
  |____|   |___|  /\___  > /_______  /|__|\___  >___  / \___  >  \____/|__|    \____|__  /____/__| \____ |\____/|__|   |__|   
                \/     \/          \/         \/_____/      \/                         \/               \/                    


";

            Console.WriteLine(asciiArt);
            // Display the game introduction
            Console.WriteLine("The Empire stands on the brink of annihilation. You, Aric Thorne, must rally the defenders, uncover the secrets of your lineage," +
                              " and wield the ancient power of Stormbreaker to face the oncoming darkness. " +
                              "The choices you make will shape the fate of humanity.\n");

            Console.WriteLine("Press Enter to continue...");
            Console.ReadLine();
            Console.Clear();

            // Update console title for the next section


            

           

            Console.WriteLine("Dawn of Destiny\n");

            string asciiArt1 = @"
 


 ______   _______           _          _______  _______    ______   _______  _______ __________________ _                
(  __  \ (  ___  )|\     /|( (    /|  (  ___  )(  ____ \  (  __  \ (  ____ \(  ____ \\__   __/\__   __/( (    /||\     /|
| (  \  )| (   ) || )   ( ||  \  ( |  | (   ) || (    \/  | (  \  )| (    \/| (    \/   ) (      ) (   |  \  ( |( \   / )
| |   ) || (___) || | _ | ||   \ | |  | |   | || (__      | |   ) || (__    | (_____    | |      | |   |   \ | | \ (_) / 
| |   | ||  ___  || |( )| || (\ \) |  | |   | ||  __)     | |   | ||  __)   (_____  )   | |      | |   | (\ \) |  \   /  
| |   ) || (   ) || || || || | \   |  | |   | || (        | |   ) || (            ) |   | |      | |   | | \   |   ) (   
| (__/  )| )   ( || () () || )  \  |  | (___) || )        | (__/  )| (____/\/\____) |   | |   ___) (___| )  \  |   | |   
(______/ |/     \|(_______)|/    )_)  (_______)|/         (______/ (_______/\_______)   )_(   \_______/|/    )_)   \_/   
                                                                                                                         


";
            Console.WriteLine(asciiArt1);
            Console.WriteLine("As the first light of dawn breaks over the ancient battlements of Altdorf, you stand clad in your family's armor, its polished surface gleaming with the golden hue of the rising sun." +
                              " Below, the bustling city awakens, unaware of the dark forces gathering beyond its walls." +
                              " Your sword, Stormbreaker, hangs at your side—a relic of your noble lineage and a symbol of hope for your people.\n");

            // Present choices to the player
            Console.WriteLine("What will you do today?");
            for (int i = 0; i < Decisions.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {Decisions[i]}");
            }

            // Get player input
            Console.Write("\nEnter the number of your choice: ");
            string option1 = Console.ReadLine();

            // Handle player choice
            switch (option1)
            {
                case "1":
                    Console.WriteLine(
                        "You stride along the battlements, your boots echoing on the cold stone. The air is thick with the scent of damp earth and iron. Soldiers nod as you pass, their faces weary but resolute. Below, the city stirs to life, merchants hurrying to secure their wares while blacksmiths labor tirelessly to forge weapons for the coming battle.\n\n" +
                        "As you examine the gatehouse, you notice cracks in the portcullis mechanism. The soldiers stationed there seem oblivious, their focus entirely on the horizon where the forces of Chaos gather.\n\n" +
                        "You call out to one of the guards, 'Captain, the portcullis mechanism is compromised. Have a team repair it immediately. We cannot afford any weaknesses when the enemy arrives.'\n\n" +
                        "The captain snaps to attention and barks orders to his men. As they begin their work, you feel a presence at your side. Turning, you find the royal advisor.\n\n" +
                        "'Lord Thorne, I have troubling news,' the advisor begins. 'A scout has reported sightings of a Chaos warband moving through the forest. They are closer than we anticipated.'\n\n" +
                        "You nod, steeling yourself for the imminent conflict. 'We must be ready. Gather the commanders. We need a strategy meeting immediately.'"
                    );

                    string[] frames = new string[]
                    {
        "          .     \n" +
        "        .n88.   \n" +
        "       .MM\"\"8.\n" +
        "       MM .M8  \n" +
        "       MM. 88  \n" +
        "       8MM. \"MM    \n" +
        "   .   8M\"     88        __    \n" +
        " .\"8n. \"    .M88     .nd8888nn.   \n" +
        " d'  \"\"8ns.8n.\"888b .d8\"' .8\" 8bn. \n" +
        " 8 . - 88 \"\"88. .8P .8P   d'   8\" 8b  \n" +
        " \"88 8\" 8b . 8.\"\" .d' .   8.. d8. 88  \n" +
        " `8b 8b \"8 .8n8P.    88. \"88 8n 8d88 .8\"\n" +
        "  88. .n88 nns88\"8  \n" +
        "     `8b.8d88\" 8\" \n",

        "    .    .       \n" +
        "  .n8 88 . \n" +
        " 88 8d88n88  \n" +
        " \"88 8\"   8\" \n" +
        "     88.88 .\" \n" +
        "     8d8n8bn.8 \n" +
        "  .88 8\" 8.8\"8\". 8n  \n" +
        "  . .88 8b8 8.8 .88n\n" +
        "   .nd88d8. 8.8\n" +
        " .n88  88\n" +
        "n8'   88 88\"8n.\n" +
        " \"8.  88.8\"  88\"\n",

        "  .  8.  \n" +
        " .n  8.8n   \n" +
        " .\"8. 8.8\" \n" +
        "8\".   8.8\"\"8 \n" +
        " .\" . 8.8\" 8n8bn.\n" +
        "    8.8 88 8d88n8n\" \n" +
        "   88.8 8\"  88 8\"\" \n" +
        "  .88.88.8\"\"88\" 88\" \n" +
        "   88 88 88. 8\" 88 8d8 \n" +
        "  .88 8n8.88b. . 8\"8n \n" +
        "  .88  8  88\" \n" +
        "    88\n"
                    };

                    int windowWidth = Console.WindowWidth;
                    int windowHeight = Console.WindowHeight;

                    for (int i = 0; i < 10; i++)
                    {
                        Console.Clear();
                        int frameWidth = frames[i % frames.Length].Split('\n')[0].Length;
                        int frameHeight = frames[i % frames.Length].Split('\n').Length;

                        int posX = (windowWidth - frameWidth) / 2;
                        int posY = (windowHeight - frameHeight) / 2;

                        Console.SetCursorPosition(posX, posY);
                        Console.Write(frames[i % frames.Length]);
                        Thread.Sleep(900); // Adjust the speed as needed
                    } 

                    List<string> NextSteps = new List<string>
    {
        "Prepare for the Strategy Meeting: Head to the war room and discuss the plan with your commanders.",
        "Scout the Enemy's Position: Personally lead a reconnaissance mission to gather more information about the approaching warband.",
        "Strengthen the Defenses: Oversee the fortifications and ensure all defenses are fully prepared for the siege."
    };

                    Console.WriteLine("What do you do next?");
                    for (int i = 0; i < NextSteps.Count; i++)
                    {
                        Console.WriteLine($"{i + 1}. {NextSteps[i]}");
                    }

                    break;


                case "2":
                    Console.WriteLine("\nYou rally your troops, moving through the barracks and addressing your comrades with words of encouragement." +
                                         " You remind them of the strength of the Empire and the courage that flows through their veins.\n");
                    break;

                case "3":
                    Console.WriteLine("\nYou find a quiet place within the keep and draw Stormbreaker from its scabbard. The ancient blade hums faintly in your hands, its light casting shifting patterns on the stone walls." +
                                        " As you meditate, a vision begins to form, showing a shadowy figure and a dire warning of the battle ahead.\n");
                    break;

                default:
                    Console.WriteLine("\nInvalid choice. Please restart and select a valid option.");
                    break;
            }
        }

    }
}
