using System.IO.Ports;

namespace gageDyne
{
    public partial class Form1 : Form
    {
        SerialPort port;
        List<string> sides;
        int i = 0;

        public Form1()
        {
            InitializeComponent();

            sides = new List<string>();

            // Find serial ports
            string[] theSerialPortNames = SerialPort.GetPortNames();
            listBoxPorts.DataSource = theSerialPortNames;
            comboBoxSides.DataSource = sides;

            if (listBoxPorts.Items.Count > 0)
            {
                buttonConnect.Enabled = true;
            }
        }

        /// <summary>
        /// Connect to device
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonConnect_Click(object sender, EventArgs e)
        {
            port.PortName = listBoxPorts?.SelectedItem?.ToString();
            port.Open();
            port.DataReceived += Port_DataReceived;
        }

        /// <summary>
        /// Incoming data
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <exception cref="NotImplementedException"></exception>
        private void Port_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            string g = e.ToString();
        }

        /// <summary>
        /// Save current measurement to selected side
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonRecord_Click(object sender, EventArgs e)
        {
            sides.Add(string.Format("{0}", i++));
            comboBoxSides.Refresh();
        }
    }
}
