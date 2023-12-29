namespace Rally
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.canvas = new System.Windows.Forms.Panel();
            this.panelScores = new System.Windows.Forms.Panel();
            this.listBox = new System.Windows.Forms.ListBox();
            this.buttonBack = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.status = new System.Windows.Forms.Label();
            this.buttonStart = new System.Windows.Forms.Button();
            this.score = new System.Windows.Forms.Label();
            this.helpText = new System.Windows.Forms.Label();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.panelSingle = new System.Windows.Forms.Panel();
            this.panelSingleGui = new System.Windows.Forms.Panel();
            this.panelButtonStart = new System.Windows.Forms.Panel();
            this.panelButtonStartLeft = new System.Windows.Forms.Panel();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.buttonExit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonRecords = new System.Windows.Forms.Button();
            this.buttonSGame = new System.Windows.Forms.Button();
            this.buttonOnline = new System.Windows.Forms.Button();
            this.panelInputNick = new System.Windows.Forms.Panel();
            this.textBoxNick = new System.Windows.Forms.TextBox();
            this.buttonSend = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.canvas.SuspendLayout();
            this.panelScores.SuspendLayout();
            this.panelSingle.SuspendLayout();
            this.panelSingleGui.SuspendLayout();
            this.panelButtonStart.SuspendLayout();
            this.panelMenu.SuspendLayout();
            this.panelInputNick.SuspendLayout();
            this.SuspendLayout();
            // 
            // canvas
            // 
            this.canvas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(72)))), ((int)(((byte)(72)))));
            this.canvas.Controls.Add(this.panelScores);
            this.canvas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.canvas.Location = new System.Drawing.Point(0, 0);
            this.canvas.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.canvas.Name = "canvas";
            this.canvas.Size = new System.Drawing.Size(493, 655);
            this.canvas.TabIndex = 0;
            this.canvas.Paint += new System.Windows.Forms.PaintEventHandler(this.CanvasPaint);
            // 
            // panelScores
            // 
            this.panelScores.BackColor = System.Drawing.Color.Black;
            this.panelScores.Controls.Add(this.listBox);
            this.panelScores.Controls.Add(this.buttonBack);
            this.panelScores.Controls.Add(this.label3);
            this.panelScores.Location = new System.Drawing.Point(101, 96);
            this.panelScores.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelScores.Name = "panelScores";
            this.panelScores.Size = new System.Drawing.Size(316, 379);
            this.panelScores.TabIndex = 8;
            this.panelScores.Visible = false;
            // 
            // listBox
            // 
            this.listBox.BackColor = System.Drawing.Color.Black;
            this.listBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBox.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listBox.ForeColor = System.Drawing.Color.White;
            this.listBox.FormattingEnabled = true;
            this.listBox.ItemHeight = 23;
            this.listBox.Location = new System.Drawing.Point(79, 96);
            this.listBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.listBox.Name = "listBox";
            this.listBox.Size = new System.Drawing.Size(169, 161);
            this.listBox.TabIndex = 8;
            // 
            // buttonBack
            // 
            this.buttonBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBack.Location = new System.Drawing.Point(79, 287);
            this.buttonBack.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(169, 39);
            this.buttonBack.TabIndex = 7;
            this.buttonBack.Text = "Back";
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.ButtonBackClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(81, 50);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(157, 31);
            this.label3.TabIndex = 6;
            this.label3.Text = "Best scores";
            // 
            // status
            // 
            this.status.BackColor = System.Drawing.Color.Black;
            this.status.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.status.ForeColor = System.Drawing.Color.White;
            this.status.Location = new System.Drawing.Point(119, 193);
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(261, 118);
            this.status.TabIndex = 5;
            this.status.Text = "GAME OVER\r\nFinal Score : 0";
            this.status.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonStart
            // 
            this.buttonStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonStart.Location = new System.Drawing.Point(345, 15);
            this.buttonStart.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(119, 34);
            this.buttonStart.TabIndex = 1;
            this.buttonStart.Text = "Restart";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.RestartGame);
            // 
            // score
            // 
            this.score.Dock = System.Windows.Forms.DockStyle.Left;
            this.score.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold);
            this.score.ForeColor = System.Drawing.Color.White;
            this.score.Location = new System.Drawing.Point(28, 0);
            this.score.Name = "score";
            this.score.Size = new System.Drawing.Size(312, 58);
            this.score.TabIndex = 2;
            this.score.Text = "Score: 0";
            this.score.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // helpText
            // 
            this.helpText.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.helpText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.helpText.ForeColor = System.Drawing.Color.White;
            this.helpText.Location = new System.Drawing.Point(0, 58);
            this.helpText.Name = "helpText";
            this.helpText.Size = new System.Drawing.Size(493, 60);
            this.helpText.TabIndex = 3;
            this.helpText.Text = "Press LEFT and RIGHT or A and D to move\r\n";
            this.helpText.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // gameTimer
            // 
            this.gameTimer.Interval = 1;
            this.gameTimer.Tick += new System.EventHandler(this.GameTimeEvent);
            // 
            // panelSingle
            // 
            this.panelSingle.Controls.Add(this.canvas);
            this.panelSingle.Controls.Add(this.panelSingleGui);
            this.panelSingle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelSingle.Location = new System.Drawing.Point(0, 0);
            this.panelSingle.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelSingle.Name = "panelSingle";
            this.panelSingle.Size = new System.Drawing.Size(493, 773);
            this.panelSingle.TabIndex = 4;
            // 
            // panelSingleGui
            // 
            this.panelSingleGui.Controls.Add(this.panelButtonStart);
            this.panelSingleGui.Controls.Add(this.helpText);
            this.panelSingleGui.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelSingleGui.Location = new System.Drawing.Point(0, 655);
            this.panelSingleGui.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelSingleGui.Name = "panelSingleGui";
            this.panelSingleGui.Size = new System.Drawing.Size(493, 118);
            this.panelSingleGui.TabIndex = 4;
            // 
            // panelButtonStart
            // 
            this.panelButtonStart.Controls.Add(this.buttonStart);
            this.panelButtonStart.Controls.Add(this.score);
            this.panelButtonStart.Controls.Add(this.panelButtonStartLeft);
            this.panelButtonStart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelButtonStart.Location = new System.Drawing.Point(0, 0);
            this.panelButtonStart.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelButtonStart.Name = "panelButtonStart";
            this.panelButtonStart.Size = new System.Drawing.Size(493, 58);
            this.panelButtonStart.TabIndex = 4;
            // 
            // panelButtonStartLeft
            // 
            this.panelButtonStartLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelButtonStartLeft.Location = new System.Drawing.Point(0, 0);
            this.panelButtonStartLeft.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelButtonStartLeft.Name = "panelButtonStartLeft";
            this.panelButtonStartLeft.Size = new System.Drawing.Size(28, 58);
            this.panelButtonStartLeft.TabIndex = 3;
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.Black;
            this.panelMenu.Controls.Add(this.buttonExit);
            this.panelMenu.Controls.Add(this.label1);
            this.panelMenu.Controls.Add(this.buttonRecords);
            this.panelMenu.Controls.Add(this.buttonSGame);
            this.panelMenu.Controls.Add(this.buttonOnline);
            this.panelMenu.Location = new System.Drawing.Point(101, 96);
            this.panelMenu.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(316, 379);
            this.panelMenu.TabIndex = 0;
            // 
            // buttonExit
            // 
            this.buttonExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonExit.Location = new System.Drawing.Point(79, 254);
            this.buttonExit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(169, 39);
            this.buttonExit.TabIndex = 7;
            this.buttonExit.Text = "Exit";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.ButtonExitClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(121, 54);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 31);
            this.label1.TabIndex = 6;
            this.label1.Text = "Menu";
            // 
            // buttonRecords
            // 
            this.buttonRecords.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRecords.Location = new System.Drawing.Point(79, 211);
            this.buttonRecords.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonRecords.Name = "buttonRecords";
            this.buttonRecords.Size = new System.Drawing.Size(169, 39);
            this.buttonRecords.TabIndex = 5;
            this.buttonRecords.Text = "Best scores";
            this.buttonRecords.UseVisualStyleBackColor = true;
            this.buttonRecords.Click += new System.EventHandler(this.ButtonRecordsClick);
            // 
            // buttonSGame
            // 
            this.buttonSGame.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSGame.Location = new System.Drawing.Point(79, 123);
            this.buttonSGame.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonSGame.Name = "buttonSGame";
            this.buttonSGame.Size = new System.Drawing.Size(169, 39);
            this.buttonSGame.TabIndex = 4;
            this.buttonSGame.Text = "Single player\r\n";
            this.buttonSGame.UseVisualStyleBackColor = true;
            this.buttonSGame.Click += new System.EventHandler(this.ButtonSGameClick);
            // 
            // buttonOnline
            // 
            this.buttonOnline.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonOnline.Location = new System.Drawing.Point(79, 168);
            this.buttonOnline.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonOnline.Name = "buttonOnline";
            this.buttonOnline.Size = new System.Drawing.Size(169, 39);
            this.buttonOnline.TabIndex = 3;
            this.buttonOnline.Text = "Online";
            this.buttonOnline.UseVisualStyleBackColor = true;
            this.buttonOnline.Click += new System.EventHandler(this.ButtonOnlineClick);
            // 
            // panelInputNick
            // 
            this.panelInputNick.BackColor = System.Drawing.Color.Black;
            this.panelInputNick.Controls.Add(this.textBoxNick);
            this.panelInputNick.Controls.Add(this.buttonSend);
            this.panelInputNick.Controls.Add(this.label2);
            this.panelInputNick.Location = new System.Drawing.Point(125, 139);
            this.panelInputNick.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelInputNick.Name = "panelInputNick";
            this.panelInputNick.Size = new System.Drawing.Size(264, 215);
            this.panelInputNick.TabIndex = 8;
            // 
            // textBoxNick
            // 
            this.textBoxNick.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.textBoxNick.Location = new System.Drawing.Point(28, 85);
            this.textBoxNick.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxNick.Name = "textBoxNick";
            this.textBoxNick.Size = new System.Drawing.Size(213, 34);
            this.textBoxNick.TabIndex = 8;
            // 
            // buttonSend
            // 
            this.buttonSend.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSend.Location = new System.Drawing.Point(147, 134);
            this.buttonSend.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonSend.Name = "buttonSend";
            this.buttonSend.Size = new System.Drawing.Size(96, 39);
            this.buttonSend.TabIndex = 7;
            this.buttonSend.Text = "Send";
            this.buttonSend.UseVisualStyleBackColor = true;
            this.buttonSend.Click += new System.EventHandler(this.ButtonSendClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(20, 32);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(210, 31);
            this.label2.TabIndex = 6;
            this.label2.Text = "Enter nickname:";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(493, 773);
            this.Controls.Add(this.panelMenu);
            this.Controls.Add(this.status);
            this.Controls.Add(this.panelSingle);
            this.Controls.Add(this.panelInputNick);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Rally";
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.KeyIsUp);
            this.canvas.ResumeLayout(false);
            this.panelScores.ResumeLayout(false);
            this.panelScores.PerformLayout();
            this.panelSingle.ResumeLayout(false);
            this.panelSingleGui.ResumeLayout(false);
            this.panelButtonStart.ResumeLayout(false);
            this.panelMenu.ResumeLayout(false);
            this.panelMenu.PerformLayout();
            this.panelInputNick.ResumeLayout(false);
            this.panelInputNick.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel canvas;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.Label score;
        private System.Windows.Forms.Label helpText;
        private System.Windows.Forms.Timer gameTimer;
        private System.Windows.Forms.Label status;
        private System.Windows.Forms.Panel panelSingle;
        private System.Windows.Forms.Panel panelSingleGui;
        private System.Windows.Forms.Panel panelButtonStart;
        private System.Windows.Forms.Panel panelButtonStartLeft;
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Button buttonRecords;
        private System.Windows.Forms.Button buttonSGame;
        private System.Windows.Forms.Button buttonOnline;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Panel panelInputNick;
        private System.Windows.Forms.Button buttonSend;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxNick;
        private System.Windows.Forms.Panel panelScores;
        private System.Windows.Forms.ListBox listBox;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.Label label3;
    }
}

