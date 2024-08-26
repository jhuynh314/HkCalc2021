using System.Collections.Generic;

namespace HK_Calc_2021
{
    class Mission
    {
        private List<int> values;
        private bool completed = false;
        private guildName guild;

        public Mission(List<int> list, guildName guil)
        {
            values = list;
            guild = guil;
        }

        public guildName getGuild()
        {
            return guild;
        }

        public bool checkValue(int val, guildName guil)
        {
            for (int i = 0; i < values.Count; i++)
            {
                if (values[i] == val && guild == guildName.none)
                {
                    return true;
                }
                if (values[i] == val && guild == guil)
                {
                    return true;
                }
            }
            return false;
        }

        public string getValues()
        {
            string vals = "";
            for (int i = 0; i < values.Count; i++)
            {
                vals += values[i].ToString();
            }
            return vals;
        }

        public void setCompleted()
        {
            completed = true;
        }

        public void unsetCompleted()
        {
            completed = false;
        }

        public bool getCompleted()
        {
            return completed;
        }
    }
}
