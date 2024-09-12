using System;
using UnityEngine;
using UnityEngine.TextCore.Text;

public abstract class Entity : MonoBehaviour {

    public Classification classification;

    /*
    * Possible attributes for Entities

    Physical Attributes
    Strength: Physical power and muscle mass.
    Agility: Speed and coordination.
    Stamina: Endurance and energy.
    Health: Overall well-being and vitality.
    Appearance: Physical look including height, weight, and distinguishing features.


    Mental Attributes
    Intelligence: Cognitive ability and problem-solving skills.
    Wisdom: Experience and judgment.
    Willpower: Mental resilience and determination.
    Perception: Awareness of surroundings.
    Memory: Ability to recall information.
    Emotional Attributes
    Empathy: Ability to understand and share feelings of others.
    Courage: Ability to face fear or danger.
    Temperament: General mood or disposition.
    Fear: Responses to perceived threats.
    Joy: Capacity for happiness and contentment.


    Social Attributes
    Charisma: Charm and influence over others.
    Reputation: Social standing and the opinions of others.
    Relationships: Connections with others, such as family, friends, and rivals.
    Leadership: Ability to guide or influence a group.
    Loyalty: Commitment to others.


    Possessions
    Clothing: Apparel and accessories.
    Weapons: Tools for defense or offense.
    Tools: Equipment for performing tasks.
    Money: Currency or wealth.
    Artifacts: Special or magical items.
    Food/Water: Basic sustenance.
    Housing: Shelter or a place to live.


    Skills
    Combat: Proficiency in fighting techniques.
    Crafting: Ability to create or repair items.
    Stealth: Ability to move undetected.
    Survival: Skills necessary to sustain life in harsh conditions.
    Magic: Proficiency in using mystical forces (if applicable).


    Status Effects
    Injuries: Wounds or physical trauma.
    Fatigue: Tiredness from exertion.
    Poison: Effects from toxic substances.
    Blessings/Curses: Positive or negative supernatural effects.
    Mood: Current emotional state that affects behavior.


    Identity
    Name: Personal or given name.
    Birthplace: Origin or hometown.
    Background: History and upbringing.
    Occupation: Job or role in society.
    Beliefs: Religious or philosophical outlook.
    */

    [System.Serializable]
    public enum Classification {
        Character,
        Item,
        Object,
    }

    private void Update() {

    }


}