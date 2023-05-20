using System.Collections;
using System.Collections.Generic;
using System.Linq;
using States;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class StateManager : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] private TextMeshProUGUI storyBoard;

    public State currState;
    public State bedroom;
    public State onTheStreet;
    public State myComputer;
    
    public State heaven;
    public State ambulance;
    public State isekai;
    public State restForEternity;
    
    public State work;
    public State myWorkPC;
    public State coffeRoom;
    public State promotion;

    [SerializeField] public TextMeshProUGUI button1;
    [SerializeField] public TextMeshProUGUI button2;
    [SerializeField] public TextMeshProUGUI button3;


    public ArrayList dialogue = new ArrayList();
    private int dialogueIndex = 0;
    // conditions
    public ArrayList totalWorkHours = new ArrayList();
    public int sleepTime;
    public int workHours;
    public bool savedChild;
    
    void Start()
    {
        totalWorkHours.Add(16);
        totalWorkHours.Add(12);
        totalWorkHours.Add(8);

        button1.text = "button 1";
        button2.text = "button 2";
        button3.text = "button 3";
        
        storyBoard.text = "Hello";
        storyBoard.color = Color.white;
        
        bedroom = new Bedroom(this);
        onTheStreet = new OnTheStreet(this);
        myComputer = new MyComputer(this);
        heaven = new Heaven(this);
        ambulance = new Ambulance(this);
        isekai = new Isekai(this);
        restForEternity = new Rest(this);
        
        work = new Work(this);
        myWorkPC = new WorkPC(this);
        coffeRoom = new CoffeeRoom(this);
        promotion = new Promotion(this);
        

        currState = bedroom;
        currState.init();
    }

    // Update is called once per frame
    void Update()
    {
        storyBoard.text = dialogue[dialogueIndex].ToString();
        button1.transform.parent.gameObject.SetActive(button1.text != "" && dialogueIndex == dialogue.Count - 1);
        button2.transform.parent.gameObject.gameObject.SetActive(button2.text != "" && dialogueIndex == dialogue.Count - 1);
        button3.transform.parent.gameObject.gameObject.SetActive(button3.text != "" && dialogueIndex == dialogue.Count - 1);
    }

    public void button1_Click()
    {
        currState.button1();
        currState.init();
        dialogueIndex = 0;
    }

    public void button2_Click()
    {
        currState.button2();
        currState.init();
        dialogueIndex = 0;
    }
    
    public void button3_Click()
    {
        currState.button3();
        currState.init();
        dialogueIndex = 0;
    }

    public void nextDialogue()
    {
        dialogueIndex += dialogueIndex != dialogue.Count - 1? 1 : 0;
    }
}
