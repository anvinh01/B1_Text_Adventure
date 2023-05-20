using System.Collections.Generic;

namespace States
{
    public class Ambulance : State
    {
        private StateManager _stateManager;
        public Ambulance(StateManager stateManager)
        {
            _stateManager = stateManager;
        }

        public void init()
        {
            _stateManager.dialogue = new List<Dialogue>()
            {
                new Dialogue("Ahhhhhhhhhhh", "Tony"),
                new Dialogue("HE IS AWAKE!!", "???"),
                new Dialogue("Tony? Tony? It's me Mom. We are all here. How are you dear?", "Mom"),
                new Dialogue("He is probably still in shock", "Brother"),
                new Dialogue("Oh my god. I just had a weird dream", "Tony"),
                new Dialogue(
                    "That was not a Dream, but the real Noobmaster69 kicking him out of heaven. But he couldn't know that",
                    "Narrator"),
            };
        throw new System.NotImplementedException();
        }

        public void button1()
        {
            throw new System.NotImplementedException();
        }

        public void button2()
        {
            throw new System.NotImplementedException();
        }

        public void button3()
        {
            throw new System.NotImplementedException();
        }
    }
}