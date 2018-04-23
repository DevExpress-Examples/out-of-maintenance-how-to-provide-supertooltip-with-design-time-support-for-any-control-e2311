Imports Microsoft.VisualBasic
Imports System
Namespace E2311
	Partial Public Class Form1
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary>
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing AndAlso (components IsNot Nothing) Then
				components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Windows Form Designer generated code"

		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Me.components = New System.ComponentModel.Container()
			Dim treeNode1 As New System.Windows.Forms.TreeNode("Contacts", 1, 1)
			Dim treeNode2 As New System.Windows.Forms.TreeNode("Deleted Items", 8, 8)
			Dim treeNode3 As New System.Windows.Forms.TreeNode("Drafts", 9, 9)
			Dim treeNode4 As New System.Windows.Forms.TreeNode("Inbox", 10, 10)
			Dim treeNode5 As New System.Windows.Forms.TreeNode("Journal", 3, 3)
			Dim treeNode6 As New System.Windows.Forms.TreeNode("Notes", 5, 5)
			Dim treeNode7 As New System.Windows.Forms.TreeNode("Outbox", 12, 12)
			Dim treeNode8 As New System.Windows.Forms.TreeNode("Sent Items", 15, 15)
			Dim treeNode9 As New System.Windows.Forms.TreeNode("Tasks", 7, 7)
			Dim treeNode10 As New System.Windows.Forms.TreeNode("Personal Folders", 13, 13, New System.Windows.Forms.TreeNode() { treeNode1, treeNode2, treeNode3, treeNode4, treeNode5, treeNode6, treeNode7, treeNode8, treeNode9})
			Dim resources As New System.ComponentModel.ComponentResourceManager(GetType(Form1))
			Dim myNavBarSuperToolTipHelperItem1 As New E2311.MyNavBarSuperToolTipHelperItem()
			Dim superToolTip1 As New DevExpress.Utils.SuperToolTip()
			Dim toolTipTitleItem1 As New DevExpress.Utils.ToolTipTitleItem()
			Dim toolTipItem1 As New DevExpress.Utils.ToolTipItem()
			Dim toolTipTitleItem2 As New DevExpress.Utils.ToolTipTitleItem()
			Dim myNavBarSuperToolTipHelperItem2 As New E2311.MyNavBarSuperToolTipHelperItem()
			Dim superToolTip2 As New DevExpress.Utils.SuperToolTip()
			Dim toolTipTitleItem3 As New DevExpress.Utils.ToolTipTitleItem()
			Dim toolTipItem2 As New DevExpress.Utils.ToolTipItem()
			Dim toolTipTitleItem4 As New DevExpress.Utils.ToolTipTitleItem()
			Dim myNavBarSuperToolTipHelperItem3 As New E2311.MyNavBarSuperToolTipHelperItem()
			Dim superToolTip3 As New DevExpress.Utils.SuperToolTip()
			Dim toolTipTitleItem5 As New DevExpress.Utils.ToolTipTitleItem()
			Dim toolTipItem3 As New DevExpress.Utils.ToolTipItem()
			Dim toolTipSeparatorItem1 As New DevExpress.Utils.ToolTipSeparatorItem()
			Dim toolTipTitleItem6 As New DevExpress.Utils.ToolTipTitleItem()
			Me.navBarGroup3 = New DevExpress.XtraNavBar.NavBarGroup()
			Me.navBarGroupControlContainer1 = New DevExpress.XtraNavBar.NavBarGroupControlContainer()
			Me.panel2 = New System.Windows.Forms.Panel()
			Me.panel1 = New System.Windows.Forms.Panel()
			Me.navBarGroup6 = New DevExpress.XtraNavBar.NavBarGroup()
			Me.navBarGroup2 = New DevExpress.XtraNavBar.NavBarGroup()
			Me.navBarItem2 = New DevExpress.XtraNavBar.NavBarItem()
			Me.navBarItem3 = New DevExpress.XtraNavBar.NavBarItem()
			Me.navBarItem4 = New DevExpress.XtraNavBar.NavBarItem()
			Me.navBarItem5 = New DevExpress.XtraNavBar.NavBarItem()
			Me.navBarItem6 = New DevExpress.XtraNavBar.NavBarItem()
			Me.navBarItem7 = New DevExpress.XtraNavBar.NavBarItem()
			Me.navBarItem1 = New DevExpress.XtraNavBar.NavBarItem()
			Me.navBarGroup4 = New DevExpress.XtraNavBar.NavBarGroup()
			Me.navBarGroupControlContainer2 = New DevExpress.XtraNavBar.NavBarGroupControlContainer()
			Me.navBarGroup5 = New DevExpress.XtraNavBar.NavBarGroup()
			Me.navBarGroup7 = New DevExpress.XtraNavBar.NavBarGroup()
			Me.navBarGroupControlContainer3 = New DevExpress.XtraNavBar.NavBarGroupControlContainer()
			Me.treeView1 = New DevExpress.Utils.Design.DXTreeView()
			Me.imageList2 = New System.Windows.Forms.ImageList(Me.components)
			Me.navBarGroup9 = New DevExpress.XtraNavBar.NavBarGroup()
			Me.navBarControl1 = New DevExpress.XtraNavBar.NavBarControl()
			Me.navBarGroup8 = New DevExpress.XtraNavBar.NavBarGroup()
			Me.navBarItem8 = New DevExpress.XtraNavBar.NavBarItem()
			Me.navBarItem9 = New DevExpress.XtraNavBar.NavBarItem()
			Me.imageList1 = New System.Windows.Forms.ImageList(Me.components)
			Me.imageList3 = New System.Windows.Forms.ImageList(Me.components)
			Me.myNavBarSuperTipHelper1 = New E2311.MyNavBarSuperTipHelper()
			Me.navBarGroupControlContainer1.SuspendLayout()
			Me.panel2.SuspendLayout()
			Me.navBarGroupControlContainer3.SuspendLayout()
			CType(Me.navBarControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.navBarControl1.SuspendLayout()
			Me.SuspendLayout()
			' 
			' navBarGroup3
			' 
			Me.navBarGroup3.Caption = "Calendar"
			Me.navBarGroup3.ControlContainer = Me.navBarGroupControlContainer1
			Me.navBarGroup3.DragDropFlags = DevExpress.XtraNavBar.NavBarDragDrop.None
			Me.navBarGroup3.GroupCaptionUseImage = DevExpress.XtraNavBar.NavBarImage.Large
			Me.navBarGroup3.GroupClientHeight = 160
			Me.navBarGroup3.GroupStyle = DevExpress.XtraNavBar.NavBarGroupStyle.ControlContainer
			Me.navBarGroup3.Hint = "No SuperTip"
			Me.navBarGroup3.LargeImageIndex = 0
			Me.navBarGroup3.Name = "navBarGroup3"
			Me.navBarGroup3.SmallImageIndex = 0
			' 
			' navBarGroupControlContainer1
			' 
			Me.navBarGroupControlContainer1.Controls.Add(Me.panel2)
			Me.navBarGroupControlContainer1.Name = "navBarGroupControlContainer1"
			Me.navBarGroupControlContainer1.Size = New System.Drawing.Size(196, 371)
			Me.navBarGroupControlContainer1.TabIndex = 0
			' 
			' panel2
			' 
			Me.panel2.BackColor = System.Drawing.Color.White
			Me.panel2.Controls.Add(Me.panel1)
			Me.panel2.Dock = System.Windows.Forms.DockStyle.Fill
			Me.panel2.Location = New System.Drawing.Point(0, 0)
			Me.panel2.Name = "panel2"
			Me.panel2.Size = New System.Drawing.Size(196, 371)
			Me.panel2.TabIndex = 1
			' 
			' panel1
			' 
			Me.panel1.Dock = System.Windows.Forms.DockStyle.Top
			Me.panel1.Location = New System.Drawing.Point(0, 0)
			Me.panel1.Name = "panel1"
			Me.panel1.Size = New System.Drawing.Size(196, 8)
			Me.panel1.TabIndex = 1
			' 
			' navBarGroup6
			' 
			Me.navBarGroup6.Caption = "Notes"
			Me.navBarGroup6.DragDropFlags = DevExpress.XtraNavBar.NavBarDragDrop.None
			Me.navBarGroup6.GroupCaptionUseImage = DevExpress.XtraNavBar.NavBarImage.Large
			Me.navBarGroup6.Hint = "Notes super"
			Me.navBarGroup6.LargeImageIndex = 5
			Me.navBarGroup6.Name = "navBarGroup6"
			Me.navBarGroup6.SelectedLinkIndex = 0
			Me.navBarGroup6.SmallImageIndex = 5
			' 
			' navBarGroup2
			' 
			Me.navBarGroup2.Caption = "Mail"
			Me.navBarGroup2.Expanded = True
			Me.navBarGroup2.GroupCaptionUseImage = DevExpress.XtraNavBar.NavBarImage.Large
			Me.navBarGroup2.GroupStyle = DevExpress.XtraNavBar.NavBarGroupStyle.SmallIconsText
			Me.navBarGroup2.Hint = "Test"
			Me.navBarGroup2.ItemLinks.AddRange(New DevExpress.XtraNavBar.NavBarItemLink() { New DevExpress.XtraNavBar.NavBarItemLink(Me.navBarItem2), New DevExpress.XtraNavBar.NavBarItemLink(Me.navBarItem3), New DevExpress.XtraNavBar.NavBarItemLink(Me.navBarItem4), New DevExpress.XtraNavBar.NavBarItemLink(Me.navBarItem5), New DevExpress.XtraNavBar.NavBarItemLink(Me.navBarItem6), New DevExpress.XtraNavBar.NavBarItemLink(Me.navBarItem7), New DevExpress.XtraNavBar.NavBarItemLink(Me.navBarItem1)})
			Me.navBarGroup2.LargeImageIndex = 4
			Me.navBarGroup2.Name = "navBarGroup2"
			Me.navBarGroup2.SelectedLinkIndex = 5
			Me.navBarGroup2.SmallImageIndex = 4
			' 
			' navBarItem2
			' 
			Me.navBarItem2.Caption = "Outbox"
			Me.navBarItem2.Hint = "test hint"
			Me.navBarItem2.Name = "navBarItem2"
			Me.navBarItem2.SmallImageIndex = 12
			' 
			' navBarItem3
			' 
			Me.navBarItem3.Caption = "Sent Items"
			Me.navBarItem3.Hint = "test hint"
			Me.navBarItem3.Name = "navBarItem3"
			Me.navBarItem3.SmallImageIndex = 15
			' 
			' navBarItem4
			' 
			Me.navBarItem4.Caption = "Deleted Items"
			Me.navBarItem4.Hint = "test hint deleted"
			Me.navBarItem4.Name = "navBarItem4"
			Me.navBarItem4.SmallImageIndex = 8
			' 
			' navBarItem5
			' 
			Me.navBarItem5.Caption = "Drafts"
			Me.navBarItem5.Hint = "test hint drafts"
			Me.navBarItem5.Name = "navBarItem5"
			Me.navBarItem5.SmallImageIndex = 9
			' 
			' navBarItem6
			' 
			Me.navBarItem6.Caption = "Tasks"
			Me.navBarItem6.Name = "navBarItem6"
			Me.navBarItem6.SmallImageIndex = 7
			' 
			' navBarItem7
			' 
			Me.navBarItem7.Caption = "Notes"
			Me.navBarItem7.Name = "navBarItem7"
			Me.navBarItem7.SmallImageIndex = 5
			' 
			' navBarItem1
			' 
			Me.navBarItem1.Caption = "Inbox"
			Me.navBarItem1.Name = "navBarItem1"
			Me.navBarItem1.SmallImageIndex = 10
			' 
			' navBarGroup4
			' 
			Me.navBarGroup4.Caption = "Contacts"
			Me.navBarGroup4.ControlContainer = Me.navBarGroupControlContainer2
			Me.navBarGroup4.DragDropFlags = DevExpress.XtraNavBar.NavBarDragDrop.None
			Me.navBarGroup4.GroupCaptionUseImage = DevExpress.XtraNavBar.NavBarImage.Large
			Me.navBarGroup4.GroupClientHeight = 160
			Me.navBarGroup4.GroupStyle = DevExpress.XtraNavBar.NavBarGroupStyle.ControlContainer
			Me.navBarGroup4.Hint = "Cont supertip"
			Me.navBarGroup4.LargeImageIndex = 1
			Me.navBarGroup4.Name = "navBarGroup4"
			Me.navBarGroup4.SmallImageIndex = 1
			' 
			' navBarGroupControlContainer2
			' 
			Me.navBarGroupControlContainer2.Name = "navBarGroupControlContainer2"
			Me.navBarGroupControlContainer2.Size = New System.Drawing.Size(198, 174)
			Me.navBarGroupControlContainer2.TabIndex = 1
			' 
			' navBarGroup5
			' 
			Me.navBarGroup5.Caption = "Tasks"
			Me.navBarGroup5.DragDropFlags = DevExpress.XtraNavBar.NavBarDragDrop.None
			Me.navBarGroup5.GroupCaptionUseImage = DevExpress.XtraNavBar.NavBarImage.Large
			Me.navBarGroup5.Hint = "Tasks super"
			Me.navBarGroup5.LargeImageIndex = 7
			Me.navBarGroup5.Name = "navBarGroup5"
			Me.navBarGroup5.SelectedLinkIndex = 0
			Me.navBarGroup5.SmallImageIndex = 7
			' 
			' navBarGroup7
			' 
			Me.navBarGroup7.Caption = "Folder List"
			Me.navBarGroup7.ControlContainer = Me.navBarGroupControlContainer3
			Me.navBarGroup7.DragDropFlags = DevExpress.XtraNavBar.NavBarDragDrop.None
			Me.navBarGroup7.GroupCaptionUseImage = DevExpress.XtraNavBar.NavBarImage.Large
			Me.navBarGroup7.GroupClientHeight = 160
			Me.navBarGroup7.GroupStyle = DevExpress.XtraNavBar.NavBarGroupStyle.ControlContainer
			Me.navBarGroup7.LargeImageIndex = 2
			Me.navBarGroup7.Name = "navBarGroup7"
			Me.navBarGroup7.SmallImageIndex = 2
			' 
			' navBarGroupControlContainer3
			' 
			Me.navBarGroupControlContainer3.Controls.Add(Me.treeView1)
			Me.navBarGroupControlContainer3.Name = "navBarGroupControlContainer3"
			Me.navBarGroupControlContainer3.Size = New System.Drawing.Size(198, 160)
			Me.navBarGroupControlContainer3.TabIndex = 2
			' 
			' treeView1
			' 
			Me.treeView1.BorderStyle = System.Windows.Forms.BorderStyle.None
			Me.treeView1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.treeView1.ImageIndex = 0
			Me.treeView1.ImageList = Me.imageList2
			Me.treeView1.Location = New System.Drawing.Point(0, 0)
			Me.treeView1.Name = "treeView1"
			treeNode1.ImageIndex = 1
			treeNode1.Name = ""
			treeNode1.SelectedImageIndex = 1
			treeNode1.Text = "Contacts"
			treeNode2.ImageIndex = 8
			treeNode2.Name = ""
			treeNode2.SelectedImageIndex = 8
			treeNode2.Text = "Deleted Items"
			treeNode3.ImageIndex = 9
			treeNode3.Name = ""
			treeNode3.SelectedImageIndex = 9
			treeNode3.Text = "Drafts"
			treeNode4.ImageIndex = 10
			treeNode4.Name = ""
			treeNode4.SelectedImageIndex = 10
			treeNode4.Text = "Inbox"
			treeNode5.ImageIndex = 3
			treeNode5.Name = ""
			treeNode5.SelectedImageIndex = 3
			treeNode5.Text = "Journal"
			treeNode6.ImageIndex = 5
			treeNode6.Name = ""
			treeNode6.SelectedImageIndex = 5
			treeNode6.Text = "Notes"
			treeNode7.ImageIndex = 12
			treeNode7.Name = ""
			treeNode7.SelectedImageIndex = 12
			treeNode7.Text = "Outbox"
			treeNode8.ImageIndex = 15
			treeNode8.Name = ""
			treeNode8.SelectedImageIndex = 15
			treeNode8.Text = "Sent Items"
			treeNode9.ImageIndex = 7
			treeNode9.Name = ""
			treeNode9.SelectedImageIndex = 7
			treeNode9.Text = "Tasks"
			treeNode10.ImageIndex = 13
			treeNode10.Name = ""
			treeNode10.SelectedImageIndex = 13
			treeNode10.Text = "Personal Folders"
			Me.treeView1.Nodes.AddRange(New System.Windows.Forms.TreeNode() { treeNode10})
			Me.treeView1.SelectedImageIndex = 0
			Me.treeView1.SelectionMode = DevExpress.Utils.Design.DXTreeSelectionMode.MultiSelectChildrenSameBranch
			Me.treeView1.Size = New System.Drawing.Size(198, 160)
			Me.treeView1.TabIndex = 0
			' 
			' imageList2
			' 
			Me.imageList2.ImageStream = (CType(resources.GetObject("imageList2.ImageStream"), System.Windows.Forms.ImageListStreamer))
			Me.imageList2.TransparentColor = System.Drawing.Color.Magenta
			Me.imageList2.Images.SetKeyName(0, "")
			Me.imageList2.Images.SetKeyName(1, "")
			Me.imageList2.Images.SetKeyName(2, "")
			Me.imageList2.Images.SetKeyName(3, "")
			Me.imageList2.Images.SetKeyName(4, "")
			Me.imageList2.Images.SetKeyName(5, "")
			Me.imageList2.Images.SetKeyName(6, "")
			Me.imageList2.Images.SetKeyName(7, "")
			Me.imageList2.Images.SetKeyName(8, "")
			Me.imageList2.Images.SetKeyName(9, "")
			Me.imageList2.Images.SetKeyName(10, "")
			Me.imageList2.Images.SetKeyName(11, "")
			Me.imageList2.Images.SetKeyName(12, "")
			Me.imageList2.Images.SetKeyName(13, "")
			Me.imageList2.Images.SetKeyName(14, "")
			Me.imageList2.Images.SetKeyName(15, "")
			' 
			' navBarGroup9
			' 
			Me.navBarGroup9.Caption = "Journal"
			Me.navBarGroup9.DragDropFlags = DevExpress.XtraNavBar.NavBarDragDrop.None
			Me.navBarGroup9.GroupCaptionUseImage = DevExpress.XtraNavBar.NavBarImage.Large
			Me.navBarGroup9.LargeImageIndex = 3
			Me.navBarGroup9.Name = "navBarGroup9"
			Me.navBarGroup9.SelectedLinkIndex = 0
			Me.navBarGroup9.SmallImageIndex = 3
			Me.navBarGroup9.Visible = False
			' 
			' navBarControl1
			' 
			Me.navBarControl1.ActiveGroup = Me.navBarGroup2
			Me.navBarControl1.AllowSelectedLink = True
			Me.navBarControl1.ContentButtonHint = Nothing
			Me.navBarControl1.Controls.Add(Me.navBarGroupControlContainer1)
			Me.navBarControl1.Controls.Add(Me.navBarGroupControlContainer2)
			Me.navBarControl1.Controls.Add(Me.navBarGroupControlContainer3)
			Me.navBarControl1.Dock = System.Windows.Forms.DockStyle.Left
			Me.navBarControl1.EachGroupHasSelectedLink = True
			Me.navBarControl1.Groups.AddRange(New DevExpress.XtraNavBar.NavBarGroup() { Me.navBarGroup2, Me.navBarGroup3, Me.navBarGroup4, Me.navBarGroup5, Me.navBarGroup6, Me.navBarGroup7, Me.navBarGroup8, Me.navBarGroup9})
			Me.navBarControl1.Items.AddRange(New DevExpress.XtraNavBar.NavBarItem() { Me.navBarItem1, Me.navBarItem2, Me.navBarItem3, Me.navBarItem4, Me.navBarItem5, Me.navBarItem6, Me.navBarItem7, Me.navBarItem8, Me.navBarItem9})
			Me.navBarControl1.LargeImages = Me.imageList1
			Me.navBarControl1.Location = New System.Drawing.Point(0, 0)
			Me.navBarControl1.Name = "navBarControl1"
			Me.navBarControl1.NavigationPaneGroupClientHeight = 160
			Me.navBarControl1.NavigationPaneMaxVisibleGroups = 5
			Me.navBarControl1.OptionsNavPane.ExpandedWidth = 200
			Me.navBarControl1.PaintStyleKind = DevExpress.XtraNavBar.NavBarViewKind.ExplorerBar
			Me.navBarControl1.Size = New System.Drawing.Size(255, 624)
			Me.navBarControl1.SmallImages = Me.imageList2
			Me.navBarControl1.StoreDefaultPaintStyleName = True
			Me.navBarControl1.TabIndex = 6
			Me.navBarControl1.Text = "navBarControl1"
			' 
			' navBarGroup8
			' 
			Me.navBarGroup8.Caption = "Shortcuts"
			Me.navBarGroup8.DragDropFlags = DevExpress.XtraNavBar.NavBarDragDrop.None
			Me.navBarGroup8.GroupCaptionUseImage = DevExpress.XtraNavBar.NavBarImage.Large
			Me.navBarGroup8.LargeImageIndex = 6
			Me.navBarGroup8.Name = "navBarGroup8"
			Me.navBarGroup8.SelectedLinkIndex = 0
			Me.navBarGroup8.SmallImageIndex = 6
			' 
			' navBarItem8
			' 
			Me.navBarItem8.Caption = "Shortcuts"
			Me.navBarItem8.Name = "navBarItem8"
			Me.navBarItem8.SmallImageIndex = 6
			' 
			' navBarItem9
			' 
			Me.navBarItem9.Caption = "Juornal"
			Me.navBarItem9.Name = "navBarItem9"
			Me.navBarItem9.SmallImageIndex = 3
			' 
			' imageList1
			' 
			Me.imageList1.ImageStream = (CType(resources.GetObject("imageList1.ImageStream"), System.Windows.Forms.ImageListStreamer))
			Me.imageList1.TransparentColor = System.Drawing.Color.Magenta
			Me.imageList1.Images.SetKeyName(0, "")
			Me.imageList1.Images.SetKeyName(1, "")
			Me.imageList1.Images.SetKeyName(2, "")
			Me.imageList1.Images.SetKeyName(3, "")
			Me.imageList1.Images.SetKeyName(4, "")
			Me.imageList1.Images.SetKeyName(5, "")
			Me.imageList1.Images.SetKeyName(6, "")
			Me.imageList1.Images.SetKeyName(7, "")
			' 
			' imageList3
			' 
			Me.imageList3.ImageStream = (CType(resources.GetObject("imageList3.ImageStream"), System.Windows.Forms.ImageListStreamer))
			Me.imageList3.TransparentColor = System.Drawing.Color.Magenta
			Me.imageList3.Images.SetKeyName(0, "")
			Me.imageList3.Images.SetKeyName(1, "")
			' 
			' myNavBarSuperTipHelper1
			' 
			myNavBarSuperToolTipHelperItem1.Group = Me.navBarGroup3
			toolTipTitleItem1.Text = "132321"
			toolTipItem1.LeftIndent = 6
			toolTipItem1.Text = "321312"
			toolTipTitleItem2.LeftIndent = 6
			toolTipTitleItem2.Text = "3123424323"
			superToolTip1.Items.Add(toolTipTitleItem1)
			superToolTip1.Items.Add(toolTipItem1)
			superToolTip1.Items.Add(toolTipTitleItem2)
			myNavBarSuperToolTipHelperItem1.SuperTip = superToolTip1
			myNavBarSuperToolTipHelperItem2.Group = Me.navBarGroup6
			toolTipTitleItem3.Text = "Test6sdf"
			toolTipItem2.LeftIndent = 6
			toolTipItem2.Text = "Test6asfddfsa"
			toolTipTitleItem4.LeftIndent = 6
			toolTipTitleItem4.Text = "Test6sdfafsda"
			superToolTip2.Items.Add(toolTipTitleItem3)
			superToolTip2.Items.Add(toolTipItem2)
			superToolTip2.Items.Add(toolTipTitleItem4)
			myNavBarSuperToolTipHelperItem2.SuperTip = superToolTip2
			myNavBarSuperToolTipHelperItem3.Group = Me.navBarGroup2
			toolTipTitleItem5.Text = "test!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!"
			toolTipItem3.LeftIndent = 6
			toolTipItem3.Text = "test!!"
			toolTipTitleItem6.LeftIndent = 6
			toolTipTitleItem6.Text = "test!!!"
			superToolTip3.Items.Add(toolTipTitleItem5)
			superToolTip3.Items.Add(toolTipItem3)
			superToolTip3.Items.Add(toolTipSeparatorItem1)
			superToolTip3.Items.Add(toolTipTitleItem6)
			myNavBarSuperToolTipHelperItem3.SuperTip = superToolTip3
			Me.myNavBarSuperTipHelper1.Items.AddRange(New E2311.MyNavBarSuperToolTipHelperItem() { myNavBarSuperToolTipHelperItem1, myNavBarSuperToolTipHelperItem2, myNavBarSuperToolTipHelperItem3})
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(806, 624)
			Me.Controls.Add(Me.navBarControl1)
			Me.Name = "Form1"
			Me.Text = "Form1"
			Me.navBarGroupControlContainer1.ResumeLayout(False)
			Me.panel2.ResumeLayout(False)
			Me.navBarGroupControlContainer3.ResumeLayout(False)
			CType(Me.navBarControl1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.navBarControl1.ResumeLayout(False)
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private imageList2 As System.Windows.Forms.ImageList
		Private navBarControl1 As DevExpress.XtraNavBar.NavBarControl
		Private navBarGroup3 As DevExpress.XtraNavBar.NavBarGroup
		Private navBarGroupControlContainer1 As DevExpress.XtraNavBar.NavBarGroupControlContainer
		Private panel2 As System.Windows.Forms.Panel
		Private panel1 As System.Windows.Forms.Panel
		Private navBarGroupControlContainer2 As DevExpress.XtraNavBar.NavBarGroupControlContainer
		Private navBarGroupControlContainer3 As DevExpress.XtraNavBar.NavBarGroupControlContainer
		Private treeView1 As DevExpress.Utils.Design.DXTreeView
		Private navBarGroup2 As DevExpress.XtraNavBar.NavBarGroup
		Private navBarGroup4 As DevExpress.XtraNavBar.NavBarGroup
		Private navBarGroup5 As DevExpress.XtraNavBar.NavBarGroup
		Private navBarGroup6 As DevExpress.XtraNavBar.NavBarGroup
		Private navBarGroup7 As DevExpress.XtraNavBar.NavBarGroup
		Private navBarGroup8 As DevExpress.XtraNavBar.NavBarGroup
		Private navBarGroup9 As DevExpress.XtraNavBar.NavBarGroup
		Private navBarItem1 As DevExpress.XtraNavBar.NavBarItem
		Private navBarItem2 As DevExpress.XtraNavBar.NavBarItem
		Private navBarItem3 As DevExpress.XtraNavBar.NavBarItem
		Private navBarItem4 As DevExpress.XtraNavBar.NavBarItem
		Private navBarItem5 As DevExpress.XtraNavBar.NavBarItem
		Private navBarItem6 As DevExpress.XtraNavBar.NavBarItem
		Private navBarItem7 As DevExpress.XtraNavBar.NavBarItem
		Private navBarItem8 As DevExpress.XtraNavBar.NavBarItem
		Private navBarItem9 As DevExpress.XtraNavBar.NavBarItem
		Private imageList1 As System.Windows.Forms.ImageList
		Private imageList3 As System.Windows.Forms.ImageList
		Private myNavBarSuperTipHelper1 As MyNavBarSuperTipHelper
	End Class
End Namespace

