///////////////////////////////////////////////////////////////////////////////////////////////////////
//////////
//
// Project: Project2
// File Name: Hand.cs
// Description: Creates a hand that is composed of a card array.  
// Course: CSCI 1260 – Introduction to Computer Science II
// Author: Christian Rock
// Created: 09/21/22
// Copyright: Christian Rock, 2022
//
////////////////////////////////////////////////////////////////////////////////////////////////////////
//////////

using Project2;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project2
{
    /// <summary>
    /// Hand class that is composed of a card array. 
    /// This class is used in the driver to create hands and have cards dealt into those hands.
    /// </summary>
    public class Hand
    {
        public Card[] GameHand { get; set; } // Creating a card array attribute
        public int HandSize { get; set; } // integer attribute to dictate hand size. 
        public int CardsInHand { get; set; } // integer attribute to keep track of how many cards have been dealt to a hand.


        /// <summary>
        /// Default constructor for hand class, that creates a hand from default values.  
        /// </summary>
        public Hand() 
        {
            // setting default value for the default constructor
            HandSize = 5;
            CardsInHand = 0;
            GameHand = new Card[HandSize];
            
            
        }

        /// <summary>
        /// Parameterized Constructor that takes in a integer for the handsize and creates an array of that size for cards to be dealt to. 
        /// </summary>
        /// <param name="handSize"> the value that will be used to determine what the hand size is </param>
        public Hand(int handSize)
        {
            //setting values for parameterized constructor. 
            CardsInHand = 0;
            HandSize = handSize;
            GameHand = new Card[handSize];
        

        }

        /// <summary>
        /// Copy constructor for the hand class that takes in a existing hand and copys those values to a new hand. 
        /// </summary>
        /// <param name="existingHand">The value of a hand that has already been created and will be passed to the constructor to create a new hand of the same value.</param>
        public Hand(Hand existingHand)
        {
            HandSize = existingHand.HandSize;
            for (int i = 0; i < existingHand.GameHand.Length;) 
            {
                GameHand[i] = existingHand.GameHand[i];
            }
           
            
        }

        /// <summary>
        /// Method that adds a card to the game hand, this is used in DealAHand to deal a hand from the deck. 
        /// </summary>
        /// <param name="Card"> the value of the card that is getting added to the hand.</param>
        public void AddCard(Card Card)
        {
            Card c = new Card(Card);
            GameHand[CardsInHand] = c;
            CardsInHand++;
            
           

        }

        /// <summary>
        /// to string that allows for the hand to be displayed coreectly and in an aesthetically pleasing manner.
        /// </summary>
        /// <returns> returns all the card values in a hand</returns>
        public override string ToString()
        {
            string msg = "";
            foreach (Card c in GameHand) // prints each card in the card array to the screen. 
            {
                msg += $"\n{c.ToString()}";
            }
            return msg;

        }
    }
}
