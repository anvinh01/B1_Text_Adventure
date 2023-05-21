using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace States
{
    public class OnTheStreet : State
    {
        private readonly StateManager _stateManager;
        private readonly AudioClip _streetNormalMusic;
        private readonly AudioClip _runMusic;
        private readonly AudioClip _saveChild;
        private readonly AudioClip _despair;
        private readonly AudioClip _late;

        private Image _streetImage;
        public OnTheStreet(StateManager stateManager)
        {
            _stateManager = stateManager;
            _streetNormalMusic = Resources.Load<AudioClip>("Audio/Le-Festin");
            _runMusic = Resources.Load<AudioClip>("Audio/Magical");
            _saveChild = Resources.Load<AudioClip>("Audio/Walpurgisnacht");
            _despair = Resources.Load<AudioClip>("Audio/Absolute Despair");
            _late = Resources.Load<AudioClip>("Audio/Snow-White");
            _streetImage = Resources.Load<Image> ("Images/hotel-entrance-lighting");
        }
        

        public void init()
        {
            _stateManager.dialogue = new List<Dialogue>()
            {
                new Dialogue(
                    "Walking briskly along the familiar city streets on my way to work, the monotony of my daily routine threatens to consume me", audio:_streetNormalMusic, image:_streetImage),
                new Dialogue(
                    "As I pass by the same storefronts and landmarks I've grown accustomed to, a sense of complacency settles in. Is this the path I'm meant to take?"),
                new Dialogue("Are these the streets that will define my existence? The humdrum of routine whispers doubts into my mind, questioning if I'm truly living up to my potential."),
                new Dialogue(
                    "The city swirls around me, a blur of faces and hurried footsteps. Each passerby seems to be on a mission, consumed by their own goals and aspirations."),
                new Dialogue("And amidst this sea of strangers, I wonder, do any of them feel the same existential tug I do? Are they chasing dreams or just going through the motions?"),
                new Dialogue(
                    "The cacophony of car horns and distant sirens becomes the backdrop to my internal dialogue. I find solace in this symphony of urban chaos, for within it lies the reminder that life is in constant motion. The city breathes, evolves, and invites me to do the same."),
                new Dialogue(
                    "Amidst the noise, I catch fragments of conversations drifting through the air—snippets of dreams, worries, and aspirations."),
                new Dialogue("They serve as a reminder that each person has their own narrative, their own battles fought silently beneath the surface. It's a humbling thought that we are all navigating our own inner worlds while existing in this shared space."),
                new Dialogue("Why am I having such deep thoughts? Am I High???", "Tony"),
                new Dialogue("Whatever ...", "Tony"),
            };

            if (_stateManager.sleepTime >= 10)
            {
                _stateManager.dialogue = _stateManager.sleepTime == 20
                    ? new List<Dialogue>()
                    {
                        new Dialogue(
                            $"'Shit! The street is too busy!\n I am already {_stateManager.sleepTime} minutes to late'",
                            "Me", _runMusic),
                        new Dialogue(
                            "Hurriedly rushing through the city streets, my heart pounds in my chest, mirroring the rapid pace of my footsteps. Anxiety gnaws at my insides as I realize I am running late for work. Time slips through my fingers, and a wave of frustration crashes over me."),
                        new Dialogue(
                            "The weight of responsibility bears down on my shoulders, and a mix of guilt and panic consumes my thoughts."),
                        new Dialogue(
                            "As I weave through the crowded sidewalks, dodging pedestrians and street vendors, I can't help but feel a sense of regret for not leaving earlier."),
                        new Dialogue("Why did I hit the snooze button? Why did I let procrastination get the best of me? These self-recriminations echo in my mind, creating a cacophony of self-doubt"),
                        new Dialogue(
                            "Time slows down as my eyes lock onto the terrifying scene unfolding before me—a child darting out into the busy street, oblivious to the oncoming Truck. Adrenaline surges through my veins, and instincts kick into overdrive."),
                    }
                    : new List<Dialogue>()
                    {
                        new Dialogue(
                            $"'Shit! The street is too busy!\n I am already {_stateManager.sleepTime} minutes to late'",
                            "Me", _late),
                        new Dialogue(
                            "Hurriedly rushing through the city streets, my heart pounds in my chest, mirroring the rapid pace of my footsteps. Anxiety gnaws at my insides as I realize I am running late for work. Time slips through my fingers, and a wave of frustration crashes over me."),
                        new Dialogue(
                            "The weight of responsibility bears down on my shoulders, and a mix of guilt and panic consumes my thoughts."),
                    };
            }

            _stateManager.button1.text = _stateManager.sleepTime != 20 ? "Keep the current pace" : "";
            _stateManager.button2.text = _stateManager.sleepTime == 20 ? "Keep Running!!" : "Run to the office building";
            _stateManager.button3.text = _stateManager.sleepTime == 20 ? "Save Child" : "";
        }

        public void button1()
        {
            _stateManager.nextState = _stateManager.work;
            _stateManager.dialogue = new List<Dialogue>()
            {
                new Dialogue(
                    "As I approach my workplace, the weight of responsibility bears down on me. The expectations and demands of my job hang like a cloud above my head. But in the midst of the anxiety, I remember the purpose that brought me here. The opportunity to contribute, to make a difference, to find fulfillment in my work."),
                new Dialogue(
                    "I look up at the towering buildings that surround me, marveling at the feats of human ingenuity and collaboration."),
                new Dialogue("It's a testament to what we can achieve when we come together, when we apply our skills and passions towards a common goal. I remind myself that my work, no matter how seemingly small, plays a part in this grand tapestry."),
                new Dialogue(
                    "As I step into the office, my inner monologue quiets down, temporarily subdued by the demands of the day. But I carry with me the awareness that the city holds infinite stories and possibilities."),
            };
            _stateManager.isTransitioning = true;
        }

        public void button2()
        {
            if (_stateManager.sleepTime > 20)
            {
                // Running because I am late
                _stateManager.nextState = _stateManager.work;
                _stateManager.dialogue = new List<Dialogue>()
                {
                    new Dialogue(
                        "As I weave through the crowded sidewalks, dodging pedestrians and street vendors, I can't help but feel a sense of regret for not leaving earlier. Why did I hit the snooze button? Why did I let procrastination get the best of me? These self-recriminations echo in my mind, creating a cacophony of self-doubt"),
                    new Dialogue(
                        "The city whirls around me, an unforgiving backdrop to my tardiness. People pass by with purpose, oblivious to my personal race against time. Their effortless strides and composed expressions amplify my feelings of inadequacy. I can't help but compare myself to the punctual individuals who seem to have it all figured out."),
                    new Dialogue(
                        "But amid the chaos and self-blame, a spark of determination ignites within me. I refuse to succumb to defeat. I gather my scattered thoughts, focusing on the steps I can take to minimize the impact of my lateness."),
                    new Dialogue(
                        "As I finally reach my workplace, breathless and flushed, I take a moment to compose myself before entering. I steel my nerves and put on a confident facade, determined to make the most of the time that remains."),
                    new Dialogue(
                        " remind myself that setbacks happen, but it's how I handle them that truly matters."),
                    new Dialogue("Now Go in and be yourself!!", "Me")
                };
            }
            else if (_stateManager.sleepTime <= 15)
            {
                _stateManager.nextState = _stateManager.work;
                _stateManager.dialogue = new List<Dialogue>()
                {
                    new Dialogue(
                        "Today, I've made a decision—a decision to break free from the chains of rushing and embrace the gift of time."),
                    new Dialogue(
                        "Today, I choose to embrace the opportunity to arrive early, to savor the moments that lead up to the start of the workday."),
                    new Dialogue(
                        "The usual cacophony of honking horns and hurried footsteps surrounds me, but I choose not to be swept away by the frenetic energy. Instead, I find solace in the rhythmic cadence of my own footsteps, the steady beat that propels me forward. Each step becomes a deliberate act of intention, a declaration that today will be different."),
                    new Dialogue(
                        "As I approach the office building, a surge of pride swells within me. I glance at my watch, only to realize that I have arrived early, much earlier than I had anticipated. A smile tugs at the corners of my lips, a testament to the power of intention and the fulfillment that comes from breaking free from the confines of rushing."),
                };
            }
            else
            {
                _stateManager.nextState = _stateManager.work;
                _stateManager.dialogue = new List<Dialogue>()
                {
                    new Dialogue(
                        "Amidst the chaos, a child's laughter momentarily pierces through the noise, capturing my attention. I glance in their direction, their innocence and joy a stark contrast to the hurried pace of the city.", audio:_despair),
                    new Dialogue(" For an instant, a flicker of concern ignites within me, but it is quickly extinguished by the demands of my own urgency."),
                    new Dialogue(
                        "My footsteps quicken, my mind consumed with the tasks and responsibilities awaiting me at work. The child fades into the periphery, just another element of the bustling urban landscape. It pains me to admit it, but in this moment, my own goals and pressures take precedence over the well-being of another."),
                    new Dialogue(
                        "As I rush forward, the screeching of tires and the sudden eruption of commotion cut through the air like a knife."),
                    new Dialogue("I turn my head, my heart momentarily seizing in my chest as I witness the unthinkable—a traffic accident involving the child I had briefly noticed. The world slows to a standstill, and I am confronted with a decision, a choice that bears the weight of consequence."),
                    new Dialogue(
                        "Conflicting emotions surge within me—guilt, regret, and a profound sense of responsibility. How could I have allowed myself to be so self-absorbed? My mind races, grappling with the ethical dilemma of whether to intervene or continue my mad dash to work, my inner turmoil a whirlwind of regret and indecision."),
                    new Dialogue(
                        "As I continue my journey to work, a newfound perspective accompanies me. The child's face, etched with fear and vulnerability, serves as a constant reminder of the responsibility we all share to look out for one another."), 
                    new Dialogue("No deadline or obligation is worth sacrificing our humanity. From this moment forward, I am determined to be more present, to extend a helping hand when it is needed, and to never let the urgent overshadow the importance of compassion."),
                    new Dialogue(
                        "I have come to realize, that my human side has come to perish, as I put my own foolish goal over the the life of a child, that has yet to come to bloom in it's full self."),
                    new Dialogue(
                        "The lesson has been learned, on the cost of an innocent soul. I cannot dare to ask for forgiveness, but to turn my head towards the future and lend my hand to those in need at all times."),
                    new Dialogue("As I approach the office building, I hope to collect my mind.")
                };
            }

            _stateManager.isTransitioning = true;
        }

        public void button3()
        {
            _stateManager.dialogue = new List<Dialogue>()
            {
                new Dialogue(
                    "In that split second, a surge of adrenaline propels me forward, my body moving with a speed and determination I didn't know I possessed. Thoughts of the child's safety flood my mind, drowning out any self-doubt or concern for my own well-being.", "narrator", _saveChild),
                new Dialogue(
                    "As I reach the child, I see the fear in their eyes, their innocence contrasted against the impending threat of the oncoming car. Every fiber of my being is focused on one goal: to snatch them out of harm's way. The weight of responsibility feels both daunting and empowering."),
                new Dialogue(
                    "As I grasp their small hand, my senses heighten. Every detail of the chaotic scene is imprinted in my mind—the smell of burnt rubber, the cacophony of panic-stricken voices, the rush of wind against my face. It's a symphony of chaos and heroism, of fear and courage."),
                new Dialogue(
                    "My muscles strain as I pull the child back towards safety, their weight becoming a symbol of the immense responsibility we hold for one another. I can feel my heart pounding, matching the rhythm of their racing heartbeat."),
                new Dialogue("In this moment, there is no room for doubt or hesitation. The instinct to protect overrides any personal fears or limitations"),
                new Dialogue(
                    "As the truck thunders past, the force of its passing sends a gust of wind that tousles our hair and leaves us momentarily breathless. The rush of relief floods over me, a surge of gratitude for the child's safety."),
                new Dialogue("A mix of awe, disbelief, and a profound sense of purpose washes over me, reminding me of the power of our actions in the face of adversity"),
                new Dialogue(
                    "With trembling hands and a racing heart, I release my grip on the child, watching as they stumble backward, disoriented but unharmed. Their tear-filled eyes meet mine, a wordless exchange of gratitude and understanding that transcends language"),
                new Dialogue(
                    "A tire, seemingly detached from its vehicle, careens towards me with frightening speed. Time slows to a crawl, and in that suspended moment, my mind races to comprehend the imminent danger before me."),
                new Dialogue("Panic surges through my veins, adrenaline courses through my body, and every instinct within me screams for self-preservation."),
                new Dialogue("BLACK"),
            };
            _stateManager.isTransitioning = true;
            _stateManager.nextState = _stateManager.heaven;
        }
    }
}