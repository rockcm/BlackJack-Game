﻿////////////////////////////////////////////////////////////////////////////////////////////////////////
//////////
//
// Project: Lab2
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
/// Deck constist of card objects.
/// 
/// </summary>

using Project2;
using System.Runtime.CompilerServices;


/// Creates a new Deck object.
Deck Deck = new Deck();


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

Console.WriteLine("------------");
Console.WriteLine();

int UserInput;
Console.WriteLine("How many players are there? ");
UserInput = Convert.ToInt32(Console.ReadLine());

int UserInput2;
Console.WriteLine("How many cards are in each Hand? ");
UserInput2 = Convert.ToInt32(Console.ReadLine());

for (int i = 0; i < UserInput; i++)
{
    if (Deck.NextCard < 52)
    {
        Console.WriteLine($"Hand {i + 1}");
        Console.WriteLine(Deck.DealAHand(UserInput2));
    }

    
    
}



/*
Hand PlayerHand = new Hand(UserInputHandSize);
PlayerHand = Deck2.DealAHand(UserInputHandSize);
Console.WriteLine(PlayerHand);
*/