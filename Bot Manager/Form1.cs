using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bot_O_Mat_App
{
    public partial class BotOMat : Form
    {
        #region VARIABLES

        Bots.InterfaceFactory iFactory; //Bots library factory
        Bots.Interfaces.IBotManager iBotManager; //Bot manager interface
        List<Bots.Interfaces.IBot> botList; //list of bot interfaces

        #endregion


        #region FORM

        //MAIN
        public BotOMat()
        {
            InitializeComponent();

            //create Bots factory and manager instances
            iFactory = new Bots.InterfaceFactory();
            iBotManager = iFactory.CreateIBotManager();
        }


        //FORM LOAD
        private void Form1_Load(object sender, EventArgs e)
        {
            //set unipedal option as default
            radioButtonUnipedal.Checked = true;

            //get the bot list
            botList = iBotManager.GetBotList();

            //subscribe
            for(int i = 0; i < botList.Count; i++)
            {
                botList[i].TaskUpdate += TaskUpdateHandler;
            }

            //init list view
            listViewBots.View = View.LargeIcon;
            listViewBots.LargeImageList = botImageList;

            //refresh list view
            RefreshListView();

            //populate tasks combo box
            Array tasks = Enum.GetValues(typeof(Bots.Interfaces.BotTask));
            foreach (Bots.Interfaces.BotTask task in tasks)
            {
                comboBoxTasks.Items.Add(task);
            }
        }


        //FORM CLOSING
        private void BotOMat_FormClosing(object sender, FormClosingEventArgs e)
        {
            //ensure persistance of bot list and settings
            iBotManager.SaveBotList();
        }

        #endregion


        #region CONNECT TO BOT

        //CONNECT TO BOT
        private void connectBotButton_Click(object sender, EventArgs e)
        {
            //verify valid bot name
            if (String.IsNullOrEmpty(textBoxBotName.Text))
            {
                return;
            }

            //determine bot type
            Bots.Interfaces.BotType botType = Bots.Interfaces.BotType.Unipedal;
            if (radioButtonUnipedal.Checked)
            {
                botType = Bots.Interfaces.BotType.Unipedal;
            }
            else if (radioButtonBipedal.Checked)
            {
                botType = Bots.Interfaces.BotType.Bipedal;
            }
            else if (radioButtonQuadripedal.Checked)
            {
                botType = Bots.Interfaces.BotType.Quadripedal;
            }
            else if (radioButtonArachnid.Checked)
            {
                botType = Bots.Interfaces.BotType.Arachnid;
            }
            else if (radioButtonRadial.Checked)
            {
                botType = Bots.Interfaces.BotType.Radial;
            }
            else if (radioButtonAero.Checked)
            {
                botType = Bots.Interfaces.BotType.Aeronautical;
            }

            //obtain interface to bot 
            Bots.Interfaces.IBot bot = iBotManager.ConnectToBot(textBoxBotName.Text, botType);
            if (iBotManager.AddBotToList(bot))
            {
                //refresh the bot list view
                RefreshListView();

                //set created bot as selected
                int connectedBotIndex = botList.IndexOf(botList.Last());
                listViewBots.Items[connectedBotIndex].Selected = true;

                //assign 5 random tasks to bot
                Array values = Enum.GetValues(typeof(Bots.Interfaces.BotTask));
                Random random = new Random();

                for (int i = 0; i < 5; i++)
                {
                    Bots.Interfaces.BotTask randomTask = (Bots.Interfaces.BotTask)values.GetValue(random.Next(values.Length));
                    bot.AssignTask(randomTask);
                }

                //refresh or update the task list
                RefreshTaskListControls(bot);

                //clear the bot name textbox 
                textBoxBotName.Clear();

                //subscribe to task event
                bot.TaskUpdate += TaskUpdateHandler;
            }
            else
            {
                //show message?
            } 
        }

        #endregion


        #region TASK LIST

        //REFRESHTASKLISTCONTROLSFROMEVENTHANDLER
        private void RefreshTaskListControlsFromEventHandler()
        {
            //verify a bot is selected before assigning a task to it
            ListView.SelectedIndexCollection index = listViewBots.SelectedIndices;

            Invoke((Action)(() => {
                if (index.Count <= 0)
                {
                    return;
                }

                //update the task list controls
                RefreshTaskListControls(botList[index[0]]);
            })); 
        }

        //REFRESHTASKLISTCONTROLS
        private void RefreshTaskListControls(Bots.Interfaces.IBot bot)
        {
            //clear the task list control
            listBoxTaskList.Items.Clear();

            //get latest bot tasks and add them to the task list control
            Queue<Bots.Interfaces.BotTask> botQueue = bot.GetTasks();
            foreach (Bots.Interfaces.BotTask task in botQueue)
            {
                listBoxTaskList.Items.Add(task);
            }

            //clear any selection from combo box for new task
            comboBoxTasks.SelectedIndex = -1;

            //set the active bot label
            labelTaskList.Text = bot.Name + "'s " + "Task List:";
        }

        //ASSIGNTASK
        private void assignTaskButton_Click(object sender, EventArgs e)
        {
            //verify a bot is selected before assigning a task to it
            ListView.SelectedIndexCollection index = listViewBots.SelectedIndices;
            if (index.Count <= 0)
            {
                return;
            }

            //assign the task
            if(comboBoxTasks.SelectedItem != null)
            {
                botList[index[0]].AssignTask((Bots.Interfaces.BotTask)comboBoxTasks.SelectedItem);

                //update the task list controls
                RefreshTaskListControls(botList[index[0]]);
            }
        }

        #endregion


        #region BOT LIST VIEW

        //REFRESHLISTVIEW
        private void RefreshListView()
        {
            //clear the list view
            listViewBots.Clear();

            //get the bot list
            botList = iBotManager.GetBotList();

            //populate the list view with bots in the list
            for (int i = 0; i < botList.Count; i++)
            {
                ListViewItem item = new ListViewItem();
                item.Text = botList[i].Name;

                if (botList[i].Type == Bots.Interfaces.BotType.Unipedal)
                {
                    item.ImageIndex = 0;
                }
                else if (botList[i].Type == Bots.Interfaces.BotType.Bipedal)
                {
                    item.ImageIndex = 1;
                }
                else if (botList[i].Type == Bots.Interfaces.BotType.Quadripedal)
                {
                    item.ImageIndex = 2;
                }
                else if (botList[i].Type == Bots.Interfaces.BotType.Arachnid)
                {
                    item.ImageIndex = 3;
                }
                else if (botList[i].Type == Bots.Interfaces.BotType.Radial)
                {
                    item.ImageIndex = 4;
                }
                else if (botList[i].Type == Bots.Interfaces.BotType.Aeronautical)
                {
                    item.ImageIndex = 5;
                }

                listViewBots.Items.Add(item);
            }
        }

        //LISTVIEWSELECTEDINDEXCHANGED
        private void listViewBots_SelectedIndexChanged(object sender, EventArgs e)
        {
            //update task list when bot selected changes
            ListView.SelectedIndexCollection index = listViewBots.SelectedIndices;
            if (index.Count <= 0)
            {
                return;
            }

            RefreshTaskListControls(botList[index[0]]);
        }

        #endregion


        #region DELETE BOT

        //DELETEBOT
        private void buttonDeleteBot_Click(object sender, EventArgs e)
        {
            //only deleted if bot is selected
            if (listViewBots.SelectedItems.Count <= 0)
            {
                return;
            }

            //delete bot from list
            ListView.SelectedIndexCollection index = listViewBots.SelectedIndices;
            if (iBotManager.DeleteBotFromList(botList[index[0]]))
            {

            }
            else
            {

            }

            //update the list view
            RefreshListView();

            //clear the task list
            listBoxTaskList.Items.Clear();
        }

        #endregion


        #region MESSAGES

        //ADDMESSAGE 
        private void AddMessage(string botNameArg, Bots.Interfaces.BotType typeArg, 
            Bots.Interfaces.BotTask taskArg, Bots.Interfaces.BotTaskStatus taskStatusArg)
        {
            DateTime time = DateTime.Now;
            string message = time.Hour + ":" + time.Minute + ":" + time.Second + " - " + botNameArg + ", " + typeArg + ": " + taskArg + taskStatusArg;
            Invoke((Action)(() => { listBoxMessages.Items.Add(message); }));        
        }

        #endregion


        #region TASK EVENT HANDLER

        //TASKUPDATEHANDLER
        private void TaskUpdateHandler(object sender, Bots.Interfaces.BotTaskUpdateEventArgs args)
        {
            AddMessage(args.Name, args.Type, args.Task, args.TaskStatus);
            RefreshTaskListControlsFromEventHandler();
        }

        #endregion
    }



}
