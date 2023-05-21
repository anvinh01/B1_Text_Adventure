using System;
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
    [SerializeField] private TextMeshProUGUI dialogName;
    [SerializeField] private AudioSource speaker;
    
    public State currState;
    public State nextState;             // Next state to transition to, after transition dialog
    public bool isTransitioning = false;
    
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

    private AudioClip _audioTest;
    static float _audioVolume = 0.8f;
    // ReSharper disable once InconsistentNaming
    public List<Dialogue> dialogue = new List<Dialogue>();
    private int _dialogueIndex = 0;
    // conditions
    public ArrayList totalWorkHours = new ArrayList();
    public int sleepTime;
    public int workHours;
    public bool savedChild;
    
    void Start()
    {
        _audioTest = Resources.Load<AudioClip>("Audio/I-see-the-light");
        speaker.clip = _audioTest;
        speaker.Play();
        
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
        storyBoard.text = dialogue[_dialogueIndex].text;
        dialogName.text = dialogue[_dialogueIndex].person;
        speaker.volume = _audioVolume;
        dialogName.transform.parent.gameObject.SetActive(dialogName.text != "narrator");
        button1.transform.parent.gameObject.SetActive(button1.text != "" && _dialogueIndex == dialogue.Count - 1 && !isTransitioning);
        button2.transform.parent.gameObject.gameObject.SetActive(button2.text != "" && _dialogueIndex == dialogue.Count - 1 && !isTransitioning);
        button3.transform.parent.gameObject.gameObject.SetActive(button3.text != "" && _dialogueIndex == dialogue.Count - 1 && !isTransitioning);
    }

    public void button1_Click()
    {
        currState.button1();
        Debug.Log($"WorkingHours: {workHours}");
        _dialogueIndex = 0;
        CheckAudio();
        if (isTransitioning) return;
        Next();
    }

    public void button2_Click()
    {
        currState.button2();
        _dialogueIndex = 0;
        CheckAudio();
        if (isTransitioning) return;
        Next();
    }
    
    public void button3_Click()
    {
        currState.button3();
        _dialogueIndex = 0;
        CheckAudio();
        if (isTransitioning) return;
        Next();
    }

    public void NextDialogue()
    {
        
        _dialogueIndex += isTransitioning || (_dialogueIndex != dialogue.Count - 1)  ? 1 : 0;

        Debug.Log($"this dialogue index is {_dialogueIndex}");

        if (_dialogueIndex >= dialogue.Count && isTransitioning)
        {
            Debug.Log($"after trans: {_dialogueIndex}");
            isTransitioning = false;
            Next();
        }
        
        CheckAudio();
    }

    private void Next()
    {
        // Change to new State
        currState = nextState;
        _dialogueIndex = 0;
        currState.init();
        
    }

    private void CheckAudio()
    {
        var tempAudio = dialogue[_dialogueIndex].audio;
        if (tempAudio is not null && tempAudio.name != speaker.clip.name)
        {
            Debug.Log($"Playing audio: {tempAudio.name}");
            speaker.clip = dialogue[_dialogueIndex].audio;
            speaker.Play();
        }
    }

    private void CheckImage()
    {
        var tempImage = dialogue[_dialogueIndex].image;
    }

    public void SetVolume(float volume)
    {
        _audioVolume = volume;
    }

    public void Reset()
    {
        currState = bedroom;
        nextState = null;
        _dialogueIndex = 0;
        totalWorkHours = new ArrayList();
        workHours = 0;
        sleepTime = 0;
        isTransitioning = false;
        speaker.clip = _audioTest;
        speaker.Play();
        currState.init();

    }
}
