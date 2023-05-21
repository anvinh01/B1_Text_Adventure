using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace States
{
    public class Work : State
    {
        private readonly StateManager _stateManager;
        private readonly AudioClip _workMusic;
        public Work(StateManager stateManager)
        {
            _stateManager = stateManager;
            _workMusic = Resources.Load<AudioClip>("Audio/when-you-wish-upon-a-star");
        }
        public void init()
        {
            var overtimeCount = 0;
            foreach (int hour in _stateManager.totalWorkHours)
            {
                if (hour > 5)
                {
                    overtimeCount++;
                }
            }
            
            _stateManager.dialogue = overtimeCount == 3 ? new List<Dialogue>()
            {
                new Dialogue("Hello There!","Tony", _workMusic),
                new Dialogue("General Kenobi!!", "Mark"),
                new Dialogue("Hi *laughts\n So what is on the plan today?", "Tony"),
                new Dialogue("Well it seems like I got a meeting with HR today again. Do you also want to attend?", "Mark"),
                new Dialogue("Tony?? Tony!! Are you there?", "???"),
                new Dialogue("OI gotta talk with you for a moment! Do you have time?", "Boss"),
                new Dialogue("Well it seems like you don't have time for my meeting with HR today. Good luck", "Mark"),

            } : new List<Dialogue>()
            {
                new Dialogue("Hello There!","Tony"),
                new Dialogue("General Kenobi!!", "Mark"),
                new Dialogue("Hi *laughts\n So what is on the plan today?", "Tony"),
                new Dialogue("Well it seems like I got a meeting with HR today again. Do you also want to attend?", "Mark"),
                new Dialogue("Of course, just call me when the time comes. I'll be working on that damm bug in the meantime", "Tony"),
            };
            
            // Buttons
            _stateManager.button1.text = "Get to work";
            _stateManager.button2.text = "Get a coffee";

            Debug.Log("Overtime hours: " + overtimeCount);
            _stateManager.button3.text = overtimeCount == 3 ? "Follow Boss" : "";
        }
        public void button1()
        {
            _stateManager.nextState = _stateManager.myWorkPC;
        }

        public void button2()
        {
            _stateManager.nextState = _stateManager.coffeRoom;
        }

        public void button3()
        {
            _stateManager.nextState = _stateManager.promotion;
        }

        public string Dialog()
        {
            throw new System.NotImplementedException();
        }


    }
}