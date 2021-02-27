using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Runtime.CompilerServices;

namespace GetWebPage
{
    public partial class txtWebCode : Form
    {
        public txtWebCode()
        { 
            InitializeComponent();
        }

        private void txtWebCode_Load(object sender, EventArgs e)
        {
            WebClient client = new WebClient();
            String strPageCode = client.DownloadString("http://wccs.school");
        }
    }
}
