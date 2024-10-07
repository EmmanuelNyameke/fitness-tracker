<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmFitness
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
        lblHeading = New Label()
        lblFirstName = New Label()
        lblDOB = New Label()
        lblCurrentDate = New Label()
        txtFirstName = New TextBox()
        btnCalcHours = New Button()
        btnClear = New Button()
        btnExit = New Button()
        lblResult = New Label()
        lblAssume = New Label()
        picFitness = New PictureBox()
        txtCurrentDay = New TextBox()
        txtCurrentMonth = New TextBox()
        txtCurrentYear = New TextBox()
        txtBirthday = New TextBox()
        txtBirthMonth = New TextBox()
        txtBirthYear = New TextBox()
        lblFormat1 = New Label()
        lblFormat2 = New Label()
        CType(picFitness, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' lblHeading
        ' 
        lblHeading.AutoSize = True
        lblHeading.BackColor = Color.White
        lblHeading.Font = New Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblHeading.ForeColor = Color.OrangeRed
        lblHeading.Location = New Point(382, 19)
        lblHeading.Name = "lblHeading"
        lblHeading.Size = New Size(149, 19)
        lblHeading.TabIndex = 0
        lblHeading.Text = "Fitness Tracker App"
        ' 
        ' lblFirstName
        ' 
        lblFirstName.AutoSize = True
        lblFirstName.BackColor = Color.White
        lblFirstName.Font = New Font("Tahoma", 11.25F)
        lblFirstName.ForeColor = Color.OrangeRed
        lblFirstName.Location = New Point(278, 76)
        lblFirstName.Name = "lblFirstName"
        lblFirstName.Size = New Size(84, 18)
        lblFirstName.TabIndex = 1
        lblFirstName.Text = "First Name:"
        ' 
        ' lblDOB
        ' 
        lblDOB.AutoSize = True
        lblDOB.BackColor = Color.White
        lblDOB.Font = New Font("Tahoma", 11.25F)
        lblDOB.ForeColor = Color.OrangeRed
        lblDOB.Location = New Point(278, 112)
        lblDOB.Name = "lblDOB"
        lblDOB.Size = New Size(96, 18)
        lblDOB.TabIndex = 2
        lblDOB.Text = "Date of Birth:"
        ' 
        ' lblCurrentDate
        ' 
        lblCurrentDate.AutoSize = True
        lblCurrentDate.BackColor = Color.White
        lblCurrentDate.Font = New Font("Tahoma", 11.25F)
        lblCurrentDate.ForeColor = Color.OrangeRed
        lblCurrentDate.Location = New Point(278, 145)
        lblCurrentDate.Name = "lblCurrentDate"
        lblCurrentDate.Size = New Size(101, 18)
        lblCurrentDate.TabIndex = 3
        lblCurrentDate.Text = "Today's Date:"
        ' 
        ' txtFirstName
        ' 
        txtFirstName.Location = New Point(382, 73)
        txtFirstName.Name = "txtFirstName"
        txtFirstName.Size = New Size(203, 22)
        txtFirstName.TabIndex = 4
        txtFirstName.TextAlign = HorizontalAlignment.Center
        ' 
        ' btnCalcHours
        ' 
        btnCalcHours.BackColor = Color.CornflowerBlue
        btnCalcHours.Font = New Font("Tahoma", 9.75F)
        btnCalcHours.ForeColor = Color.White
        btnCalcHours.Location = New Point(265, 250)
        btnCalcHours.Name = "btnCalcHours"
        btnCalcHours.Size = New Size(114, 27)
        btnCalcHours.TabIndex = 7
        btnCalcHours.Text = "Lifetime Exercise"
        btnCalcHours.UseVisualStyleBackColor = False
        ' 
        ' btnClear
        ' 
        btnClear.BackColor = Color.CornflowerBlue
        btnClear.Font = New Font("Tahoma", 9.75F)
        btnClear.ForeColor = Color.White
        btnClear.Location = New Point(385, 250)
        btnClear.Name = "btnClear"
        btnClear.Size = New Size(114, 27)
        btnClear.TabIndex = 8
        btnClear.Text = "Clear"
        btnClear.UseVisualStyleBackColor = False
        ' 
        ' btnExit
        ' 
        btnExit.BackColor = Color.CornflowerBlue
        btnExit.Font = New Font("Tahoma", 9.75F)
        btnExit.ForeColor = Color.White
        btnExit.Location = New Point(516, 250)
        btnExit.Name = "btnExit"
        btnExit.Size = New Size(114, 27)
        btnExit.TabIndex = 9
        btnExit.Text = "Exit"
        btnExit.UseVisualStyleBackColor = False
        ' 
        ' lblResult
        ' 
        lblResult.AutoSize = True
        lblResult.BackColor = Color.White
        lblResult.Font = New Font("Tahoma", 11.25F)
        lblResult.ForeColor = Color.OrangeRed
        lblResult.Location = New Point(278, 188)
        lblResult.Name = "lblResult"
        lblResult.Size = New Size(45, 18)
        lblResult.TabIndex = 11
        lblResult.Text = "name"
        ' 
        ' lblAssume
        ' 
        lblAssume.AutoSize = True
        lblAssume.BackColor = Color.White
        lblAssume.Font = New Font("Tahoma", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblAssume.ForeColor = Color.OrangeRed
        lblAssume.Location = New Point(336, 47)
        lblAssume.Name = "lblAssume"
        lblAssume.Size = New Size(244, 16)
        lblAssume.TabIndex = 14
        lblAssume.Text = "Assuming Exercise Per Week is 2.5 Hours"
        ' 
        ' picFitness
        ' 
        picFitness.Dock = DockStyle.Left
        picFitness.Image = My.Resources.Resources.Fitness
        picFitness.Location = New Point(0, 0)
        picFitness.Name = "picFitness"
        picFitness.Size = New Size(260, 325)
        picFitness.SizeMode = PictureBoxSizeMode.StretchImage
        picFitness.TabIndex = 15
        picFitness.TabStop = False
        ' 
        ' txtCurrentDay
        ' 
        txtCurrentDay.Location = New Point(464, 145)
        txtCurrentDay.Name = "txtCurrentDay"
        txtCurrentDay.Size = New Size(36, 22)
        txtCurrentDay.TabIndex = 18
        txtCurrentDay.TextAlign = HorizontalAlignment.Center
        ' 
        ' txtCurrentMonth
        ' 
        txtCurrentMonth.Location = New Point(427, 145)
        txtCurrentMonth.Name = "txtCurrentMonth"
        txtCurrentMonth.Size = New Size(36, 22)
        txtCurrentMonth.TabIndex = 19
        txtCurrentMonth.TextAlign = HorizontalAlignment.Center
        ' 
        ' txtCurrentYear
        ' 
        txtCurrentYear.Location = New Point(385, 145)
        txtCurrentYear.Name = "txtCurrentYear"
        txtCurrentYear.Size = New Size(36, 22)
        txtCurrentYear.TabIndex = 20
        txtCurrentYear.TextAlign = HorizontalAlignment.Center
        ' 
        ' txtBirthday
        ' 
        txtBirthday.Location = New Point(464, 109)
        txtBirthday.Name = "txtBirthday"
        txtBirthday.Size = New Size(36, 22)
        txtBirthday.TabIndex = 21
        txtBirthday.TextAlign = HorizontalAlignment.Center
        ' 
        ' txtBirthMonth
        ' 
        txtBirthMonth.Location = New Point(423, 109)
        txtBirthMonth.Name = "txtBirthMonth"
        txtBirthMonth.Size = New Size(36, 22)
        txtBirthMonth.TabIndex = 22
        txtBirthMonth.TextAlign = HorizontalAlignment.Center
        ' 
        ' txtBirthYear
        ' 
        txtBirthYear.Location = New Point(382, 109)
        txtBirthYear.Name = "txtBirthYear"
        txtBirthYear.Size = New Size(36, 22)
        txtBirthYear.TabIndex = 23
        txtBirthYear.TextAlign = HorizontalAlignment.Center
        ' 
        ' lblFormat1
        ' 
        lblFormat1.AutoSize = True
        lblFormat1.BackColor = Color.White
        lblFormat1.ForeColor = Color.OrangeRed
        lblFormat1.Location = New Point(528, 112)
        lblFormat1.Name = "lblFormat1"
        lblFormat1.Size = New Size(83, 14)
        lblFormat1.TabIndex = 24
        lblFormat1.Text = "YYYY/MM/DD"
        ' 
        ' lblFormat2
        ' 
        lblFormat2.AutoSize = True
        lblFormat2.BackColor = Color.White
        lblFormat2.ForeColor = Color.OrangeRed
        lblFormat2.Location = New Point(528, 153)
        lblFormat2.Name = "lblFormat2"
        lblFormat2.Size = New Size(83, 14)
        lblFormat2.TabIndex = 25
        lblFormat2.Text = "YYYY/MM/DD"
        ' 
        ' frmFitness
        ' 
        AcceptButton = btnCalcHours
        AutoScaleDimensions = New SizeF(7F, 14F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Pink
        CancelButton = btnClear
        ClientSize = New Size(635, 325)
        Controls.Add(lblFormat2)
        Controls.Add(lblFormat1)
        Controls.Add(txtBirthYear)
        Controls.Add(txtBirthMonth)
        Controls.Add(txtBirthday)
        Controls.Add(txtCurrentYear)
        Controls.Add(txtCurrentMonth)
        Controls.Add(txtCurrentDay)
        Controls.Add(picFitness)
        Controls.Add(lblAssume)
        Controls.Add(lblResult)
        Controls.Add(btnExit)
        Controls.Add(btnClear)
        Controls.Add(btnCalcHours)
        Controls.Add(txtFirstName)
        Controls.Add(lblCurrentDate)
        Controls.Add(lblDOB)
        Controls.Add(lblFirstName)
        Controls.Add(lblHeading)
        Font = New Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Name = "frmFitness"
        Text = "Fitness Tracker App"
        CType(picFitness, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblHeading As Label
    Friend WithEvents lblFirstName As Label
    Friend WithEvents lblDOB As Label
    Friend WithEvents lblCurrentDate As Label
    Friend WithEvents txtFirstName As TextBox
    Friend WithEvents btnCalcHours As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents lblUser As Label
    Friend WithEvents lblResult As Label
    Friend WithEvents lbl As Label
    Friend WithEvents lblLifetime As Label
    Friend WithEvents lblAssume As Label
    Friend WithEvents picFitness As PictureBox
    Friend WithEvents txtCurrentDay As TextBox
    Friend WithEvents txtCurrentMonth As TextBox
    Friend WithEvents txtCurrentYear As TextBox
    Friend WithEvents txtBirthday As TextBox
    Friend WithEvents txtBirthMonth As TextBox
    Friend WithEvents txtBirthYear As TextBox
    Friend WithEvents lblFormat1 As Label
    Friend WithEvents lblFormat2 As Label

End Class
