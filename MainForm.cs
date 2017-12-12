using System;
using System.Drawing;
using System.Windows.Forms;

namespace pKami.WinUtils.ShutdownTimer
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            InitializeAppearance();
        }

        private void InitializeAppearance()
        {
            Font fBold = new Font(btnShutdown.Font, FontStyle.Bold);
            btnShutdown.Font = fBold;
        }

        private void inputControl_SelectAllText(object sender, EventArgs e)
        {
            if (sender is TextBoxBase)
            {
                ((TextBoxBase)sender).SelectAll();
            }
            else if (sender is UpDownBase)
            {
                UpDownBase udb = (UpDownBase)sender;
                udb.Select(0, 2);
            }
        }

        private void inputControl_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return)
            {
                btnShutdown_Click(sender, e);
            }
        }

        private void btnShutdown_Click(object sender, EventArgs e)
        {
            if ((nudHours.Value * 60 + nudMinutes.Value) < 1)
            {
                DialogResult dr = MessageBox.Show("Selected time is less than 1 minute. Are you sure?", "Less than 1 minute", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (dr != DialogResult.Yes)
                    return;
            }

            try
            {
                ShutdownCommand.Execute(nudHours.Value, nudMinutes.Value, nudSeconds.Value, cbForce.Checked, cbRestart.Checked);

                MessageBox.Show(this, String.Format("The computer will {0} in {1}{2}{3}.",
                        cbRestart.Checked ? "restart" : "shut down",
                        nudHours.Value > 0 ? nudHours.Value.ToString() + "h" : "",
                        nudMinutes.Value > 0 ? " " + nudMinutes.Value.ToString() + "m" : "",
                        nudSeconds.Value > 0 ? " " + nudSeconds.Value.ToString() + "s" : ""),
                    "Shutdown imminent", MessageBoxButtons.OK, MessageBoxIcon.Information);

                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAbout_Click(object sender, EventArgs e)
        {
            using (AboutBox about = new AboutBox())
            {
                about.ShowDialog(this);
            }
        }
    }
}
