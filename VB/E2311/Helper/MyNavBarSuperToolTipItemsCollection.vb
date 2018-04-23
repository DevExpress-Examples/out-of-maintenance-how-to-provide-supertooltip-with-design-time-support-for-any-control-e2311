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
Imports DevExpress.XtraEditors.Controls
Imports DevExpress.XtraEditors.Repository

Namespace E2311
	Public Class MyNavBarSuperToolTipItemsCollection
		Inherits CollectionBase
		Private lockUpdate As Integer
		Private indexes_Renamed As Hashtable
		Public Event CollectionChanged As CollectionChangeEventHandler
		Public Sub New()
			Me.indexes_Renamed = New Hashtable()
			Me.lockUpdate = 0
		End Sub


		Protected Overridable Function CreateComparer() As IComparer
			Return New DevExpress.Data.ValueComparer()
		End Function

		<Description("Gets or sets an item at the specified position.")> _
		Default Public Property Item(ByVal index As Integer) As MyNavBarSuperToolTipHelperItem
			Get
				Return TryCast(List(index), MyNavBarSuperToolTipHelperItem)
			End Get
			Set(ByVal value As MyNavBarSuperToolTipHelperItem)
				List(index) = value
			End Set
		End Property
		Protected Overridable ReadOnly Property Indexes() As Hashtable
			Get
				Return indexes_Renamed
			End Get
		End Property
		Public Overridable Sub BeginUpdate()
			lockUpdate += 1
		End Sub
		Public Overridable Sub EndUpdate()
'INSTANT VB TODO TASK: Assignments within expressions are not supported in VB.NET
'ORIGINAL LINE: if (--lockUpdate == 0)
			If --lockUpdate = 0 Then
				RaiseCollectionChanged(New CollectionChangeEventArgs(CollectionChangeAction.Refresh, Nothing))
			End If
		End Sub

		Public Overridable Function Add(ByVal item As MyNavBarSuperToolTipHelperItem) As Integer
			Return List.Add(item)
		End Function
		Public Overridable Sub AddRange(ByVal collection As ICollection)
			BeginUpdate()
			Try
				For Each item As Object In collection
					Add(TryCast(item, MyNavBarSuperToolTipHelperItem))
				Next item
			Finally
				EndUpdate()
			End Try
		End Sub
		Public Overridable Sub AddRange(ByVal items() As MyNavBarSuperToolTipHelperItem)
			BeginUpdate()
			Try
				For Each item As MyNavBarSuperToolTipHelperItem In items
					Add(item)
				Next item
			Finally
				EndUpdate()
			End Try
		End Sub
		Public Overridable Sub Remove(ByVal item As MyNavBarSuperToolTipHelperItem)
			List.Remove(item)
		End Sub
		Public Overridable Sub Insert(ByVal index As Integer, ByVal item As MyNavBarSuperToolTipHelperItem)
			List.Insert(index, item)
		End Sub
		Public Overridable Function IndexOf(ByVal item As MyNavBarSuperToolTipHelperItem) As Integer
			If item IsNot Nothing AndAlso Indexes.Contains(item) Then
				Return CInt(Fix(Indexes(item)))
			End If
			Dim i As Integer = List.IndexOf(item)
			If item IsNot Nothing AndAlso i > -1 Then
				Indexes(item) = i
			End If
			Return i
		End Function
		Public Overridable Function Contains(ByVal item As MyNavBarSuperToolTipHelperItem) As Boolean
			Return IndexOf(item) <> -1
		End Function
		Protected Overridable Function CanAddItem(ByVal item As Object) As Boolean
			Return True
		End Function


		Protected ReadOnly Property IsLockUpdate() As Boolean
			Get
				Return Me.lockUpdate <> 0
			End Get
		End Property
		Protected Overridable Sub RaiseCollectionChanged(ByVal e As CollectionChangeEventArgs)
			If IsLockUpdate Then
				Return
			End If
			RaiseEvent CollectionChanged(Me, e)
		End Sub
	End Class
End Namespace
