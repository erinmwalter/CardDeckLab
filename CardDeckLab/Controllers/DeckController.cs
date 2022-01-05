using CardDeckLab.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CardDeckLab.Controllers
{
    public class DeckController : Controller
    {
        DeckDAL dd = new DeckDAL();
        int HAND_SIZE = 5;

        //initial view where the player draws a new hand for first time
        public IActionResult Index() 
        {
            Deck d = dd.GetDeck();
            //draw 5 cards
            Hand h = dd.DrawHand(d.deck_id, HAND_SIZE);

            //add to player 1's pile of cards
            //so need to get these into a string array to send to the addtopile method
            List<string> newCards = new List<string>();
            foreach (Card c in h.cards)
            {
                newCards.Add(c.code);
            }

            //now, add the code of the cards drawn to the player's pile  
            dd.AddToPile(d.deck_id, "player1", newCards.ToArray());
            PileResult p = dd.GetPile(h.deck_id);
            return View(p);
        }

        [HttpPost]
        public IActionResult Index(string deckID, string[] discards) 
        {

            //add discards to discard pile
            dd.AddToPile(deckID, "discard", discards);
            

            //figure out how many new ones to draw and draw them.
            //do this by looking at the "REMAINING" value of the player's pile
            int numToDraw = HAND_SIZE - dd.GetPile(deckID).piles.player1.remaining;
            
            Hand h = dd.DrawHand(deckID, numToDraw);

            //we only need the codes for these cards
            //so need to get these into a string array to send to the addtopile method
            List<string> newCards = new List<string>();
            foreach(Card c in h.cards)
            {
                newCards.Add(c.code);  
            }

            //now, add the code of the cards drawn to the player's pile  
            dd.AddToPile(deckID, "player1", newCards.ToArray());
      
            //the above methods just "wrote" to the player pile/discard pile
            //snow we need to call again to the DAL to get the LIST of the player's cards to display them
            PileResult p = dd.GetPile(deckID);

            //then we want to display this pile of cards and allow this to repeat cycle.
            return View(p);

        }

    }
}
