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

Namespace E2311
	Public Class MyNavBarSuperTipHelper
		Inherits Component

		Public Sub New()
			_Items = New MyNavBarSuperToolTipItemsCollection()
			AddHandler ToolTipController.DefaultController.GetActiveObjectInfo, AddressOf DefaultController_GetActiveObjectInfo
		End Sub

		Private Sub DefaultController_GetActiveObjectInfo(ByVal sender As Object, ByVal e As ToolTipControllerGetActiveObjectInfoEventArgs)
			Dim navBar As NavBarControl = TryCast(e.SelectedControl, NavBarControl)
			If navBar IsNot Nothing Then
				Dim hi As NavBarHitInfo = navBar.CalcHitInfo(e.ControlMousePosition)

				If hi.InLink Then
					Dim superTip As New SuperToolTip()
					Dim args As New SuperToolTipSetupArgs()
					args.Title.Text = hi.Link.Caption
					superTip.Setup(args)
					e.Info.SuperTip = superTip
				Else
					If hi.InGroup Then
						Dim superTip As SuperToolTip = GetSuperTipByGroup(hi.Group)
							If e.Info Is Nothing Then
								e.Info = New ToolTipControlInfo(e.SelectedControl, "")
							End If
							e.Info.ToolTipType = ToolTipType.SuperTip
							e.Info.SuperTip = superTip

					End If
				End If
			End If
		End Sub

		Public Function GetSuperTipByGroup(ByVal group As NavBarGroup) As SuperToolTip
			If group Is Nothing Then
				Return Nothing
			End If
			For Each item As MyNavBarSuperToolTipHelperItem In Items
				If item.Group Is group Then
					Return item.SuperTip
				End If
			Next item
			Return Nothing
		End Function

		Private _Items As MyNavBarSuperToolTipItemsCollection

		<DesignerSerializationVisibility(DesignerSerializationVisibility.Content)> _
		Public Property Items() As MyNavBarSuperToolTipItemsCollection
			Get
				Return _Items
			End Get
			Set(ByVal value As MyNavBarSuperToolTipItemsCollection)
				_Items = value
			End Set
		End Property

		Protected Overrides Overloads Sub Dispose(ByVal disposing As Boolean)
			RemoveHandler ToolTipController.DefaultController.GetActiveObjectInfo, AddressOf DefaultController_GetActiveObjectInfo
			MyBase.Dispose(disposing)
		End Sub
	End Class
End Namespace
