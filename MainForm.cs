using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Media;
using System.Net.Sockets;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Rally.Car;

namespace Rally
{
    public partial class MainForm : Form
    {
        private float roadSpeed;
        private float trafficSpeed;
        private float scoreCount;
        private float playerY;
        private int carImage;
        private bool goLeft;
        private bool goRight;
        private bool gameOver;
        private bool win;
        private bool sGame;
        private Player onlinePlayer;
        private Car oppenent;
        private DateTime lastTime;
        private readonly int playerSpeed = 5;
        private readonly Random random = new Random();
        private readonly Car[] cars;
        private readonly Car player;
        private readonly GifPlayer explosion;

        public MainForm()
        {
            InitializeComponent();
            canvas.MakeDoubleBuffered();
            cars = new Car[]
            {
                new Car(CarLocation.Left),
                new Car(CarLocation.Right)
            };
            player = new Car() { Image = Properties.Resources.car };
            explosion = new GifPlayer(Properties.Resources.explosion);
            lastTime = DateTime.Now;
            ResetGame();
            var x = random.Next(34, 178);
            var y = random.Next(50, 200);
            cars[0].SetPosition(x, y);
            x = random.Next(233, 320);
            y = random.Next(50, 200);
            cars[1].SetPosition(x, y);
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            switch (keyData)
            {
                case Keys.Left:
                    goLeft = true;
                    break;
                case Keys.Right:
                    goRight = true;
                    break;
                case Keys.A:
                    goLeft = true;
                    break;
                case Keys.D:
                    goRight = true;
                    break;
            }

            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void KeyIsUp(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                 case Keys.Left:
                    goLeft = false;
                    break;
                 case Keys.Right:
                    goRight = false;
                    break;
                case Keys.A:
                    goLeft = false;
                    break;
                case Keys.D:
                    goRight = false;
                    break;
                case Keys.R:
                    if (oppenent == null)
                        ResetGame();
                    break;
                case Keys.Escape:
                    gameTimer.Stop();
                    panelMenu.Visible = true;
                    panelMenu.BringToFront();
                    break;
            }
        }

        private void GameTimeEvent(object sender, EventArgs e)
        {
            var time = DateTime.Now;
            var deltaTime = (time - lastTime).Duration().Ticks / 200000.0f;
            lastTime = time;

            if (!gameOver)
            {
                score.Text = $"Score: {(int)scoreCount}";
                scoreCount += deltaTime;

                if (goLeft == true && player.DrawBounds.Left > 34)
                    player.MoveLeft(playerSpeed * deltaTime);
                if (goRight == true && player.DrawBounds.Right < 320)
                    player.MoveRight(playerSpeed * deltaTime);

                playerY += roadSpeed * deltaTime;

                foreach (var car in cars)
                    car.MoveDown(trafficSpeed * deltaTime);

                foreach (var car in cars)
                    if (car.DrawBounds.Bottom > ClientSize.Height)
                        RadomCar(car);

                foreach (var car in cars)
                    if (player.CollisionBounds.IntersectsWith(car.CollisionBounds))
                        GameOver();

                roadSpeed += 1 / 300.0f;
                trafficSpeed += 2 / 300.0f;
            }

            canvas.Invalidate();     
        }

        private void RadomCar(Car car)
        {
            carImage = random.Next(1, 4);
            switch (carImage)
            {
                case 1:
                    car.Image = Properties.Resources.car1;
                    break;
                case 2:
                    car.Image = Properties.Resources.car2;
                    break;
                case 3:
                    car.Image = Properties.Resources.car3;
                    break;
            }
    
            var x = 0.0f;
            var y = random.Next(100, 400) * -1;
            if (car.Location == Car.CarLocation.Left)
                x = random.Next(34, 178);
            else if (car.Location == Car.CarLocation.Right)
                x = random.Next(233, 320);
            car.SetPosition(x, y);
        }

        private void GameOver()
        {
            gameOver = true;
            explosion.Bounds = new RectangleF(player.DrawBounds.Left - 10, 
                player.DrawBounds.Top - 10, player.DrawBounds.Width + 20, 
                player.DrawBounds.Height + 20);

            explosion.Play();
            PlayHitSound();
            ShowStatus($"GAME OVER\nYOUR SCORE: {(int)scoreCount}");
        }

        private void ResetGame()
        {
            status?.Hide();
            panelInputNick?.Hide();
            panelScores?.Hide();
            foreach (var car in cars)
                RadomCar(car);
            goLeft = false;
            goRight= false;

            scoreCount = 0;
            roadSpeed = 4;
            trafficSpeed = 3;
            player.Image = Properties.Resources.car;
            var x = (canvas.ClientSize.Width - player.DrawBounds.Width) / 2;
            var y = canvas.ClientSize.Height - player.DrawBounds.Height - 10;
            player.SetPosition(x, y);
            oppenent?.SetPosition(x, y);
            gameOver = false;
            canvas.Focus();
            canvas?.Invalidate();
        }

        private void RestartGame(object sender, EventArgs e)
        {
            ResetGame();
        }

        private void PlayHitSound()
        {
            var sound = Properties.Resources.hit;
            var player = new SoundPlayer(sound);
            //player.Play();
        }

        private void CanvasPaint(object sender, PaintEventArgs e)
        {
            var graphics = e.Graphics;
            var bounds = e.ClipRectangle;
            graphics.SmoothingMode = SmoothingMode.HighQuality;
            graphics.DrawRoad(bounds, playerY);
            if (oppenent != null)
                graphics.DrawImage(oppenent.Image, oppenent.DrawBounds);
            graphics.DrawImage(player.Image, player.DrawBounds);
            foreach (var car in cars)
                graphics.DrawImage(car.Image, car.DrawBounds);
            graphics.DrawGif(explosion);
            if (explosion.GetProgress() >= 0.5)
            {
                if (win && oppenent != null)
                    oppenent.Image = Properties.Resources.oppenentDeath;
                else
                    player.Image = Properties.Resources.carDeath;
            }
        }

        private void ButtonSingleClick(object sender, EventArgs e)
        {
            buttonStart.Show();
            panelMenu.Hide();
            oppenent = null;
            ResetGame();
            gameTimer.Start();
        }

        private void ButtonExitClick(object sender, EventArgs e)
        {
            Close();
        }

        private void ButtonOnlineClick(object sender, EventArgs e)
        {
            sGame = false;
            PlayOnline();
        }

        private void ButtonSendClick(object sender, EventArgs e)
        {
            if (textBoxNick.Text == "")
                MessageBox.Show("Enter nickname!");
            else
            {
                onlinePlayer.Client.SendString(textBoxNick.Text);
                HideGui();
                ShowStatus("Waiting opponent ...");
            }
        }

        private void ButtonBackClick(object sender, EventArgs e)
        {
            panelScores.Hide();
            ShowMenu();
        }

        private void ButtonRecordsClick(object sender, EventArgs e)
        {
            HideGui();
            panelScores.Show();
            panelScores.BringToFront();
            Task.Run(() => 
            {
                try
                {
                    var socket = new Socket(AddressFamily.InterNetwork, 
                        SocketType.Stream, ProtocolType.Tcp);
                    var ip = Properties.Resources.ServerIp;
                    socket.Connect(ip, 1367);
                    var client = new Client(socket);
                    var size = client.AcceptInt();
                    Invoke(new Action(() => listBox.Items.Clear()));
                    for (int i = 0; i < size; i++)
                    {
                        var nick = client.AcceptString();
                        var score = client.AcceptFloat();
                        Invoke(new Action(() => listBox.Items
                            .Add(string.Format("{0, -10}{1, -5}", nick, (int)score))));
                    }
                }
                catch { };
            });
        }

        //private void ButtonWhithBotClick(object sender, EventArgs e)
        //{
        //    sGame = true;
        //    PlayOnline();
        //}
        private void ButtonSGameClick(object sender, EventArgs e)
        {
            sGame = true;
            PlayOnline();
        }


        public void ShowStatus(string statusText)
        {
            Invoke(new Action(() =>
            {
                canvas.Invalidate();
                status.Text = statusText;
                status.Visible = true;
                status.BringToFront();
            }));
        }

        public void ShowNickInput()
        {
            Invoke(new Action(() =>
            {
                panelInputNick.Visible = true;
                panelInputNick.BringToFront();
                canvas.Invalidate();
            }));
        }

        public void ShowMenu()
        {
            Invoke(new Action(() =>
            {
                panelMenu.Visible = true;
                panelMenu.BringToFront();
                canvas.Invalidate();
            }));
        }

        public void HideGui()
        {
            Invoke(new Action(() =>
            {
                panelMenu?.Hide();
                status?.Hide();
                panelInputNick?.Hide();
                panelScores?.Hide();
                canvas?.Invalidate();
            }));
        }

        private void PlayOnline()
        {
            HideGui();
            buttonStart.Visible = false;
            Task.Run(() =>
            {
                ShowStatus("Connecting to server ...");
                try
                {
                    var socket = new Socket(AddressFamily.InterNetwork,
                        SocketType.Stream, ProtocolType.Tcp);
                    var ip = Properties.Resources.ServerIp;
                    socket.Connect(ip, 1366);
                  //  ShowStatus("Waiting opponent ...");
                    onlinePlayer = new Player(socket);
                    player.Image = Properties.Resources.car;
                    //oppenent = new Car
                    //{
                    //    Image = Properties.Resources.oppenent,
                    //    DrawBounds = player.DrawBounds
                    //};
                    while (onlinePlayer.Connected)
                    {
                        var time = DateTime.Now;
                        var deltaTime = (time - lastTime)
                            .Duration().Ticks / 200000.0f;
                        lastTime = time;

                        if (goLeft == true && player.DrawBounds.Left > 34)
                            player.MoveLeft(playerSpeed * deltaTime);
                        if (goRight == true && player.DrawBounds.Right < 320)
                            player.MoveRight(playerSpeed * deltaTime);

                        //if (onlinePlayer.Client.Socket.Available == 0)
                        //    continue;

                        var command = onlinePlayer.AcceptCommand();
                        switch (command)
                        {
                            case Command.SGame:
                                onlinePlayer.Client.SendInt(sGame ? 1 : 0);
                                break;
                            case Command.GetNick:
                                HideGui();
                                ShowNickInput();
                                break;
                            case Command.GetPosition:
                                var position = player.DrawBounds.Location;
                                onlinePlayer.SendPosition(position);
                                break;
                            case Command.SetCarPosition:
                                {
                                    var index = onlinePlayer.Client.AcceptInt();
                                    var x = onlinePlayer.Client.AcceptFloat();
                                    var y = onlinePlayer.Client.AcceptFloat();
                                    cars[(int)index].SetPosition((float)x, (float)y);
                                }
                                break;
                            case Command.SetCarColor:
                                {
                                    var index = (int)onlinePlayer.Client.AcceptInt();
                                    var color = onlinePlayer.Client.AcceptInt();
                                    switch (color)
                                    {
                                        case 1:
                                            cars[index].Image = Properties.Resources.car1;
                                            break;
                                        case 2:
                                            cars[index].Image = Properties.Resources.car2;
                                            break;
                                        case 3:
                                            cars[index].Image = Properties.Resources.car3;
                                            break;
                                    }
                                }
                                break;
                            //case Command.SetOpponentPosition:
                            //    {
                            //        var x = onlinePlayer.Client.AcceptFloat();
                            //        var y = onlinePlayer.Client.AcceptFloat();
                            //        oppenent.SetPosition((float)x, (float)y);
                            //    }
                            //    break;
                            case Command.SetPosition:
                                {
                                    playerY = (float)onlinePlayer.Client.AcceptFloat();
                                }
                                break;
                            case Command.Start:
                                HideGui();
                                break;
                            case Command.SetResult:
                                {
                                   // var x = onlinePlayer.Client.AcceptInt() == 1;
                                    Invoke(new Action(() =>
                                    {
                                        //win = x;
                                        //var loser = win ? oppenent : player;
                                        explosion.Bounds = new RectangleF(player.DrawBounds.Left - 10,
                                            player.DrawBounds.Top - 10, player.DrawBounds.Width + 20,
                                            player.DrawBounds.Height + 20);
                                        explosion.Play();
                                        Task.Run(() =>
                                        {
                                            for (int i = 0; i < 100; i++)
                                            {
                                                Invoke(new Action(() => canvas.Invalidate()));
                                                Thread.Sleep(10);
                                            }
                                        });
                                        HideGui();
                                        ShowStatus(  $"\nSCORE {(int)scoreCount}");
                                        //ShowStatus((win ? "YOU WIN" : "YOU LOSE") +
                                        //    $"\nSCORE {(int)scoreCount}");
                                    }));
                                }
                                break;
                            case Command.SetScore:
                                {
                                    scoreCount = (float)onlinePlayer.Client.AcceptFloat();
                                    Invoke(new Action(() => score.Text = $"Score: {(int)scoreCount}"));
                                }
                                break;
                            case Command.Disconnect:
                                onlinePlayer.Disconnect();
                                break;
                        }
                        Invoke(new Action(() => canvas.Invalidate()));
                    }
                }
                catch
                {
                    ShowStatus("Failed connecting to server!");
                    Thread.Sleep(2000);
                    HideGui();
                    ShowMenu();
                }
            });
        }
    }
}
