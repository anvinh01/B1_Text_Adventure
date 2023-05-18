using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class StateManager : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] private TextMeshProUGUI txt;
    void Start()
    {
        txt.text = "Hello";
        txt.color = Color.green;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
