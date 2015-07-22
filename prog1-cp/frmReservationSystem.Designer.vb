<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmReservationSystem
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmReservationSystem))
        Me.lblHeading01 = New System.Windows.Forms.Label()
        Me.lblHeading03 = New System.Windows.Forms.Label()
        Me.txtGroupSize = New System.Windows.Forms.TextBox()
        Me.btnDisplayInvoice = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.picLogo = New System.Windows.Forms.PictureBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.lblTour11 = New System.Windows.Forms.Label()
        Me.lstTourList = New System.Windows.Forms.ListBox()
        Me.lblTour21 = New System.Windows.Forms.Label()
        Me.lblTour31 = New System.Windows.Forms.Label()
        Me.lblTour1Description = New System.Windows.Forms.Label()
        Me.lblTour2Description = New System.Windows.Forms.Label()
        Me.lblTour3Description = New System.Windows.Forms.Label()
        Me.txtChildrenNumber = New System.Windows.Forms.TextBox()
        Me.lblGroupSize = New System.Windows.Forms.Label()
        Me.lblChildrenUnder12 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.lblInvoiceHeader = New System.Windows.Forms.Label()
        Me.pnlInvoice = New System.Windows.Forms.Panel()
        Me.lblSubtotal = New System.Windows.Forms.Label()
        Me.lblSubtotalLabel = New System.Windows.Forms.Label()
        Me.lblTour3Total = New System.Windows.Forms.Label()
        Me.lblTaxLabel = New System.Windows.Forms.Label()
        Me.lblTour3TotalLabel = New System.Windows.Forms.Label()
        Me.lblTour1TotalLabel = New System.Windows.Forms.Label()
        Me.lblTour2Total = New System.Windows.Forms.Label()
        Me.lblServiceChargeLabel = New System.Windows.Forms.Label()
        Me.lblTour2TotalLabel = New System.Windows.Forms.Label()
        Me.lblFinalTotalLabel = New System.Windows.Forms.Label()
        Me.lblGroupDiscount = New System.Windows.Forms.Label()
        Me.lblTour1Total = New System.Windows.Forms.Label()
        Me.lblTourSubtotalLabel = New System.Windows.Forms.Label()
        Me.lblTax = New System.Windows.Forms.Label()
        Me.lblTourSubtotal = New System.Windows.Forms.Label()
        Me.lblServiceCharge = New System.Windows.Forms.Label()
        Me.lblChildDiscount = New System.Windows.Forms.Label()
        Me.lblFinalTotal = New System.Windows.Forms.Label()
        Me.lblGroupDiscountLabel = New System.Windows.Forms.Label()
        Me.lblChildDiscountLabel = New System.Windows.Forms.Label()
        Me.pnlTourDescription = New System.Windows.Forms.Panel()
        Me.rdoAdventure = New System.Windows.Forms.RadioButton()
        Me.rdoEducational = New System.Windows.Forms.RadioButton()
        Me.rdoMilitary = New System.Windows.Forms.RadioButton()
        Me.btnSelectTours = New System.Windows.Forms.Button()
        Me.btnClearTourSelection = New System.Windows.Forms.Button()
        Me.DirectoryEntry1 = New System.DirectoryServices.DirectoryEntry()
        CType(Me.picLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlInvoice.SuspendLayout()
        Me.pnlTourDescription.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblHeading01
        '
        Me.lblHeading01.AutoSize = True
        Me.lblHeading01.Font = New System.Drawing.Font("Tahoma", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHeading01.Location = New System.Drawing.Point(188, 9)
        Me.lblHeading01.Name = "lblHeading01"
        Me.lblHeading01.Size = New System.Drawing.Size(323, 78)
        Me.lblHeading01.TabIndex = 0
        Me.lblHeading01.Text = "Columbus Agency " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "for Regional Travel"
        Me.lblHeading01.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblHeading03
        '
        Me.lblHeading03.AutoSize = True
        Me.lblHeading03.Font = New System.Drawing.Font("Tahoma", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHeading03.ForeColor = System.Drawing.Color.ForestGreen
        Me.lblHeading03.Location = New System.Drawing.Point(224, 97)
        Me.lblHeading03.Name = "lblHeading03"
        Me.lblHeading03.Size = New System.Drawing.Size(250, 29)
        Me.lblHeading03.TabIndex = 1
        Me.lblHeading03.Text = "Reservation System"
        '
        'txtGroupSize
        '
        Me.txtGroupSize.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtGroupSize.Location = New System.Drawing.Point(211, 432)
        Me.txtGroupSize.Name = "txtGroupSize"
        Me.txtGroupSize.Size = New System.Drawing.Size(36, 22)
        Me.txtGroupSize.TabIndex = 5
        '
        'btnDisplayInvoice
        '
        Me.btnDisplayInvoice.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btnDisplayInvoice.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDisplayInvoice.Location = New System.Drawing.Point(24, 495)
        Me.btnDisplayInvoice.Name = "btnDisplayInvoice"
        Me.btnDisplayInvoice.Size = New System.Drawing.Size(120, 25)
        Me.btnDisplayInvoice.TabIndex = 20
        Me.btnDisplayInvoice.Text = "Display Invoice"
        Me.btnDisplayInvoice.UseVisualStyleBackColor = False
        '
        'btnClear
        '
        Me.btnClear.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btnClear.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.Location = New System.Drawing.Point(165, 495)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(103, 25)
        Me.btnClear.TabIndex = 21
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = False
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btnExit.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.Location = New System.Drawing.Point(289, 495)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(103, 25)
        Me.btnExit.TabIndex = 22
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'picLogo
        '
        Me.picLogo.Image = Global.prog1_cp.My.Resources.Resources.White_Water_Rafting_Clipart
        Me.picLogo.Location = New System.Drawing.Point(21, 9)
        Me.picLogo.Name = "picLogo"
        Me.picLogo.Size = New System.Drawing.Size(140, 120)
        Me.picLogo.TabIndex = 23
        Me.picLogo.TabStop = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(18, 141)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(140, 16)
        Me.Label7.TabIndex = 39
        Me.Label7.Text = "Select Tour Type(s):"
        '
        'lblTour11
        '
        Me.lblTour11.AutoSize = True
        Me.lblTour11.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTour11.Location = New System.Drawing.Point(6, 8)
        Me.lblTour11.Name = "lblTour11"
        Me.lblTour11.Size = New System.Drawing.Size(42, 13)
        Me.lblTour11.TabIndex = 44
        Me.lblTour11.Text = "Tour 1:"
        '
        'lstTourList
        '
        Me.lstTourList.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstTourList.FormattingEnabled = True
        Me.lstTourList.Location = New System.Drawing.Point(21, 185)
        Me.lstTourList.Name = "lstTourList"
        Me.lstTourList.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lstTourList.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple
        Me.lstTourList.Size = New System.Drawing.Size(372, 82)
        Me.lstTourList.TabIndex = 45
        Me.lstTourList.Visible = False
        '
        'lblTour21
        '
        Me.lblTour21.AutoSize = True
        Me.lblTour21.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTour21.Location = New System.Drawing.Point(6, 42)
        Me.lblTour21.Name = "lblTour21"
        Me.lblTour21.Size = New System.Drawing.Size(42, 13)
        Me.lblTour21.TabIndex = 48
        Me.lblTour21.Text = "Tour 2:"
        '
        'lblTour31
        '
        Me.lblTour31.AutoSize = True
        Me.lblTour31.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTour31.Location = New System.Drawing.Point(6, 75)
        Me.lblTour31.Name = "lblTour31"
        Me.lblTour31.Size = New System.Drawing.Size(45, 13)
        Me.lblTour31.TabIndex = 49
        Me.lblTour31.Text = "Tour 3: "
        '
        'lblTour1Description
        '
        Me.lblTour1Description.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTour1Description.Location = New System.Drawing.Point(47, 8)
        Me.lblTour1Description.Name = "lblTour1Description"
        Me.lblTour1Description.Size = New System.Drawing.Size(330, 27)
        Me.lblTour1Description.TabIndex = 50
        Me.lblTour1Description.Text = "Label15"
        '
        'lblTour2Description
        '
        Me.lblTour2Description.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTour2Description.Location = New System.Drawing.Point(47, 42)
        Me.lblTour2Description.Name = "lblTour2Description"
        Me.lblTour2Description.Size = New System.Drawing.Size(330, 27)
        Me.lblTour2Description.TabIndex = 51
        Me.lblTour2Description.Text = "Label16"
        '
        'lblTour3Description
        '
        Me.lblTour3Description.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTour3Description.Location = New System.Drawing.Point(47, 75)
        Me.lblTour3Description.Name = "lblTour3Description"
        Me.lblTour3Description.Size = New System.Drawing.Size(330, 27)
        Me.lblTour3Description.TabIndex = 52
        Me.lblTour3Description.Text = "Label17"
        '
        'txtChildrenNumber
        '
        Me.txtChildrenNumber.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtChildrenNumber.Location = New System.Drawing.Point(211, 460)
        Me.txtChildrenNumber.Name = "txtChildrenNumber"
        Me.txtChildrenNumber.Size = New System.Drawing.Size(36, 21)
        Me.txtChildrenNumber.TabIndex = 54
        '
        'lblGroupSize
        '
        Me.lblGroupSize.AutoSize = True
        Me.lblGroupSize.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGroupSize.Location = New System.Drawing.Point(24, 440)
        Me.lblGroupSize.Name = "lblGroupSize"
        Me.lblGroupSize.Size = New System.Drawing.Size(69, 14)
        Me.lblGroupSize.TabIndex = 55
        Me.lblGroupSize.Text = "Group Size:"
        '
        'lblChildrenUnder12
        '
        Me.lblChildrenUnder12.AutoSize = True
        Me.lblChildrenUnder12.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblChildrenUnder12.Location = New System.Drawing.Point(24, 467)
        Me.lblChildrenUnder12.Name = "lblChildrenUnder12"
        Me.lblChildrenUnder12.Size = New System.Drawing.Size(171, 14)
        Me.lblChildrenUnder12.TabIndex = 56
        Me.lblChildrenUnder12.Text = "Number of Childern Under 12:"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(546, 9)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(140, 120)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 58
        Me.PictureBox1.TabStop = False
        '
        'lblInvoiceHeader
        '
        Me.lblInvoiceHeader.AutoSize = True
        Me.lblInvoiceHeader.Font = New System.Drawing.Font("Tahoma", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInvoiceHeader.ForeColor = System.Drawing.Color.ForestGreen
        Me.lblInvoiceHeader.Location = New System.Drawing.Point(3, 17)
        Me.lblInvoiceHeader.Name = "lblInvoiceHeader"
        Me.lblInvoiceHeader.Size = New System.Drawing.Size(203, 29)
        Me.lblInvoiceHeader.TabIndex = 57
        Me.lblInvoiceHeader.Text = "FINAL INVOICE"
        '
        'pnlInvoice
        '
        Me.pnlInvoice.Controls.Add(Me.lblSubtotal)
        Me.pnlInvoice.Controls.Add(Me.lblSubtotalLabel)
        Me.pnlInvoice.Controls.Add(Me.lblInvoiceHeader)
        Me.pnlInvoice.Controls.Add(Me.lblTour3Total)
        Me.pnlInvoice.Controls.Add(Me.lblTaxLabel)
        Me.pnlInvoice.Controls.Add(Me.lblTour3TotalLabel)
        Me.pnlInvoice.Controls.Add(Me.lblTour1TotalLabel)
        Me.pnlInvoice.Controls.Add(Me.lblTour2Total)
        Me.pnlInvoice.Controls.Add(Me.lblServiceChargeLabel)
        Me.pnlInvoice.Controls.Add(Me.lblTour2TotalLabel)
        Me.pnlInvoice.Controls.Add(Me.lblFinalTotalLabel)
        Me.pnlInvoice.Controls.Add(Me.lblGroupDiscount)
        Me.pnlInvoice.Controls.Add(Me.lblTour1Total)
        Me.pnlInvoice.Controls.Add(Me.lblTourSubtotalLabel)
        Me.pnlInvoice.Controls.Add(Me.lblTax)
        Me.pnlInvoice.Controls.Add(Me.lblTourSubtotal)
        Me.pnlInvoice.Controls.Add(Me.lblServiceCharge)
        Me.pnlInvoice.Controls.Add(Me.lblChildDiscount)
        Me.pnlInvoice.Controls.Add(Me.lblFinalTotal)
        Me.pnlInvoice.Controls.Add(Me.lblGroupDiscountLabel)
        Me.pnlInvoice.Controls.Add(Me.lblChildDiscountLabel)
        Me.pnlInvoice.Location = New System.Drawing.Point(426, 178)
        Me.pnlInvoice.Name = "pnlInvoice"
        Me.pnlInvoice.Size = New System.Drawing.Size(260, 323)
        Me.pnlInvoice.TabIndex = 62
        '
        'lblSubtotal
        '
        Me.lblSubtotal.AutoSize = True
        Me.lblSubtotal.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSubtotal.Location = New System.Drawing.Point(149, 177)
        Me.lblSubtotal.Name = "lblSubtotal"
        Me.lblSubtotal.Size = New System.Drawing.Size(46, 14)
        Me.lblSubtotal.TabIndex = 59
        Me.lblSubtotal.Text = "$88.88"
        '
        'lblSubtotalLabel
        '
        Me.lblSubtotalLabel.AutoSize = True
        Me.lblSubtotalLabel.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSubtotalLabel.Location = New System.Drawing.Point(5, 177)
        Me.lblSubtotalLabel.Name = "lblSubtotalLabel"
        Me.lblSubtotalLabel.Size = New System.Drawing.Size(80, 14)
        Me.lblSubtotalLabel.TabIndex = 58
        Me.lblSubtotalLabel.Text = "Final Subtotal"
        '
        'lblTour3Total
        '
        Me.lblTour3Total.AutoSize = True
        Me.lblTour3Total.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTour3Total.Location = New System.Drawing.Point(149, 101)
        Me.lblTour3Total.Name = "lblTour3Total"
        Me.lblTour3Total.Size = New System.Drawing.Size(46, 14)
        Me.lblTour3Total.TabIndex = 43
        Me.lblTour3Total.Text = "$88.88"
        '
        'lblTaxLabel
        '
        Me.lblTaxLabel.AutoSize = True
        Me.lblTaxLabel.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTaxLabel.Location = New System.Drawing.Point(5, 196)
        Me.lblTaxLabel.Name = "lblTaxLabel"
        Me.lblTaxLabel.Size = New System.Drawing.Size(31, 14)
        Me.lblTaxLabel.TabIndex = 10
        Me.lblTaxLabel.Text = "Tax:"
        '
        'lblTour3TotalLabel
        '
        Me.lblTour3TotalLabel.AutoSize = True
        Me.lblTour3TotalLabel.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTour3TotalLabel.Location = New System.Drawing.Point(5, 101)
        Me.lblTour3TotalLabel.Name = "lblTour3TotalLabel"
        Me.lblTour3TotalLabel.Size = New System.Drawing.Size(80, 14)
        Me.lblTour3TotalLabel.TabIndex = 42
        Me.lblTour3TotalLabel.Text = "Tour 3 Total:"
        '
        'lblTour1TotalLabel
        '
        Me.lblTour1TotalLabel.AutoSize = True
        Me.lblTour1TotalLabel.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTour1TotalLabel.Location = New System.Drawing.Point(5, 63)
        Me.lblTour1TotalLabel.Name = "lblTour1TotalLabel"
        Me.lblTour1TotalLabel.Size = New System.Drawing.Size(80, 14)
        Me.lblTour1TotalLabel.TabIndex = 11
        Me.lblTour1TotalLabel.Text = "Tour 1 Total:"
        '
        'lblTour2Total
        '
        Me.lblTour2Total.AutoSize = True
        Me.lblTour2Total.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTour2Total.Location = New System.Drawing.Point(149, 82)
        Me.lblTour2Total.Name = "lblTour2Total"
        Me.lblTour2Total.Size = New System.Drawing.Size(46, 14)
        Me.lblTour2Total.TabIndex = 41
        Me.lblTour2Total.Text = "$88.88"
        '
        'lblServiceChargeLabel
        '
        Me.lblServiceChargeLabel.AutoSize = True
        Me.lblServiceChargeLabel.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblServiceChargeLabel.Location = New System.Drawing.Point(5, 215)
        Me.lblServiceChargeLabel.Name = "lblServiceChargeLabel"
        Me.lblServiceChargeLabel.Size = New System.Drawing.Size(92, 14)
        Me.lblServiceChargeLabel.TabIndex = 12
        Me.lblServiceChargeLabel.Text = "Service Charge:"
        '
        'lblTour2TotalLabel
        '
        Me.lblTour2TotalLabel.AutoSize = True
        Me.lblTour2TotalLabel.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTour2TotalLabel.Location = New System.Drawing.Point(5, 82)
        Me.lblTour2TotalLabel.Name = "lblTour2TotalLabel"
        Me.lblTour2TotalLabel.Size = New System.Drawing.Size(80, 14)
        Me.lblTour2TotalLabel.TabIndex = 40
        Me.lblTour2TotalLabel.Text = "Tour 2 Total:"
        '
        'lblFinalTotalLabel
        '
        Me.lblFinalTotalLabel.AutoSize = True
        Me.lblFinalTotalLabel.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFinalTotalLabel.ForeColor = System.Drawing.Color.ForestGreen
        Me.lblFinalTotalLabel.Location = New System.Drawing.Point(5, 242)
        Me.lblFinalTotalLabel.Name = "lblFinalTotalLabel"
        Me.lblFinalTotalLabel.Size = New System.Drawing.Size(62, 18)
        Me.lblFinalTotalLabel.TabIndex = 13
        Me.lblFinalTotalLabel.Text = "TOTAL:"
        '
        'lblGroupDiscount
        '
        Me.lblGroupDiscount.AutoSize = True
        Me.lblGroupDiscount.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGroupDiscount.Location = New System.Drawing.Point(149, 158)
        Me.lblGroupDiscount.Name = "lblGroupDiscount"
        Me.lblGroupDiscount.Size = New System.Drawing.Size(46, 14)
        Me.lblGroupDiscount.TabIndex = 38
        Me.lblGroupDiscount.Text = "$88.88"
        '
        'lblTour1Total
        '
        Me.lblTour1Total.AutoSize = True
        Me.lblTour1Total.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTour1Total.Location = New System.Drawing.Point(149, 63)
        Me.lblTour1Total.Name = "lblTour1Total"
        Me.lblTour1Total.Size = New System.Drawing.Size(46, 14)
        Me.lblTour1Total.TabIndex = 14
        Me.lblTour1Total.Text = "$88.88"
        '
        'lblTourSubtotalLabel
        '
        Me.lblTourSubtotalLabel.AutoSize = True
        Me.lblTourSubtotalLabel.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTourSubtotalLabel.Location = New System.Drawing.Point(5, 120)
        Me.lblTourSubtotalLabel.Name = "lblTourSubtotalLabel"
        Me.lblTourSubtotalLabel.Size = New System.Drawing.Size(87, 14)
        Me.lblTourSubtotalLabel.TabIndex = 37
        Me.lblTourSubtotalLabel.Text = "Tour Subtotal:"
        '
        'lblTax
        '
        Me.lblTax.AutoSize = True
        Me.lblTax.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTax.Location = New System.Drawing.Point(149, 196)
        Me.lblTax.Name = "lblTax"
        Me.lblTax.Size = New System.Drawing.Size(46, 14)
        Me.lblTax.TabIndex = 15
        Me.lblTax.Text = "$88.88"
        '
        'lblTourSubtotal
        '
        Me.lblTourSubtotal.AutoSize = True
        Me.lblTourSubtotal.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTourSubtotal.Location = New System.Drawing.Point(149, 120)
        Me.lblTourSubtotal.Name = "lblTourSubtotal"
        Me.lblTourSubtotal.Size = New System.Drawing.Size(46, 14)
        Me.lblTourSubtotal.TabIndex = 36
        Me.lblTourSubtotal.Text = "$88.88"
        '
        'lblServiceCharge
        '
        Me.lblServiceCharge.AutoSize = True
        Me.lblServiceCharge.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblServiceCharge.Location = New System.Drawing.Point(149, 215)
        Me.lblServiceCharge.Name = "lblServiceCharge"
        Me.lblServiceCharge.Size = New System.Drawing.Size(46, 14)
        Me.lblServiceCharge.TabIndex = 16
        Me.lblServiceCharge.Text = "$88.88"
        '
        'lblChildDiscount
        '
        Me.lblChildDiscount.AutoSize = True
        Me.lblChildDiscount.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblChildDiscount.Location = New System.Drawing.Point(149, 139)
        Me.lblChildDiscount.Name = "lblChildDiscount"
        Me.lblChildDiscount.Size = New System.Drawing.Size(46, 14)
        Me.lblChildDiscount.TabIndex = 35
        Me.lblChildDiscount.Text = "$88.88"
        '
        'lblFinalTotal
        '
        Me.lblFinalTotal.AutoSize = True
        Me.lblFinalTotal.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFinalTotal.ForeColor = System.Drawing.Color.ForestGreen
        Me.lblFinalTotal.Location = New System.Drawing.Point(143, 242)
        Me.lblFinalTotal.Name = "lblFinalTotal"
        Me.lblFinalTotal.Size = New System.Drawing.Size(63, 18)
        Me.lblFinalTotal.TabIndex = 17
        Me.lblFinalTotal.Text = "$88.88"
        '
        'lblGroupDiscountLabel
        '
        Me.lblGroupDiscountLabel.AutoSize = True
        Me.lblGroupDiscountLabel.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGroupDiscountLabel.Location = New System.Drawing.Point(5, 158)
        Me.lblGroupDiscountLabel.Name = "lblGroupDiscountLabel"
        Me.lblGroupDiscountLabel.Size = New System.Drawing.Size(129, 14)
        Me.lblGroupDiscountLabel.TabIndex = 34
        Me.lblGroupDiscountLabel.Text = "Large Group Discount:"
        '
        'lblChildDiscountLabel
        '
        Me.lblChildDiscountLabel.AutoSize = True
        Me.lblChildDiscountLabel.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblChildDiscountLabel.Location = New System.Drawing.Point(5, 139)
        Me.lblChildDiscountLabel.Name = "lblChildDiscountLabel"
        Me.lblChildDiscountLabel.Size = New System.Drawing.Size(87, 14)
        Me.lblChildDiscountLabel.TabIndex = 33
        Me.lblChildDiscountLabel.Text = "Child Discount:"
        '
        'pnlTourDescription
        '
        Me.pnlTourDescription.Controls.Add(Me.lblTour3Description)
        Me.pnlTourDescription.Controls.Add(Me.lblTour1Description)
        Me.pnlTourDescription.Controls.Add(Me.lblTour2Description)
        Me.pnlTourDescription.Controls.Add(Me.lblTour11)
        Me.pnlTourDescription.Controls.Add(Me.lblTour21)
        Me.pnlTourDescription.Controls.Add(Me.lblTour31)
        Me.pnlTourDescription.Location = New System.Drawing.Point(12, 317)
        Me.pnlTourDescription.Name = "pnlTourDescription"
        Me.pnlTourDescription.Size = New System.Drawing.Size(381, 109)
        Me.pnlTourDescription.TabIndex = 63
        '
        'rdoAdventure
        '
        Me.rdoAdventure.AutoSize = True
        Me.rdoAdventure.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdoAdventure.Location = New System.Drawing.Point(21, 160)
        Me.rdoAdventure.Name = "rdoAdventure"
        Me.rdoAdventure.Size = New System.Drawing.Size(83, 18)
        Me.rdoAdventure.TabIndex = 64
        Me.rdoAdventure.TabStop = True
        Me.rdoAdventure.Text = "Adventure"
        Me.rdoAdventure.UseVisualStyleBackColor = True
        '
        'rdoEducational
        '
        Me.rdoEducational.AutoSize = True
        Me.rdoEducational.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdoEducational.Location = New System.Drawing.Point(156, 160)
        Me.rdoEducational.Name = "rdoEducational"
        Me.rdoEducational.Size = New System.Drawing.Size(87, 18)
        Me.rdoEducational.TabIndex = 65
        Me.rdoEducational.TabStop = True
        Me.rdoEducational.Text = "Educational"
        Me.rdoEducational.UseVisualStyleBackColor = True
        '
        'rdoMilitary
        '
        Me.rdoMilitary.AutoSize = True
        Me.rdoMilitary.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdoMilitary.Location = New System.Drawing.Point(289, 160)
        Me.rdoMilitary.Name = "rdoMilitary"
        Me.rdoMilitary.Size = New System.Drawing.Size(61, 18)
        Me.rdoMilitary.TabIndex = 66
        Me.rdoMilitary.TabStop = True
        Me.rdoMilitary.Text = "Military"
        Me.rdoMilitary.UseVisualStyleBackColor = True
        '
        'btnSelectTours
        '
        Me.btnSelectTours.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSelectTours.Location = New System.Drawing.Point(21, 277)
        Me.btnSelectTours.Name = "btnSelectTours"
        Me.btnSelectTours.Size = New System.Drawing.Size(100, 23)
        Me.btnSelectTours.TabIndex = 67
        Me.btnSelectTours.Text = "Select Tours"
        Me.btnSelectTours.UseVisualStyleBackColor = True
        '
        'btnClearTourSelection
        '
        Me.btnClearTourSelection.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClearTourSelection.Location = New System.Drawing.Point(156, 278)
        Me.btnClearTourSelection.Name = "btnClearTourSelection"
        Me.btnClearTourSelection.Size = New System.Drawing.Size(127, 23)
        Me.btnClearTourSelection.TabIndex = 68
        Me.btnClearTourSelection.Text = "Clear Tour Selection"
        Me.btnClearTourSelection.UseVisualStyleBackColor = True
        '
        'frmReservationSystem
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(699, 536)
        Me.Controls.Add(Me.btnClearTourSelection)
        Me.Controls.Add(Me.btnSelectTours)
        Me.Controls.Add(Me.rdoMilitary)
        Me.Controls.Add(Me.rdoEducational)
        Me.Controls.Add(Me.rdoAdventure)
        Me.Controls.Add(Me.lblChildrenUnder12)
        Me.Controls.Add(Me.txtChildrenNumber)
        Me.Controls.Add(Me.lblGroupSize)
        Me.Controls.Add(Me.pnlTourDescription)
        Me.Controls.Add(Me.pnlInvoice)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.txtGroupSize)
        Me.Controls.Add(Me.lstTourList)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.picLogo)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnDisplayInvoice)
        Me.Controls.Add(Me.lblHeading03)
        Me.Controls.Add(Me.lblHeading01)
        Me.Name = "frmReservationSystem"
        Me.Text = "CART Reservation System"
        CType(Me.picLogo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlInvoice.ResumeLayout(False)
        Me.pnlInvoice.PerformLayout()
        Me.pnlTourDescription.ResumeLayout(False)
        Me.pnlTourDescription.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblHeading01 As System.Windows.Forms.Label
    Friend WithEvents lblHeading03 As System.Windows.Forms.Label
    Friend WithEvents lblTour12 As System.Windows.Forms.Label
    Friend WithEvents txtTour2Size As System.Windows.Forms.TextBox
    Friend WithEvents lblTour22 As System.Windows.Forms.Label
    Friend WithEvents txtGroupSize As System.Windows.Forms.TextBox
    Friend WithEvents txtTour3Children As System.Windows.Forms.TextBox
    Friend WithEvents txtTour2Children As System.Windows.Forms.TextBox
    Friend WithEvents lblTour32 As System.Windows.Forms.Label
    Friend WithEvents txtTour3Size As System.Windows.Forms.TextBox
    Friend WithEvents btnDisplayInvoice As System.Windows.Forms.Button
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents picLogo As System.Windows.Forms.PictureBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents lblTour11 As System.Windows.Forms.Label
    Friend WithEvents lstTourList As System.Windows.Forms.ListBox
    Friend WithEvents lblTour21 As System.Windows.Forms.Label
    Friend WithEvents lblTour31 As System.Windows.Forms.Label
    Friend WithEvents lblTour1Description As System.Windows.Forms.Label
    Friend WithEvents lblTour2Description As System.Windows.Forms.Label
    Friend WithEvents lblTour3Description As System.Windows.Forms.Label
    Friend WithEvents lblGroupDescription As System.Windows.Forms.Label
    Friend WithEvents txtChildrenNumber As System.Windows.Forms.TextBox
    Friend WithEvents lblGroupSize As System.Windows.Forms.Label
    Friend WithEvents lblChildrenUnder12 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents lblInvoiceHeader As System.Windows.Forms.Label
    Friend WithEvents pnlInvoice As System.Windows.Forms.Panel
    Friend WithEvents lblTour3Total As System.Windows.Forms.Label
    Friend WithEvents lblTaxLabel As System.Windows.Forms.Label
    Friend WithEvents lblTour3TotalLabel As System.Windows.Forms.Label
    Friend WithEvents lblTour1TotalLabel As System.Windows.Forms.Label
    Friend WithEvents lblTour2Total As System.Windows.Forms.Label
    Friend WithEvents lblServiceChargeLabel As System.Windows.Forms.Label
    Friend WithEvents lblTour2TotalLabel As System.Windows.Forms.Label
    Friend WithEvents lblFinalTotalLabel As System.Windows.Forms.Label
    Friend WithEvents lblGroupDiscount As System.Windows.Forms.Label
    Friend WithEvents lblTour1Total As System.Windows.Forms.Label
    Friend WithEvents lblTourSubtotalLabel As System.Windows.Forms.Label
    Friend WithEvents lblTax As System.Windows.Forms.Label
    Friend WithEvents lblTourSubtotal As System.Windows.Forms.Label
    Friend WithEvents lblServiceCharge As System.Windows.Forms.Label
    Friend WithEvents lblChildDiscount As System.Windows.Forms.Label
    Friend WithEvents lblFinalTotal As System.Windows.Forms.Label
    Friend WithEvents lblGroupDiscountLabel As System.Windows.Forms.Label
    Friend WithEvents lblChildDiscountLabel As System.Windows.Forms.Label
    Friend WithEvents pnlTourDescription As System.Windows.Forms.Panel
    Friend WithEvents pnlGroupDescription As System.Windows.Forms.Panel
    Friend WithEvents rdoAdventure As System.Windows.Forms.RadioButton
    Friend WithEvents rdoEducational As System.Windows.Forms.RadioButton
    Friend WithEvents rdoMilitary As System.Windows.Forms.RadioButton
    Friend WithEvents btnSelectTours As System.Windows.Forms.Button
    Friend WithEvents btnClearTourSelection As System.Windows.Forms.Button
    Friend WithEvents lblSubtotal As System.Windows.Forms.Label
    Friend WithEvents lblSubtotalLabel As System.Windows.Forms.Label
    Friend WithEvents DirectoryEntry1 As System.DirectoryServices.DirectoryEntry

End Class
