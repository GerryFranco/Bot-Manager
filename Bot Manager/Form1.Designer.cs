namespace Bot_O_Mat_App
{
    partial class BotOMat
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BotOMat));
            this.listViewBots = new System.Windows.Forms.ListView();
            this.botImageList = new System.Windows.Forms.ImageList(this.components);
            this.buttonCreateBot = new System.Windows.Forms.Button();
            this.textBoxBotName = new System.Windows.Forms.TextBox();
            this.radioButtonUnipedal = new System.Windows.Forms.RadioButton();
            this.radioButtonAero = new System.Windows.Forms.RadioButton();
            this.radioButtonRadial = new System.Windows.Forms.RadioButton();
            this.radioButtonArachnid = new System.Windows.Forms.RadioButton();
            this.radioButtonQuadripedal = new System.Windows.Forms.RadioButton();
            this.radioButtonBipedal = new System.Windows.Forms.RadioButton();
            this.labelBotName = new System.Windows.Forms.Label();
            this.buttonDeleteBot = new System.Windows.Forms.Button();
            this.listBoxTaskList = new System.Windows.Forms.ListBox();
            this.assignTaskButton = new System.Windows.Forms.Button();
            this.comboBoxTasks = new System.Windows.Forms.ComboBox();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.panelCreateBot = new System.Windows.Forms.Panel();
            this.labelUnique = new System.Windows.Forms.Label();
            this.labelBotType = new System.Windows.Forms.Label();
            this.panelRadioButtons = new System.Windows.Forms.Panel();
            this.panelAssignTask = new System.Windows.Forms.Panel();
            this.labelNewTask = new System.Windows.Forms.Label();
            this.labelTaskList = new System.Windows.Forms.Label();
            this.panelBotList = new System.Windows.Forms.Panel();
            this.labelBotList = new System.Windows.Forms.Label();
            this.panelMessages = new System.Windows.Forms.Panel();
            this.labelMessages = new System.Windows.Forms.Label();
            this.listBoxMessages = new System.Windows.Forms.ListBox();
            this.panelCreateBot.SuspendLayout();
            this.panelRadioButtons.SuspendLayout();
            this.panelAssignTask.SuspendLayout();
            this.panelBotList.SuspendLayout();
            this.panelMessages.SuspendLayout();
            this.SuspendLayout();
            // 
            // listViewBots
            // 
            this.listViewBots.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listViewBots.HideSelection = false;
            this.listViewBots.Location = new System.Drawing.Point(23, 33);
            this.listViewBots.MultiSelect = false;
            this.listViewBots.Name = "listViewBots";
            this.listViewBots.Size = new System.Drawing.Size(467, 235);
            this.listViewBots.TabIndex = 0;
            this.listViewBots.UseCompatibleStateImageBehavior = false;
            this.listViewBots.SelectedIndexChanged += new System.EventHandler(this.listViewBots_SelectedIndexChanged);
            // 
            // botImageList
            // 
            this.botImageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("botImageList.ImageStream")));
            this.botImageList.TransparentColor = System.Drawing.Color.Transparent;
            this.botImageList.Images.SetKeyName(0, "BotUniped.png");
            this.botImageList.Images.SetKeyName(1, "BotBiped.png");
            this.botImageList.Images.SetKeyName(2, "BotQuad.png");
            this.botImageList.Images.SetKeyName(3, "BotArachnid.png");
            this.botImageList.Images.SetKeyName(4, "BotRadial.png");
            this.botImageList.Images.SetKeyName(5, "BotAero.png");
            // 
            // buttonCreateBot
            // 
            this.buttonCreateBot.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.buttonCreateBot.FlatAppearance.BorderSize = 0;
            this.buttonCreateBot.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCreateBot.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCreateBot.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonCreateBot.Location = new System.Drawing.Point(279, 219);
            this.buttonCreateBot.Name = "buttonCreateBot";
            this.buttonCreateBot.Size = new System.Drawing.Size(131, 31);
            this.buttonCreateBot.TabIndex = 1;
            this.buttonCreateBot.Text = "Connect to Bot";
            this.buttonCreateBot.UseVisualStyleBackColor = false;
            this.buttonCreateBot.Click += new System.EventHandler(this.connectBotButton_Click);
            // 
            // textBoxBotName
            // 
            this.textBoxBotName.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxBotName.ForeColor = System.Drawing.Color.Black;
            this.textBoxBotName.Location = new System.Drawing.Point(101, 18);
            this.textBoxBotName.Name = "textBoxBotName";
            this.textBoxBotName.Size = new System.Drawing.Size(200, 23);
            this.textBoxBotName.TabIndex = 2;
            // 
            // radioButtonUnipedal
            // 
            this.radioButtonUnipedal.AutoSize = true;
            this.radioButtonUnipedal.Location = new System.Drawing.Point(10, 8);
            this.radioButtonUnipedal.Name = "radioButtonUnipedal";
            this.radioButtonUnipedal.Size = new System.Drawing.Size(81, 20);
            this.radioButtonUnipedal.TabIndex = 3;
            this.radioButtonUnipedal.TabStop = true;
            this.radioButtonUnipedal.Text = "Unipedal";
            this.radioButtonUnipedal.UseVisualStyleBackColor = true;
            // 
            // radioButtonAero
            // 
            this.radioButtonAero.AutoSize = true;
            this.radioButtonAero.Location = new System.Drawing.Point(174, 34);
            this.radioButtonAero.Name = "radioButtonAero";
            this.radioButtonAero.Size = new System.Drawing.Size(108, 20);
            this.radioButtonAero.TabIndex = 8;
            this.radioButtonAero.TabStop = true;
            this.radioButtonAero.Text = "Aeronautical";
            this.radioButtonAero.UseVisualStyleBackColor = true;
            // 
            // radioButtonRadial
            // 
            this.radioButtonRadial.AutoSize = true;
            this.radioButtonRadial.Location = new System.Drawing.Point(97, 34);
            this.radioButtonRadial.Name = "radioButtonRadial";
            this.radioButtonRadial.Size = new System.Drawing.Size(64, 20);
            this.radioButtonRadial.TabIndex = 7;
            this.radioButtonRadial.TabStop = true;
            this.radioButtonRadial.Text = "Radial";
            this.radioButtonRadial.UseVisualStyleBackColor = true;
            // 
            // radioButtonArachnid
            // 
            this.radioButtonArachnid.AutoSize = true;
            this.radioButtonArachnid.Location = new System.Drawing.Point(10, 34);
            this.radioButtonArachnid.Name = "radioButtonArachnid";
            this.radioButtonArachnid.Size = new System.Drawing.Size(83, 20);
            this.radioButtonArachnid.TabIndex = 6;
            this.radioButtonArachnid.TabStop = true;
            this.radioButtonArachnid.Text = "Arachnid";
            this.radioButtonArachnid.UseVisualStyleBackColor = true;
            // 
            // radioButtonQuadripedal
            // 
            this.radioButtonQuadripedal.AutoSize = true;
            this.radioButtonQuadripedal.Location = new System.Drawing.Point(174, 8);
            this.radioButtonQuadripedal.Name = "radioButtonQuadripedal";
            this.radioButtonQuadripedal.Size = new System.Drawing.Size(103, 20);
            this.radioButtonQuadripedal.TabIndex = 5;
            this.radioButtonQuadripedal.TabStop = true;
            this.radioButtonQuadripedal.Text = "Quadripedal";
            this.radioButtonQuadripedal.UseVisualStyleBackColor = true;
            // 
            // radioButtonBipedal
            // 
            this.radioButtonBipedal.AutoSize = true;
            this.radioButtonBipedal.Location = new System.Drawing.Point(97, 8);
            this.radioButtonBipedal.Name = "radioButtonBipedal";
            this.radioButtonBipedal.Size = new System.Drawing.Size(72, 20);
            this.radioButtonBipedal.TabIndex = 4;
            this.radioButtonBipedal.TabStop = true;
            this.radioButtonBipedal.Text = "Bipedal";
            this.radioButtonBipedal.UseVisualStyleBackColor = true;
            // 
            // labelBotName
            // 
            this.labelBotName.AutoSize = true;
            this.labelBotName.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBotName.ForeColor = System.Drawing.Color.White;
            this.labelBotName.Location = new System.Drawing.Point(21, 21);
            this.labelBotName.Name = "labelBotName";
            this.labelBotName.Size = new System.Drawing.Size(77, 16);
            this.labelBotName.TabIndex = 5;
            this.labelBotName.Text = "Bot Name:";
            // 
            // buttonDeleteBot
            // 
            this.buttonDeleteBot.BackColor = System.Drawing.Color.Maroon;
            this.buttonDeleteBot.FlatAppearance.BorderSize = 0;
            this.buttonDeleteBot.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDeleteBot.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDeleteBot.ForeColor = System.Drawing.Color.White;
            this.buttonDeleteBot.Location = new System.Drawing.Point(831, 385);
            this.buttonDeleteBot.Name = "buttonDeleteBot";
            this.buttonDeleteBot.Size = new System.Drawing.Size(109, 31);
            this.buttonDeleteBot.TabIndex = 6;
            this.buttonDeleteBot.Text = "Delete Bot";
            this.buttonDeleteBot.UseVisualStyleBackColor = false;
            this.buttonDeleteBot.Click += new System.EventHandler(this.buttonDeleteBot_Click);
            // 
            // listBoxTaskList
            // 
            this.listBoxTaskList.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxTaskList.FormattingEnabled = true;
            this.listBoxTaskList.ItemHeight = 16;
            this.listBoxTaskList.Location = new System.Drawing.Point(23, 36);
            this.listBoxTaskList.Name = "listBoxTaskList";
            this.listBoxTaskList.Size = new System.Drawing.Size(351, 84);
            this.listBoxTaskList.TabIndex = 7;
            // 
            // assignTaskButton
            // 
            this.assignTaskButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.assignTaskButton.FlatAppearance.BorderSize = 0;
            this.assignTaskButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.assignTaskButton.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.assignTaskButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.assignTaskButton.Location = new System.Drawing.Point(302, 445);
            this.assignTaskButton.Name = "assignTaskButton";
            this.assignTaskButton.Size = new System.Drawing.Size(109, 31);
            this.assignTaskButton.TabIndex = 8;
            this.assignTaskButton.Text = "Assign Task";
            this.assignTaskButton.UseVisualStyleBackColor = false;
            this.assignTaskButton.Click += new System.EventHandler(this.assignTaskButton_Click);
            // 
            // comboBoxTasks
            // 
            this.comboBoxTasks.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxTasks.FormattingEnabled = true;
            this.comboBoxTasks.Location = new System.Drawing.Point(193, 131);
            this.comboBoxTasks.Name = "comboBoxTasks";
            this.comboBoxTasks.Size = new System.Drawing.Size(180, 24);
            this.comboBoxTasks.TabIndex = 9;
            // 
            // panelLogo
            // 
            this.panelLogo.BackColor = System.Drawing.Color.Transparent;
            this.panelLogo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelLogo.BackgroundImage")));
            this.panelLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panelLogo.Location = new System.Drawing.Point(264, 1);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(428, 90);
            this.panelLogo.TabIndex = 10;
            // 
            // panelCreateBot
            // 
            this.panelCreateBot.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panelCreateBot.Controls.Add(this.labelUnique);
            this.panelCreateBot.Controls.Add(this.labelBotType);
            this.panelCreateBot.Controls.Add(this.panelRadioButtons);
            this.panelCreateBot.Controls.Add(this.labelBotName);
            this.panelCreateBot.Controls.Add(this.textBoxBotName);
            this.panelCreateBot.Location = new System.Drawing.Point(14, 95);
            this.panelCreateBot.Name = "panelCreateBot";
            this.panelCreateBot.Size = new System.Drawing.Size(398, 124);
            this.panelCreateBot.TabIndex = 11;
            // 
            // labelUnique
            // 
            this.labelUnique.AutoSize = true;
            this.labelUnique.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUnique.ForeColor = System.Drawing.Color.White;
            this.labelUnique.Location = new System.Drawing.Point(20, 104);
            this.labelUnique.Name = "labelUnique";
            this.labelUnique.Size = new System.Drawing.Size(180, 13);
            this.labelUnique.TabIndex = 14;
            this.labelUnique.Text = "*Can only connect to bot once";
            // 
            // labelBotType
            // 
            this.labelBotType.AutoSize = true;
            this.labelBotType.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBotType.ForeColor = System.Drawing.Color.White;
            this.labelBotType.Location = new System.Drawing.Point(22, 51);
            this.labelBotType.Name = "labelBotType";
            this.labelBotType.Size = new System.Drawing.Size(46, 16);
            this.labelBotType.TabIndex = 13;
            this.labelBotType.Text = "Type:";
            // 
            // panelRadioButtons
            // 
            this.panelRadioButtons.Controls.Add(this.radioButtonAero);
            this.panelRadioButtons.Controls.Add(this.radioButtonBipedal);
            this.panelRadioButtons.Controls.Add(this.radioButtonRadial);
            this.panelRadioButtons.Controls.Add(this.radioButtonUnipedal);
            this.panelRadioButtons.Controls.Add(this.radioButtonArachnid);
            this.panelRadioButtons.Controls.Add(this.radioButtonQuadripedal);
            this.panelRadioButtons.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelRadioButtons.ForeColor = System.Drawing.Color.White;
            this.panelRadioButtons.Location = new System.Drawing.Point(91, 43);
            this.panelRadioButtons.Name = "panelRadioButtons";
            this.panelRadioButtons.Size = new System.Drawing.Size(292, 65);
            this.panelRadioButtons.TabIndex = 12;
            // 
            // panelAssignTask
            // 
            this.panelAssignTask.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panelAssignTask.Controls.Add(this.labelNewTask);
            this.panelAssignTask.Controls.Add(this.labelTaskList);
            this.panelAssignTask.Controls.Add(this.listBoxTaskList);
            this.panelAssignTask.Controls.Add(this.comboBoxTasks);
            this.panelAssignTask.Location = new System.Drawing.Point(14, 266);
            this.panelAssignTask.Name = "panelAssignTask";
            this.panelAssignTask.Size = new System.Drawing.Size(398, 179);
            this.panelAssignTask.TabIndex = 14;
            // 
            // labelNewTask
            // 
            this.labelNewTask.AutoSize = true;
            this.labelNewTask.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNewTask.ForeColor = System.Drawing.Color.White;
            this.labelNewTask.Location = new System.Drawing.Point(114, 135);
            this.labelNewTask.Name = "labelNewTask";
            this.labelNewTask.Size = new System.Drawing.Size(76, 16);
            this.labelNewTask.TabIndex = 14;
            this.labelNewTask.Text = "New Task:";
            // 
            // labelTaskList
            // 
            this.labelTaskList.AutoSize = true;
            this.labelTaskList.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTaskList.ForeColor = System.Drawing.Color.White;
            this.labelTaskList.Location = new System.Drawing.Point(21, 15);
            this.labelTaskList.Name = "labelTaskList";
            this.labelTaskList.Size = new System.Drawing.Size(71, 16);
            this.labelTaskList.TabIndex = 14;
            this.labelTaskList.Text = "Task List:";
            // 
            // panelBotList
            // 
            this.panelBotList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panelBotList.Controls.Add(this.labelBotList);
            this.panelBotList.Controls.Add(this.listViewBots);
            this.panelBotList.Location = new System.Drawing.Point(426, 95);
            this.panelBotList.Name = "panelBotList";
            this.panelBotList.Size = new System.Drawing.Size(514, 290);
            this.panelBotList.TabIndex = 15;
            // 
            // labelBotList
            // 
            this.labelBotList.AutoSize = true;
            this.labelBotList.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBotList.ForeColor = System.Drawing.Color.White;
            this.labelBotList.Location = new System.Drawing.Point(20, 12);
            this.labelBotList.Name = "labelBotList";
            this.labelBotList.Size = new System.Drawing.Size(64, 16);
            this.labelBotList.TabIndex = 15;
            this.labelBotList.Text = "Bot List:";
            // 
            // panelMessages
            // 
            this.panelMessages.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panelMessages.Controls.Add(this.labelMessages);
            this.panelMessages.Controls.Add(this.listBoxMessages);
            this.panelMessages.Location = new System.Drawing.Point(430, 429);
            this.panelMessages.Name = "panelMessages";
            this.panelMessages.Size = new System.Drawing.Size(510, 186);
            this.panelMessages.TabIndex = 15;
            // 
            // labelMessages
            // 
            this.labelMessages.AutoSize = true;
            this.labelMessages.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMessages.ForeColor = System.Drawing.Color.White;
            this.labelMessages.Location = new System.Drawing.Point(21, 10);
            this.labelMessages.Name = "labelMessages";
            this.labelMessages.Size = new System.Drawing.Size(105, 16);
            this.labelMessages.TabIndex = 14;
            this.labelMessages.Text = "Bot Messages:";
            // 
            // listBoxMessages
            // 
            this.listBoxMessages.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxMessages.ForeColor = System.Drawing.Color.Green;
            this.listBoxMessages.FormattingEnabled = true;
            this.listBoxMessages.ItemHeight = 16;
            this.listBoxMessages.Location = new System.Drawing.Point(23, 30);
            this.listBoxMessages.Name = "listBoxMessages";
            this.listBoxMessages.Size = new System.Drawing.Size(463, 132);
            this.listBoxMessages.TabIndex = 7;
            // 
            // BotOMat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(954, 631);
            this.Controls.Add(this.panelMessages);
            this.Controls.Add(this.panelBotList);
            this.Controls.Add(this.panelAssignTask);
            this.Controls.Add(this.panelCreateBot);
            this.Controls.Add(this.panelLogo);
            this.Controls.Add(this.buttonCreateBot);
            this.Controls.Add(this.assignTaskButton);
            this.Controls.Add(this.buttonDeleteBot);
            this.MaximumSize = new System.Drawing.Size(970, 670);
            this.MinimumSize = new System.Drawing.Size(970, 670);
            this.Name = "BotOMat";
            this.Text = "Bot Manager by Gerry Franco";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.BotOMat_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelCreateBot.ResumeLayout(false);
            this.panelCreateBot.PerformLayout();
            this.panelRadioButtons.ResumeLayout(false);
            this.panelRadioButtons.PerformLayout();
            this.panelAssignTask.ResumeLayout(false);
            this.panelAssignTask.PerformLayout();
            this.panelBotList.ResumeLayout(false);
            this.panelBotList.PerformLayout();
            this.panelMessages.ResumeLayout(false);
            this.panelMessages.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listViewBots;
        private System.Windows.Forms.ImageList botImageList;
        private System.Windows.Forms.Button buttonCreateBot;
        private System.Windows.Forms.TextBox textBoxBotName;
        private System.Windows.Forms.RadioButton radioButtonUnipedal;
        private System.Windows.Forms.RadioButton radioButtonAero;
        private System.Windows.Forms.RadioButton radioButtonRadial;
        private System.Windows.Forms.RadioButton radioButtonArachnid;
        private System.Windows.Forms.RadioButton radioButtonQuadripedal;
        private System.Windows.Forms.RadioButton radioButtonBipedal;
        private System.Windows.Forms.Label labelBotName;
        private System.Windows.Forms.Button buttonDeleteBot;
        private System.Windows.Forms.ListBox listBoxTaskList;
        private System.Windows.Forms.Button assignTaskButton;
        private System.Windows.Forms.ComboBox comboBoxTasks;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Panel panelCreateBot;
        private System.Windows.Forms.Label labelBotType;
        private System.Windows.Forms.Panel panelRadioButtons;
        private System.Windows.Forms.Panel panelAssignTask;
        private System.Windows.Forms.Label labelTaskList;
        private System.Windows.Forms.Label labelNewTask;
        private System.Windows.Forms.Panel panelBotList;
        private System.Windows.Forms.Label labelBotList;
        private System.Windows.Forms.Panel panelMessages;
        private System.Windows.Forms.Label labelMessages;
        private System.Windows.Forms.ListBox listBoxMessages;
        private System.Windows.Forms.Label labelUnique;
    }
}

