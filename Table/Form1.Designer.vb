<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form은 Dispose를 재정의하여 구성 요소 목록을 정리합니다.
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

    'Windows Form 디자이너에 필요합니다.
    Private components As System.ComponentModel.IContainer

    '참고: 다음 프로시저는 Windows Form 디자이너에 필요합니다.
    '수정하려면 Windows Form 디자이너를 사용하십시오.  
    '코드 편집기를 사용하여 수정하지 마십시오.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.peo = New System.Windows.Forms.TextBox()
        Me.wtf = New System.Windows.Forms.TextBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.count = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.column = New System.Windows.Forms.TextBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.정보ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NovangToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.방태건박주영ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.OpenSourceToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(245, 40)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(45, 12)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "인원수:"
        '
        'peo
        '
        Me.peo.Location = New System.Drawing.Point(296, 37)
        Me.peo.Name = "peo"
        Me.peo.Size = New System.Drawing.Size(52, 21)
        Me.peo.TabIndex = 1
        Me.peo.Text = "0"
        '
        'wtf
        '
        Me.wtf.Location = New System.Drawing.Point(12, 37)
        Me.wtf.Name = "wtf"
        Me.wtf.ReadOnly = True
        Me.wtf.Size = New System.Drawing.Size(37, 21)
        Me.wtf.TabIndex = 3
        '
        'Timer1
        '
        Me.Timer1.Interval = 1
        '
        'count
        '
        Me.count.AutoSize = True
        Me.count.Location = New System.Drawing.Point(54, 40)
        Me.count.Name = "count"
        Me.count.Size = New System.Drawing.Size(42, 12)
        Me.count.TabIndex = 4
        Me.count.Text = "Label2"
        Me.count.Visible = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(184, 40)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(21, 12)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "열:"
        '
        'column
        '
        Me.column.Location = New System.Drawing.Point(211, 37)
        Me.column.Name = "column"
        Me.column.Size = New System.Drawing.Size(28, 21)
        Me.column.TabIndex = 8
        Me.column.Text = "0"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.Transparent
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.정보ToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(360, 24)
        Me.MenuStrip1.TabIndex = 10
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        '정보ToolStripMenuItem
        '
        Me.정보ToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NovangToolStripMenuItem})
        Me.정보ToolStripMenuItem.Name = "정보ToolStripMenuItem"
        Me.정보ToolStripMenuItem.Size = New System.Drawing.Size(43, 20)
        Me.정보ToolStripMenuItem.Text = "정보"
        '
        'NovangToolStripMenuItem
        '
        Me.NovangToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.방태건박주영ToolStripMenuItem, Me.ToolStripMenuItem2, Me.OpenSourceToolStripMenuItem})
        Me.NovangToolStripMenuItem.Name = "NovangToolStripMenuItem"
        Me.NovangToolStripMenuItem.Size = New System.Drawing.Size(164, 22)
        Me.NovangToolStripMenuItem.Text = "ⓒNovang, ASCII"
        '
        '방태건박주영ToolStripMenuItem
        '
        Me.방태건박주영ToolStripMenuItem.Name = "방태건박주영ToolStripMenuItem"
        Me.방태건박주영ToolStripMenuItem.Size = New System.Drawing.Size(165, 22)
        Me.방태건박주영ToolStripMenuItem.Text = "ⓒ방태건, 박주영"
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(165, 22)
        Me.ToolStripMenuItem2.Text = "2014"
        '
        'OpenSourceToolStripMenuItem
        '
        Me.OpenSourceToolStripMenuItem.Name = "OpenSourceToolStripMenuItem"
        Me.OpenSourceToolStripMenuItem.Size = New System.Drawing.Size(165, 22)
        Me.OpenSourceToolStripMenuItem.Text = "Open Source"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(296, 8)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(52, 23)
        Me.Button1.TabIndex = 11
        Me.Button1.Text = "GEN!"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'RichTextBox1
        '
        Me.RichTextBox1.BackColor = System.Drawing.SystemColors.Control
        Me.RichTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.RichTextBox1.Font = New System.Drawing.Font("맑은 고딕", 15.0!)
        Me.RichTextBox1.Location = New System.Drawing.Point(12, 64)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.ReadOnly = True
        Me.RichTextBox1.Size = New System.Drawing.Size(336, 372)
        Me.RichTextBox1.TabIndex = 12
        Me.RichTextBox1.Text = ""
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(360, 448)
        Me.Controls.Add(Me.RichTextBox1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.column)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.count)
        Me.Controls.Add(Me.wtf)
        Me.Controls.Add(Me.peo)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.Text = "난수 좌석 배치"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents peo As System.Windows.Forms.TextBox
    Friend WithEvents wtf As System.Windows.Forms.TextBox
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents count As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents column As System.Windows.Forms.TextBox
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents 정보ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NovangToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents 방태건박주영ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem2 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents RichTextBox1 As System.Windows.Forms.RichTextBox
    Friend WithEvents OpenSourceToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class
