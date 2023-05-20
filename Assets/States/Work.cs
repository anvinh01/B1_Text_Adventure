using System.Linq;
using UnityEngine;

namespace States
{
    public class Work : State
    {
        private StateManager _stateManager;
        public Work(StateManager stateManager)
        {
            _stateManager = stateManager;
        }
        public void init()
        {
            _stateManager.button1.text = "Get to work";
            _stateManager.button2.text = "Get a coffee";
            var overtimeCount = 0;
            foreach (int hour in _stateManager.totalWorkHours)
            {
                if (hour > 5)
                {
                    overtimeCount++;
                }
            }
            Debug.Log("Overtime hours: " + overtimeCount);
            _stateManager.button3.text = overtimeCount >= 3 ? "Follow Boss" : "";
        }
        public void button1()
        {
            _stateManager.currState = _stateManager.myWorkPC;
        }

        public void button2()
        {
            _stateManager.currState = _stateManager.coffeRoom;
        }

        public void button3()
        {
            _stateManager.currState = _stateManager.promotion;
        }

        public string Dialog()
        {
            throw new System.NotImplementedException();
        }


    }
}