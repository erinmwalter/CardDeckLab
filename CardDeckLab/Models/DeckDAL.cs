using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace CardDeckLab.Models
{
    public class DeckDAL
    {
        public Deck GetDeck() 
        {
            //the api allows for multiple decks so maybe will play around with this in future
            //however the PILES functionality only works with a single deck
            int numDecks = 1;

            //setting up the URL API call
            string url = $"https://deckofcardsapi.com/api/deck/new/shuffle/?deck_count={numDecks}";

            //need to create our request
            HttpWebRequest request = WebRequest.CreateHttp(url);

            //get response
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();

            //read response and save as string
            StreamReader rd = new StreamReader(response.GetResponseStream());
            string result = rd.ReadToEnd();
            rd.Close();

            //now need to parse into a Deck Model
            Deck d = JsonConvert.DeserializeObject<Deck>(result);

            return d;
        }

        //draws 5 cards and returns Hand of cards
        public Hand DrawHand(string deckId, int numCards) 
        {
            //setting up the URL API call
            string url = $"https://deckofcardsapi.com/api/deck/{deckId}/draw/?count={numCards}";

            //need to create our request
            HttpWebRequest request = WebRequest.CreateHttp(url);

            //get response
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();

            //read response and save as string
            StreamReader rd = new StreamReader(response.GetResponseStream());
            string result = rd.ReadToEnd();
            rd.Close();

            //now need to parse into a Hand model
            Hand h = JsonConvert.DeserializeObject<Hand>(result);

            return h;
        }

        
        public void AddToPile(string deckId, string pileName, string[] toAdd) 
        {
            //set up URL API Call
            string url = $"https://deckofcardsapi.com/api/deck/{deckId}/pile/{pileName}/add/?cards=";
            //add each keeper card to the end of the url to add to pile
            foreach (string s in toAdd) 
            {
                url += $"{s},";
            }

            //need to create our request
            HttpWebRequest request = WebRequest.CreateHttp(url);

            //get response
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();

            //read response and save as string
            StreamReader rd = new StreamReader(response.GetResponseStream());
            string result = rd.ReadToEnd();
            rd.Close();

        }


        public PileResult GetPile(string deckId) 
        {
            //setting up the URL API call
            string url = $"https://deckofcardsapi.com/api/deck/{deckId}/pile/player1/list";

            //need to create our request
            HttpWebRequest request = WebRequest.CreateHttp(url);

            //get response
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();

            //read response and save as string
            StreamReader rd = new StreamReader(response.GetResponseStream());
            string result = rd.ReadToEnd();
            rd.Close();

            //now need to parse into a Hand model
            PileResult p = JsonConvert.DeserializeObject<PileResult>(result);

            return p;

        }
    }
}
