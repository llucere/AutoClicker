using System;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;
using System.Windows.Input;

namespace AutoClicker
{
    public partial class Window : Form
    {
        enum delayType
        {
            noSec,
            halfSec,
            oneSec,
            oneHalfSec,
            twoSec,
            twoHalfSec,
            threeSec,
            threeHalfSec,
            fourSec,
            fourHalfSec,
            fiveSec
        };

        bool gettingLocation, autoClickerActive, isBootingAutoClicker, usingSelectedLocation, usingRepeats;
        int inputMode = 0;
        delayType delay = 0;

        static uint LDOWN = 0x02;
        static uint LUP = 0x04;
        static uint MDOWN = 0x20;
        static uint MUP = 0x40;
        static uint RDOWN = 0x08;
        static uint RUP = 0x10;
        uint input0 = LDOWN, input1 = LUP;

        HintMain hint = new HintMain();
        
        public Window() => InitializeComponent();

        private void Window_Load(object sender, EventArgs e)
        {
            hint.Hide();

            new Thread(new ThreadStart(delegate {
                while (true)
                {
                    if ((ModifierKeys & Keys.Control) != 0 && (ModifierKeys & Keys.Shift) != 0 && !autoClickerActive)
                    {
                        this.Invoke(new Action(delegate { StartAutoClicker(); }));
                    }
                    Thread.Sleep(100);
                }
            })).Start();
        }

        private void InputType_Click(object sender, EventArgs e)
        {
            switch (inputMode)
            {
                case (0):
                    inputMode++;
                    input0 = RDOWN;
                    input1 = RUP;
                    InputType.Text = "Type (RMB)";
                    break;
                case (1):
                    inputMode++;
                    input0 = MDOWN;
                    input1 = MUP;
                    InputType.Text = "Type (MMB)";
                    break;
                case (2):
                    inputMode = 0;
                    input0 = LDOWN;
                    input1 = LUP;
                    InputType.Text = "Type (LMB)";
                    break;
            }
        }

        private void Delay_Click(object sender, EventArgs e)
        {
            switch (delay)
            {
                case (delayType.noSec): delay++; Delay.Text = "Delay (.5s)"; break;
                case (delayType.halfSec): delay++; Delay.Text = "Delay (1s)"; break;
                case (delayType.oneSec): delay++; Delay.Text = "Delay (1.5s)"; break;
                case (delayType.oneHalfSec): delay++; Delay.Text = "Delay (2s)"; break;
                case (delayType.twoSec): delay++; Delay.Text = "Delay (2.5s)"; break;
                case (delayType.twoHalfSec): delay++; Delay.Text = "Delay (3s)"; break;
                case (delayType.threeSec): delay++; Delay.Text = "Delay (3.5s)"; break;
                case (delayType.threeHalfSec): delay++; Delay.Text = "Delay (4s)"; break;
                case (delayType.fourSec): delay++; Delay.Text = "Delay (4.5s)"; break;
                case (delayType.fourHalfSec): delay++; Delay.Text = "Delay (5s)"; break;
                case (delayType.fiveSec): delay = 0; Delay.Text = "Delay (0s)"; break;
            }
        }

        [DllImport("user32.dll")]
        static extern void mouse_event(uint dwFlags, int dx, int dy, uint dwData, int dwExtraInfo);

        [DllImport("user32.dll")]
        static extern bool SetCursorPos(int X, int Y);

        private void EndWorkerThread()
        {
            while (autoClickerActive)
            {
                if ((ModifierKeys & Keys.Control) != 0 && (ModifierKeys & Keys.Alt) != 0) break;
                Thread.Sleep(50);
            }

            this.Invoke(new Action(delegate { EndAutoClicker(); }));
        }
       
        private void WorkerThread()
        {
            int hrs = (int)(Convert.ToInt32(Hours.Text) * 3.6e+6);
            int mins = Convert.ToInt32(Minutes.Text) * 60000;
            int secs = Convert.ToInt32(Seconds.Text) * 1000;
            int msecs = Convert.ToInt32(MilliSeconds.Text);
            int clicks = Convert.ToInt32(ClicksPerRender.Text);
            int repeats = Convert.ToInt32(Repeats.Text);

            int compiled = hrs + mins + secs + msecs;
            int x = Convert.ToInt32(X.Text), y = Convert.ToInt32(Y.Text);
            int loops = 0;

            while (autoClickerActive)
            {
                if (!usingSelectedLocation)
                {
                    x = Cursor.Position.X;
                    y = Cursor.Position.Y;
                } else SetCursorPos(x, y);

                for (int i = 0; i < clicks; i++)
                {
                    mouse_event(input0, x, y, 0, 0);
                    mouse_event(input1, x, y, 0, 0);
                }

                if (compiled > 0) Thread.Sleep(compiled);

                if (usingRepeats)
                {
                    loops++;
                    if (loops >= repeats) break;
                } 
            }

            autoClickerActive = false;
        }

        private void StartButton_Click(object sender, EventArgs e) => StartAutoClicker();

        private void TimeVal_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBox newSender = sender as TextBox;
            if ((!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))) e.Handled = true;

            Console.WriteLine(newSender.Text);
            if (e.KeyChar == (char)Keys.Back && newSender.Text.Length <= 1) {
                newSender.Text = (newSender.Name != "ClicksPerRender" && newSender.Name != "Repeats") ? "0" : "1";
                e.Handled = true;
            }
        }

        private void RepeatUntilStoppedCheckbox_CheckedChanged(object sender, EventArgs e) => usingRepeats = RepeatUntilStoppedCheckbox.Checked;

        private void TopMost_CheckedChanged(object sender, EventArgs e)
        {
            this.TopMost = TopMostCheck.Checked;
        }

        private void PickLocation_Click(object sender, EventArgs e)
        {
            if (isBootingAutoClicker || autoClickerActive) return;
            EndAutoClicker();
            if (gettingLocation) return;

            this.TopMost = true;
            Hide();
            hint.Show();
            hint.TopMost = true;
            gettingLocation = true;
            Thread render = new Thread(new ThreadStart(delegate {
                while ((ModifierKeys & Keys.Control) == 0 && Control.MouseButtons != MouseButtons.Left)
                {
                    hint.Invoke(new Action(delegate {hint.setCoords(Cursor.Position.X, Cursor.Position.Y);}));
                    Thread.Sleep(5);
                }

                gettingLocation = false;
                this.Invoke(new Action(delegate {
                    hint.Hide();
                    hint.TopMost = false;
                    Show();
                    X.Text = Convert.ToString(Cursor.Position.X);
                    Y.Text = Convert.ToString(Cursor.Position.Y);
                    this.TopMost = TopMostCheck.Checked;
                    SpecifiedLocationBox.Checked = true;
                }));
            }));

            render.Start();
        }

        private void SpecifiedLocationBox_CheckedChanged(object sender, EventArgs e) => usingSelectedLocation = SpecifiedLocationBox.Checked;

        private void StartAutoClicker()
        {
            if (gettingLocation) return;
            if (isBootingAutoClicker || autoClickerActive) return;
            StopButton.Enabled = false;
            StartButton.Enabled = false;
            Hours.Enabled = false;
            Minutes.Enabled = false;
            Seconds.Enabled = false;
            MilliSeconds.Enabled = false;
            PickLocation.Enabled = false;
            SpecifiedLocationBox.Enabled = false;
            RepeatUntilStoppedCheckbox.Enabled = false;
            Repeats.Enabled = false;
            X.Enabled = false;
            Y.Enabled = false;

            isBootingAutoClicker = true;
            if (delay != delayType.noSec) Thread.Sleep(((int)delay / 2) * 1000);
            autoClickerActive = true;
            isBootingAutoClicker = false;

            Thread threadObject = new Thread(new ThreadStart(delegate { WorkerThread(); }));
            threadObject.Start();
            Thread inputCheckThreadObject = new Thread(new ThreadStart(EndWorkerThread));
            inputCheckThreadObject.Start();

            Thread.Sleep(1000);

            StopButton.Enabled = true;
        }

        private void EndAutoClicker()
        {
            if (gettingLocation) return;
            autoClickerActive = false;

            StartButton.Enabled = true;
            StopButton.Enabled = false;
            Hours.Enabled = true;
            Minutes.Enabled = true;
            Seconds.Enabled = true;
            MilliSeconds.Enabled = true;
            PickLocation.Enabled = true;
            SpecifiedLocationBox.Enabled = true;
            RepeatUntilStoppedCheckbox.Enabled = true;
            Repeats.Enabled = true;
            X.Enabled = true;
            Y.Enabled = true;
        }

        private void StopButton_Click(object sender, EventArgs e)
        {
            if (isBootingAutoClicker || !autoClickerActive) return;
            EndAutoClicker();
        }
    }
}
