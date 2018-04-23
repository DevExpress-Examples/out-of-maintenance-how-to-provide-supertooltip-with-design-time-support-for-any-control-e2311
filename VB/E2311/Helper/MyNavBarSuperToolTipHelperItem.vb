Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports DevExpress.XtraNavBar
Imports DevExpress.Utils
Imports System.Drawing.Design
Imports System.Collections

Namespace E2311
	Public Class MyNavBarSuperToolTipHelperItem
		Private _SuperTip As SuperToolTip
        <Localizable(True), Description("Gets or sets a SuperToolTip for the current control."), Editor("DevExpress.XtraEditors.Design.ToolTipContainerUITypeEditor, " + AssemblyInfo.SRAssemblyEditorsDesign, GetType(UITypeEditor))> _
  Public Property SuperTip() As SuperToolTip
            Get
                Return _SuperTip
            End Get
            Set(ByVal value As SuperToolTip)
                _SuperTip = value
            End Set
        End Property

		Private _Group As NavBarGroup
		Public Property Group() As NavBarGroup
			Get
				Return _Group
			End Get
			Set(ByVal value As NavBarGroup)
				_Group = value
			End Set
		End Property

		Public Sub New()

		End Sub
	End Class

End Namespace
