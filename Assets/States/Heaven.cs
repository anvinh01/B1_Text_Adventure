using System.Collections.Generic;
using UnityEngine;

namespace States
{
    public class Heaven : State
    {
        private StateManager _stateManager;
        private readonly AudioClip _overTheRainbow;

        public Heaven(StateManager stateManager)
        {
            _stateManager = stateManager;
            _overTheRainbow = Resources.Load<AudioClip>("Audio/Somewhere-over-the-rainbow");
        }

        public void init()
        {
            _stateManager.dialogue = new List<Dialogue>()
            {
                new Dialogue("Suddenly, a light appears and Tony is on top of clouds", audio: _overTheRainbow),
                new Dialogue("Are thy exhausted?", "???"),
                new Dialogue("What is happening? Am I in heaven?", "Tony"),
                new Dialogue(
                    "Not yet. But thy has already proven to the lord and shown the humans on earth the warmth of a caring heart.",
                    "???"),
                new Dialogue(
                    "The way to heaven is open to anyone who has chosen to walk the path for others. To those who have selfless desires and a soul kind. "),
                new Dialogue(
                    "It is not the weight of one action, but the way you have chosen to live, which has granted a path to the peace you have in front of you.",
                    "???"),
                new Dialogue("Who are you?", "Tony"),
                new Dialogue(
                    "Throughout the thousand years, living with the humans and watching them, I have been called by many names: Angel, ",
                    "???"),
                new Dialogue("Devil", "?Angel?"),
                new Dialogue("Buddha", "?Angel/Devil?"),
                new Dialogue("These names have been mine for a long time, but you can call me Noobmaster69",
                    "?Angel/Devil/Buddha?"),
                new Dialogue(
                    "H-H-How can it be...? You are not a symbol of an angel. you can never be. You are the DEVILLLL",
                    "Tony"),
                new Dialogue(
                    "Since you have still much to learn on earth. I shall give you a choice. Rest in peace in heaven or go back and learn to play",
                    "Noobmaster69"),
            };
            _stateManager.button1.text = "I wanna live";
            _stateManager.button2.text = "Rest in Peace";
            _stateManager.button3.text = _stateManager.savedChild ? "Into the new world" : "";
        }

        public void button1()
        {
            _stateManager.nextState = _stateManager.ambulance;
            _stateManager.dialogue = new List<Dialogue>()
            {
                new Dialogue(
                    "I think I am done here. I have gone out with everything I stand for. Peace seems like a good option.",
                    "Tony"),
                new Dialogue("So you have chosen to rest in peace?", "Noobmaster69"),
                new Dialogue("Yes.", "Tony"),
                new Dialogue(
                    "Toooo baaaaad. I wont let you. I cant let a a noob like you into heaven. It ruins their whole reputation. Get back to earth idiot.",
                    "Noobmaster69"),
                new Dialogue("W-w-what ... ??", "Tony"),
                new Dialogue("You heard me! Come back once you think you deserve to be here!! Byeeeee!!",
                    "Noobmaster69"),
                new Dialogue("Ahhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhh", "Tony"),
            };
            _stateManager.isTransitioning = true;
        }

        public void button2()
        {
            _stateManager.nextState = _stateManager.restForEternity;
            _stateManager.dialogue = new List<Dialogue>()
            {
                new Dialogue(
                    "I think I am done here. I have gone out with everything I stand for. Peace seems like a good option.",
                    "Tony"),
                new Dialogue("So you have chosen to rest in peace?", "Noobmaster69"),
                new Dialogue("Yes.", "Tony"),
                new Dialogue(
                    "Well It is probably better that way. Even though you can't play for shit. You still have a good heart.",
                    "Noobmaster69"),
                new Dialogue("Then Rest in Peace.", "Noobmaster69"),
            };
            _stateManager.isTransitioning = true;
        }

        public void button3()
        {
            _stateManager.nextState = _stateManager.isekai;
        }
    }
}