using System.Collections;
using System.Collections.Generic;
using States;
using UnityEngine;
using TMPro;

public class StateManager : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] private TextMeshProUGUI txt;

    private State currState;
    public State wakeUpState;
    public State onTheStreetState;
    public State work;
    public State workAtHome;
    public State heaven;
    public State baby;
    public State isekai;
    public State restForEternity;
    
    void Start()
    {
        txt.text = "Hello";
        txt.color = Color.green;

        wakeUpState = new WakeUp(this);
        onTheStreetState = new OnTheStreet(this);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void button1_Click()
    {
        currState.button1();
    }

    private void button2_Click()
    {
        currState.button2();
    }
}
