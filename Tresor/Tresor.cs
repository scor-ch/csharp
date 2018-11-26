using System;
using System.Drawing;
using System.Media;
using System.Windows.Forms;

namespace Tresor
{
    public partial class Tresor : Form

    {
        // Variable für den Code der mit SET gesetzt wurde und zur Öffnung der Tresortüre benötigt wird
        int gesetzterCode;
        // Variable für den vom Benutzer "versuchten" Code um die Türe zu öffnen
        int eingegebenerCode;
        // Variable die festhält, ob ein Code gesetzt wurde und damit aktiv ist
        bool codeIsSet = false;
        // Variable die festhält, ob das Display zurückgesetzt werden darf oder nicht
        bool resetDisplayOk = true;
        

        public Tresor()
        {
            InitializeComponent();
            // Tooltip zum "?" Knopf anzeigen
            ToolTip helpToolTip = new ToolTip();
            helpToolTip.SetToolTip(this.hilfe, "Aktueller Code anzeigen");
            helpToolTip.InitialDelay = 400;
            // Neuer Tresor mit offener Tür starten
            oeffnenSchliessen(true);
        }

        private void button_Click(object sender, EventArgs e)
        {
            SystemSounds.Beep.Play();
            // Sound-Datei im .wav Format abspielen wenn ein Knopf gedrückt wird
            //SystemSound btn_sound = new SystemSound(@"c:\Windows\media\Windows-Geblocktes Popup.wav");
            //btn_sound.Play();

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
            schliessfach.Enabled = bewegen;
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
                this.eingegebenerCode = Convert.ToInt32(display.Text);

                if (this.codeIsSet = true && eingegebenerCode == gesetzterCode)
                {
                    display.Text = "Code Korrekt";
                    this.codeIsSet = false;
                    this.resetDisplayOk = true;
                    oeffnenSchliessen(true);
                }
                else
                {
                    display.Text = "Code Inkorrekt";
                    this.codeIsSet = true;
                    this.resetDisplayOk = true;
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
        private void hilfe_Click(object sender, EventArgs e)
        {
            if (this.codeIsSet == true)
            {
                // Wenn ein Code gesetzt wurde, diesen anzeigen
                display.Text = Convert.ToString("Code ist: " + gesetzterCode);
                this.resetDisplayOk = true;
            }
            else
                // Ausgeben wenn noch kein Code gesetzt wurde
                display.Text = "Kein Code";
                this.resetDisplayOk = true;
        }
    }
}
