//Introduction
using System.ComponentModel.Design;

Console.WriteLine("You are walking through the forest when you notice an odd looking tree to your left.");
Console.WriteLine("There is a heart carved into the side of the tree that reads \"LAu + RAg\"");
Console.WriteLine("There is also an odd looking branch. On closer inspection, the branch appears to be a secret lever!");
Console.WriteLine("");
Console.WriteLine("Pull the lever?");

string leverPulled = Console.ReadLine();

//Right (waterfall) route activated
if (leverPulled == "yes")
{
    Console.WriteLine("You hear a kerchunk as you pull the lever down.");
    Console.WriteLine("Ahead, you hear the sound of stone scraping against itself, followed by the sound of rushing water.");
    Console.WriteLine("You decide to go investigate the sound.");
    Console.WriteLine("");
    Console.WriteLine("Heading towards the noise, you stumble upon a large waterfall. Through the waterfall, you can faintly see a small cave.");
    Console.WriteLine("");
    Console.WriteLine("You decide to investigate, trudging your way through the cool water.");
    Console.WriteLine("On the other side, you appear to have entered a narrow stone entryway. To your right lays three coins, one made of gold, one of silver, and the other copper.");
    Console.WriteLine("Ahead, you see a large mechanical door with two coin slots.");
    Console.WriteLine("");
    Console.WriteLine("Which coin would you like to put into the left slot?");
    //Periodic Table Puzzle Variables
    string leftCoin = Console.ReadLine();
    bool leftCoinVerifier = false;
    bool rightCoinVerifier = false;
    string goldCoin = "gold";
    string silverCoin = "silver";
    string copperCoin = "copper";

    //Coin 1: Gold Coin (LAu = Left Au (Gold on the periodic table)
    if (leftCoin == "gold")
    {
        leftCoinVerifier = !leftCoinVerifier;
        Console.WriteLine($"You hear a click as you insert the {goldCoin} coin into the left slot.");
        Console.WriteLine("");
        Console.WriteLine("Which coin would you like to put into the right slot?");
    }
    else if (leftCoin == "silver")
    {
        Console.WriteLine($"You hear a click as you insert the {silverCoin} coin into the left slot.");
        Console.WriteLine("");
        Console.WriteLine("Which coin would you like to put into the right slot?");
    }
    else if (leftCoin == "copper")
    {
        Console.WriteLine($"You hear a click as you insert the {copperCoin} coin into the left slot.");
        Console.WriteLine("");
        Console.WriteLine("Which coin would you like to put into the right slot?");
    }
    else
    {
        Console.WriteLine("Invalid input.");
    }
    string rightCoin = Console.ReadLine();
    //Coin 2: Silver Coin (RAg = Right Ag (Silver on the periodic table)
    if (rightCoin == "gold")
    {
        Console.WriteLine($"You hear a click as you insert the {goldCoin} coin into the right slot.");
    }
    else if (rightCoin == "silver")
    {
        rightCoinVerifier = !rightCoinVerifier;
        Console.WriteLine($"You hear a click as you insert the {silverCoin} coin into the right slot.");
    }
    else if (rightCoin == "copper")
    {
        Console.WriteLine($"You hear a click as you insert the {copperCoin} coin into the right slot.");
    }
    else
    {
        Console.WriteLine("Invalid input.");
    }
    //Door Verifier
    bool openDoor = leftCoinVerifier && rightCoinVerifier;
    //Ending 1: Flushed Away (Right route Bad End)
    if (openDoor == false)
    {
        Console.WriteLine("");
        Console.WriteLine("You wait for the door to open, but instead you hear the sound of rushing water.");
        Console.WriteLine("Suddenly, you are flushed out of the cavern by a flood of water!");
        Console.WriteLine("");
        Console.WriteLine("As you come to your senses, you find yourself drifting down a river, far away from where you last were.");
        Console.WriteLine("");
        Console.WriteLine("END");
    }
    //Ending 2: Waterfall Haul (Right route Good End)
    else if (openDoor == true)
    {
        Console.WriteLine("");
        Console.WriteLine($"You stand back after inserting the {goldCoin} and {silverCoin} coins into the slots.");
        Console.WriteLine("The door opens after a few seconds, revealing a room filled to the brim with gold and various magical trinkets.");
        Console.WriteLine("You pack up everything into a magical pocket dimension bag and head home, happy with your finds.");
        Console.WriteLine("");
        Console.WriteLine("END");
    }
}
//Left (unicorn) route activated
else if (leverPulled == "no")
{
    Console.WriteLine("You decide that it's best to not touch the lever.");
    Console.WriteLine("");
    Console.WriteLine("You carry on down the path you were headed, passing by a large waterfall.");
    Console.WriteLine("You walk for a while before stumbling upon a nice, sunny patch in the middle of an otherwise shady forest.");
    Console.WriteLine("Tired, you decide to sit down for a bit and rest.");
    Console.WriteLine("");
    Console.WriteLine("As you lean back and close your eyes, you hear the sound of hooves trotting towards you.");
    Console.WriteLine("Curious, you open your eyes to find yourself face-to-face with a unicorn!");
    Console.WriteLine("");
    Console.WriteLine("The unicorn takes a seat next to you.");
    Console.WriteLine("\"I never see any humans out this way!\" it says. \"Would you like some berries? I just went out and picked some for lunch, but you can have a few if you'd like!\"");
    Console.WriteLine("It shows you the inside of the basket. There are 20 berries inside.");
    Console.WriteLine("");
    Console.WriteLine($"How many berries do you want?");

    int berryCount = int.Parse(Console.ReadLine());
    //Number of berries (Correct answer is >1 and <11)
    //Ending 3: Zero Berries (Left path Bad End 1)
    if (berryCount == 0)
    {
        Console.WriteLine($"The unicorn looks at you as you say {berryCount}.");
        Console.WriteLine("\"What? Do you not trust me?\" it says, offended.");
        Console.WriteLine("Before you can explain yourself, it scoffs at you and teleports you out of the forest.");
        Console.WriteLine("");
        Console.WriteLine("You sit down on the side of the road, wondering where you messed up.");
        Console.WriteLine("");
        Console.WriteLine("END");
    }
    //Ending 4a: Normal Amount of Berries (Left path Good End) <- Here specifically to fix one grammatical error.
    else if (berryCount == 1)
    {
        Console.WriteLine($"The unicorn nods and gives you {berryCount} berry.");
        Console.WriteLine("It looks at you curiously as you bite into it.");
        Console.WriteLine("\"I'm going to take a nap, you are free to join me.\" it says, yawning.");
        Console.WriteLine("You agree, and lay down against its soft body.");
        Console.WriteLine("");
        Console.WriteLine("You wake up asleep in your own bed. You wonder if all of that was just a dream.");
        Console.WriteLine("");
        Console.WriteLine("END");
    }
    //Ending 4b: Normal Amount of Berries (Left path Good End)
    else if (berryCount <= 10)
    {
        Console.WriteLine($"The unicorn nods and gives you {berryCount} berries.");
        Console.WriteLine("It looks at you curiously as you bite into one of them.");
        Console.WriteLine("\"I'm going to take a nap, you are free to join me.\" it says, yawning.");
        Console.WriteLine("You agree, and lay down against its soft body.");
        Console.WriteLine("");
        Console.WriteLine("You wake up asleep in your own bed. You wonder if all of that was just a dream.");
        Console.WriteLine("");
        Console.WriteLine("END");
    }
    //Ending 5: Too Many Berries (Left path Bad End 2)
    else if (berryCount > 10)
    {
        Console.WriteLine($"The unicorn jumps back, surprised. \"{berryCount} berries?!? Are you mad?!? This is my lunch!\" It says angrily.");
        Console.WriteLine("Before you can explain yourself, it shoos you away. \"I knew I shouldn't have trusted you, greedy human.\"");
        Console.WriteLine("");
        Console.WriteLine("You sadly walk out of the forest, hungry and alone.");
        Console.WriteLine("");
        Console.WriteLine("END");
    }
    else if (berryCount > 20)
    {
        Console.WriteLine("Invalid berry number!");
    }
    else
    {
        Console.WriteLine("Invalid input.");
    }

}

else
{
    Console.WriteLine("Invalid input");
}