using System.Collections;
using Unity.VisualScripting;

namespace States
{
    public class MyComputer : State
    {
        private StateManager _stateManager;
        public MyComputer(StateManager stateManager)
        {
            _stateManager = stateManager;
        }
        
        public void init()
        {
            _stateManager.dialogue = _stateManager.workHours == 0 ? new ArrayList()
            {
                "Well let's see.... No merge request, no meetings today. I guess I'll still have to work on that bug.",
                "*working sounds",
                "that seems to do the trick"
            }:new ArrayList()
            {
                "Hmmmmmm.... not another bug...",
            };
            _stateManager.button1.text = "work for 1 more hour";
            _stateManager.button2.text = "go take a rest";
            _stateManager.button3.text = _stateManager.workHours >= 5 ? "go back to the bedroom" : "";
        }
        
        public void button1()
        {
            _stateManager.currState = _stateManager.myComputer;
            _stateManager.workHours += 1;
        }

        public void button2()
        {
            _stateManager.currState = _stateManager.myComputer;
        }

        public void button3()
        {
            _stateManager.currState = _stateManager.bedroom;
        }

        public string Dialog()
        {
            throw new System.NotImplementedException();
        }


    }
}