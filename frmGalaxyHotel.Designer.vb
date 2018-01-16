<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmGalaxyHotel
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
        Me.lblHeading = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnOccupancyRate = New System.Windows.Forms.Button()
        Me.lstGalaxyHotelOccupancy = New System.Windows.Forms.ListBox()
        Me.lblOccupancyRate = New System.Windows.Forms.Label()
        Me.lblVacantRooms = New System.Windows.Forms.Label()
        Me.lblOccupiedRooms = New System.Windows.Forms.Label()
        Me.lblTotalRooms = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClearToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblHeading
        '
        Me.lblHeading.AutoSize = True
        Me.lblHeading.Font = New System.Drawing.Font("ISOCPEUR", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHeading.Location = New System.Drawing.Point(67, 43)
        Me.lblHeading.Name = "lblHeading"
        Me.lblHeading.Size = New System.Drawing.Size(173, 37)
        Me.lblHeading.TabIndex = 0
        Me.lblHeading.Text = "Galaxy Hotel"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("ISOCPEUR", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(22, 89)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(263, 27)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Occupancy Rate Calculator"
        '
        'btnOccupancyRate
        '
        Me.btnOccupancyRate.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOccupancyRate.Location = New System.Drawing.Point(70, 134)
        Me.btnOccupancyRate.Name = "btnOccupancyRate"
        Me.btnOccupancyRate.Size = New System.Drawing.Size(177, 41)
        Me.btnOccupancyRate.TabIndex = 2
        Me.btnOccupancyRate.Text = "Calculate Occupancy"
        Me.btnOccupancyRate.UseVisualStyleBackColor = True
        '
        'lstGalaxyHotelOccupancy
        '
        Me.lstGalaxyHotelOccupancy.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstGalaxyHotelOccupancy.FormattingEnabled = True
        Me.lstGalaxyHotelOccupancy.ItemHeight = 20
        Me.lstGalaxyHotelOccupancy.Location = New System.Drawing.Point(56, 193)
        Me.lstGalaxyHotelOccupancy.Name = "lstGalaxyHotelOccupancy"
        Me.lstGalaxyHotelOccupancy.Size = New System.Drawing.Size(204, 144)
        Me.lstGalaxyHotelOccupancy.TabIndex = 3
        '
        'lblOccupancyRate
        '
        Me.lblOccupancyRate.AutoSize = True
        Me.lblOccupancyRate.Font = New System.Drawing.Font("ISOCPEUR", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOccupancyRate.Location = New System.Drawing.Point(79, 478)
        Me.lblOccupancyRate.Name = "lblOccupancyRate"
        Me.lblOccupancyRate.Size = New System.Drawing.Size(215, 21)
        Me.lblOccupancyRate.TabIndex = 4
        Me.lblOccupancyRate.Text = "Total Occupancy Rate is __.__%"
        Me.lblOccupancyRate.Visible = False
        '
        'lblVacantRooms
        '
        Me.lblVacantRooms.AutoSize = True
        Me.lblVacantRooms.Font = New System.Drawing.Font("ISOCPEUR", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVacantRooms.Location = New System.Drawing.Point(79, 445)
        Me.lblVacantRooms.Name = "lblVacantRooms"
        Me.lblVacantRooms.Size = New System.Drawing.Size(164, 21)
        Me.lblVacantRooms.TabIndex = 4
        Me.lblVacantRooms.Text = "Number of vacant rooms:"
        Me.lblVacantRooms.Visible = False
        '
        'lblOccupiedRooms
        '
        Me.lblOccupiedRooms.AutoSize = True
        Me.lblOccupiedRooms.Font = New System.Drawing.Font("ISOCPEUR", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOccupiedRooms.Location = New System.Drawing.Point(79, 414)
        Me.lblOccupiedRooms.Name = "lblOccupiedRooms"
        Me.lblOccupiedRooms.Size = New System.Drawing.Size(174, 21)
        Me.lblOccupiedRooms.TabIndex = 4
        Me.lblOccupiedRooms.Text = "Number of occupied rooms:"
        Me.lblOccupiedRooms.Visible = False
        '
        'lblTotalRooms
        '
        Me.lblTotalRooms.AutoSize = True
        Me.lblTotalRooms.Font = New System.Drawing.Font("ISOCPEUR", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalRooms.Location = New System.Drawing.Point(79, 383)
        Me.lblTotalRooms.Name = "lblTotalRooms"
        Me.lblTotalRooms.Size = New System.Drawing.Size(161, 21)
        Me.lblTotalRooms.TabIndex = 4
        Me.lblTotalRooms.Text = "Total number of rooms: "
        Me.lblTotalRooms.Visible = False
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(317, 24)
        Me.MenuStrip1.TabIndex = 5
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ClearToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "&File"
        '
        'ClearToolStripMenuItem
        '
        Me.ClearToolStripMenuItem.Name = "ClearToolStripMenuItem"
        Me.ClearToolStripMenuItem.Size = New System.Drawing.Size(101, 22)
        Me.ClearToolStripMenuItem.Text = "&Clear"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(101, 22)
        Me.ExitToolStripMenuItem.Text = "E&xit"
        '
        'frmGalaxyHotel
        '
        Me.AcceptButton = Me.btnOccupancyRate
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.MediumPurple
        Me.ClientSize = New System.Drawing.Size(317, 541)
        Me.Controls.Add(Me.lblTotalRooms)
        Me.Controls.Add(Me.lblOccupiedRooms)
        Me.Controls.Add(Me.lblVacantRooms)
        Me.Controls.Add(Me.lblOccupancyRate)
        Me.Controls.Add(Me.lstGalaxyHotelOccupancy)
        Me.Controls.Add(Me.btnOccupancyRate)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblHeading)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmGalaxyHotel"
        Me.Text = "Galaxy Hotel Occupancy Rate"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblHeading As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents btnOccupancyRate As Button
    Friend WithEvents lstGalaxyHotelOccupancy As ListBox
    Friend WithEvents lblOccupancyRate As Label
    Friend WithEvents lblVacantRooms As Label
    Friend WithEvents lblOccupiedRooms As Label
    Friend WithEvents lblTotalRooms As Label
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ClearToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
End Class
