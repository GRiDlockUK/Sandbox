using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CompareListWeb
{
    public partial class _Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ButtonSwap_Click(object sender, EventArgs e)
        {
            //declarations
            
            string[] split;
            int[] want;
            int[] swap;

            // check ME swaps

            split = textBoxMeWant.Text.Split(',');
            want = new int[split.Length];
            for (int i = 0; i < split.Length; i++)
                want[i] = Convert.ToInt32(split[i].Trim());

            split = textBoxFriendSwap.Text.Split(',');
            swap = new int[split.Length];
            for (int i = 0; i < split.Length; i++)
                swap[i] = Convert.ToInt32(split[i].Trim());

            Array.Sort(swap);
            Array.Sort(want);

            textBoxMe.Text = "";
            foreach (int i in swap)
                if (Array.IndexOf(want, i) > -1)
                    textBoxMe.Text = textBoxMe.Text + i.ToString() + " ";

            // check FRIEND swaps

            split = textBoxFriendWant.Text.Split(',');
            want = new int[split.Length];
            for (int i = 0; i < split.Length; i++)
                want[i] = Convert.ToInt32(split[i].Trim());

            split = textBoxMeSwap.Text.Split(',');
            swap = new int[split.Length];
            for (int i = 0; i < split.Length; i++)
                swap[i] = Convert.ToInt32(split[i].Trim());

            Array.Sort(swap);
            Array.Sort(want);

            textBoxFriend.Text = "";
            foreach (int i in swap)
                if (Array.IndexOf(want, i) > -1)
                    textBoxFriend.Text = textBoxFriend.Text + i.ToString() + " ";
	
        }
    }
}