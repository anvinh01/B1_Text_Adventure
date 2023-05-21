using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

namespace States
{
    public class Rest: State
    {
        private StateManager _stateManager;
        private AudioClip _heavenSound;
        public Rest(StateManager stateManager)
        {
            _stateManager = stateManager;
            _heavenSound = Resources.Load<AudioClip>("Audio/when-you-wish-upon-a-star");
        }

        

        public void init()
        {
            _stateManager.dialogue = new List<Dialogue>()
            {
                new Dialogue("Welcome to the afterlife.", "Dad", _heavenSound),
                new Dialogue("Hi Dad", "Tony"),
                new Dialogue("And so they spend their time resting together as a family")
            };
            _stateManager.button1.text = "Back to menu";
            _stateManager.button2.text = "";
            _stateManager.button3.text = "";
        }

        public void button1()
        {
            UnityEngine.SceneManagement.SceneManager.LoadScene("Main Menu");
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