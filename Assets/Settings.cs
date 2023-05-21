using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UIElements;

public class Settings : MonoBehaviour
{
    [SerializeField] private AudioSource audioSource;

    [SerializeField] private TextMeshProUGUI walkthroughWindow;
    [SerializeField] private TextMeshProUGUI audioWindow;

    // Start is called before the first frame update
    void Start()
    {
        var tempChildren = GetComponentsInChildren<TextMeshProUGUI>();
        walkthroughWindow = tempChildren[0];
        audioWindow = tempChildren[1];
        OpenWalkthroughWindow();
    }

    // Update is called once per frame
    void Update()
    {
    }

    public void OpenWalkthroughWindow()
    {
        audioWindow.transform.parent.gameObject.SetActive(false);
        walkthroughWindow.transform.parent.gameObject.SetActive(true);
    }

    public void OpenAudioWindow()
    {
        audioWindow.transform.parent.gameObject.SetActive(true);
        walkthroughWindow.transform.parent.gameObject.SetActive(false);
    }

    public void SwitchSettingsPanel()
    {
        this.gameObject.SetActive(!this.gameObject.activeSelf);
    }
}