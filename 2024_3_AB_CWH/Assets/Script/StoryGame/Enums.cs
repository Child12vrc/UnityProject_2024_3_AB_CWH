using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace STORYGAME
{
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
            GoToBattle = 100,
            CheckSTR = 1000,
            CheckDEX,
            CheckCON,
            CheckINT,
            CheckWIS,
            CheckCHA
        }

        public enum ResultType
        {
            ChangeHP,
            ChangeSp,
            AddExperience,
            GoToShop,
            GoToNextStory,
            GoToRandomStory,
            GoToEnding
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
}
