<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.btnAddArray = New System.Windows.Forms.Button()
        Me.listArrays = New System.Windows.Forms.ListBox()
        Me.btnSortArray = New System.Windows.Forms.Button()
        Me.btnReverse = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnAddArray
        '
        Me.btnAddArray.Location = New System.Drawing.Point(254, 26)
        Me.btnAddArray.Name = "btnAddArray"
        Me.btnAddArray.Size = New System.Drawing.Size(126, 23)
        Me.btnAddArray.TabIndex = 0
        Me.btnAddArray.Text = "Add Array Elements"
        Me.btnAddArray.UseVisualStyleBackColor = True
        '
        'listArrays
        '
        Me.listArrays.FormattingEnabled = True
        Me.listArrays.Location = New System.Drawing.Point(12, 26)
        Me.listArrays.Name = "listArrays"
        Me.listArrays.Size = New System.Drawing.Size(222, 186)
        Me.listArrays.TabIndex = 1
        '
        'btnSortArray
        '
        Me.btnSortArray.Location = New System.Drawing.Point(254, 83)
        Me.btnSortArray.Name = "btnSortArray"
        Me.btnSortArray.Size = New System.Drawing.Size(126, 23)
        Me.btnSortArray.TabIndex = 2
        Me.btnSortArray.Text = "Sort Array"
        Me.btnSortArray.UseVisualStyleBackColor = True
        '
        'btnReverse
        '
        Me.btnReverse.Location = New System.Drawing.Point(254, 127)
        Me.btnReverse.Name = "btnReverse"
        Me.btnReverse.Size = New System.Drawing.Size(126, 23)
        Me.btnReverse.TabIndex = 3
        Me.btnReverse.Text = "Reverse Array"
        Me.btnReverse.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(438, 261)
        Me.Controls.Add(Me.btnReverse)
        Me.Controls.Add(Me.btnSortArray)
        Me.Controls.Add(Me.listArrays)
        Me.Controls.Add(Me.btnAddArray)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnAddArray As Button
    Friend WithEvents listArrays As ListBox
    Friend WithEvents btnSortArray As Button
    Friend WithEvents btnReverse As Button
End Class
