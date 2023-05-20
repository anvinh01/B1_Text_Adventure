using System.Collections.Generic;

namespace States
{
    public class Promotion : State
    {
        private StateManager _stateManager;
        public Promotion(StateManager stateManager)
        {
            _stateManager = stateManager;
        }

        public void init()
        {
            _stateManager.dialogue = new List<Dialogue>()
            {
                new Dialogue("Yeah it seems that way. Yes sir, I have time right now!", "Tony"),
                new Dialogue(
                    "The morning sun cast a warm glow through the office windows as employees hurriedly prepared for another busy day. The air was filled with anticipation and nervous energy, as rumors of promotions and career advancements had been circulating for weeks. Among the employees was Alex, a dedicated and hardworking individual who had been with the company for several years. Little did Alex know that today would be a defining moment in their professional life."),
                new Dialogue("Good morning, Mr. Anderson. How can I assist you today?", "Tony"),
                new Dialogue(
                    "Good morning, Tony. Could we have a quick chat in my office? I'd like to discuss something important with you.",
                    "Mr. Anderson"),
                new Dialogue(
                    "With each word, Tonys's heart skipped a beat. Their mind raced, trying to decipher the reason behind this sudden invitation. Was it good news or perhaps a reprimand? Alex rose from their chair, following Mr. Anderson to his office, nerves tightening their grip."),
                new Dialogue(
                    "Entering the boss's office, Tony took a seat opposite Mr. Anderson, their hands clasped tightly in their lap. The room felt stifling, the weight of uncertainty heavy upon their shoulders."),
                new Dialogue(
                    "Tony, I've been observing your exceptional work ethic and commitment to this company over the years. Your dedication hasn't gone unnoticed, and I believe it's time for you to take on a new role.",
                    "Mr.Anderson"),
                new Dialogue(
                    "The words hung in the air, sinking into Alex's mind. It took a moment for the gravity of the situation to fully sink in. A promotion? Alex's heart soared with a mix of relief and joy. Their hard work had paid off, and their dreams of advancement were finally becoming a reality"),
                new Dialogue(
                    "Thank you, Mr. Anderson. I can't express how honored and grateful I am for this opportunity. I won't let you down.",
                    "Tony"),
                new Dialogue(
                    "I have full confidence in your abilities, Tony. Your promotion is well-deserved. I believe you'll thrive in this new role and contribute even more to our company's success. Congratulations.",
                    "Mr.Anderson"),
                new Dialogue(
                    "The weight of the world seemed to lift off Tony's shoulders, replaced by a newfound sense of purpose. Their dreams had materialized, and with the support of their boss, they felt an overwhelming sense of determination to excel in their new position."),
                new Dialogue(
                    "As they left Mr. Anderson's office, Alex couldn't contain their excitement. They walked through the office with a newfound confidence, a spring in their step. Co-workers noticed the radiant smile on Tony's face, and whispers of congratulations filled the air."),
                new Dialogue(
                    "Passing by their colleagues, Tony exchanged joyful glances and grateful nods. Their promotion not only symbolized personal growth but also served as a source of inspiration for others. They felt a responsibility to lead by example, to show that hard work and dedication could be rewarded."),
                new Dialogue("It seems like a good ending, but we all know that it is just fiction.")
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