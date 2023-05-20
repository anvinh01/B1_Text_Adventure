namespace States
{
    public class OnTheStreet : State
    {
        private StateManager _stateManager;
        public OnTheStreet(StateManager stateManager)
        {
            _stateManager = stateManager;
        }
        public string Dialog()
        {
            throw new System.NotImplementedException();
        }
        public void init()
        {
            _stateManager.button1.text = "Normal zur Arbeit gehen";
            _stateManager.button2.text = "Zur Arbeit rennen";
            _stateManager.button3.text = _stateManager.sleepTime == 25 ? "Save Child" : "";
        }
        
        public void button1()
        {
            _stateManager.currState = _stateManager.work;
        }

        public void button2()
        {
            _stateManager.currState = _stateManager.heaven;
        }

        public void button3()
        {
            _stateManager.currState = _stateManager.heaven;
        }

    }
}