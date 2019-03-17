<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmMain
	 Inherits System.Windows.Forms.Form

	 'Form overrides dispose to clean up the component list.
	 <System.Diagnostics.DebuggerNonUserCode()>
	 Protected Overrides Sub Dispose(ByVal disposing As Boolean)
		  Try
				If disposing AndAlso components IsNot Nothing Then
					 components.Dispose()
				End If
		  Finally
				MyBase.Dispose(disposing)
		  End Try
	 End Sub

	 'Required by the Windows Form Designer
	 Private components As System.ComponentModel.IContainer

	 'NOTE: The following procedure is required by the Windows Form Designer
	 'It can be modified using the Windows Form Designer.  
	 'Do not modify it using the code editor.
	 <System.Diagnostics.DebuggerStepThrough()>
	 Private Sub InitializeComponent()
		  Me.components = New System.ComponentModel.Container()
		  Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
		  Me.MovieBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
		  Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
		  Me.MovieBindingSource = New System.Windows.Forms.BindingSource(Me.components)
		  Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
		  Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
		  Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
		  Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
		  Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
		  Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
		  Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
		  Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
		  Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
		  Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
		  Me.MovieBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
		  Me.MovieDataGridView = New System.Windows.Forms.DataGridView()
		  Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
		  Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
		  Me.Genre = New System.Windows.Forms.DataGridViewTextBoxColumn()
		  Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
		  Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
		  CType(Me.MovieBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
		  Me.MovieBindingNavigator.SuspendLayout()
		  CType(Me.MovieBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
		  CType(Me.MovieDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
		  Me.SuspendLayout()
		  '
		  'MovieBindingNavigator
		  '
		  Me.MovieBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
		  Me.MovieBindingNavigator.BindingSource = Me.MovieBindingSource
		  Me.MovieBindingNavigator.CountItem = Me.BindingNavigatorCountItem
		  Me.MovieBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
		  Me.MovieBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.MovieBindingNavigatorSaveItem})
		  Me.MovieBindingNavigator.Location = New System.Drawing.Point(0, 0)
		  Me.MovieBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
		  Me.MovieBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
		  Me.MovieBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
		  Me.MovieBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
		  Me.MovieBindingNavigator.Name = "MovieBindingNavigator"
		  Me.MovieBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
		  Me.MovieBindingNavigator.Size = New System.Drawing.Size(810, 25)
		  Me.MovieBindingNavigator.TabIndex = 0
		  Me.MovieBindingNavigator.Text = "BindingNavigator1"
		  '
		  'BindingNavigatorAddNewItem
		  '
		  Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
		  Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
		  Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
		  Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
		  Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 22)
		  Me.BindingNavigatorAddNewItem.Text = "Add new"
		  '
		  'MovieBindingSource
		  '
		  Me.MovieBindingSource.AllowNew = False
		  Me.MovieBindingSource.DataSource = GetType(CLient.Movie)
		  '
		  'BindingNavigatorCountItem
		  '
		  Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
		  Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(35, 22)
		  Me.BindingNavigatorCountItem.Text = "of {0}"
		  Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
		  '
		  'BindingNavigatorDeleteItem
		  '
		  Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
		  Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
		  Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
		  Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
		  Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 22)
		  Me.BindingNavigatorDeleteItem.Text = "Delete"
		  '
		  'BindingNavigatorMoveFirstItem
		  '
		  Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
		  Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
		  Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
		  Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
		  Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 22)
		  Me.BindingNavigatorMoveFirstItem.Text = "Move first"
		  '
		  'BindingNavigatorMovePreviousItem
		  '
		  Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
		  Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
		  Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
		  Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
		  Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 22)
		  Me.BindingNavigatorMovePreviousItem.Text = "Move previous"
		  '
		  'BindingNavigatorSeparator
		  '
		  Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
		  Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
		  '
		  'BindingNavigatorPositionItem
		  '
		  Me.BindingNavigatorPositionItem.AccessibleName = "Position"
		  Me.BindingNavigatorPositionItem.AutoSize = False
		  Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
		  Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 23)
		  Me.BindingNavigatorPositionItem.Text = "0"
		  Me.BindingNavigatorPositionItem.ToolTipText = "Current position"
		  '
		  'BindingNavigatorSeparator1
		  '
		  Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
		  Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 25)
		  '
		  'BindingNavigatorMoveNextItem
		  '
		  Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
		  Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
		  Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
		  Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
		  Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 22)
		  Me.BindingNavigatorMoveNextItem.Text = "Move next"
		  '
		  'BindingNavigatorMoveLastItem
		  '
		  Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
		  Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
		  Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
		  Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
		  Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 22)
		  Me.BindingNavigatorMoveLastItem.Text = "Move last"
		  '
		  'BindingNavigatorSeparator2
		  '
		  Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
		  Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
		  '
		  'MovieBindingNavigatorSaveItem
		  '
		  Me.MovieBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
		  Me.MovieBindingNavigatorSaveItem.Enabled = False
		  Me.MovieBindingNavigatorSaveItem.Image = CType(resources.GetObject("MovieBindingNavigatorSaveItem.Image"), System.Drawing.Image)
		  Me.MovieBindingNavigatorSaveItem.Name = "MovieBindingNavigatorSaveItem"
		  Me.MovieBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
		  Me.MovieBindingNavigatorSaveItem.Text = "Save Data"
		  '
		  'MovieDataGridView
		  '
		  Me.MovieDataGridView.AllowUserToAddRows = False
		  Me.MovieDataGridView.AllowUserToDeleteRows = False
		  Me.MovieDataGridView.AutoGenerateColumns = False
		  Me.MovieDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
		  Me.MovieDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.Genre, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn5})
		  Me.MovieDataGridView.DataSource = Me.MovieBindingSource
		  Me.MovieDataGridView.Dock = System.Windows.Forms.DockStyle.Fill
		  Me.MovieDataGridView.Location = New System.Drawing.Point(0, 25)
		  Me.MovieDataGridView.Name = "MovieDataGridView"
		  Me.MovieDataGridView.ReadOnly = True
		  Me.MovieDataGridView.Size = New System.Drawing.Size(810, 425)
		  Me.MovieDataGridView.TabIndex = 1
		  '
		  'DataGridViewTextBoxColumn1
		  '
		  Me.DataGridViewTextBoxColumn1.DataPropertyName = "ID"
		  Me.DataGridViewTextBoxColumn1.HeaderText = "ID"
		  Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
		  Me.DataGridViewTextBoxColumn1.ReadOnly = True
		  '
		  'DataGridViewTextBoxColumn2
		  '
		  Me.DataGridViewTextBoxColumn2.DataPropertyName = "Title"
		  Me.DataGridViewTextBoxColumn2.HeaderText = "Title"
		  Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
		  Me.DataGridViewTextBoxColumn2.ReadOnly = True
		  '
		  'Genre
		  '
		  Me.Genre.DataPropertyName = "Genre"
		  Me.Genre.HeaderText = "Genre"
		  Me.Genre.Name = "Genre"
		  Me.Genre.ReadOnly = True
		  '
		  'DataGridViewTextBoxColumn3
		  '
		  Me.DataGridViewTextBoxColumn3.DataPropertyName = "ReleaseDate"
		  Me.DataGridViewTextBoxColumn3.HeaderText = "ReleaseDate"
		  Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
		  Me.DataGridViewTextBoxColumn3.ReadOnly = True
		  '
		  'DataGridViewTextBoxColumn5
		  '
		  Me.DataGridViewTextBoxColumn5.DataPropertyName = "Price"
		  Me.DataGridViewTextBoxColumn5.HeaderText = "Price"
		  Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
		  Me.DataGridViewTextBoxColumn5.ReadOnly = True
		  '
		  'frmMain
		  '
		  Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		  Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		  Me.ClientSize = New System.Drawing.Size(810, 450)
		  Me.Controls.Add(Me.MovieDataGridView)
		  Me.Controls.Add(Me.MovieBindingNavigator)
		  Me.Name = "frmMain"
		  Me.Text = "Form1"
		  CType(Me.MovieBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
		  Me.MovieBindingNavigator.ResumeLayout(False)
		  Me.MovieBindingNavigator.PerformLayout()
		  CType(Me.MovieBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
		  CType(Me.MovieDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
		  Me.ResumeLayout(False)
		  Me.PerformLayout()

	 End Sub

	 Friend WithEvents MovieBindingSource As BindingSource
	 Friend WithEvents MovieBindingNavigator As BindingNavigator
	 Friend WithEvents BindingNavigatorAddNewItem As ToolStripButton
	 Friend WithEvents BindingNavigatorCountItem As ToolStripLabel
	 Friend WithEvents BindingNavigatorDeleteItem As ToolStripButton
	 Friend WithEvents BindingNavigatorMoveFirstItem As ToolStripButton
	 Friend WithEvents BindingNavigatorMovePreviousItem As ToolStripButton
	 Friend WithEvents BindingNavigatorSeparator As ToolStripSeparator
	 Friend WithEvents BindingNavigatorPositionItem As ToolStripTextBox
	 Friend WithEvents BindingNavigatorSeparator1 As ToolStripSeparator
	 Friend WithEvents BindingNavigatorMoveNextItem As ToolStripButton
	 Friend WithEvents BindingNavigatorMoveLastItem As ToolStripButton
	 Friend WithEvents BindingNavigatorSeparator2 As ToolStripSeparator
	 Friend WithEvents MovieBindingNavigatorSaveItem As ToolStripButton
	 Friend WithEvents MovieDataGridView As DataGridView
	 Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
	 Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
	 Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
	 Friend WithEvents Genre As DataGridViewTextBoxColumn
	 Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
	 Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
End Class
