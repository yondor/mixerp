﻿
using MixERP.Net.Core.Modules.Purchase.Resources;
using MixERP.Net.FrontEnd.Base;
using System;

namespace MixERP.Net.Core.Modules.Purchase.Entry
{
    public partial class DirectPurchase : MixERPUserControl
    {
        public override void OnControlLoad(object sender, EventArgs e)
        {
            DirectPurchaseControl.Text = Titles.DirectPurchase;
            base.OnControlLoad(sender, e);
        }
    }
}