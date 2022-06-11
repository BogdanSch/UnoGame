﻿using CardModel;
using GraphicCardInfrasctructure;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

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
        public enum MovesDiraction
        {
            Normal,
            Inverted
        }
        private static readonly Random rnd = new Random();
        private readonly int maxCountCards = 5;
        private bool isPassUsed = false;

        public UnoData GameState = new UnoData();
        
        public string StateInfo
        {
            get
            {
                switch (mode)
                {
                    case Mode.Move:
                        return $"{GameState.ActivePlayer.Name}!! This is your turn";
                    case Mode.Pass:
                        return $"{GetPasserName()} is passing";
                    case Mode.Bluff:
                        return $"{GetBlufferName()} has bluffed";
                    default:
                        throw new Exception("We don't know this game mode!");
                }
            }
        }
        public string GetPossibleActions()
        {
            if (GameState.Table.LastCard.Color == CardColor.Black)
                return "Bluff";
            return "Pass";
        }
        private Mode mode;
        private Action showState;
        private Func<CardColor> changeColor;

        public UnoGame(List<Player> players, Action showState,  Func<CardColor> changeColor)
        {
            GameState.Players = players;
            this.showState = showState;
            this.changeColor = changeColor;
            GameState.Table = new CardSet();
            GameState.Deck = new CardSet();
        }
        public UnoGame() { }
        public void Prepare()
        {
            foreach (Player player in GameState.Players)
            {
                player.IsInGame = true;
            }
            GameState.Deck.Full();
            GameState.Deck.Shuffle();
            GameState.Deck.CutTo(46);
        }
        public void Deal()
        {
            GameState.IsGameOver = false;

            foreach (Player player in GameState.Players)
            {
                player.Hand.Add(GameState.Deck.Deal(7));
                player.Hand.Sort();
            }

            GameState.ResultInfo = "All right!";
            mode = Mode.Move;

            GameState.ActivePlayer = WhoFirst();
            GameState.Table.Add(GetFirstCard());

            showState();
        }

        public void Turn(Card cardToTurn)
        {
            if (!Impossible(cardToTurn))
            {
                isPassUsed = false;
                if (GameState.Table.Count > maxCountCards) ClearTable();
                GameState.IsBluffed = false;

                mode = Mode.Move;
                GameState.Table.Add(GameState.ActivePlayer.Hand.Pull(cardToTurn));

                CheckPlayers();
                CheckWinner();

                CheckCardSpecialPower(cardToTurn);

                GetNewActivePlayer();

                GameState.ResultInfo = "";
                showState();
                SerializeGame();
            }
        }
        private void CheckCardSpecialPower(Card cardToTurn)
        {
            switch (cardToTurn.Figure)
            {
                case CardFigure.Block:
                    if (ContainsCardToBeat(GetNextPlayer(GameState.ActivePlayer), cardToTurn.Figure))
                        return;
                    GetNewActivePlayer();
                    break;
                case CardFigure.Switcher:
                    SwitchMovesMode();
                    break;
                case CardFigure.DoubleCards:
                    if (GameState.Deck.Count > 0)
                    {
                        if (ContainsCardToBeat(GetNextPlayer(GameState.ActivePlayer), cardToTurn.Figure))
                            return;

                        GetNewActivePlayer();

                        if (GameState.Deck.Count < 2)
                        {
                            GameState.ActivePlayer.Hand.Add(GameState.Deck.Deal(GameState.Deck.Count));
                            return;
                        }
                        GameState.ActivePlayer.Hand.Add(GameState.Deck.Deal(2));
                    }
                    break;
                case CardFigure.ColorSwitcher:
                    GameState.ChosedColor = changeColor();
                    break;
                case CardFigure.SquadCards:
                    GameState.ChosedColor = changeColor();
                    if(GameState.Deck.Count > 0)
                    {
                        if(ContainsCardToBeat(GetNextPlayer(GameState.ActivePlayer), cardToTurn.Figure))
                            return;
                        GetNewActivePlayer();
                        if(GameState.Deck.Count < 4)
                        {
                            GameState.ActivePlayer.Hand.Add(GameState.Deck.Deal(GameState.Deck.Count));
                            return;
                        }
                        GameState.ActivePlayer.Hand.Add(GameState.Deck.Deal(4));
                    }
                    break;
            }
        }
        private bool ContainsCardToBeat(Player player, CardFigure figure)
        {
            foreach (Card card in player.Hand)
            {
                if (card.Figure == figure)
                {
                    GameState.CanBeat = true;
                    return true;
                }
            }
            return false;
        }
        private void SwitchMovesMode()
        {
            switch (GameState.MoveDiraction)
            {
                case MovesDiraction.Normal:
                    GameState.MoveDiraction = MovesDiraction.Inverted;
                    break;
                case MovesDiraction.Inverted:
                    GameState.MoveDiraction = MovesDiraction.Normal;
                    break;
                default:
                    throw new Exception("Unknow moves diraction!");
            }
        }
        private void CheckPlayers()
        {
            for (int i = 0; i < GameState.Players.Count; i++)
            {
                if (GameState.Players[i].Hand.Count <= 0)
                    GameState.Players[i].IsInGame = false;
            }
            //foreach (Player player in GameState.Players)
            //{
            //    if (player.Hand.Count > 1)
            //        player.Uno = false;
            //}
        }
        private void CheckWinner()
        {
            int playersInGame = GameState.Players.Count(p => p.IsInGame);

            if (!PlayersContainsCardToTurn())
            {
                GameState.IsGameOver = true;
                GameState.ResultInfo = "No one has a card to do a turn! \n Game over!";
            }
            if (playersInGame == 1)
            {
                GameState.IsGameOver = true;
                GameState.ResultInfo = $"{GameState.Players.FirstOrDefault(p => p.IsInGame).Name} loose!";
            }
            else if(playersInGame == 0)
            {
                GameState.IsGameOver = true;
                GameState.ResultInfo = "There is a draw";
            }
            showState();
        }
        private bool PlayersContainsCardToTurn()
        {
            List<Player> leftPlayers = GameState.Players.FindAll(p => p.IsInGame && p.Hand.Count > 0);

            foreach (Player player in leftPlayers)
            {
                foreach (Card c in player.Hand)
                {
                    if(GameState.Deck.Count > 0)
                        if (c.Color == GameState.Deck.LastCard.Color || c.Figure == GameState.Deck.LastCard.Figure || c.Color == CardColor.Black)
                            return true;
                }
            }
            return false;
        }
        public void Pass()
        {
            if (isPassUsed) return;
            isPassUsed = true;
            CheckPlayers();
            CheckWinner();

            mode = Mode.Pass;

            if(GameState.Deck.Count > 0)
            {
                GameState.ActivePlayer.Hand.Add(GameState.Deck.Pull(GameState.Deck.Count - 1));
                GameState.ActivePlayer.Hand.Sort();

                if (!Impossible(GameState.ActivePlayer.Hand.LastCard))
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
            if (GameState.IsBluffed)
                return;
            Player bluffedPlayer = GetBluffedPlayer();

            Card targetCard = GameState.Table[GameState.Table.Count - 2];

            if (IsBluff(bluffedPlayer, targetCard))
            {
                mode = Mode.Bluff;
                if (GameState.Deck.Count > 2)
                    bluffedPlayer.Hand.Add(GameState.Deck.Deal(2));
                else bluffedPlayer.Hand.Add(GameState.Deck.Deal(GameState.Deck.Count));

                GameState.IsBluffed = true;
                bluffedPlayer.Hand.Sort();
                showState();
            }
            else
            {
                if (GameState.Deck.Count >= 2)
                {
                    GameState.ActivePlayer.Hand.Add(GameState.Deck.Deal(2));
                    GameState.ActivePlayer.Hand.Sort();
                }
                GetNewActivePlayer();
                showState();
            }
        }
        //public void Uno()
        //{
        //    if (ActivePlayer.Hand.Count == 1)
        //    {
        //        ActivePlayer.Uno = true;
        //    }
        //    foreach (Player player in Players)
        //    {
        //        if (player.Hand.Count == 1 && !player.Uno)
        //        {
        //            player.Hand.Add(Deck.Deal(2));
        //        }
        //    }
        //}
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
            GameState.Table.CutTo(GameState.Table.Count - 1);
        }
        private bool Impossible(Card cardToTurn)
        {
            return GameState.IsGameOver ||
                !GameState.ActivePlayer.Hand.Contains(cardToTurn) ||
                !IsBeat(cardToTurn, GameState.Table.LastCard);
        }
        private bool IsBeat(Card front, Card back)
        {
            if (GameState.CanBeat)
            {
                GameState.CanBeat = false;
                return front.Figure == back.Figure;
            }
           if(GameState.Table.LastCard.Color == CardColor.Black)
               return front.Color == back.Color ||
                   front.Color == GameState.ChosedColor;

            return front.Color == back.Color ||
                    front.Figure == back.Figure ||
                    front.Color == CardColor.Black;
        }
        private Player WhoFirst()
        {
            return GameState.Players[0];
        }
        private Card GetFirstCard()
        {
            Card card = GameState.Deck.Pull(GameState.Deck.Count - 1);

            if (card.Color == CardColor.Black)
            {
                int randomCardNum = rnd.Next(0, GameState.Deck.Count - 1);

                Card randomCard = GameState.Deck[randomCardNum];
                Card temp = randomCard;
                GameState.Deck[randomCardNum] = card;
                card = temp;

                if (card.Color == CardColor.Black)
                {
                    GameState.Deck.Add(card);
                    GetFirstCard();
                }
            }
            return card;
        }
        private void GetNewActivePlayer()
        {
            GameState.ActivePlayer = GetNextPlayer(GameState.ActivePlayer);
        }
        private Player GetBluffedPlayer()
        {
            Player bluffedPlayer = null;

            if (GameState.Table.LastCard.Figure == CardFigure.SquadCards)
                bluffedPlayer = GetPreviousPlayer(GetPreviousPlayer(GameState.ActivePlayer));
            else
                bluffedPlayer = GetPreviousPlayer(GameState.ActivePlayer);

            return bluffedPlayer;
        }
        private Player GetNextPlayer(Player player)
        {
            switch (GameState.MoveDiraction)
            {
                case MovesDiraction.Normal:
                    player = NextPlayer(GameState.ActivePlayer);
                    break;
                case MovesDiraction.Inverted:
                    player = PreviousPlayer(GameState.ActivePlayer);
                    break;
                default:
                    throw new Exception("We can't find new player!");
            }

            return player;
        }
        private Player GetPreviousPlayer(Player player)
        {
            switch (GameState.MoveDiraction)
            {
                case MovesDiraction.Normal:
                    player = PreviousPlayer(GameState.ActivePlayer);
                    break;
                case MovesDiraction.Inverted:
                    player = NextPlayer(GameState.ActivePlayer);
                    break;
                default:
                    throw new Exception("We can't find new player!");
            }

            return player;
        }
        private Player NextPlayer(Player player)
        {
            Player applicant = GameState.Players[GameState.Players.Count - 1] == player ? GameState.Players[0] : GameState.Players[GameState.Players.IndexOf(player) + 1];
            if (!applicant.IsInGame) return NextPlayer(applicant);
            return applicant;
        }
        private Player PreviousPlayer(Player player)
        {
            Player applicant = GameState.Players[0] == player ? GameState.Players[GameState.Players.Count - 1] : GameState.Players[GameState.Players.IndexOf(player) - 1];
            if (!applicant.IsInGame) return PreviousPlayer(applicant);
            return applicant;
        }
        private string GetBlufferName()
        {
            return GetPreviousPlayer(GetPreviousPlayer(GameState.ActivePlayer)).Name;
            //switch (GameState.MoveDiraction)
            //{
            //    case MovesDiraction.Normal:
            //        return PreviousPlayer(PreviousPlayer(GameState.ActivePlayer)).Name;
            //    case MovesDiraction.Inverted:
            //        return NextPlayer(NextPlayer(GameState.ActivePlayer)).Name;
            //    default:
            //        throw new Exception("Unknown game mode!");
            //}
        }
        private string GetPasserName()
        {
            return GetPreviousPlayer(GameState.ActivePlayer).Name;
            //switch (GameState.MoveDiraction)
            //{
            //    case MovesDiraction.Normal:
            //        return PreviousPlayer(GameState.ActivePlayer).Name;
            //    case MovesDiraction.Inverted:
            //        return NextPlayer(GameState.ActivePlayer).Name;
            //    default:
            //        throw new Exception("Unknnown game mode!");
            //}
        }
        private void SerializeGame()
        {
            XmlSerializer xmlSerializer = new XmlSerializer(GameState.GetType());

            using (FileStream fs = new FileStream("Game.xml", FileMode.Create))
            {
                xmlSerializer.Serialize(fs, GameState);
            }
        }
    }
}
