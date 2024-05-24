using System.Collections;
using System.Collections.Generic;
using UnityEngine;


    public class Enums
    {
        public enum StoryType
        {
            MAIN,
            SUB,
            SERIAL
        }

        public enum EvenType
        {
            NONE,
            GOTOBATTLE = 100,
            CheckSTR = 1000,
        }

        public enum ResultType
        {

            AddExperience,
            GoToNextStory,
            GoToRandomStory
        }
    }

    [System.Serializable]
    public class Stats
    {
        public int hpPoint;
        public int spPoint;

        public int currentHpPoint;
        public int currentSpPoint;
        public int currentXpPoint;

        public int strength;        //STP
        public int dexterity;       //DEX
        public int consitiution;    //CON
        public int Intelligence;    //INT
        public int wisdom;          //WIS
        public int charisma;        //CHA
    }
