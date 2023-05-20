using System.Collections;

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
            _stateManager.dialogue = _stateManager.sleepTime == 0 ? new ArrayList()
            {
                "Whaaaaaah Damm that was a nice dream. I'm still kinda sleepy. \n It's already 6:00am. Hmmmm.....",
                "should I skip breakfast and go to sleep again?"
            }:new ArrayList()
            {
                "Pleaseeeee another minute..."
            };
            _stateManager.button1.text = "Go to work";
            _stateManager.button2.text = "Work at home";
            _stateManager.button3.text = "Sleep for 5 more minutes";
        }
        
        public void button1()
        {
            _stateManager.currState = _stateManager.onTheStreet;
        }

        public void button2()
        {
            _stateManager.currState = _stateManager.myComputer;
        }

        public void button3()
        {
            _stateManager.currState = _stateManager.bedroom;
            _stateManager.sleepTime += 5;
        }




    }
}