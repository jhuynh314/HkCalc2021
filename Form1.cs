using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace HK_Calc_2021
{
    public partial class Form1 : Form
    {
        List<Dice> dices = new List<Dice>();
        List<Mission> missions = new List<Mission>();

        public Form1()
        {
            InitializeComponent();
        }

        private void createDieButton_Click(object sender, EventArgs e)
        {
            int value = int.Parse(dieValueTextBox.Text);
            guildName guild;
            if (noneRadioButton.Checked)
            {
                guild = guildName.none;
            }
            else if (rangerRadioButton.Checked)
            {
                guild = guildName.ranger;
            }
            else if (mageRadioButton.Checked)
            {
                guild = guildName.mage;
            }
            else
            {
                guild = guildName.knight;
            }

            dices.Add(new Dice(guild, value));

            updateDice();
        }

        private void updateDice()
        {
            currentDiceLabel.Text = "";
            for (int i = 0; i < dices.Count; i++)
            {
                string guild = "";
                if (dices[i].getGuild() == guildName.none)
                {
                    guild = "N";
                }
                else if (dices[i].getGuild() == guildName.ranger)
                {
                    guild = "R";
                }
                else if (dices[i].getGuild() == guildName.mage)
                {
                    guild = "M";
                }
                else
                {
                    guild = "K";
                }
                currentDiceLabel.Text += dices[i].getDieValue().ToString() + guild + "   ";
            }
        }

        private void clearDiceButton_Click(object sender, EventArgs e)
        {
            dices.Clear();
            updateDice();
        }

        private void addRequirementButton_Click(object sender, EventArgs e)
        {
            List<int> list = new List<int>();
            if (checkBox1.Checked) list.Add(1);
            if (checkBox2.Checked) list.Add(2);
            if (checkBox3.Checked) list.Add(3);
            if (checkBox4.Checked) list.Add(4);
            if (checkBox5.Checked) list.Add(5);
            if (checkBox6.Checked) list.Add(6);

            guildName guild;
            if (nRadioButton.Checked) guild = guildName.none;
            else if (rRadioButton.Checked) guild = guildName.ranger;
            else if (mRadioButton.Checked) guild = guildName.mage;
            else guild = guildName.knight;

            missions.Add(new Mission(list, guild));
            updateMission();
        }

        private void updateMission()
        {
            currentMissionLabel.Text = "";
            for (int i = 0; i < missions.Count; i++)
            {
                string guild = "";
                if (missions[i].getGuild() == guildName.none)
                {
                    guild = "N";
                }
                else if (missions[i].getGuild() == guildName.ranger)
                {
                    guild = "R";
                }
                else if (missions[i].getGuild() == guildName.mage)
                {
                    guild = "M";
                }
                else
                {
                    guild = "K";
                }
                currentMissionLabel.Text += missions[i].getValues() + guild + "   ";
            }
        }

        private void clearMissionButton_Click(object sender, EventArgs e)
        {
            missions.Clear();
            updateMission();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            double total = double.Parse(trialsTextBox.Text);
            double successes = 0.0;
            double probability = 0.0;
            bool completed;

            //for each trial
            for(int t=0; t<total; t++)
            {
                //reset mission
                for(int m = 0; m <missions.Count; m++)
                {
                    missions[m].unsetCompleted();
                }

                //for each die
                for(int d=0; d< dices.Count; d++)
                {
                    int roll = dices[d].roll();
                    guildName guild = dices[d].getGuild();

                    //check each mission
                    for (int m = 0; m < missions.Count; m++)
                    {
                        //make sure it hasnt already been completed
                        if (!missions[m].getCompleted())
                        {
                            //check to see if current roll meets that requirement and if it does skip the rest of the missions
                            if (missions[m].checkValue(roll, guild))
                            {
                                missions[m].setCompleted();
                                m = missions.Count;
                            }
                        }
                    }
                }

                //check if all mission requirements are met
                completed = true;
                for(int m = 0; m < missions.Count; m++)
                {
                    if (!missions[m].getCompleted())
                    {
                        completed = false;
                        m = missions.Count;
                    }
                }

                //when the mission is completed
                if (completed)
                {
                    successes += 1;
                }
            }

            //after all trials
            successesLabel.Text = successes.ToString();
            probability = successes / total;
            probabilityLabel.Text = probability.ToString();
        }
    }

}
