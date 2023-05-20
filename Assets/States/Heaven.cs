namespace States
{
    public class Heaven : State 
    {
        private StateManager _stateManager;
        public Heaven(StateManager stateManager)
        {
            _stateManager = stateManager;
        }
        public string Dialog()
        {
            throw new System.NotImplementedException();
        }

        public void init()
        {
            _stateManager.button1.text = "I wanna live";
            _stateManager.button2.text = "Rest";
            _stateManager.button3.text = _stateManager.savedChild ? "Into the new world" : "";
        }
        public void button1()
        {
            _stateManager.currState = _stateManager.ambulance;
        }

        public void button2()
        {
            _stateManager.currState = _stateManager.restForEternity;
        }

        public void button3()
        {
            _stateManager.currState = _stateManager.isekai;
        }


    }
}