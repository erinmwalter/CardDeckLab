using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CardDeckLab.Models
{

    public class PileResult
    {
        public bool success { get; set; }
        public string deck_id { get; set; }
        public int remaining { get; set; }
        public Piles piles { get; set; }
    }

    public class Piles
    {
        public Pile player1 { get; set; }
        public Pile discard { get; set; }
    }

    public class Pile
    {
        public int remaining { get; set; }

        public Card[] cards {get;set;}
    }



}
