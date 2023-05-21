using UnityEngine;
using UnityEngine.UI;

namespace States
{
    public class Dialogue
    {
        public string text;
        public string person;
        public AudioClip audio;
        public Image image;

        public Dialogue(string text, string person = "narrator", AudioClip audio = null, Image image = null)
        {
            this.text = person != "narrator" ? $"{text}" : text;
            this.person = person;
            this.audio = audio;
            this.image = image;
        }
    }
}