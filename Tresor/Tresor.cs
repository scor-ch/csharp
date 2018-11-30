using System;
using System.Drawing;
using System.Media;
using System.Windows.Forms;

//Todo: dragndrop, visible.enabled wenn open
//Todo: alarm counter im display

namespace Tresor
{
    public partial class Tresor : Form
    {
        SoundPlayer player = new SoundPlayer();
        // Variable für den Code der mit SET gesetzt wurde und zur Öffnung der Tresortüre benötigt wird
        int gesetzterCode;
        // Variable für den vom Benutzer "versuchten" Code um die Türe zu öffnen
        int eingegebenerCode;
        // Variable die festhält, ob ein Code gesetzt wurde und damit aktiv ist
        bool codeIsSet = false;
        // Variable die festhält, ob das Display zurückgesetzt werden darf oder nicht
        bool resetDisplayOk = true;
        // Zähler Versuche
        int fehlversuche = 0;
        // Flag um die autom. Türöffnung zu aktivieren/deaktivieren
        bool auto;
        // Flag um Soundeffekte zu aktivieren/deaktivieren
        bool soundOn;
        // Methode um Instanz neu laden nachdem die Türe (autom.) geöffnet wurde
        private void resetForm()
        {
            // Sound bei erfolgreicher Öffnung und aktivierten Soundeffekten
            if (soundOn)
            {
                player.SoundLocation = @"C:\\Windows\\Media\\tada.wav";
                player.Play();
            }
            display.Text = "Code Korrekt";
            codeIsSet = false;
            resetDisplayOk = true;
            oeffnenSchliessen(true);
            fehlversuche = default(int);
        }
        public Tresor()
        {
            InitializeComponent();
            // Tooltip zum "?" Knopf anzeigen
            ToolTip helpToolTip = new ToolTip();
            helpToolTip.SetToolTip(hilfe, "Aktueller Code anzeigen");
            helpToolTip.InitialDelay = 400;
            // Neuer Tresor mit offener Tür starten
            oeffnenSchliessen(true);
        }
        private void button_Click(object sender, EventArgs e)
        {
            // Tastentöne
            if (soundOn)
            {
                player.SoundLocation = @"C:\\Windows\\Media\\ding.wav";
                player.Play();
            }
            // Display vorgängig zurücksetzen wenn resetDisplayOk 'true' ist
            if (resetDisplayOk == true)
            {
                display.Clear();
            }
            // Knopf-Text (Zahl) erfassen und für die Anzeige im Display verwenden
            Button b = (Button)sender;
            display.Text = display.Text + b.Text;
            // Display nicht mehr zurücksetzen damit Zahlen aneinandergereiht werden können
            resetDisplayOk = false;
            // Display nicht mehr zurücksetzen damit Zahlen aneinandergereiht werden können
            if (auto && display.Text == Convert.ToString(gesetzterCode))
            {
                resetForm();
            }
        }
        // Event für die Knöpfe "SET" und "C"
        private void setOrC_Click(object sender, EventArgs e)
        {
            try
            {
                Button b = (Button)sender;
                // Code nur setzen, wenn der Wert grösser als 0 ist und noch kein andere Code gesetzt wurde
                if (b.Text == "SET" && Convert.ToInt32(display.Text) >= 1 && codeIsSet == false)
                {
                    gesetzterCode = Convert.ToInt32(display.Text);
                    display.Text = "Code gesetzt";
                    codeIsSet = true;
                    resetDisplayOk = true;
                    // Tresortüre schliessen (rot)
                    oeffnenSchliessen(false);
                }
                // Nachricht ausgeben, wenn ein Code mit "0/00/000" gesetzt werden soll
                else if (b.Text != "C" && Convert.ToInt32(display.Text) <= 0)
                {
                    display.Text = "Ungültig";
                    resetDisplayOk = true;
                }
                else if (b.Text == "SET" && codeIsSet == true)
                {
                    display.Text = "Alter Code aktiv";
                    resetDisplayOk = true;
                }
                else if (b.Text == "C")
                {
                    // Eingegebene Zahlen zurücksetzen
                    eingegebenerCode = default(int);
                    // Display auf 0000 zurücksetzen
                    display.Clear();
                    display.Text = "0000";
                    resetDisplayOk = true;
                }
            }
            // Versucht einen string zu "SETTEN" abfangen
            catch (FormatException)
            {
                display.Text = "Nicht erlaubt";
            }
        }
        private void oeffnenSchliessen(bool bewegen)
        {
            // Panel aktivieren / deaktivieren
            //schliessfach.Enabled = bewegen;
            if (bewegen)
            {
                schliessfach.BackColor = Color.DarkGreen;
            }
            else
                schliessfach.BackColor = Color.DarkRed;
        }

        private void open_Click(object sender, EventArgs e)
        {
            // Exception Handling für das Abfangen falscher Manipulationen
            try
            {
                eingegebenerCode = Convert.ToInt32(display.Text);
                {
                    if (codeIsSet = true && eingegebenerCode == gesetzterCode && Convert.ToInt32(display.Text) >= 1)
                    {
                        // Code Korrekt
                        resetForm();
                    }
                    else
                    {
                        // Anzahl Fehlversuche
                        if (fehlversuche > 1)
                        {
                            // Sound bei 3 Fehlversuchen
                            if (soundOn)
                            {
                                player.SoundLocation = @"C:\\Windows\\Media\\ir_end.wav";
                                player.Play();
                            }
                            // Pop-up wenn Alarm losgeht
                            MessageBox.Show("Zu viele Versuche. Der Tresor wird geschlossen", "ALARM", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            /*int i = 10;
                            do
                            {
                                display.Clear();
                                display.Text = display.Text + i;
                                System.Threading.Thread.Sleep(100);
                                i--;
                            } while (i >= 0);*/
                            Timer myTimer = new Timer();
                            //myTimer.Tick += new EventHandler(myTimer_Tick);

                            // Tresor nach 3 Fehlerversuchen schliessen, andere Instanzen bleiben geöffnet
                            Close();
                        }
                        else
                            if (soundOn)
                        {
                            player.SoundLocation = @"C:\\Windows\\Media\\chord.wav";
                            player.Play();
                        }
                        display.Text = "Code Inkorrekt";
                        codeIsSet = true;
                        resetDisplayOk = true;
                        fehlversuche++;
                    }
                }
            }
            // Benutzerfreundliche Meldung bei falscher Eingabe
            catch (FormatException)
            {
                display.Text = "Falsches Format";
            }
            // Generelle benutzerfreundliche Ausgabe anderer Exceptions als Popup
            catch (Exception exception)
            {
                MessageBox.Show(display.Text = exception.GetType() + ": " + exception.Message);
            }
        }
        private void Hilfe_Click(object sender, EventArgs e)
        {
            if (codeIsSet == true)
            {
                // Wenn ein Code gesetzt wurde, diesen anzeigen
                display.Text = Convert.ToString("Code ist: " + gesetzterCode);
                resetDisplayOk = true;
            }
            else
                // Ausgeben wenn noch kein Code gesetzt wurde
                display.Text = "Kein Code";
            resetDisplayOk = true;
        }
        private void autoOpen_CheckedChanged(object sender, EventArgs e)
        {
            if (autoOpen.Checked)
            {
                auto = true;
            }
            else
                auto = false;
        }
        private void soundCB_CheckedChanged(object sender, EventArgs e)
        {
            if (soundCB.Checked)
            {
                soundOn = true;
            }
            else
                soundOn = false;
        }
    }
}