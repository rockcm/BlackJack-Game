///////////////////////////////////////////////////////////////////////////////////////////////////////
//////////
//
// Project: Lab2
// File Name: Hand.cs
// Description: Creates a hand that is composed of a card array.  
// Course: CSCI 1260 – Introduction to Computer Science II
// Author: Christian Rock
// Created: 09/14/22
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
    public class Hand
    {
        public Card[] GameHand { get; set; }
        public int HandSize { get; set; }
        public int CardsInHand { get; set; }



        public Hand()
        {
            HandSize = 5;
            CardsInHand = 0;
            GameHand = new Card[HandSize];
            
        }

        public Hand(int handSize)
        {
            CardsInHand = 0;
            HandSize = handSize;
            GameHand = new Card[handSize];
           

        }

        public Hand(Hand existingHand)
        {
            HandSize = existingHand.HandSize;
            for (int i = 0; i < existingHand.GameHand.Length;)
            {
                existingHand.GameHand[i] = GameHand[i];
            }
            
        }

        public void AddCard(Card Card)
        {
            Card c = new Card(Card);
            GameHand[CardsInHand] = c;
            CardsInHand++;
           

        }

        
        public override string ToString()
        {
            string msg = "";
            foreach (Card c in GameHand)
            {
                msg += $"\n{c.ToString()}";
            }
            return msg;

        }
    }
}
