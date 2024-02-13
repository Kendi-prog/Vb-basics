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
        components = New ComponentModel.Container()
        Button1 = New Button()
        Button2 = New Button()
        ToolTip1 = New ToolTip(components)
        SuspendLayout()
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(363, 214)
        Button1.Name = "Button1"
        Button1.Size = New Size(120, 50)
        Button1.TabIndex = 1
        Button1.Text = "EXIT"
        ToolTip1.SetToolTip(Button1, "Terminate the Form")
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(141, 214)
        Button2.Name = "Button2"
        Button2.Size = New Size(120, 50)
        Button2.TabIndex = 3
        Button2.Text = "Load Object Demo"
        ToolTip1.SetToolTip(Button2, "load the object demonstration form")
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Name = "Form1"
        Text = "Welcoming Form"
        ResumeLayout(False)
    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents ToolTip1 As ToolTip

End Class
