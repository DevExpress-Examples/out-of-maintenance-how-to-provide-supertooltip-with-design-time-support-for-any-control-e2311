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

namespace E2311
{
    public class MyNavBarSuperTipHelper : Component
    {

        public MyNavBarSuperTipHelper()
        {
            _Items = new MyNavBarSuperToolTipItemsCollection();
            ToolTipController.DefaultController.GetActiveObjectInfo += DefaultController_GetActiveObjectInfo;
        }

        void DefaultController_GetActiveObjectInfo(object sender, ToolTipControllerGetActiveObjectInfoEventArgs e)
        {
            NavBarControl navBar = e.SelectedControl as NavBarControl;
            if (navBar != null)
            {
                NavBarHitInfo hi = navBar.CalcHitInfo(e.ControlMousePosition);

                if (hi.InLink)
                {
                    SuperToolTip superTip = new SuperToolTip();
                    SuperToolTipSetupArgs args = new SuperToolTipSetupArgs();
                    args.Title.Text = hi.Link.Caption;
                    superTip.Setup(args);
                    e.Info.SuperTip = superTip;
                }
                else
                    if (hi.InGroup)
                    {
                        SuperToolTip superTip = GetSuperTipByGroup(hi.Group);
                        {
                            if (e.Info == null)
                                e.Info = new ToolTipControlInfo(e.SelectedControl, "");
                            e.Info.ToolTipType = ToolTipType.SuperTip;
                            e.Info.SuperTip = superTip;
                        }

                    }
            }
        }

        public SuperToolTip GetSuperTipByGroup(NavBarGroup group)
        {
            if (group == null) return null;
            foreach (MyNavBarSuperToolTipHelperItem item in Items)
            {
                if (item.Group == group) return item.SuperTip;
            }
            return null;
        }

        private MyNavBarSuperToolTipItemsCollection _Items;

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public MyNavBarSuperToolTipItemsCollection Items
        {
            get { return _Items; }
            set { _Items = value; }
        }

        protected override void Dispose(bool disposing)
        {
            ToolTipController.DefaultController.GetActiveObjectInfo -= DefaultController_GetActiveObjectInfo;
            base.Dispose(disposing);
        }
    }
}
