using CardModel;
using GraphicCardInfrasctructure;
using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;
using static UnoLogic.UnoGame;

namespace UnoLogic
{
    [XmlInclude(typeof(GraphicCard))]
    public class UnoData
    {
        public UnoData() { }
        public List<Player> Players { get; set; }
        public CardSet Deck { get; set; }
        public CardSet Table { get; set; }
        public bool IsGameOver { get; set; } = false;
        public string ResultInfo { get; set; }
        public Player ActivePlayer { get; set; }
        public CardColor ChosedColor { get; set; }
        public MovesDiraction MoveDiraction { get; set; } = MovesDiraction.Normal;
        public bool IsBluffed { get; set; } = false;
        public bool CanBeatSpeciallCard { get; set; } = false;
        public bool IsPassUsed { get; set; } = false;

    }
}
