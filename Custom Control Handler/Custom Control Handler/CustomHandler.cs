using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Custom_Control_Handler
{
    public class CustomHandler
    {
        private int num;
        private Button subject;

        public CustomHandler(Button subject, int num)
        {
            this.num = num;
            this.subject = subject;

            subject.Click += new EventHandler(CustomEventHandlerMethod);
        }

        public void CustomEventHandlerMethod(object o, EventArgs e)
        {
            string message = "";
            message += "This is a custom handler.\n";
            message += "My code number is " + num + ".\n";
            message += "My Button that triggered me is " + subject.Name;
            MessageBox.Show(message);

        }

    }
}
