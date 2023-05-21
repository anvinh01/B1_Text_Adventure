using System.Collections.Generic;

namespace States
{
    public class CoffeeRoom : State
    {
        private StateManager _stateManager;

        public CoffeeRoom(StateManager stateManager)
        {
            _stateManager = stateManager;
        }

        public void init()
        {
            _stateManager.dialogue = new List<Dialogue>()
            {
                new Dialogue("Hey, guys! Mind if I join you for a quick coffee break?", "Tony"),
                new Dialogue(
                    "Not at all, Tony! Grab a seat. We were just discussing the latest updates on the web development project.",
                    "Albert"),
                new Dialogue(
                    "Yeah, we've been making some good progress, but there are a few challenges we need to address.",
                    "Barney"),
                new Dialogue(
                    "Excellent! I've been looking forward to catching up on our project. What's been going on?",
                    "Tony"),
                new Dialogue(
                    "Well, we've successfully implemented the new user authentication system. It's working smoothly, and the feedback from the client has been positive.",
                    "Albert"),
                new Dialogue(
                    "That's true, but we've encountered a slight setback with the database integration. It's causing some issues with data retrieval and processing.",
                    "Barney"),
                new Dialogue(
                    "Hmm, sounds like we need to dive deeper into the problem. Have we identified the root cause yet",
                    "Tony"),
                new Dialogue(
                    "We suspect it might be a compatibility issue between the database software and our web framework. We've started investigating, but it's taking longer than expected to pinpoint the exact problem.",
                    "Albert"),
                new Dialogue(
                    "Yeah, we've been going through logs, conducting tests, and trying different configurations, but so far, no luck. It's been a bit frustrating.",
                    "Barney"),
                new Dialogue(
                    "I understand the frustration, but don't worry, guys. We'll figure it out together. Let's take a systematic approach and break it down step by step. Have we considered reaching out to the framework's support community or consulting any relevant documentation?",
                    "Tony"),
                new Dialogue(
                    "We've explored the online forums, and some developers have faced similar issues. We've gathered a few potential solutions to try, but we haven't had a chance to implement them yet",
                    "Albert"),
                new Dialogue(
                    "I think it's worth giving those solutions a shot. It might just be the missing piece to solve our problem",
                    "Barney"),
                new Dialogue(
                    "Agreed. Let's schedule a team meeting tomorrow morning to discuss our findings and plan the next steps. We can brainstorm together and collaborate on possible solutions. I believe that with our combined expertise, we can overcome this hurdle.",
                    "Tony"),
                new Dialogue(
                    "That's a great idea, Tony. We definitely need to regroup and align our efforts. It'll give us a fresh perspective and the opportunity to pool our knowledge and skills.",
                    "Albert"),
                new Dialogue(
                    "Absolutely. Working as a team always yields better results. I appreciate your positive attitude, Tony. It motivates us to keep pushing forward.",
                    "Barney"),
                new Dialogue(
                    "Thanks, guys. We're in this together, and I have complete faith in our abilities. We've overcome challenges before, and we'll do it again. Let's finish our coffee and get back to work with renewed determination.",
                    "Tony"),
                new Dialogue(
                    "Cheers to that, Tony! Let's tackle this issue head-on and deliver an exceptional web development project.",
                    "Albert"),
                new Dialogue("I couldn't agree more. Here's to teamwork and successful problem-solving.", "Barney"),
            };
            _stateManager.button1.text = "Go back to work.";
            _stateManager.button2.text = "";
            _stateManager.button3.text = "";
        }

        public void button1()
        {
            _stateManager.nextState = _stateManager.myWorkPC;
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