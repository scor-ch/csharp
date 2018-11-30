using System;
using System.Drawing;
using System.Media;
using System.Windows.Forms;

namespace Tresor
{
    public partial class Tresor : Form
    {
        // SoundPlayer Objekt instanzieren
        SoundPlayer player = new SoundPlayer();
        // Variable für den Code der mit SET gesetzt wurde und zur Öffnung der Tresortüre benötigt wird
        int gesetzterCode;
        // Variable für den vom Benutzer "versuchten" Code um die Türe zu öffnen
        int eingegebenerCode;
        // Variable die festhält, ob ein Code gesetzt wurde und damit aktiv ist
        bool codeGesetzt = false;
        // Variable die festhält, ob das Display zurückgesetzt werden darf oder nicht
        bool zuruecksetzenDisplay = true;
        // Variable um die Anzahl Versuche festzuhalten
        int fehlversuche = 0;
        // Flag um die autom. Türöffnung zu aktivieren/deaktivieren
        bool autoOeffnung;
        // Flag um Soundeffekte zu aktivieren/deaktivieren
        bool soundsAn;

        // Methode um Instanz neu laden nachdem die Türe (autom.) geöffnet wurde
        public Tresor()
        {
            InitializeComponent();
            // Tooltip zum "?" Knopf anzeigen
            ToolTip hilfeToolTip = new ToolTip();
            hilfeToolTip.SetToolTip(hilfe, "Aktuellen Code anzeigen");
            hilfeToolTip.InitialDelay = 400;
            // Den neuen Tresor mit offener Tür starten
            oeffnenSchliessen(true);

        }
        // Methode um das Formular (den Tresor) zurückzusetzen
        private void ZuruecksetzenFormular()
        {
            // Sound bei erfolgreicher Öffnung und aktivierten Soundeffekten
            if (soundsAn)
            {
                player.SoundLocation = @"C:\\Windows\\Media\\tada.wav";
                player.Play();
            }
            anzeige.Text = "Code Korrekt";
            codeGesetzt = false;
            zuruecksetzenDisplay = true;
            oeffnenSchliessen(true);
            fehlversuche = default(int);
            ControlBox = false;
        }

        // Methode um die Tresortüre zu öffnen/schliessen
        private void oeffnenSchliessen(bool bewegen)
        {
            // Panel Farben grün = Tresor offen, rot = Tresor zu
            if (bewegen)
            {
                schliessfach.BackColor = Color.DarkGreen;
            }
            else
                schliessfach.BackColor = Color.DarkRed;
        }
        // Click-Event Handler für alle Zahlen von 0-9
        private void Knopf_Click(object sender, EventArgs e)
        {
            // Tastentöne
            if (soundsAn)
            {
                player.SoundLocation = @"C:\\Windows\\Media\\ding.wav";
                player.Play();
            }
            // Display vorgängig zurücksetzen wenn zuruecksetzenDisplay 'true' ist
            if (zuruecksetzenDisplay == true)
            {
                anzeige.Clear();
            }
            // Knopf-Text (Zahl) erfassen und für die Anzeige im Display verwenden
            Button b = (Button)sender;
            anzeige.Text = anzeige.Text + b.Text;
            // Display nicht mehr zurücksetzen damit Zahlen aneinandergereiht werden können
            zuruecksetzenDisplay = false;
            // Überprüfung ob - bei aktivierter Autom. Öffnung - der eingegebene Code mit dem gesetzten Code übereinstimmt
            // Wenn zutreffend, entsprechend die Zurücksetzung des Formulars auslösen
            if (autoOeffnung && anzeige.Text == Convert.ToString(gesetzterCode))
            {
                ZuruecksetzenFormular();
            }
        }
        // Click-Event Handler für die Knöpfe "EINGABE" und "C"
        private void setOrC_Click(object sender, EventArgs e)
        {
            // Beginn Ausnahmebehandlung
            try
            {
                Button b = (Button)sender;
                // Code nur setzen, wenn der Wert grösser als 0 ist und noch kein andere Code gesetzt wurde
                if (b.Text == "EINGABE" && Convert.ToInt32(anzeige.Text) >= 1 && codeGesetzt == false)
                {
                    gesetzterCode = Convert.ToInt32(anzeige.Text);
                    anzeige.Text = "Code gesetzt";
                    codeGesetzt = true;
                    zuruecksetzenDisplay = true;
                    // Tresortüre schliessen (rot)
                    oeffnenSchliessen(false);
                    ControlBox = true;
                }
                // Nachricht ausgeben, wenn ein ungültiger Code mit "0/00/000" gesetzt wird
                else if (b.Text != "C" && Convert.ToInt32(anzeige.Text) <= 0)
                {
                    anzeige.Text = "Ungültig";
                    zuruecksetzenDisplay = true;
                }
                // Überprüfen, ob schon ein Code gesetzt wurde und entsprechende Nachricht ausgeben
                else if (b.Text == "EINGABE" && codeGesetzt == true)
                {
                    anzeige.Text = "Alter Code aktiv";
                    zuruecksetzenDisplay = true;
                }
                // Wenn "C" betätigt wird, soll das Display auf 0000 zurückgesetzt werden
                else if (b.Text == "C")
                {
                    // Eingegebene Zahlen zurücksetzen
                    eingegebenerCode = default(int);
                    // Display auf 0000 zurücksetzen
                    anzeige.Clear();
                    anzeige.Text = "0000";
                    zuruecksetzenDisplay = true;
                }
            }
            // Versuch einen string zu "SETZEN" abfangen
            catch (FormatException)
            {
                anzeige.Text = "Nicht erlaubt";
            }
        }

        // Event-Handler für den OEFFNEN Knopf
        private void oeffnen_Click(object sender, EventArgs e)
        {
            // Ausnahmebehandlung für das Abfangen falscher Manipulationen
            try
            {
                eingegebenerCode = Convert.ToInt32(anzeige.Text);
                {
                    // Prüfung ob Code übereinstimmt
                    if (codeGesetzt = true && eingegebenerCode == gesetzterCode && Convert.ToInt32(anzeige.Text) >= 1)
                    {
                        // Code Korrekt - Formular zurücksetzen
                        ZuruecksetzenFormular();
                    }
                    else
                    {
                        // Anzahl Fehlversuche
                        if (fehlversuche > 1)
                        {
                            // Sound bei 3 Fehlversuchen
                            if (soundsAn)
                            {
                                player.SoundLocation = @"C:\\Windows\\Media\\ir_end.wav";
                                player.Play();
                            }
                            // Pop-up wenn Alarm losgeht
                            MessageBox.Show("Zu viele Versuche. Der Tresor wird geschlossen", "ALARM", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            // Tresor nach 3 Fehlerversuchen schliessen, andere Instanzen bleiben geöffnet
                            Close();
                        }
                        // Sound und Nachricht ausgeben wenn der eingegebene Code nicht korrekt ist
                        // Anzahl Fehlversuche werden hochgezählt
                        else
                            if (soundsAn)
                        {
                            player.SoundLocation = @"C:\\Windows\\Media\\chord.wav";
                            player.Play();
                        }
                        anzeige.Text = "Code Inkorrekt";
                        codeGesetzt = true;
                        zuruecksetzenDisplay = true;
                        fehlversuche++;
                    }
                }
            }
            // Benutzerfreundliche Meldung bei falscher Eingabe
            catch (FormatException)
            {
                anzeige.Text = "Falsches Format";
            }
            // Generelle, benutzerfreundliche Ausgabe anderer Ausnahmen in Form einer Popupmeldung
            catch (Exception exception)
            {
                MessageBox.Show(anzeige.Text = exception.GetType() + ": " + exception.Message);
            }
        }

        // Click Event-Handler für den Hilfe-Knopf
        private void Hilfe_Click(object sender, EventArgs e)
        {
            if (codeGesetzt == true)
            {
                // Wenn ein Code gesetzt wurde, diesen im Display anzeigen
                anzeige.Text = Convert.ToString("Code ist: " + gesetzterCode);
                zuruecksetzenDisplay = true;
            }
            else
                // Im Display ausgeben, wenn noch kein Code gesetzt wurde
                anzeige.Text = "Kein Code";
            zuruecksetzenDisplay = true;
        }
        // Wenn die Autom. Öffnung Checkbox manipuliert wird wird, wird auch das Flag entsprechend gesetzt und aktiviert/deaktiviert damit die Funktion
        private void AutoOeffnen_CheckedChanged(object sender, EventArgs e)
        {
            if (AutoOeffnungCheckbox.Checked)
            {
                autoOeffnung = true;
            }
            else
                autoOeffnung = false;
        }// Wenn die Sounds Checkbox manipuliert wird wird, wird auch das Flag entsprechend gesetzt und aktiviert/deaktiviert damit die Funktion
        private void Sounds_CheckedChanged(object sender, EventArgs e)
        {
            if (SoundsCheckbox.Checked)
            {
                soundsAn = true;
            }
            else
                soundsAn = false;
        }
    }
}