using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraNavBar;
using DevExpress.Utils;
using System.Drawing.Design;
using System.Collections;

namespace E2311
{
    public class MyNavBarSuperToolTipHelperItem
    {
        private SuperToolTip _SuperTip;
        [Localizable(true)]
        [Description("Gets or sets a SuperToolTip for the current control.")]
        [Editor("DevExpress.XtraEditors.Design.ToolTipContainerUITypeEditor, " + AssemblyInfo.SRAssemblyEditorsDesign, typeof(UITypeEditor))]
        public SuperToolTip SuperTip
        {
            get { return _SuperTip; }
            set { _SuperTip = value; }
        }

        private NavBarGroup _Group;
        public NavBarGroup Group
        {
            get { return _Group; }
            set { _Group = value; }
        }

        public MyNavBarSuperToolTipHelperItem()
        {

        }
    }

}
