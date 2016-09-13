using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace Enigma.Simulator
{
    public partial class EnigmaForm : Form
    {
        private EnigmaSim.Components.Rotor.StandardRotorCollection availablRotors = 
            new EnigmaSim.Components.Rotor.StandardRotorCollection();
        private EnigmaSim.Components.Reflector.ReflectorCollection availableReflectors =
            new EnigmaSim.Components.Reflector.ReflectorCollection();

        public EnigmaForm()
        {
            InitializeComponent();
            string[] startPos = new string[] {"A", "B", "C", "D", "E", "F",
                "G", "H", "I", "J", "K",
                "L", "M", "N", "O", "P",
                "Q", "R", "S", "T", "U",
                "V", "W", "X", "Y", "Z"};
            fastStart.Items.AddRange(startPos);
            middleStart.Items.AddRange(startPos);
            slowStart.Items.AddRange(startPos);
            fastStart.SelectedIndex = 0;
            middleStart.SelectedIndex = 0;
            slowStart.SelectedIndex = 0;

            foreach (EnigmaSim.Components.Rotor.BaseRotor rotor in availablRotors)
            {
                fastName.Items.Add(rotor.Name);
                middleName.Items.Add(rotor.Name);
                slowName.Items.Add(rotor.Name);
            }

            foreach (EnigmaSim.Components.Reflector.BaseReflector reflector in availableReflectors)
            {
                reflectorName.Items.Add(reflector.Name);
            }

            fastName.SelectedIndex = 2;
            middleName.SelectedIndex = 1;
            slowName.SelectedIndex = 0;
            reflectorName.SelectedIndex = 0;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private EnigmaSim.Model.IEnigma engine = null;

        private EnigmaSim.Components.Rotor.BaseRotor Rotor(string name)
        {
            var rotor = (from r in engine.Rotors
                        where r.Name == name
                        select r).First();
            return rotor;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (engine == null)
            {
                MessageBox.Show("The rotors have not been sent");
            }
            else
            {
                string text = engine.DecipherString(inputText.Text.ToUpper());
                outputText.Text = text;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            engine = new EnigmaSim.EnigmaEngine.Basic3Wheel(fastName.Text, middleName.Text, slowName.Text, reflectorName.Text);
            Rotor(fastName.Text).SetWheelOffset(fastStart.Text[0]);
            Rotor(middleName.Text).SetWheelOffset(middleStart.Text[0]);
            Rotor(slowName.Text).SetWheelOffset(slowStart.Text[0]);
        }
    }
}
