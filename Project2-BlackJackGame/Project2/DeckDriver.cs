////////////////////////////////////////////////////////////////////////////////////////////////////////
//////////
//
// Project: Project2
// File Name: DeckDriver.cs
// Description: Driver class that demonstrates functionality of deck, card and hand classes. 
// Course: CSCI 1260 – Introduction to Computer Science II
// Author: Christian Rock
// Created:  09/21/2022
// Copyright: Christian Rock, 2022
//
////////////////////////////////////////////////////////////////////////////////////////////////////////
//////////



/// <summary>
/// Implementation of Suit and Face enums with Card Class objects and Deck objects. Creates a deck object and calls methods to perform actions on the deck object.
/// Also used the hand class to dictate how many cards should be dealt from the deck to each player.
/// Deck constist of card objects.
/// 
/// </summary>

using Project2;
using System.Runtime.CompilerServices;



Deck Deck = new Deck(); /// Creates a new Deck object.
int UserInput; // input for the amount of players 
int UserInput2; // input for the amount of cards in each players hand.

/*
/// Displays the deck object. 
Console.WriteLine("Original Deck of Cards:");
Console.WriteLine(Deck);

/// Shuffles the deck and then displays the shuffled deck. 
Deck.Shuffle();
Console.WriteLine("------------");
Console.WriteLine("Shuffled Deck of Cards:");
Console.WriteLine(Deck);

Console.WriteLine("------------");

/// Creates a second deck based on the first one using the copy constructor 
Deck Deck2 = new Deck(Deck);

/// 1st hand dealt from 2nd deck.  
Console.WriteLine("Hand 1 from copy deck:");
Console.WriteLine(Deck2.DealAHand(7));

/// 2nd hand dealt from 2nd deck.
Console.WriteLine("------------");
Console.WriteLine("Hand 2 from copy deck:");
Console.WriteLine(Deck2.DealAHand(7));

// just to keep code clean
Console.WriteLine("------------");




Deck.Shuffle(); // just to make sure deck is shuffled for upcoming game hands

// do while loop to ensure cards being dealt do not exceed deck's limit.
do
{
    Console.WriteLine($"\nHow many players are there? "); // prompts user for amount of players and stores that in a variable. 
    UserInput = Convert.ToInt32(Console.ReadLine());


    Console.WriteLine("\nHow many cards are in each Hand? "); // prompts user for amount of cards in each hand and stores that in a variable. 
    UserInput2 = Convert.ToInt32(Console.ReadLine());

    if (UserInput * UserInput2 > Deck.DeckCards.Length) // if statement for if the users hands dealt exceeds decks card limit
    {
        Console.WriteLine($"\nCARDS DEALT WILL EXCEED 52, PLEASE TRY AGAIN.");
    } 

} while (UserInput * UserInput2 > Deck.DeckCards.Length); // continues to loop if card amount to be dealt is not less than 52.

// for loop that deals a hand according to how many players were entered and how many cards are in each hand that was entered. 
for (int i = 0; i < UserInput; i++)
{
   
    
        Console.WriteLine($"\nHand {i + 1}"); // prints which players hand is being displyed below. 
        Console.WriteLine(Deck.DealAHand(UserInput2)); // prints out the hand for the player
    
    
 
}

//exit message 
Console.WriteLine("\nThank you for using my program. \nThe program has ended, press any key to exit. ");
Console.ReadKey();
*/




/// Game is designed to quickly simulate hands of blackjack that could be dealt at a casino. 

// shuffles deck for upcoming game.

Deck.Shuffle(); 
Console.WriteLine();
string PlayAgain = ""; 
do 
{
    Deck.Shuffle(); // shuffling deck to make sure that no matter how many games are played, there will be cards available in the deck. 
    Console.WriteLine("------------");
    string dealers = "";
    int counter = 0; // counter to keep track of cards dealt to players 

//string for dealers hand



    Console.WriteLine("Dealer's Hand: ");


    // do while loop to create 2 cards for dealers hand but only show 1.
    do
    {

        dealers += $"\n{Deck.DealACard()}";

        counter++;
        if (counter == 1) // if statemtent that makes cards show while dealer only has 1 to show. 
        {
            Console.WriteLine($"\nOne Hidden Card " +
                $"              {dealers} ");
        }
    } while (counter < 2); // adds card after dealers card was shown. 



    // string for players hand.
    Console.WriteLine("------------");
    Console.WriteLine("Player Hand: ");
    string players = "";
    int counter2 = 0;

    //do while loop to create players hand and shows it to player.
    do
    {

        players += $"\n{Deck.DealACard()}";

        counter2++;


    } while (counter2 < 2);
    Console.WriteLine(players);

   

    string userinput4; //  variable for if the dealer should hit. 
    string UserInput3 = ""; // variable for if the user wants to hit


    // asks user if they want to hit after seeing thier first 2 cards.
 
        Console.WriteLine("\nDo you want to hit? (Y or N): ");
        UserInput3 = Console.ReadLine();
   
   

    if (UserInput3 == "n" || UserInput3 == "N") // if statement for if the user does not want to hit. 
    {
        do // loop to show the hands after the first cards are dealt and prompts user to make dealer hit till 17 or bust. Displays final hands after completion.
        {
            //shows player and dealers cards, then prompts used to make dealer hit till at least 17. 
            Console.WriteLine("\nHANDS AFTER PLAYER ROUND"); 
            Console.WriteLine($"\nDealers Hand: \n{dealers}\n");
            Console.WriteLine($"\nPlayers Hand:\n{players}");
            Console.WriteLine();
            Console.WriteLine("Dealer must hit till 17. Should Dealer hit again? (Y or N): ");
            userinput4 = Console.ReadLine();
            if (userinput4 == "n" || userinput4 == "N") // shows final hands if dealer should not hit again. 
            {
                Console.WriteLine("FINAL HANDS");
                Console.WriteLine($"Dealers Hand: \n{dealers}\n");
                Console.WriteLine($"Players Hand:\n{players}");
                Console.WriteLine();
                Console.WriteLine("Your game is completed. Please determine winner. Automation to be added later. :)");
                Console.WriteLine("\ndo you want to play again?"); // asks player if they want to play again and store in variable. 
                PlayAgain = Console.ReadLine();
                Console.Clear(); // clears console for new game
            }
            else if (userinput4 == "Y" || userinput4 == "y") // adds card to dealers hand if selected 
            {
                dealers += $"\n{Deck.DealACard()}";
                Console.WriteLine(dealers);
            }
        } while (userinput4 == "y" || userinput4 == "Y");
    }

    if (UserInput3 == "y" || UserInput3 == "Y") // if statement for if the user would like to "hit" aka add a card to their hand.
    {

        do // do while loop to ask user if they would like to hit again after first initital hit. 
        {
            players += $"\n{Deck.DealACard()}";
            Console.WriteLine($"\nPlayers Hand: \n{players}");

            Console.WriteLine("\ndo you want to hit? (Y or N): ");
            UserInput3 = Console.ReadLine();
            
            if (UserInput3 == "n" || UserInput3 == "N") // if statement for if the user does not want to hit anymore.
            {
                do // loop to show the hands after the first cards are dealt and prompts user to make dealer hit till 17 or bust. Displays final hands after completion.
                {
                    Console.WriteLine("\nHANDS AFTER PLAYER ROUND");
                    Console.WriteLine($"\nDealers Hand: \n{dealers}\n");
                    Console.WriteLine($"\nPlayers Hand:\n{players}");
                    Console.WriteLine();
                    Console.WriteLine("Dealer must hit till 17. Should Dealer hit again? (Y or N): ");
                    userinput4 = Console.ReadLine();
                    if (userinput4 == "n" || userinput4 == "N") // shows final hands if dealer should not hit again. 
                    {
                        Console.WriteLine("\nFINAL HANDS");
                        Console.WriteLine($"\nDealers Hand: \n{dealers}\n");
                        Console.WriteLine($"\nPlayers Hand:\n{players}");
                        Console.WriteLine();
                        Console.WriteLine("Your game is completed. Please determine winner. Automation to be added later. :)");
                      
                    }
                    else if (userinput4 == "Y" || userinput4 == "y") // adds card to dealers hand if selected 
                    {
                        dealers += $"\n{Deck.DealACard()}";
                        Console.WriteLine($"\nDealers Hand:\n{dealers}");
                    }
                } while (userinput4 == "Y" || userinput4 == "y");
            }
        }
        while (UserInput3 == "y" || UserInput3 == "Y");

        Console.WriteLine("\nDo you want to play again? (Y or N): "); // option for if user wants to play again 
        PlayAgain = Console.ReadLine();
        Console.Clear();
    }
} while (PlayAgain == "Y" || PlayAgain == "y"); // loop for if user wants to play again. 




/*
    do
    {
        Console.WriteLine("HANDS AFTER FIRST ROUND");
        Console.WriteLine($"Dealers Hand: \n{dealers}\n");
        Console.WriteLine($"Players Hand:\n{players}");
        Console.WriteLine();
        Console.WriteLine("dealer must hit till 17. Should Dealer hit again?");
        userinput4 = Console.ReadLine();
        if (userinput4 == "n" || userinput4 == "N")
        {
            Console.WriteLine("FINAL HANDS");
            Console.WriteLine($"Dealers Hand: \n{dealers}\n");
            Console.WriteLine($"Players Hand:\n{players}");
            Console.WriteLine();
            Console.WriteLine("Your game is completed.");
        }
        else if (userinput4 == "Y" || userinput4 == "y")
        {
            dealers += Deck.DealACard();
            Console.WriteLine(dealers);
        }
    } while (userinput4 == "n" || userinput4 == "N");

}
    */
