using System;
using System.Collections.Generic;
using System.Threading;
using System.Windows.Forms;


namespace KeySender
{
    public partial class AppForm : Form
    {
        //Available keys//
        private readonly string[] basic_keys = {"q","w","e","r","t","y","u","i","o"};
        //Available windows//
        public string[] wndNames = WndsGetter.getWndNames();
        public IDictionary<IntPtr, string> allWnds = WndsGetter.GetOpenWindows();
        //Current key//
        public Keys key;
        //Current hWnd//
        public IntPtr hashWnd;
        //Key sending handler//
        private SendHandler sendingKeys;

        public AppForm()
        {
            //Init//
            InitializeComponent();
            wndslistbox.Items.AddRange(wndNames);
        }

        private void AppForm_Load(object sender, EventArgs e)
        {
            //Load Form//
            keylistbox.Items.AddRange(basic_keys);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Start Button//
            Enum.TryParse(keylistbox.GetItemText(keylistbox.SelectedItem).ToUpper(), out key);
            foreach (object item in wndslistbox.CheckedItems) //foreach in windows checked items
            {
                foreach(KeyValuePair<IntPtr, string> wnd in allWnds) //foreach in all windows
                {
                    if (wnd.Value == item.ToString()) 
                    {
                        hashWnd = wnd.Key;
                        break;
                    }
                }
            }
            currentStatus.Text = $"Sending {key}";
            KeySendStart(); //Start sending thread
        }

        private void KeySendStart() 
        {
            //Sending thread starter
            if (key != Keys.None & hashWnd != (IntPtr)0)
            {
                sendingKeys = new SendHandler(hashWnd, key);
                Thread startSending = new Thread(() => sendingKeys.runKeysender());
                startSending.Start();
            }
            else 
            {
                currentStatus.Text = "No key.";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //Stop Button//
            sendingKeys.StopSending();
        }

        private void refBtn_Click(object sender, EventArgs e)
        {
            //Refresh button//
            wndslistbox.Items.Clear();
            wndNames = WndsGetter.getWndNames();
            wndslistbox.Items.AddRange(wndNames);
        }

        private void wndslistbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            //More than 2 => Disable selection//
            if (wndslistbox.CheckedItems.Count > 1)
            {
                for (int i = 0; i < wndslistbox.Items.Count; i++)
                    wndslistbox.SetItemChecked(i, false);
                wndslistbox.SetItemChecked(wndslistbox.SelectedIndex, true);
            }
        }
    }
}