using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

namespace States
{
    public class MyComputer : State
    {
        private StateManager _stateManager;
        private Image _computerImage;

        public MyComputer(StateManager stateManager)
        {
            _stateManager = stateManager;
            _computerImage = Resources.Load<Image>("Images/office-computer-screen");
        }

        public void init()
        {
            _stateManager.dialogue = _stateManager.workHours == 0
                ? new List<Dialogue>()
                {
                    new Dialogue(
                        "Well let's see.... No merge request, no meetings today. I guess I'll still have to work on that bug.",
                        "Tony", image: _computerImage),
                    new Dialogue("*working sounds"),
                }
                : new List<Dialogue>()
                {
                    new Dialogue("that seems to do the trick", "Tony"),
                    new Dialogue("Hmmmmmm.... not another bug...", "Tony"),
                };
            _stateManager.button1.text = "work for 1 more hour";
            _stateManager.button2.text = "go take a rest";
            _stateManager.button3.text = _stateManager.workHours >= 5 ? "go back to the bedroom" : "";
        }

        public void button1()
        {
            _stateManager.nextState = _stateManager.myComputer;
            _stateManager.workHours += 1;
        }

        public void button2()
        {
            _stateManager.nextState = _stateManager.myComputer;
        }

        public void button3()
        {
            _stateManager.TotalWorkHours.Add(_stateManager.workHours);
            _stateManager.workHours = 0;
            _stateManager.nextState = _stateManager.bedroom;
            _stateManager.dialogue = new List<Dialogue>()
            {
                new Dialogue("Oh god, that was a hard day. I just can't get to the bottom of this bug.", "Tony"),
                new Dialogue("Well Tomorrow is another day. I will fix it by then", "Tony"),
                new Dialogue(
                    "This was not possible. Tony was lying to himself. The bug he was working on, will continue to exist for eternity")
            };
            _stateManager.isTransitioning = true;
        }
    }
}