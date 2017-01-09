namespace ExampleCsharp
{
    partial class FormExampleCsharp
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormExampleCsharp));
            this.cywControl = new ControlYourWay.CywControl();
            this.buttonSetDownloadRequestTimeout = new System.Windows.Forms.Button();
            this.textBoxDownloadRequestTimeout = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.checkBoxDiscoverable = new System.Windows.Forms.CheckBox();
            this.buttonDiscover = new System.Windows.Forms.Button();
            this.textBoxInstanceName = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.buttonSetInstanceName = new System.Windows.Forms.Button();
            this.labelBufferedAmount = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBoxToNetworks = new System.Windows.Forms.TextBox();
            this.labelSelectNetworkNames = new System.Windows.Forms.Label();
            this.textBoxToSessionIDs = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.radioButtonSelectedNetworks = new System.Windows.Forms.RadioButton();
            this.radioButtonSessionIDs = new System.Windows.Forms.RadioButton();
            this.radioButtonDefaultNetworks = new System.Windows.Forms.RadioButton();
            this.labelDownloadInfo = new System.Windows.Forms.Label();
            this.textBoxDataType = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.checkBoxEnableDebugMessages = new System.Windows.Forms.CheckBox();
            this.checkBoxUseEncryption = new System.Windows.Forms.CheckBox();
            this.checkBoxAddSendCount = new System.Windows.Forms.CheckBox();
            this.labelSendCount = new System.Windows.Forms.Label();
            this.buttonClearListbox = new System.Windows.Forms.Button();
            this.labelSessionID = new System.Windows.Forms.Label();
            this.listBoxMessages = new System.Windows.Forms.ListBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.labelRequestCount = new System.Windows.Forms.Label();
            this.buttonClearRec = new System.Windows.Forms.Button();
            this.label22 = new System.Windows.Forms.Label();
            this.textBoxRecData = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonSend = new System.Windows.Forms.Button();
            this.textBoxSendData = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.timerUpdateRequestCount = new System.Windows.Forms.Timer(this.components);
            this.checkBoxUseWebSockets = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cywControl
            // 
            this.cywControl.Discoverable = true;
            this.cywControl.DownloadRequestTimeout = 120;
            this.cywControl.EnableDebugMessages = false;
            this.cywControl.InstanceName = "cywCsWebInterface";
            this.cywControl.Location = new System.Drawing.Point(12, 12);
            this.cywControl.Name = "cywControl";
            this.cywControl.NetworkNames = ((System.Collections.Generic.List<string>)(resources.GetObject("cywControl.NetworkNames")));
            this.cywControl.NetworkPassword = "network password";
            this.cywControl.ShowControls = true;
            this.cywControl.Size = new System.Drawing.Size(141, 143);
            this.cywControl.TabIndex = 0;
            this.cywControl.UseEncryption = false;
            this.cywControl.UserName = "user name";
            this.cywControl.ConnectionStatus += new ControlYourWay.CywCloudInterface.connectionStatusDelegate(this.cywControl_ConnectionStatus);
            this.cywControl.DataReceived += new ControlYourWay.CywControl.byteArrayReceivedDelegate(this.cywControl_DataReceived);
            this.cywControl.DebugMessage += new ControlYourWay.CywCloudInterface.debugMessagesDelegate(this.cywControl_DebugMessage);
            this.cywControl.Error += new ControlYourWay.CywCloudInterface.errorDelegate(this.cywControl_Error);
            // 
            // buttonSetDownloadRequestTimeout
            // 
            this.buttonSetDownloadRequestTimeout.Location = new System.Drawing.Point(496, 289);
            this.buttonSetDownloadRequestTimeout.Name = "buttonSetDownloadRequestTimeout";
            this.buttonSetDownloadRequestTimeout.Size = new System.Drawing.Size(56, 24);
            this.buttonSetDownloadRequestTimeout.TabIndex = 154;
            this.buttonSetDownloadRequestTimeout.Text = "Set";
            this.buttonSetDownloadRequestTimeout.UseVisualStyleBackColor = true;
            this.buttonSetDownloadRequestTimeout.Click += new System.EventHandler(this.buttonSetDownloadRequestTimeout_Click);
            // 
            // textBoxDownloadRequestTimeout
            // 
            this.textBoxDownloadRequestTimeout.Location = new System.Drawing.Point(453, 292);
            this.textBoxDownloadRequestTimeout.Multiline = true;
            this.textBoxDownloadRequestTimeout.Name = "textBoxDownloadRequestTimeout";
            this.textBoxDownloadRequestTimeout.Size = new System.Drawing.Size(37, 20);
            this.textBoxDownloadRequestTimeout.TabIndex = 153;
            this.textBoxDownloadRequestTimeout.Text = "120";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(322, 295);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(133, 13);
            this.label11.TabIndex = 152;
            this.label11.Text = "Download request timeout:";
            // 
            // checkBoxDiscoverable
            // 
            this.checkBoxDiscoverable.AutoSize = true;
            this.checkBoxDiscoverable.Checked = true;
            this.checkBoxDiscoverable.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxDiscoverable.Location = new System.Drawing.Point(186, 95);
            this.checkBoxDiscoverable.Name = "checkBoxDiscoverable";
            this.checkBoxDiscoverable.Size = new System.Drawing.Size(88, 17);
            this.checkBoxDiscoverable.TabIndex = 151;
            this.checkBoxDiscoverable.Text = "Discoverable";
            this.checkBoxDiscoverable.UseVisualStyleBackColor = true;
            this.checkBoxDiscoverable.CheckedChanged += new System.EventHandler(this.checkBoxDiscoverable_CheckedChanged);
            // 
            // buttonDiscover
            // 
            this.buttonDiscover.Enabled = false;
            this.buttonDiscover.Location = new System.Drawing.Point(82, 290);
            this.buttonDiscover.Name = "buttonDiscover";
            this.buttonDiscover.Size = new System.Drawing.Size(93, 24);
            this.buttonDiscover.TabIndex = 150;
            this.buttonDiscover.Text = "Discover";
            this.buttonDiscover.UseVisualStyleBackColor = true;
            this.buttonDiscover.Click += new System.EventHandler(this.buttonDiscover_Click);
            // 
            // textBoxInstanceName
            // 
            this.textBoxInstanceName.Location = new System.Drawing.Point(182, 148);
            this.textBoxInstanceName.Multiline = true;
            this.textBoxInstanceName.Name = "textBoxInstanceName";
            this.textBoxInstanceName.Size = new System.Drawing.Size(144, 20);
            this.textBoxInstanceName.TabIndex = 149;
            this.textBoxInstanceName.Text = "cywCsWebInterface";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(179, 132);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(82, 13);
            this.label10.TabIndex = 148;
            this.label10.Text = "Instance Name:";
            // 
            // buttonSetInstanceName
            // 
            this.buttonSetInstanceName.Location = new System.Drawing.Point(182, 174);
            this.buttonSetInstanceName.Name = "buttonSetInstanceName";
            this.buttonSetInstanceName.Size = new System.Drawing.Size(142, 24);
            this.buttonSetInstanceName.TabIndex = 147;
            this.buttonSetInstanceName.Text = "Set Instance Name";
            this.buttonSetInstanceName.UseVisualStyleBackColor = true;
            this.buttonSetInstanceName.Click += new System.EventHandler(this.buttonSetInstanceName_Click);
            // 
            // labelBufferedAmount
            // 
            this.labelBufferedAmount.AutoSize = true;
            this.labelBufferedAmount.Location = new System.Drawing.Point(270, 46);
            this.labelBufferedAmount.Name = "labelBufferedAmount";
            this.labelBufferedAmount.Size = new System.Drawing.Size(23, 13);
            this.labelBufferedAmount.TabIndex = 146;
            this.labelBufferedAmount.Text = "null";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(183, 46);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(89, 13);
            this.label12.TabIndex = 145;
            this.label12.Text = "Buffered Amount:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBoxToNetworks);
            this.groupBox1.Controls.Add(this.labelSelectNetworkNames);
            this.groupBox1.Controls.Add(this.textBoxToSessionIDs);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.radioButtonSelectedNetworks);
            this.groupBox1.Controls.Add(this.radioButtonSessionIDs);
            this.groupBox1.Controls.Add(this.radioButtonDefaultNetworks);
            this.groupBox1.Location = new System.Drawing.Point(334, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(221, 275);
            this.groupBox1.TabIndex = 144;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Send to:";
            // 
            // textBoxToNetworks
            // 
            this.textBoxToNetworks.Enabled = false;
            this.textBoxToNetworks.Location = new System.Drawing.Point(9, 148);
            this.textBoxToNetworks.Multiline = true;
            this.textBoxToNetworks.Name = "textBoxToNetworks";
            this.textBoxToNetworks.Size = new System.Drawing.Size(205, 121);
            this.textBoxToNetworks.TabIndex = 109;
            this.textBoxToNetworks.Text = "network 1";
            // 
            // labelSelectNetworkNames
            // 
            this.labelSelectNetworkNames.AutoSize = true;
            this.labelSelectNetworkNames.Location = new System.Drawing.Point(6, 132);
            this.labelSelectNetworkNames.Name = "labelSelectNetworkNames";
            this.labelSelectNetworkNames.Size = new System.Drawing.Size(157, 13);
            this.labelSelectNetworkNames.TabIndex = 108;
            this.labelSelectNetworkNames.Text = "Set Network Names (1 per line):";
            // 
            // textBoxToSessionIDs
            // 
            this.textBoxToSessionIDs.Enabled = false;
            this.textBoxToSessionIDs.Location = new System.Drawing.Point(9, 109);
            this.textBoxToSessionIDs.Name = "textBoxToSessionIDs";
            this.textBoxToSessionIDs.Size = new System.Drawing.Size(205, 20);
            this.textBoxToSessionIDs.TabIndex = 107;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 93);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(208, 13);
            this.label8.TabIndex = 106;
            this.label8.Text = "Send to Session IDs (comma sparated list):";
            // 
            // radioButtonSelectedNetworks
            // 
            this.radioButtonSelectedNetworks.AutoSize = true;
            this.radioButtonSelectedNetworks.Location = new System.Drawing.Point(6, 65);
            this.radioButtonSelectedNetworks.Name = "radioButtonSelectedNetworks";
            this.radioButtonSelectedNetworks.Size = new System.Drawing.Size(115, 17);
            this.radioButtonSelectedNetworks.TabIndex = 2;
            this.radioButtonSelectedNetworks.Text = "Selected Networks";
            this.radioButtonSelectedNetworks.UseVisualStyleBackColor = true;
            this.radioButtonSelectedNetworks.CheckedChanged += new System.EventHandler(this.radioButtonsSendTo_CheckedChanged);
            // 
            // radioButtonSessionIDs
            // 
            this.radioButtonSessionIDs.AutoSize = true;
            this.radioButtonSessionIDs.Location = new System.Drawing.Point(6, 42);
            this.radioButtonSessionIDs.Name = "radioButtonSessionIDs";
            this.radioButtonSessionIDs.Size = new System.Drawing.Size(81, 17);
            this.radioButtonSessionIDs.TabIndex = 1;
            this.radioButtonSessionIDs.Text = "Session IDs";
            this.radioButtonSessionIDs.UseVisualStyleBackColor = true;
            this.radioButtonSessionIDs.CheckedChanged += new System.EventHandler(this.radioButtonsSendTo_CheckedChanged);
            // 
            // radioButtonDefaultNetworks
            // 
            this.radioButtonDefaultNetworks.AutoSize = true;
            this.radioButtonDefaultNetworks.Checked = true;
            this.radioButtonDefaultNetworks.Location = new System.Drawing.Point(6, 19);
            this.radioButtonDefaultNetworks.Name = "radioButtonDefaultNetworks";
            this.radioButtonDefaultNetworks.Size = new System.Drawing.Size(107, 17);
            this.radioButtonDefaultNetworks.TabIndex = 0;
            this.radioButtonDefaultNetworks.TabStop = true;
            this.radioButtonDefaultNetworks.Text = "Default Networks";
            this.radioButtonDefaultNetworks.UseVisualStyleBackColor = true;
            this.radioButtonDefaultNetworks.CheckedChanged += new System.EventHandler(this.radioButtonsSendTo_CheckedChanged);
            // 
            // labelDownloadInfo
            // 
            this.labelDownloadInfo.AutoSize = true;
            this.labelDownloadInfo.Location = new System.Drawing.Point(97, 445);
            this.labelDownloadInfo.Name = "labelDownloadInfo";
            this.labelDownloadInfo.Size = new System.Drawing.Size(48, 13);
            this.labelDownloadInfo.TabIndex = 143;
            this.labelDownloadInfo.Text = "Rec Info";
            // 
            // textBoxDataType
            // 
            this.textBoxDataType.Location = new System.Drawing.Point(15, 174);
            this.textBoxDataType.Multiline = true;
            this.textBoxDataType.Name = "textBoxDataType";
            this.textBoxDataType.Size = new System.Drawing.Size(144, 20);
            this.textBoxDataType.TabIndex = 142;
            this.textBoxDataType.Text = "test data";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 158);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(56, 13);
            this.label9.TabIndex = 141;
            this.label9.Text = "Data type:";
            // 
            // checkBoxEnableDebugMessages
            // 
            this.checkBoxEnableDebugMessages.AutoSize = true;
            this.checkBoxEnableDebugMessages.Location = new System.Drawing.Point(186, 79);
            this.checkBoxEnableDebugMessages.Name = "checkBoxEnableDebugMessages";
            this.checkBoxEnableDebugMessages.Size = new System.Drawing.Size(142, 17);
            this.checkBoxEnableDebugMessages.TabIndex = 140;
            this.checkBoxEnableDebugMessages.Text = "Enable debug messages";
            this.checkBoxEnableDebugMessages.UseVisualStyleBackColor = true;
            this.checkBoxEnableDebugMessages.CheckedChanged += new System.EventHandler(this.checkBoxEnableDebugMessages_CheckedChanged);
            // 
            // checkBoxUseEncryption
            // 
            this.checkBoxUseEncryption.AutoSize = true;
            this.checkBoxUseEncryption.Location = new System.Drawing.Point(186, 62);
            this.checkBoxUseEncryption.Name = "checkBoxUseEncryption";
            this.checkBoxUseEncryption.Size = new System.Drawing.Size(97, 17);
            this.checkBoxUseEncryption.TabIndex = 139;
            this.checkBoxUseEncryption.Text = "Use encryption";
            this.checkBoxUseEncryption.UseVisualStyleBackColor = true;
            this.checkBoxUseEncryption.CheckedChanged += new System.EventHandler(this.checkBoxUseEncryption_CheckedChanged);
            // 
            // checkBoxAddSendCount
            // 
            this.checkBoxAddSendCount.AutoSize = true;
            this.checkBoxAddSendCount.Checked = true;
            this.checkBoxAddSendCount.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxAddSendCount.Location = new System.Drawing.Point(181, 294);
            this.checkBoxAddSendCount.Name = "checkBoxAddSendCount";
            this.checkBoxAddSendCount.Size = new System.Drawing.Size(143, 17);
            this.checkBoxAddSendCount.TabIndex = 138;
            this.checkBoxAddSendCount.Text = "Add send count to String";
            this.checkBoxAddSendCount.UseVisualStyleBackColor = true;
            // 
            // labelSendCount
            // 
            this.labelSendCount.AutoSize = true;
            this.labelSendCount.Location = new System.Drawing.Point(270, 33);
            this.labelSendCount.Name = "labelSendCount";
            this.labelSendCount.Size = new System.Drawing.Size(23, 13);
            this.labelSendCount.TabIndex = 137;
            this.labelSendCount.Text = "null";
            // 
            // buttonClearListbox
            // 
            this.buttonClearListbox.Location = new System.Drawing.Point(15, 641);
            this.buttonClearListbox.Name = "buttonClearListbox";
            this.buttonClearListbox.Size = new System.Drawing.Size(61, 24);
            this.buttonClearListbox.TabIndex = 133;
            this.buttonClearListbox.Text = "Clear";
            this.buttonClearListbox.UseVisualStyleBackColor = true;
            this.buttonClearListbox.Click += new System.EventHandler(this.buttonClearListbox_Click);
            // 
            // labelSessionID
            // 
            this.labelSessionID.AutoSize = true;
            this.labelSessionID.Location = new System.Drawing.Point(270, 7);
            this.labelSessionID.Name = "labelSessionID";
            this.labelSessionID.Size = new System.Drawing.Size(23, 13);
            this.labelSessionID.TabIndex = 136;
            this.labelSessionID.Text = "null";
            // 
            // listBoxMessages
            // 
            this.listBoxMessages.FormattingEnabled = true;
            this.listBoxMessages.Location = new System.Drawing.Point(15, 488);
            this.listBoxMessages.Name = "listBoxMessages";
            this.listBoxMessages.Size = new System.Drawing.Size(540, 147);
            this.listBoxMessages.TabIndex = 132;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(183, 33);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 13);
            this.label7.TabIndex = 135;
            this.label7.Text = "Send Count:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(183, 20);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 13);
            this.label6.TabIndex = 134;
            this.label6.Text = "Request Count:";
            // 
            // labelRequestCount
            // 
            this.labelRequestCount.AutoSize = true;
            this.labelRequestCount.Location = new System.Drawing.Point(270, 20);
            this.labelRequestCount.Name = "labelRequestCount";
            this.labelRequestCount.Size = new System.Drawing.Size(23, 13);
            this.labelRequestCount.TabIndex = 131;
            this.labelRequestCount.Text = "null";
            // 
            // buttonClearRec
            // 
            this.buttonClearRec.Location = new System.Drawing.Point(15, 445);
            this.buttonClearRec.Name = "buttonClearRec";
            this.buttonClearRec.Size = new System.Drawing.Size(61, 24);
            this.buttonClearRec.TabIndex = 129;
            this.buttonClearRec.Text = "Clear";
            this.buttonClearRec.UseVisualStyleBackColor = true;
            this.buttonClearRec.Click += new System.EventHandler(this.buttonClearRec_Click);
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(183, 7);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(61, 13);
            this.label22.TabIndex = 130;
            this.label22.Text = "Session ID:";
            // 
            // textBoxRecData
            // 
            this.textBoxRecData.Location = new System.Drawing.Point(15, 356);
            this.textBoxRecData.Multiline = true;
            this.textBoxRecData.Name = "textBoxRecData";
            this.textBoxRecData.Size = new System.Drawing.Size(540, 83);
            this.textBoxRecData.TabIndex = 128;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 340);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 13);
            this.label4.TabIndex = 127;
            this.label4.Text = "Text received:";
            // 
            // buttonSend
            // 
            this.buttonSend.Enabled = false;
            this.buttonSend.Location = new System.Drawing.Point(15, 290);
            this.buttonSend.Name = "buttonSend";
            this.buttonSend.Size = new System.Drawing.Size(61, 24);
            this.buttonSend.TabIndex = 126;
            this.buttonSend.Text = "Send";
            this.buttonSend.UseVisualStyleBackColor = true;
            this.buttonSend.Click += new System.EventHandler(this.buttonSend_Click);
            // 
            // textBoxSendData
            // 
            this.textBoxSendData.Location = new System.Drawing.Point(15, 213);
            this.textBoxSendData.Multiline = true;
            this.textBoxSendData.Name = "textBoxSendData";
            this.textBoxSendData.Size = new System.Drawing.Size(313, 68);
            this.textBoxSendData.TabIndex = 125;
            this.textBoxSendData.Text = "test message";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 197);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 13);
            this.label3.TabIndex = 124;
            this.label3.Text = "Text to send:";
            // 
            // timerUpdateRequestCount
            // 
            this.timerUpdateRequestCount.Enabled = true;
            this.timerUpdateRequestCount.Interval = 1000;
            this.timerUpdateRequestCount.Tick += new System.EventHandler(this.timerUpdateRequestCount_Tick);
            // 
            // checkBoxUseWebSockets
            // 
            this.checkBoxUseWebSockets.AutoSize = true;
            this.checkBoxUseWebSockets.Checked = true;
            this.checkBoxUseWebSockets.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxUseWebSockets.Location = new System.Drawing.Point(186, 112);
            this.checkBoxUseWebSockets.Name = "checkBoxUseWebSockets";
            this.checkBoxUseWebSockets.Size = new System.Drawing.Size(105, 17);
            this.checkBoxUseWebSockets.TabIndex = 155;
            this.checkBoxUseWebSockets.Text = "Use WebSocket";
            this.checkBoxUseWebSockets.UseVisualStyleBackColor = true;
            this.checkBoxUseWebSockets.CheckedChanged += new System.EventHandler(this.checkBoxUseWebSockets_CheckedChanged);
            // 
            // FormExampleCsharp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(567, 674);
            this.Controls.Add(this.checkBoxUseWebSockets);
            this.Controls.Add(this.buttonSetDownloadRequestTimeout);
            this.Controls.Add(this.textBoxDownloadRequestTimeout);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.checkBoxDiscoverable);
            this.Controls.Add(this.buttonDiscover);
            this.Controls.Add(this.textBoxInstanceName);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.buttonSetInstanceName);
            this.Controls.Add(this.labelBufferedAmount);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.labelDownloadInfo);
            this.Controls.Add(this.textBoxDataType);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.checkBoxEnableDebugMessages);
            this.Controls.Add(this.checkBoxUseEncryption);
            this.Controls.Add(this.checkBoxAddSendCount);
            this.Controls.Add(this.labelSendCount);
            this.Controls.Add(this.buttonClearListbox);
            this.Controls.Add(this.labelSessionID);
            this.Controls.Add(this.listBoxMessages);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.labelRequestCount);
            this.Controls.Add(this.buttonClearRec);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.textBoxRecData);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.buttonSend);
            this.Controls.Add(this.textBoxSendData);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cywControl);
            this.Name = "FormExampleCsharp";
            this.Text = "C# Example";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ControlYourWay.CywControl cywControl;
        private System.Windows.Forms.Button buttonSetDownloadRequestTimeout;
        private System.Windows.Forms.TextBox textBoxDownloadRequestTimeout;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.CheckBox checkBoxDiscoverable;
        private System.Windows.Forms.Button buttonDiscover;
        private System.Windows.Forms.TextBox textBoxInstanceName;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button buttonSetInstanceName;
        private System.Windows.Forms.Label labelBufferedAmount;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label labelSelectNetworkNames;
        private System.Windows.Forms.TextBox textBoxToSessionIDs;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.RadioButton radioButtonSelectedNetworks;
        private System.Windows.Forms.RadioButton radioButtonSessionIDs;
        private System.Windows.Forms.RadioButton radioButtonDefaultNetworks;
        private System.Windows.Forms.Label labelDownloadInfo;
        private System.Windows.Forms.TextBox textBoxDataType;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.CheckBox checkBoxEnableDebugMessages;
        private System.Windows.Forms.CheckBox checkBoxUseEncryption;
        private System.Windows.Forms.CheckBox checkBoxAddSendCount;
        private System.Windows.Forms.Label labelSendCount;
        private System.Windows.Forms.Button buttonClearListbox;
        private System.Windows.Forms.Label labelSessionID;
        private System.Windows.Forms.ListBox listBoxMessages;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label labelRequestCount;
        private System.Windows.Forms.Button buttonClearRec;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.TextBox textBoxRecData;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonSend;
        private System.Windows.Forms.TextBox textBoxSendData;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Timer timerUpdateRequestCount;
        private System.Windows.Forms.TextBox textBoxToNetworks;
        private System.Windows.Forms.CheckBox checkBoxUseWebSockets;
    }
}

