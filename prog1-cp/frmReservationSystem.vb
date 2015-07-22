'****************************************************************************** 
' PROGRAM: Columbus Agency for Regional Travel v2
' AUTHOR: Crystal Pendergrass
' DATE: 3 April 2015
' PURPOSE: The Columbus Agency for Regional Travel Reservation System allows 
' the customer to view different types of tours and compute the cost of the 
' customer’s reservation.  
'******************************************************************************

Option Strict On
Public Class frmReservationSystem
    ' constants for this application
    Const cdecDiscountChild As Decimal = 0.35D
    Const cdecDiscountLargeGroup As Decimal = 0.05D
    Const cdecPricePerWhitewaterClassic As Decimal = 32.5D
    Const cdecPricePerWhitewaterHighwater As Decimal = 48.5D
    Const cdecPricePerZipLine As Decimal = 16D
    Const cdecPricePerCanopyBoat As Decimal = 21D
    Const cdecPricePerOxbowMeadows As Decimal = 20D
    Const cdecPricePerCocaColaSpace As Decimal = 18D
    Const cdecPricePerHistoricDistrict As Decimal = 15D
    Const cdecPricePerInfantryMusuem As Decimal = 22D
    Const cdecPricePerPortColumbus As Decimal = 10D
    Const cdecTaxPercent As Decimal = 0.15D
    Const cdecServiceChargePercent As Decimal = 0.07D
    Const cintMaxNumberOfTours As Integer = 3
    Const cintLargeGroupSize As Integer = 10

    Dim intCountChildren As Integer
    Dim intGroupSize As Integer
    Dim decPricePerTour1 As Decimal
    Dim decPricePerTour2 As Decimal
    Dim decPricePerTour3 As Decimal

    Dim strTours(cintMaxNumberOfTours) As String

    '****************************************************************************** 
    'When the formed is loaded the "Display Invoice" button is disabled, radiobuttons 
    'are blank.  
    '******************************************************************************
    Private Sub frmReservationSystem_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        rdoAdventure.Checked = False
        rdoEducational.Checked = False
        rdoMilitary.Checked = False

        MakeObjectsInvisible()
    End Sub

    '****************************************************************************** 
    'When the Adventure radiobutton is selected, a list of tours for this category
    'is displayed .  If any previous tours were selected, they are erased.  
    '******************************************************************************
    Private Sub rdoAdventure_CheckedChanged(sender As Object, e As EventArgs) Handles rdoAdventure.CheckedChanged
        If (rdoAdventure.Checked) Then
            EraseTours()
            lstTourList.Visible = True
            MakeObjectsVisible()
            lstTourList.Items.Clear()
            lstTourList.Items.Add("Whitewater Classic")
            lstTourList.Items.Add("Whitewater Highwater")
            lstTourList.Items.Add("Zip Line")
            lstTourList.Items.Add("Canopy Boat")
        Else
            lstTourList.Visible = False
            MakeObjectsInvisible()
        End If
    End Sub

    '****************************************************************************** 
    'When the Educational radiobutton is selected, a list of tours for this category
    'is displayed .  If any previous tours were selected, they are erased.  
    '******************************************************************************
    Private Sub rdoEducational_CheckedChanged(sender As Object, e As EventArgs) Handles rdoEducational.CheckedChanged
        If (rdoEducational.Checked) Then
            EraseTours()
            lstTourList.Visible = True
            MakeObjectsVisible()
            lstTourList.Items.Clear()
            lstTourList.Items.Add("Oxbow Meadows with Canopy Treetop Bridge")
            lstTourList.Items.Add("Coca Cola Space Science Center with Planetarium")
            lstTourList.Items.Add("Historic District and Columbus Museum Tour including Pemberton’s Pharmacy and McCullers House")
        Else
            lstTourList.Visible = False
            MakeObjectsInvisible()
        End If
    End Sub

    '****************************************************************************** 
    'When the Military radiobutton is selected, a list of tours for this category
    'is displayed .  If any previous tours were selected, they are erased.  
    '******************************************************************************
    Private Sub rdoMilitary_CheckedChanged(sender As Object, e As EventArgs) Handles rdoMilitary.CheckedChanged
        If (rdoMilitary.Checked) Then
            EraseTours()
            lstTourList.Visible = True
            MakeObjectsVisible()
            lstTourList.Items.Clear()
            lstTourList.Items.Add("Infantry Museum including iMax movie")
            lstTourList.Items.Add("Port Columbus Civil War Naval Museum")
        Else
            lstTourList.Visible = False
            MakeObjectsInvisible()
        End If
    End Sub

    '****************************************************************************** 
    'When at least one tour is selected the select tours and clear tours selected
    'buttons are enabled.
    '******************************************************************************
    Private Sub lstTourList_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstTourList.SelectedIndexChanged
        If (lstTourList.SelectedIndex <> -1) Then
            btnSelectTours.Enabled = True
            btnClearTourSelection.Enabled = True

        End If
    End Sub

    '****************************************************************************** 
    'When the Select Tours button is clicked, the selected tours and their costs
    'per person are displayed.  If more than the maximum number of allowed tours
    'is selected the user is warned and selections are erased.  
    '******************************************************************************
    Private Sub btnSelectTours_Click(sender As Object, e As EventArgs) Handles btnSelectTours.Click
        If (lstTourList.SelectedItems.Count <= cintMaxNumberOfTours) Then
            EraseTours()

            lstTourList.SelectedItems.CopyTo(strTours, 0)
            If (strTours(0) <> Nothing) Then
                decPricePerTour1 = GetTourPrice(strTours(0))
                lblTour1Description.Text = strTours(0) & " [" & decPricePerTour1.ToString("C") & "]"
            End If
            If (strTours(1) <> Nothing) Then
                decPricePerTour2 = GetTourPrice(strTours(1))
                lblTour2Description.Text = strTours(1) & " [" & decPricePerTour2.ToString("C") & "]"
            End If
            If (strTours(2) <> Nothing) Then
                decPricePerTour3 = GetTourPrice(strTours(2))
                lblTour3Description.Text = strTours(2) & " [" & decPricePerTour3.ToString("C") & "]"
            End If

            lblGroupSize.Visible = True
            txtGroupSize.Visible = True

            lblChildrenUnder12.Visible = True
            txtChildrenNumber.Visible = True

            btnDisplayInvoice.Enabled = True
        Else
            MsgBox("You have selected " & lstTourList.SelectedItems.Count & " tours." & Environment.NewLine & "You can only select " & cintMaxNumberOfTours & " tours.", MsgBoxStyle.OkOnly Or MsgBoxStyle.Critical, "Too Many Tours Selected")
            lstTourList.ClearSelected()
            btnClearTourSelection.Enabled = False
            btnSelectTours.Enabled = False
        End If

    End Sub

    '****************************************************************************** 
    'When the Adventure radiobutton is selected, a list of tours for this category
    'is displayed .  If any previous tours were selected, they are erased.  
    '******************************************************************************
    Private Sub btnClearTourSelection_Click(sender As Object, e As EventArgs) Handles btnClearTourSelection.Click
        lstTourList.Visible = False

        rdoAdventure.Checked = False
        rdoEducational.Checked = False
        rdoMilitary.Checked = False

        EraseTours()

        MakeObjectsInvisible()
    End Sub

    '****************************************************************************** 
    'When the Display Invoice button is clicked then the total cost of all 
    'tours is calculated, as well as discounts, tax, service charge and the final 
    'total of the entire reservation.
    '******************************************************************************
    Private Sub btnDisplayInvoice_Click(sender As Object, e As EventArgs) Handles btnDisplayInvoice.Click
        Dim decTotalTour1 As Decimal
        Dim decTotalTour2 As Decimal
        Dim decTotalTour3 As Decimal
        Dim decTourSubTotal As Decimal
        Dim decDiscountChild As Decimal
        Dim decDiscountGroup As Decimal
        Dim decTax As Decimal
        Dim decServiceCharge As Decimal
        Dim decSubTotal As Decimal
        Dim decFinalTotal As Decimal

        Try
            If (txtGroupSize.TextLength = 0) Then
                intGroupSize = 0
            ElseIf (Convert.ToInt32(txtGroupSize.Text) < 0) Then
                MsgBox("Group size cannot be a negative number! You entered" & Environment.NewLine & "Group Size: " & txtGroupSize.Text, MsgBoxStyle.OkOnly Or MsgBoxStyle.Critical, "Entered Negative Value")
                txtGroupSize.Clear()
            Else
                intGroupSize = Convert.ToInt32(txtGroupSize.Text)
            End If

            If (txtChildrenNumber.TextLength = 0) Then
                intCountChildren = 0
            ElseIf (Convert.ToInt32(txtChildrenNumber.Text) < 0) Then
                MsgBox("Number of children cannot be a negative number! You entered: " & Environment.NewLine & "Number of Children Under 12: " & txtChildrenNumber.Text, MsgBoxStyle.OkOnly Or MsgBoxStyle.Critical, "Entered Negative Value")
                txtChildrenNumber.Clear()
            Else
                intCountChildren = Convert.ToInt32(txtChildrenNumber.Text)
            End If

            If (intGroupSize < intCountChildren) Then
                MsgBox("Number of children greater than total group size! You entered: " & Environment.NewLine & "Group Size: " & txtGroupSize.Text & Environment.NewLine & "Number of Chidren Under 12: " & txtChildrenNumber.Text, MsgBoxStyle.OkOnly Or MsgBoxStyle.Critical, "Incorrect Values")
                txtGroupSize.Clear()
                txtChildrenNumber.Clear()
            Else
                decTotalTour1 = decPricePerTour1 * intGroupSize
                decTotalTour2 = decPricePerTour2 * intGroupSize
                decTotalTour3 = decPricePerTour3 * intGroupSize

                decTourSubTotal = decTotalTour1 + decTotalTour2 + decTotalTour3
                If (intGroupSize >= cintLargeGroupSize) Then
                    decDiscountGroup = decSubTotal * cdecDiscountLargeGroup
                End If

                decDiscountChild = (decPricePerTour1 + decPricePerTour2 + decPricePerTour3) * intCountChildren * cdecDiscountChild
                decSubTotal = decTourSubTotal - decDiscountGroup - decDiscountChild
                decTax = decSubTotal * cdecTaxPercent
                decServiceCharge = decSubTotal * cdecServiceChargePercent

                decFinalTotal = decTax + decServiceCharge + decSubTotal

                lblTour1Total.Text = decTotalTour1.ToString("C")
                lblTour2Total.Text = decTotalTour2.ToString("C")
                lblTour3Total.Text = decTotalTour3.ToString("C")
                lblTourSubtotal.Text = decTourSubTotal.ToString("C")
                lblGroupDiscount.Text = decDiscountGroup.ToString("C")
                lblChildDiscount.Text = decDiscountChild.ToString("C")
                lblSubtotal.Text = decSubTotal.ToString("C")
                lblTax.Text = decTax.ToString("C")
                lblServiceCharge.Text = decServiceCharge.ToString("C")
                lblFinalTotal.Text = decFinalTotal.ToString("C")

                pnlInvoice.Visible = True
            End If
        Catch Exception As FormatException
            MsgBox("One of your entries is not a number. You entered: " & Environment.NewLine & "Group Size: " & txtGroupSize.Text & Environment.NewLine & "Number of Chidren Under 12: " & txtChildrenNumber.Text, MsgBoxStyle.OkOnly Or MsgBoxStyle.Critical, "Incorrect Values")
            txtGroupSize.Clear()
            txtChildrenNumber.Clear()
        End Try
    End Sub

    '****************************************************************************** 
    'Completely resets reservation process.  All stored data and calculations are
    'erased.  Screen returns to screen when program initially launched.  
    '******************************************************************************
    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        rdoAdventure.Checked = False
        rdoEducational.Checked = False
        rdoMilitary.Checked = False

        txtGroupSize.Clear()
        txtChildrenNumber.Clear()

        lblTour1Total.Text = ""
        lblTour2Total.Text = ""
        lblTour3Total.Text = ""
        lblTourSubtotal.Text = ""
        lblChildDiscount.Text = ""
        lblGroupDiscount.Text = ""
        lblTax.Text = ""
        lblServiceCharge.Text = ""
        lblFinalTotal.Text = ""

        lstTourList.Items.Clear()

        EraseTours()
    End Sub

    '****************************************************************************** 
    'Exits window and closes application
    '******************************************************************************
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Close()
    End Sub

    '****************************************************************************** 
    'Returns the per person cost of a select tour.  
    '******************************************************************************
    Private Function GetTourPrice(ByVal strTourName As String) As Decimal
        Select Case strTourName
            Case "Whitewater Classic"
                Return cdecPricePerWhitewaterClassic
            Case "Whitewater Highwater"
                Return cdecPricePerWhitewaterHighwater
            Case "Zip Line"
                Return cdecPricePerZipLine
            Case "Canopy Boat"
                Return cdecPricePerCanopyBoat
            Case "Oxbow Meadows with Canopy Treetop Bridge"
                Return cdecPricePerOxbowMeadows
            Case "Coca Cola Space Science Center with Planetarium"
                Return cdecPricePerCocaColaSpace
            Case "Historic District and Columbus Museum Tour including Pemberton’s Pharmacy and McCullers House"
                Return cdecPricePerHistoricDistrict
            Case "Infantry Museum including iMax movie"
                Return cdecPricePerInfantryMusuem
            Case "Port Columbus Civil War Naval Museum"
                Return cdecPricePerPortColumbus
            Case Else
                Return 0
        End Select
    End Function

    '****************************************************************************** 
    'Sets the visiblity status for select components.
    '******************************************************************************
    Private Sub MakeObjectsVisible()
        ' This proceudre displays the objects showing the results
        pnlTourDescription.Visible = True

        btnClearTourSelection.Visible = True
        btnSelectTours.Visible = True

        btnClearTourSelection.Enabled = False
        btnSelectTours.Enabled = False

        lblTour1Total.Text = ""
        lblTour2Total.Text = ""
        lblTour3Total.Text = ""
        lblTourSubtotal.Text = ""
        lblChildDiscount.Text = ""
        lblGroupDiscount.Text = ""
        lblSubtotal.Text = ""
        lblTax.Text = ""
        lblServiceCharge.Text = ""
        lblFinalTotal.Text = ""
    End Sub

    '****************************************************************************** 
    'Sets the invisiblity status for select components.
    '******************************************************************************
    Private Sub MakeObjectsInvisible()
        ' This proceudre displays the objects showing the results
        pnlTourDescription.Visible = False
        pnlInvoice.Visible = False

        btnClearTourSelection.Visible = False
        btnSelectTours.Visible = False

        lblGroupSize.Visible = False
        txtGroupSize.Visible = False

        lblChildrenUnder12.Visible = False
        txtChildrenNumber.Visible = False

        btnDisplayInvoice.Enabled = False
    End Sub

    '****************************************************************************** 
    'Erases tour selection information
    '******************************************************************************
    Private Sub EraseTours()
        Array.Clear(strTours, Nothing, strTours.Length)

        lblTour1Description.Text = ""
        lblTour2Description.Text = ""
        lblTour3Description.Text = ""
    End Sub

End Class
