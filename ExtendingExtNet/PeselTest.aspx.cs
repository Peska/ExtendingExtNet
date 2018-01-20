using Ext.Net;
using System;
using System.Web.UI;

namespace ExtendingExtNet
{
    public partial class PeselTest : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        { }

        protected void Submit_Click(object sender, DirectEventArgs e)
        {
            X.Msg.Show(new MessageBoxConfig() { Title = "Info", Message = pesel.AutoFilledValue });
        }
    }
}