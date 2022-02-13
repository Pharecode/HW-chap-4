<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmhoodie
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmhoodie))
        Me.lbltitle = New System.Windows.Forms.Label()
        Me.lblpriceofhoodies = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.pichoodie1 = New System.Windows.Forms.PictureBox()
        Me.pichoodie2 = New System.Windows.Forms.PictureBox()
        Me.lblpayment = New System.Windows.Forms.Label()
        Me.lbltaxes = New System.Windows.Forms.Label()
        Me.lbltotalamount = New System.Windows.Forms.Label()
        Me.btnexitwindow = New System.Windows.Forms.Button()
        Me.lblamountofhoodies = New System.Windows.Forms.Label()
        Me.txtamountofhoodies = New System.Windows.Forms.TextBox()
        Me.txtcost = New System.Windows.Forms.TextBox()
        Me.txttaxes = New System.Windows.Forms.TextBox()
        Me.txttotalamount = New System.Windows.Forms.TextBox()
        Me.lblhoodies = New System.Windows.Forms.Label()
        Me.txthoodienumber = New System.Windows.Forms.TextBox()
        Me.lblhoodie1 = New System.Windows.Forms.Label()
        Me.lblhoodie2 = New System.Windows.Forms.Label()
        Me.btnselect = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pichoodie1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pichoodie2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbltitle
        '
        Me.lbltitle.AutoSize = True
        Me.lbltitle.Font = New System.Drawing.Font("Cooper Black", 18.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltitle.Location = New System.Drawing.Point(426, 9)
        Me.lbltitle.Name = "lbltitle"
        Me.lbltitle.Size = New System.Drawing.Size(272, 35)
        Me.lbltitle.TabIndex = 0
        Me.lbltitle.Text = "The Hoodie Shop"
        '
        'lblpriceofhoodies
        '
        Me.lblpriceofhoodies.AutoSize = True
        Me.lblpriceofhoodies.Font = New System.Drawing.Font("Cooper Black", 16.2!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblpriceofhoodies.ForeColor = System.Drawing.Color.NavajoWhite
        Me.lblpriceofhoodies.Location = New System.Drawing.Point(630, 106)
        Me.lblpriceofhoodies.Name = "lblpriceofhoodies"
        Me.lblpriceofhoodies.Size = New System.Drawing.Size(330, 32)
        Me.lblpriceofhoodies.TabIndex = 1
        Me.lblpriceofhoodies.Text = "All Hoodies are $19.95"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(56, 64)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(298, 166)
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'pichoodie1
        '
        Me.pichoodie1.Image = CType(resources.GetObject("pichoodie1.Image"), System.Drawing.Image)
        Me.pichoodie1.Location = New System.Drawing.Point(625, 141)
        Me.pichoodie1.Name = "pichoodie1"
        Me.pichoodie1.Size = New System.Drawing.Size(182, 164)
        Me.pichoodie1.TabIndex = 3
        Me.pichoodie1.TabStop = False
        '
        'pichoodie2
        '
        Me.pichoodie2.Image = CType(resources.GetObject("pichoodie2.Image"), System.Drawing.Image)
        Me.pichoodie2.Location = New System.Drawing.Point(813, 141)
        Me.pichoodie2.Name = "pichoodie2"
        Me.pichoodie2.Size = New System.Drawing.Size(179, 164)
        Me.pichoodie2.TabIndex = 4
        Me.pichoodie2.TabStop = False
        '
        'lblpayment
        '
        Me.lblpayment.AutoSize = True
        Me.lblpayment.Location = New System.Drawing.Point(12, 262)
        Me.lblpayment.Name = "lblpayment"
        Me.lblpayment.Size = New System.Drawing.Size(65, 27)
        Me.lblpayment.TabIndex = 5
        Me.lblpayment.Text = "Cost"
        '
        'lbltaxes
        '
        Me.lbltaxes.AutoSize = True
        Me.lbltaxes.ForeColor = System.Drawing.Color.PaleGreen
        Me.lbltaxes.Location = New System.Drawing.Point(-1, 348)
        Me.lbltaxes.Name = "lbltaxes"
        Me.lbltaxes.Size = New System.Drawing.Size(118, 27)
        Me.lbltaxes.TabIndex = 6
        Me.lbltaxes.Text = "Tax Due:"
        '
        'lbltotalamount
        '
        Me.lbltotalamount.AutoSize = True
        Me.lbltotalamount.Location = New System.Drawing.Point(12, 437)
        Me.lbltotalamount.Name = "lbltotalamount"
        Me.lbltotalamount.Size = New System.Drawing.Size(77, 27)
        Me.lbltotalamount.TabIndex = 7
        Me.lbltotalamount.Text = "Total"
        '
        'btnexitwindow
        '
        Me.btnexitwindow.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnexitwindow.Font = New System.Drawing.Font("Cooper Black", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnexitwindow.ForeColor = System.Drawing.Color.Black
        Me.btnexitwindow.Location = New System.Drawing.Point(923, 467)
        Me.btnexitwindow.Name = "btnexitwindow"
        Me.btnexitwindow.Size = New System.Drawing.Size(100, 72)
        Me.btnexitwindow.TabIndex = 10
        Me.btnexitwindow.Text = "Exit"
        Me.btnexitwindow.UseVisualStyleBackColor = True
        '
        'lblamountofhoodies
        '
        Me.lblamountofhoodies.AutoSize = True
        Me.lblamountofhoodies.ForeColor = System.Drawing.Color.Gold
        Me.lblamountofhoodies.Location = New System.Drawing.Point(402, 111)
        Me.lblamountofhoodies.Name = "lblamountofhoodies"
        Me.lblamountofhoodies.Size = New System.Drawing.Size(130, 27)
        Me.lblamountofhoodies.TabIndex = 11
        Me.lblamountofhoodies.Text = "Quantity:"
        '
        'txtamountofhoodies
        '
        Me.txtamountofhoodies.Location = New System.Drawing.Point(407, 155)
        Me.txtamountofhoodies.Name = "txtamountofhoodies"
        Me.txtamountofhoodies.Size = New System.Drawing.Size(100, 34)
        Me.txtamountofhoodies.TabIndex = 12
        '
        'txtcost
        '
        Me.txtcost.Font = New System.Drawing.Font("Cooper Black", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcost.Location = New System.Drawing.Point(4, 292)
        Me.txtcost.Name = "txtcost"
        Me.txtcost.Size = New System.Drawing.Size(100, 34)
        Me.txtcost.TabIndex = 13
        Me.txtcost.Text = "8888"
        '
        'txttaxes
        '
        Me.txttaxes.Font = New System.Drawing.Font("Cooper Black", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txttaxes.Location = New System.Drawing.Point(4, 378)
        Me.txttaxes.Name = "txttaxes"
        Me.txttaxes.Size = New System.Drawing.Size(100, 34)
        Me.txttaxes.TabIndex = 14
        '
        'txttotalamount
        '
        Me.txttotalamount.Font = New System.Drawing.Font("Cooper Black", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txttotalamount.Location = New System.Drawing.Point(4, 467)
        Me.txttotalamount.Name = "txttotalamount"
        Me.txttotalamount.Size = New System.Drawing.Size(100, 34)
        Me.txttotalamount.TabIndex = 15
        '
        'lblhoodies
        '
        Me.lblhoodies.AutoSize = True
        Me.lblhoodies.ForeColor = System.Drawing.Color.Gold
        Me.lblhoodies.Location = New System.Drawing.Point(274, 262)
        Me.lblhoodies.Name = "lblhoodies"
        Me.lblhoodies.Size = New System.Drawing.Size(301, 27)
        Me.lblhoodies.TabIndex = 18
        Me.lblhoodies.Text = "Choose Hoodie Number:"
        '
        'txthoodienumber
        '
        Me.txthoodienumber.Location = New System.Drawing.Point(363, 309)
        Me.txthoodienumber.Name = "txthoodienumber"
        Me.txthoodienumber.Size = New System.Drawing.Size(100, 34)
        Me.txthoodienumber.TabIndex = 19
        '
        'lblhoodie1
        '
        Me.lblhoodie1.AutoSize = True
        Me.lblhoodie1.BackColor = System.Drawing.Color.Sienna
        Me.lblhoodie1.ForeColor = System.Drawing.Color.CornflowerBlue
        Me.lblhoodie1.Location = New System.Drawing.Point(662, 316)
        Me.lblhoodie1.Name = "lblhoodie1"
        Me.lblhoodie1.Size = New System.Drawing.Size(117, 27)
        Me.lblhoodie1.TabIndex = 20
        Me.lblhoodie1.Text = "Hoodie 1"
        '
        'lblhoodie2
        '
        Me.lblhoodie2.AutoSize = True
        Me.lblhoodie2.ForeColor = System.Drawing.Color.CornflowerBlue
        Me.lblhoodie2.Location = New System.Drawing.Point(843, 316)
        Me.lblhoodie2.Name = "lblhoodie2"
        Me.lblhoodie2.Size = New System.Drawing.Size(117, 27)
        Me.lblhoodie2.TabIndex = 21
        Me.lblhoodie2.Text = "Hoodie 2"
        '
        'btnselect
        '
        Me.btnselect.Font = New System.Drawing.Font("Cooper Black", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnselect.ForeColor = System.Drawing.Color.Black
        Me.btnselect.Location = New System.Drawing.Point(363, 361)
        Me.btnselect.Name = "btnselect"
        Me.btnselect.Size = New System.Drawing.Size(100, 40)
        Me.btnselect.TabIndex = 22
        Me.btnselect.Text = "Select"
        Me.btnselect.UseVisualStyleBackColor = True
        '
        'frmhoodie
        '
        Me.AcceptButton = Me.btnselect
        Me.AutoScaleDimensions = New System.Drawing.SizeF(15.0!, 26.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Sienna
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.CancelButton = Me.btnexitwindow
        Me.ClientSize = New System.Drawing.Size(1026, 538)
        Me.Controls.Add(Me.btnselect)
        Me.Controls.Add(Me.lblhoodie2)
        Me.Controls.Add(Me.lblhoodie1)
        Me.Controls.Add(Me.txthoodienumber)
        Me.Controls.Add(Me.lblhoodies)
        Me.Controls.Add(Me.txttotalamount)
        Me.Controls.Add(Me.txttaxes)
        Me.Controls.Add(Me.txtcost)
        Me.Controls.Add(Me.txtamountofhoodies)
        Me.Controls.Add(Me.lblamountofhoodies)
        Me.Controls.Add(Me.btnexitwindow)
        Me.Controls.Add(Me.lbltotalamount)
        Me.Controls.Add(Me.lbltaxes)
        Me.Controls.Add(Me.lblpayment)
        Me.Controls.Add(Me.pichoodie2)
        Me.Controls.Add(Me.pichoodie1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.lblpriceofhoodies)
        Me.Controls.Add(Me.lbltitle)
        Me.Font = New System.Drawing.Font("Cooper Black", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.BurlyWood
        Me.Margin = New System.Windows.Forms.Padding(6, 5, 6, 5)
        Me.Name = "frmhoodie"
        Me.Text = "The Hoodie Shop"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pichoodie1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pichoodie2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbltitle As Label
    Friend WithEvents lblpriceofhoodies As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents pichoodie1 As PictureBox
    Friend WithEvents pichoodie2 As PictureBox
    Friend WithEvents lblpayment As Label
    Friend WithEvents lbltaxes As Label
    Friend WithEvents lbltotalamount As Label
    Friend WithEvents btnexitwindow As Button
    Friend WithEvents lblamountofhoodies As Label
    Friend WithEvents txtamountofhoodies As TextBox
    Friend WithEvents txtcost As TextBox
    Friend WithEvents txttaxes As TextBox
    Friend WithEvents txttotalamount As TextBox
    Friend WithEvents lblhoodies As Label
    Friend WithEvents txthoodienumber As TextBox
    Friend WithEvents lblhoodie1 As Label
    Friend WithEvents lblhoodie2 As Label
    Friend WithEvents btnselect As Button
End Class
