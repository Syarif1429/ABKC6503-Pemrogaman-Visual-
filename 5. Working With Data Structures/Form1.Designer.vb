<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Me.txtName1 = New System.Windows.Forms.TextBox()
        Me.txtName2 = New System.Windows.Forms.TextBox()
        Me.btnOrCheck = New System.Windows.Forms.Button()
        Me.lstFriends = New System.Windows.Forms.ListBox()
        Me.btnArrayElement = New System.Windows.Forms.Button()
        Me.btnEnumarteArray = New System.Windows.Forms.Button()
        Me.btnArrayAsParameters = New System.Windows.Forms.Button()
        Me.btnMoreArrayParameters = New System.Windows.Forms.Button()
        Me.btnSortingArray = New System.Windows.Forms.Button()
        Me.btnReversingAnArray = New System.Windows.Forms.Button()
        Me.btnIntializingArrayWithVakues = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtName1
        '
        Me.txtName1.Location = New System.Drawing.Point(12, 12)
        Me.txtName1.Name = "txtName1"
        Me.txtName1.Size = New System.Drawing.Size(100, 20)
        Me.txtName1.TabIndex = 0
        '
        'txtName2
        '
        Me.txtName2.Location = New System.Drawing.Point(12, 47)
        Me.txtName2.Name = "txtName2"
        Me.txtName2.Size = New System.Drawing.Size(100, 20)
        Me.txtName2.TabIndex = 1
        '
        'btnOrCheck
        '
        Me.btnOrCheck.Location = New System.Drawing.Point(12, 88)
        Me.btnOrCheck.Name = "btnOrCheck"
        Me.btnOrCheck.Size = New System.Drawing.Size(75, 23)
        Me.btnOrCheck.TabIndex = 2
        Me.btnOrCheck.Text = "Or Check"
        Me.btnOrCheck.UseVisualStyleBackColor = True
        '
        'lstFriends
        '
        Me.lstFriends.FormattingEnabled = True
        Me.lstFriends.IntegralHeight = False
        Me.lstFriends.Location = New System.Drawing.Point(118, 12)
        Me.lstFriends.Name = "lstFriends"
        Me.lstFriends.Size = New System.Drawing.Size(220, 251)
        Me.lstFriends.TabIndex = 3
        '
        'btnArrayElement
        '
        Me.btnArrayElement.Location = New System.Drawing.Point(354, 12)
        Me.btnArrayElement.Name = "btnArrayElement"
        Me.btnArrayElement.Size = New System.Drawing.Size(143, 23)
        Me.btnArrayElement.TabIndex = 4
        Me.btnArrayElement.Text = "Array Element"
        Me.btnArrayElement.UseVisualStyleBackColor = True
        '
        'btnEnumarteArray
        '
        Me.btnEnumarteArray.Location = New System.Drawing.Point(354, 41)
        Me.btnEnumarteArray.Name = "btnEnumarteArray"
        Me.btnEnumarteArray.Size = New System.Drawing.Size(143, 23)
        Me.btnEnumarteArray.TabIndex = 5
        Me.btnEnumarteArray.Text = "Enumerate Array"
        Me.btnEnumarteArray.UseVisualStyleBackColor = True
        '
        'btnArrayAsParameters
        '
        Me.btnArrayAsParameters.Location = New System.Drawing.Point(354, 70)
        Me.btnArrayAsParameters.Name = "btnArrayAsParameters"
        Me.btnArrayAsParameters.Size = New System.Drawing.Size(143, 23)
        Me.btnArrayAsParameters.TabIndex = 6
        Me.btnArrayAsParameters.Text = "Array as Parameters"
        Me.btnArrayAsParameters.UseVisualStyleBackColor = True
        '
        'btnMoreArrayParameters
        '
        Me.btnMoreArrayParameters.Location = New System.Drawing.Point(354, 99)
        Me.btnMoreArrayParameters.Name = "btnMoreArrayParameters"
        Me.btnMoreArrayParameters.Size = New System.Drawing.Size(143, 23)
        Me.btnMoreArrayParameters.TabIndex = 7
        Me.btnMoreArrayParameters.Text = "More Array Parameters"
        Me.btnMoreArrayParameters.UseVisualStyleBackColor = True
        '
        'btnSortingArray
        '
        Me.btnSortingArray.Location = New System.Drawing.Point(354, 128)
        Me.btnSortingArray.Name = "btnSortingArray"
        Me.btnSortingArray.Size = New System.Drawing.Size(143, 23)
        Me.btnSortingArray.TabIndex = 8
        Me.btnSortingArray.Text = "Sorting Array"
        Me.btnSortingArray.UseVisualStyleBackColor = True
        '
        'btnReversingAnArray
        '
        Me.btnReversingAnArray.Location = New System.Drawing.Point(354, 157)
        Me.btnReversingAnArray.Name = "btnReversingAnArray"
        Me.btnReversingAnArray.Size = New System.Drawing.Size(143, 23)
        Me.btnReversingAnArray.TabIndex = 9
        Me.btnReversingAnArray.Text = "Reversing An Array"
        Me.btnReversingAnArray.UseVisualStyleBackColor = True
        '
        'btnIntializingArrayWithVakues
        '
        Me.btnIntializingArrayWithVakues.Location = New System.Drawing.Point(354, 186)
        Me.btnIntializingArrayWithVakues.Name = "btnIntializingArrayWithVakues"
        Me.btnIntializingArrayWithVakues.Size = New System.Drawing.Size(165, 23)
        Me.btnIntializingArrayWithVakues.TabIndex = 10
        Me.btnIntializingArrayWithVakues.Text = "Initializing Array With Values"
        Me.btnIntializingArrayWithVakues.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(545, 595)
        Me.Controls.Add(Me.btnIntializingArrayWithVakues)
        Me.Controls.Add(Me.btnReversingAnArray)
        Me.Controls.Add(Me.btnSortingArray)
        Me.Controls.Add(Me.btnMoreArrayParameters)
        Me.Controls.Add(Me.btnArrayAsParameters)
        Me.Controls.Add(Me.btnEnumarteArray)
        Me.Controls.Add(Me.btnArrayElement)
        Me.Controls.Add(Me.lstFriends)
        Me.Controls.Add(Me.btnOrCheck)
        Me.Controls.Add(Me.txtName2)
        Me.Controls.Add(Me.txtName1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtName1 As TextBox
    Friend WithEvents txtName2 As TextBox
    Friend WithEvents btnOrCheck As Button
    Friend WithEvents lstFriends As ListBox
    Friend WithEvents btnArrayElement As Button
    Friend WithEvents btnEnumarteArray As Button
    Friend WithEvents btnArrayAsParameters As Button
    Friend WithEvents btnMoreArrayParameters As Button
    Friend WithEvents btnSortingArray As Button
    Friend WithEvents btnReversingAnArray As Button
    Friend WithEvents btnIntializingArrayWithVakues As Button
End Class
