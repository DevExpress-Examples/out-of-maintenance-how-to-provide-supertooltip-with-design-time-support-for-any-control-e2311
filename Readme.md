# How to provide SuperToolTip with design-time support for any control


<p>This example shows how to create a custom component that allows you to specify SuperTips for objects that don't provide the SuperTip property. All you need is to customize the Items collection of the helper class. This particular example illustrates how this solution can be used to provide SuperTips for the NavBarControl's items. However, you can use the same approach for any DevExpress control. All you need is to specify another type for the MyNavBarSuperToolTipHelperItem.Group property and modify the DefaultController_GetActiveObjectInfo method.</p>

<br/>


