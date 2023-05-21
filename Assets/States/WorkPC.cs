using System.Collections.Generic;

namespace States
{
    public class WorkPC : State
    {
        private StateManager _stateManager;
        public WorkPC(StateManager stateManager)
        {
            _stateManager = stateManager;
        }

        public void init()
        {
            _stateManager.dialogue = _stateManager.workHours == 0
                ? new List<Dialogue>()
                {
                    new Dialogue("Helllooo!!", "Tony"),
                    new Dialogue("Hi!.", "Colleagues"),
                    new Dialogue("Let's try to fix that bug.", "Tony"),
                }
                : new List<Dialogue>()
                {
                    new Dialogue("that seems to do the trick", "Tony"),
                    new Dialogue("Hmmmmmm.... not another bug...", "Tony"),
                };
            _stateManager.button1.text = "get back to work";
            _stateManager.button2.text = "take a break";
            _stateManager.button3.text = _stateManager.workHours >= 5 ? "Go Home" : "";
        }

        public void button1()
        {
            _stateManager.nextState = _stateManager.myWorkPC;
            _stateManager.workHours += 1;
        }

        public void button2()
        {
            _stateManager.nextState = _stateManager.coffeRoom;
            _stateManager.dialogue = new List<Dialogue>()
            {
                new Dialogue("Guys, I'll take a little break. Maybe I'll get the solution to that bug", "Tony"),
                new Dialogue("Yeah Good Luck.", "Colleagues"),
                new Dialogue("Heading to the break room...")
            };
            _stateManager.isTransitioning = true;
        }

        public void button3()
        {
            _stateManager.totalWorkHours.Add(_stateManager.workHours);
            _stateManager.workHours = 0;
            _stateManager.nextState = _stateManager.bedroom;
            _stateManager.dialogue = new List<Dialogue>()
            {
                new Dialogue("Well That's it for today guys. I'm going Home", "Tony"),
                new Dialogue("Yeah I will go too in a minute. Bye!", "Albert"),
                new Dialogue("On The way home I meet a nice cat. Well that made me hungry so i hurried home"),
            };
        }
    }
}