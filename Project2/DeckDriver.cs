////////////////////////////////////////////////////////////////////////////////////////////////////////
//////////
//
// Project: Project2
// File Name: DeckDriver.cs
// Description: Lab1 
// Course: CSCI 1260 – Introduction to Computer Science II
// Author: Christian Rock
// Created: 08/31/22
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


/// Displays the deck object. 
Console.WriteLine(Deck);
/// Shuffles the deck and then displays the shuffled deck. 
Deck.Shuffle();
Console.WriteLine("------------");
Console.WriteLine("Shuffled Deck:");
Console.WriteLine(Deck);

Console.WriteLine("------------");

/// Creates a second deck based on the first one using the copy constructor 
Deck Deck2 = new Deck(Deck);

/// 1st hand dealt from 2nd deck.  
Console.WriteLine("Hand 1:");
Console.WriteLine(Deck2.DealAHand(7));

/// 2nd hand dealt from 2nd deck.
Console.WriteLine("------------");
Console.WriteLine("Hand 2:");
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
   
    
        Console.WriteLine($"Hand {i + 1}"); // prints which players hand is being displyed below. 
        Console.WriteLine(Deck.DealAHand(UserInput2)); // prints out the hand for the player
    
    
 
}

Console.WriteLine("Program has ended, press any key to exit. ");
Console.ReadKey();


////////////////////////////////////////////////////////
///Created black jack game. Based off lab 2 will create a new one for project 2 when I have time. Will try to implement hand class :)
/*
Deck.Shuffle();
Console.WriteLine();
Console.WriteLine("------------");

Console.WriteLine("Dealer's Hand");
string dealers = "";
int counter = 0;

do
{
 
    dealers += $"\n{Deck.DealACard()}";

    counter++;
    if(counter == 1)
    {
        Console.WriteLine($"One hidden card " +
            $"              {dealers}");
    }
} while (counter < 2);




Console.WriteLine("------------");
Console.WriteLine("Player Hand");
string players ="";
int counter2 = 0;
do
{
   
    players += $"\n{Deck.DealACard()}";

    counter2++;
    

} while (counter2 < 2);
Console.WriteLine(players);



string UserInput3 = "";
Console.WriteLine("do you want to hit?");
UserInput3 = Console.ReadLine();
string msg = "";
if (UserInput3 == "n" || UserInput3 == "N")
{
    Console.WriteLine("FINAL HANDS");
    Console.WriteLine($"Dealers Hand: \n{dealers}\n");
    Console.WriteLine($"Players Hand:\n{players}");
    Console.WriteLine();
    Console.WriteLine("Your game is completed.");

}
if (UserInput3 == "y" || UserInput3 == "Y")
{

    do
    {
        players += $"\n{Deck.DealACard()}";
        Console.WriteLine(players);
        
        Console.WriteLine("do you want to hit?");
        UserInput3 = Console.ReadLine();
        Console.ReadKey();
        if (UserInput3 == "n" || UserInput3 == "N")
        {
            Console.WriteLine("FINAL HANDS");
            Console.WriteLine($"Dealers Hand: \n{dealers}\n");
            Console.WriteLine($"Players Hand:\n{players}");
            Console.WriteLine();
            Console.WriteLine("Your game is completed.");

        }
    }
    while (UserInput3 == "y" || UserInput3 == "Y");

}

*/