using CardModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UnoLogic
{
    public class UnoGame
    {
        enum Mode
        {
            Move,
            Pass,
            Bluff
        }
        enum MovesDiraction
        {
            Normal,
            Inverted
        }

        private static readonly Random rnd = new Random();
        public List<Player> Players { get; set; }
        public CardSet Deck { get; set; }
        public CardSet Table { get; set; }
        public bool IsGameOver { get; set; } = false;
        public string ResultInfo { get; set; }
        public Player ActivePlayer { get; set; }
        public string StateInfo
        {
            get
            {
                switch (mode)
                {
                    case Mode.Move:
                        return $"{ActivePlayer.Name}!! This is your turn";
                    case Mode.Pass:
                        return $"{PreviousPlayer(ActivePlayer).Name} is passing";
                    case Mode.Bluff:
                        return $"{PreviousPlayer(PreviousPlayer(ActivePlayer)).Name} has bluffed";
                    default:
                        throw new Exception("We don't know this game mode!");
                }
            }
        }
        public string GetPossibleActions()
        {
            if (Table.LastCard.Color == CardColor.Black)
                return "Bluff";
            if (ActivePlayer.Hand.Count == 1 || PreviousPlayer(ActivePlayer).Hand.Count == 1)
                return "Uno";
            return "Pass";
        }

        public CardColor ChosedColor { get; set; }

        private Mode mode;
        private MovesDiraction movesDiraction = MovesDiraction.Normal;
        private Action showState;
        private Func<CardColor> changeColor;
        private readonly int maxCountCards = 6;

        public UnoGame(List<Player> players, Action showState,  Func<CardColor> changeColor)
        {
            Players = players;
            this.showState = showState;
            this.changeColor = changeColor;
            Table = new CardSet();
            Deck = new CardSet();
        }
        public void Prepare()
        {
            foreach (Player player in Players)
            {
                player.IsInGame = true;
            }
            Deck.Full();
            Deck.Shuffle();
            Deck.CutTo(46);
        }
        public void Deal()
        {
            IsGameOver = false;

            foreach (Player player in Players)
            {
                player.Hand.Add(Deck.Deal(7));
                player.Hand.Sort();
            }

            ResultInfo = "All right!";
            mode = Mode.Move;

            ActivePlayer = WhoFirst();
            Table.Add(Deck.Pull(Deck.Count - 1));

            showState();
        }
        public void Turn(Card cardToTurn)
        {
            if (!Impossible(cardToTurn))
            {
                if (Table.Count > maxCountCards) ClearTable();

                mode = Mode.Move;
                Table.Add(ActivePlayer.Hand.Pull(cardToTurn));

                CheckPlayers();
                CheckWinner();

                CheckCardSpecialPower(cardToTurn);

                GetNewActivePlayer();

                ResultInfo = "";
                showState();
            }
        }
        private void CheckCardSpecialPower(Card cardToTurn)
        {
            switch (cardToTurn.Figure)
            {
                case CardFigure.Block:
                    GetNewActivePlayer();
                    break;
                case CardFigure.Switcher:
                    SwitchMovesMode();
                    break;
                case CardFigure.DoubleCards:
                    if (Deck.Count > 0)
                    {
                        GetNewActivePlayer();
                        ActivePlayer.Hand.Add(Deck.Deal(2));
                    }
                    break;
                case CardFigure.ColorSwitcher:
                    ChosedColor = changeColor();
                    break;
                case CardFigure.SquadCards:
                    ChosedColor = changeColor();
                    if(Deck.Count > 0)
                    {
                        GetNewActivePlayer();
                        ActivePlayer.Hand.Add(Deck.Deal(4));
                    }
                    break;
            }
        }
        private void SwitchMovesMode()
        {
            switch (movesDiraction)
            {
                case MovesDiraction.Normal:
                    movesDiraction = MovesDiraction.Inverted;
                    break;
                case MovesDiraction.Inverted:
                    movesDiraction = MovesDiraction.Normal;
                    break;
                default:
                    throw new Exception("Unknow moves diraction!");
            }
        }
        private void CheckPlayers()
        {
            for (int i = 0; i < Players.Count; i++)
            {
                if (Players[i].Hand.Count <= 0)
                    Players[i].IsInGame = false;
            }
        }
        private void CheckWinner()
        {
            int playersInGame = Players.Count(p => p.IsInGame);

            if (!PlayersContainsCardToTurn())
            {
                IsGameOver = true;
                ResultInfo = "No one has a card to do a turn!";
            }
            if (playersInGame == 1)
            {
                IsGameOver = true;
                ResultInfo = $"{Players.FirstOrDefault(p => p.IsInGame).Name} loose!";
            }
            else if(playersInGame == 0)
            {
                IsGameOver = true;
                ResultInfo = "There is a draw";
            }
            showState();
        }
        private bool PlayersContainsCardToTurn()
        {
            List<Player> leftPlayers = Players.FindAll(p => p.IsInGame && p.Hand.Count > 0);

            foreach (Player player in leftPlayers)
            {
                foreach (Card c in player.Hand)
                {
                    if(Deck.Count > 0)
                        if (c.Color == Deck.LastCard.Color || c.Figure == Deck.LastCard.Figure || c.Color == CardColor.Black)
                            return true;
                }
            }

            return false;
        }
        public void Pass()
        {
            CheckPlayers();
            CheckWinner();

            mode = Mode.Pass;

            if(Deck.Count > 0)
            {
                ActivePlayer.Hand.Add(Deck.Pull(Deck.Count - 1));
                ActivePlayer.Hand.Sort();

                if (!Impossible(ActivePlayer.Hand.LastCard))
                {
                    showState();
                    return;
                }

                GetNewActivePlayer();
                showState();
            }
            else
            {
                GetNewActivePlayer();
                showState();
            }
        }
        public void Bluff()
        {
            Player bluffedPlayer;

            if (Table.LastCard.Figure == CardFigure.SquadCards)
                bluffedPlayer = PreviousPlayer(PreviousPlayer(ActivePlayer));
            else bluffedPlayer = PreviousPlayer(ActivePlayer);

            Card targetCard = Table[Table.Count - 2];

            if(IsBluff(bluffedPlayer, targetCard))
            {
                mode = Mode.Bluff;
                if (Deck.Count > 2) 
                    bluffedPlayer.Hand.Add(Deck.Deal(2));
                bluffedPlayer.Hand.Sort();
                showState();
            }
            else
            {
                if (Deck.Count > 2)
                { 
                    ActivePlayer.Hand.Add(Deck.Deal(2));
                    ActivePlayer.Hand.Sort();
                }
                GetNewActivePlayer();
                showState();
            }
        }
        public void Uno()
        {
        }
        private bool IsBluff(Player bluffedPlayer, Card targetCard)
        {
            foreach (Card card in bluffedPlayer.Hand)
            {
                if (card.Color == targetCard.Color || card.Figure == targetCard.Figure)
                    return true;
            }
            return false;
        }
        private void ClearTable()
        {
            Table.CutTo(Table.Count - 1);
        }
        private Player WhoFirst()
        {
            return Players[0];
        }
        private bool Impossible(Card cardToTurn)
        {
            return IsGameOver ||
                !ActivePlayer.Hand.Contains(cardToTurn) ||
                !IsBeat(cardToTurn, Table.LastCard);
        }
        private bool IsBeat(Card front, Card back)
        {
           if(Table.LastCard.Color == CardColor.Black)
               return front.Color == back.Color ||
                   front.Color == ChosedColor;

            return front.Color == back.Color ||
                    front.Figure == back.Figure ||
                    front.Color == CardColor.Black;
        }
        private void GetNewActivePlayer()
        {
            switch (movesDiraction)
            {
                case MovesDiraction.Normal:
                    ActivePlayer = NextPlayer(ActivePlayer);
                    break;
                case MovesDiraction.Inverted:
                    ActivePlayer = PreviousPlayer(ActivePlayer);
                    break;
                default:
                    throw new Exception("We can't find new player!");
            }
        }
        private Player NextPlayer(Player player)
        {
            Player applicant = Players[Players.Count - 1] == player ? Players[0] : Players[Players.IndexOf(player) + 1];
            if (!applicant.IsInGame) return NextPlayer(applicant);
            return applicant;
        }
        private Player PreviousPlayer(Player player)
        {
            Player applicant = Players[0] == player ? Players[Players.Count - 1] : Players[Players.IndexOf(player) - 1];
            if (!applicant.IsInGame) return PreviousPlayer(applicant);
            return applicant;
        }
    }
}
