using ControlYourWay;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExampleCsharp
{
    public partial class FormExampleCsharp : Form
    {
        private List<string> discoveredNames;
        private List<int> discoveredSessionIDs;

        public FormExampleCsharp()
        {
            InitializeComponent();
        }

        private void cywControl_ConnectionStatus(object sender, bool connected)
        {
            if (connected)
            {
                AddLineToListbox("Connection successful", "Connection Status");
                buttonSend.Enabled = true;
                buttonDiscover.Enabled = true;
                labelSessionID.Text = cywControl.SessionId.ToString();
            }
            else
            {
                //there was an error - get error message
                AddLineToListbox("Connection stopped", "Connection Status");
                buttonSend.Enabled = false;
                buttonDiscover.Enabled = false;
            }
        }

        //add a line to the messages list box and move to the end so the last message is always visible
        private void AddLineToListbox(string text, string fromEvent)
        {
            StringBuilder sb = new StringBuilder()
                .Append(fromEvent)
                .Append(" - ")
                .Append(text);
            listBoxMessages.Items.Add(sb.ToString());
            listBoxMessages.SelectedIndex = listBoxMessages.Items.Count - 1;
        }

        private void cywControl_DataReceived(object sender, byte[] data, string dataType, int fromSessionID)
        {
            if (cywControl.Discoverable && (dataType == "Discovery Response"))
            {
                string discoveredName = CywCloudInterface.ConvertByteArrayToString(data);
                discoveredNames.Add(discoveredName);
                discoveredSessionIDs.Add(fromSessionID);
                AddLineToListbox("Name: " + discoveredName + " session ID: " + fromSessionID.ToString(), "Device discovered");
            }
            else
            {
                //data was received
                AddLineToListbox("Data received, size: " + data.Length.ToString() + " bytes", "Data Received");
                string dataStr = CywCloudInterface.ConvertByteArrayToString(data);
                AddLineToListbox(dataStr, "Data Received");
                textBoxRecData.Text = textBoxRecData.Text + dataStr;
                labelDownloadInfo.Text = "Last Message Type: " + dataType + ", from session ID: " + fromSessionID.ToString();
            }
        }

        private void cywControl_DebugMessage(object sender, string message)
        {
            AddLineToListbox(message, "Debug Message");
        }

        private void cywControl_Error(object sender, string errorCode)
        {
            AddLineToListbox(errorCode, "Error");
        }

        private void checkBoxUseEncryption_CheckedChanged(object sender, EventArgs e)
        {
            cywControl.UseEncryption = checkBoxUseEncryption.Checked;
        }

        //timer event to periodically update the counters
        private void timerUpdateRequestCount_Tick(object sender, EventArgs e)
        {
            cywCounters counters = cywControl.GetCounters();
            labelRequestCount.Text = counters.downloadCount.ToString();
            labelBufferedAmount.Text = cywControl.GetBufferedAmount().ToString();
        }

        private void checkBoxEnableDebugMessages_CheckedChanged(object sender, EventArgs e)
        {
            cywControl.EnableDebugMessages = checkBoxEnableDebugMessages.Checked;
        }

        private void checkBoxDiscoverable_CheckedChanged(object sender, EventArgs e)
        {
            cywControl.Discoverable = checkBoxDiscoverable.Checked;
        }

        //set the name other devices will see when this instance responds to a discovery message
        private void buttonSetInstanceName_Click(object sender, EventArgs e)
        {
            cywControl.InstanceName = textBoxInstanceName.Text;
        }

        private void buttonSend_Click(object sender, EventArgs e)
        {
            bool error = false;
            StringBuilder sendStr = new StringBuilder(textBoxSendData.Text);
            cywCounters counters = cywControl.GetCounters();

            if (checkBoxAddSendCount.Checked)
            {
                sendStr.Append(counters.uploadCount.ToString());
            }
            CywDataToSend sendData = new CywDataToSend();

            //check which option is selected for sending data to
            if (radioButtonSelectedNetworks.Checked)
            {
                //when this option is selected then the message will be sent to the all the devices which are listening to the selected networks
                using (StringReader sr = new StringReader(textBoxToNetworks.Text))
                {
                    string line;
                    while ((line = sr.ReadLine()) != null) //split textbox text into lines
                    {
                        sendData.toNetworks.Add(line);
                    }
                }
                if (sendData.toNetworks.Count == 0)
                {
                    //when this option is selected then at least one network needs to be selected
                    MessageBox.Show("Please select at least one network", "No networks selected", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    error = true;
                }
            }
            else if (radioButtonSessionIDs.Checked)
            {
                //when this option is selected then the message will only be sent to the session IDs entered
                if (textBoxToSessionIDs.Text != "")
                {
                    string[] parts = textBoxToSessionIDs.Text.Split(',');
                    for (int i = 0; i < parts.Length; i++)
                    {
                        int sessionId;
                        bool success;
                        success = int.TryParse(parts[i], out sessionId);
                        if (success)
                        {
                            sendData.toSessionIDs.Add(sessionId);
                        }
                        else
                        {
                            MessageBox.Show("Error parsing session IDs. Please make sure that you have a comma delimited list of numbers.", "Session ID error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            error = true;
                        }
                    }
                }
                if (sendData.toSessionIDs.Count == 0)
                {
                    //when this option is selected then at least one session ID needs to be entered
                    MessageBox.Show("Please enter at least one session ID", "No session IDs", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    error = true;
                }
            }

            if (!error)
            {
                sendData.ConvertStringForSending(sendStr.ToString());
                sendData.dataType = textBoxDataType.Text;
                int errorCode = cywControl.SendData(sendData);  //--------->send data
                if (errorCode == 0)
                {
                    //data sent
                    labelSendCount.Text = counters.uploadCount.ToString();
                }
                else
                {
                    AddLineToListbox("Send error: " + errorCode.ToString() + " " + cywControl.GetErrorCodeDescription(errorCode.ToString()), "Send Data");
                }
            }
        }

        private List<string> GetNetworks()
        {
            List<string> networks = new List<string>();

            using (StringReader sr = new StringReader(textBoxToNetworks.Text))
            {
                string line;
                while ((line = sr.ReadLine()) != null) //split textbox text into lines
                {
                    networks.Add(line);
                }
            }
            return networks;
        }

        private void buttonDiscover_Click(object sender, EventArgs e)
        {
            discoveredNames = new List<string>();
            discoveredSessionIDs = new List<int>();
            
            if (radioButtonDefaultNetworks.Checked)
            {
                //send discovery to selected networks
                cywControl.SendDiscovery(GetNetworks());
            }
            else
            {
                //send discovery to default networks
                cywControl.SendDiscovery();
            }
        }

        private void buttonSetDownloadRequestTimeout_Click(object sender, EventArgs e)
        {
            cywControl.DownloadRequestTimeout = int.Parse(textBoxDownloadRequestTimeout.Text);
        }

        private void buttonClearRec_Click(object sender, EventArgs e)
        {
            textBoxRecData.Text = "";
        }

        private void buttonClearListbox_Click(object sender, EventArgs e)
        {
            listBoxMessages.Items.Clear();
        }

        private void radioButtonsSendTo_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rb = (RadioButton)sender;
            switch (rb.Name)
            {
                case "radioButtonDefaultNetworks":
                    textBoxToSessionIDs.Enabled = false;
                    textBoxToNetworks.Enabled = false;
                    break;
                case "radioButtonSessionIDs":
                    textBoxToSessionIDs.Enabled = true;
                    textBoxToNetworks.Enabled = false;
                    break;
                case "radioButtonSelectedNetworks":
                    textBoxToSessionIDs.Enabled = false;
                    textBoxToNetworks.Enabled = true;
                    break;
            }
        }

        private void checkBoxUseWebSockets_CheckedChanged(object sender, EventArgs e)
        {
            cywControl.UseWebsocket = checkBoxUseWebSockets.Checked;
        }
    }
}
