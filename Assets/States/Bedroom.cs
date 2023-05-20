using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace States
{
    public class Bedroom : State
    {
        private StateManager _stateManager;
        public Bedroom(StateManager stateManager)
        {
            _stateManager = stateManager;
        }
        public string Dialog()
        {
            throw new System.NotImplementedException();
        }
        public void init()
        {
            _stateManager.dialogue = _stateManager.sleepTime == 0 ? new List<Dialogue>()
            {
                new Dialogue("Whaaaaaah Damm that was a nice dream. I'm still kinda sleepy. \n It's already 6:00am. Hmmmm.....",
                    "Tony"
                    ),
                new Dialogue("should I skip breakfast and go to sleep again?",
                    "Tony")
            }:new List<Dialogue>()
            {
                new Dialogue("Pleaseeeee another minute...", "Tony")
            };
            _stateManager.button1.text = "Go to work";
            _stateManager.button2.text = "Work at home";
            _stateManager.button3.text = "Sleep for 5 more minutes";
        }
        
        public void button1()
        {
            _stateManager.dialogue = new List<Dialogue>()
            {
                new Dialogue("Okay, It's Time to stand up now.", "Tony"),
            };
            _stateManager.isTransitioning = true;
            _stateManager.nextState = _stateManager.onTheStreet;
        }

        public void button2()
        {
            _stateManager.dialogue = new List<Dialogue>()
            {
                new Dialogue("Going to the PC..."),
            };
            _stateManager.isTransitioning = true;
            _stateManager.nextState = _stateManager.myComputer;
        }

        public void button3()
        {
            _stateManager.dialogue = new List<Dialogue>()
            {
                new Dialogue("I'm going to sleep for 5 more minutes.", "Tony"),
                new Dialogue("Good night")
            };
            _stateManager.isTransitioning = true;
            _stateManager.nextState = _stateManager.bedroom;
            _stateManager.sleepTime += 5;
        }




    }
}