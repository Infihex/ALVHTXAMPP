﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class main
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(main))
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.tbDomainName = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tbLaravelLocation = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnLaravelLocation = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ServiceController1 = New System.ServiceProcess.ServiceController()
        Me.btnXAMPPLocation = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.tbXAMPPLocation = New System.Windows.Forms.TextBox()
        Me.tbWebPort = New System.Windows.Forms.TextBox()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.tsslVersion = New System.Windows.Forms.ToolStripStatusLabel()
        Me.tsslAdmin = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel3 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.pbWorking = New System.Windows.Forms.ProgressBar()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnAdd
        '
        Me.btnAdd.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdd.Location = New System.Drawing.Point(333, 65)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(75, 23)
        Me.btnAdd.TabIndex = 0
        Me.btnAdd.Text = "Add vhost"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'tbDomainName
        '
        Me.tbDomainName.Location = New System.Drawing.Point(152, 66)
        Me.tbDomainName.Name = "tbDomainName"
        Me.tbDomainName.Size = New System.Drawing.Size(89, 22)
        Me.tbDomainName.TabIndex = 1
        Me.tbDomainName.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(64, 69)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(82, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Domain Name:"
        '
        'tbLaravelLocation
        '
        Me.tbLaravelLocation.Location = New System.Drawing.Point(152, 40)
        Me.tbLaravelLocation.Name = "tbLaravelLocation"
        Me.tbLaravelLocation.ReadOnly = True
        Me.tbLaravelLocation.Size = New System.Drawing.Size(175, 22)
        Me.tbLaravelLocation.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 43)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(134, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Laravel ""Public"" Location:"
        '
        'btnLaravelLocation
        '
        Me.btnLaravelLocation.Location = New System.Drawing.Point(333, 39)
        Me.btnLaravelLocation.Name = "btnLaravelLocation"
        Me.btnLaravelLocation.Size = New System.Drawing.Size(75, 23)
        Me.btnLaravelLocation.TabIndex = 5
        Me.btnLaravelLocation.Text = "Browse..."
        Me.btnLaravelLocation.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(247, 69)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(31, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = ".dev:"
        '
        'btnXAMPPLocation
        '
        Me.btnXAMPPLocation.Location = New System.Drawing.Point(333, 11)
        Me.btnXAMPPLocation.Name = "btnXAMPPLocation"
        Me.btnXAMPPLocation.Size = New System.Drawing.Size(75, 23)
        Me.btnXAMPPLocation.TabIndex = 9
        Me.btnXAMPPLocation.Text = "Browse..."
        Me.btnXAMPPLocation.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(54, 15)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(92, 13)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "XAMPP Location:"
        '
        'tbXAMPPLocation
        '
        Me.tbXAMPPLocation.Location = New System.Drawing.Point(152, 12)
        Me.tbXAMPPLocation.Name = "tbXAMPPLocation"
        Me.tbXAMPPLocation.ReadOnly = True
        Me.tbXAMPPLocation.Size = New System.Drawing.Size(175, 22)
        Me.tbXAMPPLocation.TabIndex = 7
        Me.tbXAMPPLocation.Text = "C:\xampp"
        '
        'tbWebPort
        '
        Me.tbWebPort.Location = New System.Drawing.Point(281, 66)
        Me.tbWebPort.Name = "tbWebPort"
        Me.tbWebPort.Size = New System.Drawing.Size(46, 22)
        Me.tbWebPort.TabIndex = 10
        Me.tbWebPort.Text = "80"
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsslVersion, Me.tsslAdmin, Me.ToolStripStatusLabel3})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 97)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(420, 22)
        Me.StatusStrip1.SizingGrip = False
        Me.StatusStrip1.TabIndex = 11
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'tsslVersion
        '
        Me.tsslVersion.Name = "tsslVersion"
        Me.tsslVersion.Size = New System.Drawing.Size(88, 17)
        Me.tsslVersion.Text = "0.0.0 Build 0000"
        '
        'tsslAdmin
        '
        Me.tsslAdmin.ActiveLinkColor = System.Drawing.Color.White
        Me.tsslAdmin.LinkColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.tsslAdmin.Name = "tsslAdmin"
        Me.tsslAdmin.Size = New System.Drawing.Size(205, 17)
        Me.tsslAdmin.Spring = True
        '
        'ToolStripStatusLabel3
        '
        Me.ToolStripStatusLabel3.ActiveLinkColor = System.Drawing.Color.White
        Me.ToolStripStatusLabel3.IsLink = True
        Me.ToolStripStatusLabel3.LinkColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ToolStripStatusLabel3.Name = "ToolStripStatusLabel3"
        Me.ToolStripStatusLabel3.Size = New System.Drawing.Size(112, 17)
        Me.ToolStripStatusLabel3.Text = "© 2015-2017 Infihex"
        '
        'pbWorking
        '
        Me.pbWorking.Location = New System.Drawing.Point(0, 0)
        Me.pbWorking.Name = "pbWorking"
        Me.pbWorking.Size = New System.Drawing.Size(420, 5)
        Me.pbWorking.Style = System.Windows.Forms.ProgressBarStyle.Marquee
        Me.pbWorking.TabIndex = 12
        Me.pbWorking.Visible = False
        '
        'main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(420, 119)
        Me.Controls.Add(Me.pbWorking)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.tbWebPort)
        Me.Controls.Add(Me.btnXAMPPLocation)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.tbXAMPPLocation)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btnLaravelLocation)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.tbLaravelLocation)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.tbDomainName)
        Me.Controls.Add(Me.btnAdd)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "main"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Add Laravel Virtual Host To XAMPP"
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnAdd As System.Windows.Forms.Button
    Friend WithEvents tbDomainName As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents tbLaravelLocation As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnLaravelLocation As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents ServiceController1 As System.ServiceProcess.ServiceController
    Friend WithEvents btnXAMPPLocation As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents tbXAMPPLocation As System.Windows.Forms.TextBox
    Friend WithEvents tbWebPort As System.Windows.Forms.TextBox
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents tsslVersion As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents tsslAdmin As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel3 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents pbWorking As ProgressBar
End Class
