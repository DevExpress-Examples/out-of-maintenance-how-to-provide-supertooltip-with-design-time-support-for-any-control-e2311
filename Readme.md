<!-- default file list -->
*Files to look at*:

* [Form1.cs](./CS/E2311/Form1.cs) (VB: [Form1.vb](./VB/E2311/Form1.vb))
* [MyNavBarSuperTipHelper.cs](./CS/E2311/Helper/MyNavBarSuperTipHelper.cs) (VB: [MyNavBarSuperTipHelper.vb](./VB/E2311/Helper/MyNavBarSuperTipHelper.vb))
* [MyNavBarSuperToolTipHelperItem.cs](./CS/E2311/Helper/MyNavBarSuperToolTipHelperItem.cs) (VB: [MyNavBarSuperToolTipHelperItem.vb](./VB/E2311/Helper/MyNavBarSuperToolTipHelperItem.vb))
* [MyNavBarSuperToolTipItemsCollection.cs](./CS/E2311/Helper/MyNavBarSuperToolTipItemsCollection.cs) (VB: [MyNavBarSuperToolTipItemsCollection.vb](./VB/E2311/Helper/MyNavBarSuperToolTipItemsCollection.vb))
* [Program.cs](./CS/E2311/Program.cs) (VB: [Program.vb](./VB/E2311/Program.vb))
<!-- default file list end -->
# How to provide SuperToolTip with design-time support for any control


<p>This example shows how to create a custom component that allows you to specify SuperTips for objects that don't provide the SuperTip property. All you need is to customize the Items collection of the helper class. This particular example illustrates how this solution can be used to provide SuperTips for the NavBarControl's items. However, you can use the same approach for any DevExpress control. All you need is to specify another type for the MyNavBarSuperToolTipHelperItem.Group property and modify the DefaultController_GetActiveObjectInfo method.</p>

<br/>


