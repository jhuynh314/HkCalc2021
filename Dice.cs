using System;

namespace HK_Calc_2021
{

    class Dice
    {
        private guildName guild;
        private int dieValue;
        private bool used = false;
        Random rnd = new Random();

        public Dice(guildName name, int value)
        {
            guild = name;
            dieValue = value;
        }

        public guildName getGuild()
        {
            return guild;
        }

        public int getDieValue()
        {
            return dieValue;
        }

        public void setUsed()
        {
            used = true;
        }

        public void unsetUsed()
        {
            used = false;
        }

        public int roll()
        {
            return rnd.Next(1, dieValue + 1);
        }
    }
}
