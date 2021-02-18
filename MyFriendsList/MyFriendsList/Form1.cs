using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyFriendsList
{
    public partial class Form1 : Form
    {
        List<String> myFriends = new List<String>();
        BindingSource bs = new BindingSource();

        public Form1()
        {
            InitializeComponent();
            bs.DataSource = myFriends;
        }

        private void btn_addFriend_Click(object sender, EventArgs e)
        {
            myFriends.Add(txt_newFriend.Text);
            listBox1.DataSource = bs;
            bs.ResetBindings(false);
            label1.Text = "There are " + myFriends.Count + " people in the list";
        }

        private void btn_addFive_Click(object sender, EventArgs e)
        {
            myFriends.Add("Steven");
            myFriends.Add("Vicki");
            myFriends.Add("Manuel");
            myFriends.Add("Hanna");
            myFriends.Add("Lorenzo");
            // listBox1.DataSource = bs;
            bs.ResetBindings(false);
            label1.Text = "There are " + myFriends.Count + " people in the list";
        }

        private void btn_sortA_Click(object sender, EventArgs e)
        {
            myFriends.Sort();
            bs.ResetBindings(false);
        }

        private void btn_sortD_Click(object sender, EventArgs e)
        {
            myFriends.Sort();
            myFriends.Reverse();
            bs.ResetBindings(false);
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            myFriends.Clear();
            txt_newFriend.Clear();
            bs.ResetBindings(false);
            label1.Text = "";
        }
    }
}
