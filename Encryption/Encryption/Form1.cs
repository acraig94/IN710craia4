using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Encryption
{
    public partial class Form1 : Form
    {
        public enum EEncryptionType {ROT17, StringReverse};

        public Form1()
        {
            InitializeComponent();
        }

        private void bttnEncrpyt_Click(object sender, EventArgs e)
        {
            string input = tbInput.Text.ToString();
            string output = "";
            string selectedEncryption = getCheckedRdo();
            EEncryptionType encryptionType = (EEncryptionType)Enum.Parse(typeof(EEncryptionType), selectedEncryption);

            switch (encryptionType)
            {
                case EEncryptionType.ROT17:
                    Rot17Parser rot17Machine = new Rot17Parser();
                    output = rot17Machine.encrypt(input);
                    break;
                case EEncryptionType.StringReverse:
                    StringReverseParser StrReverseMachine = new StringReverseParser();
                    output = StrReverseMachine.encrypt(input);
                    break;
                default:
                    output = null;
                    break;
            }
            if (output != null)
            {
                tbOutput.Text = output;
            }

        }

        private string getCheckedRdo()
        {            
            String encryptionType = "ROT17";            
            foreach (RadioButton rdo in groupBox1.Controls)
            {
                if (rdo.Checked)
                {                   
                    encryptionType = rdo.Name.Substring(3);
                }
            }
            return encryptionType;
        }

        private void bttnDecrypt_Click(object sender, EventArgs e)
        {
            string input = tbInput.Text.ToString();
            string output = "";
            string selectedEncryption = getCheckedRdo();
            EEncryptionType encryptionType = (EEncryptionType)Enum.Parse(typeof(EEncryptionType), selectedEncryption);

            switch (encryptionType)
            {
                case EEncryptionType.ROT17:
                    Rot17Parser rot17Machine = new Rot17Parser();
                    output = rot17Machine.decrypt(input);
                    break;
                case EEncryptionType.StringReverse:
                    StringReverseParser StrReverseMachine = new StringReverseParser();
                    output = StrReverseMachine.decrypt(input);
                    break;
                default:
                    output = null;
                    break;
            }
            if (output != null)
            {
                tbOutput.Text = output;
            }
        }
    }
}
