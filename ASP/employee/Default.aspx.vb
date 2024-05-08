
Partial Class _Default
    Inherits System.Web.UI.Page

    <Serializable()> Structure Employee
        Dim name, id, department, designation As String
        Dim basic As Integer
        Dim netSalary, HRA, DA, PF, IT As Single
    End Structure


    Dim a(10) As Employee
    Dim n As Integer


    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.Table1.BorderStyle = BorderStyle.Outset
        Me.Table1.BorderWidth = Unit.Pixel(10)
        Me.Table1.Visible = False
        Me.displayBtn.Visible = False
        Me.tableTitle.Visible = False

        n = CType(Me.ViewState("size"), Integer)
    End Sub




    Protected Sub submitBtn_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles submitBtn.Click


        Dim i As Integer = n + 1
        a = CType(Me.ViewState("empInfo"), Employee())

        a(i).name = txtName.Text
        a(i).id = txtId.Text
        a(i).department = txtDpt.Text
        a(i).designation = txtDes.Text
        a(i).basic = Val(txtSalary.Text)

        If a(i).basic > 20000 And a(i).basic <= 40000 Then
            a(i).HRA = (a(i).basic * 3) / 100
            a(i).DA = (a(i).basic * 5) / 100
            a(i).PF = (a(i).basic * 2) / 100
            a(i).IT = (a(i).basic * 1) / 100

        ElseIf a(i).basic > 40000 And a(i).basic <= 60000 Then
            a(i).HRA = (a(i).basic * 5) / 100
            a(i).DA = (a(i).basic * 8) / 100
            a(i).PF = (a(i).basic * 3) / 100
            a(i).IT = (a(i).basic * 2.5) / 100

        ElseIf a(i).basic > 60000 And a(i).basic <= 80000 Then
            a(i).HRA = (a(i).basic * 7) / 100
            a(i).DA = (a(i).basic * 10) / 100
            a(i).PF = (a(i).basic * 5) / 100
            a(i).IT = (a(i).basic * 4) / 100

        ElseIf a(i).basic > 80000 And a(i).basic <= 100000 Then
            a(i).HRA = (a(i).basic * 9) / 100
            a(i).DA = (a(i).basic * 12) / 100
            a(i).PF = (a(i).basic * 7) / 100
            a(i).IT = (a(i).basic * 5) / 100

        ElseIf a(i).basic > 100000 Then
            a(i).HRA = (a(i).basic * 10) / 100
            a(i).DA = (a(i).basic * 15) / 100
            a(i).PF = (a(i).basic * 8) / 100
            a(i).IT = (a(i).basic * 6) / 100

        Else
            a(i).HRA = 0
            a(i).DA = 0
            a(i).PF = 0
            a(i).IT = 0
        End If


        a(i).netSalary = a(i).basic + a(i).DA + a(i).HRA - (a(i).PF + a(i).IT)

        n = i      
        displayBtn.Visible = True
        Me.txtName.Text = ""
        Me.txtId.Text = ""
        Me.txtDpt.Text = ""
        Me.txtDes.Text = ""
        Me.txtSalary.Text = ""
        Me.txtName.Focus()
    End Sub


    Protected Sub Page_PreRender(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.PreRender
        Me.ViewState("size") = n
        Me.ViewState("empInfo") = a               
    End Sub



    Protected Sub displayBtn_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles displayBtn.Click
        Me.tableTitle.Visible = True

        Me.Table1.Visible = True



        a = CType(Me.ViewState("empInfo"), Employee())
        n = CType(Me.ViewState("size"), Integer)


        Dim r As New TableHeaderRow
        Me.Table1.Controls.Add(r)

        Dim c1 As New TableHeaderCell
        c1.Text = "Employee Name"
        c1.BorderStyle = BorderStyle.Ridge
        c1.BorderWidth = Unit.Pixel(2)
        r.Controls.Add(c1)

        Dim c2 As New TableHeaderCell
        c2.Text = "Employee Id"
        c2.BorderStyle = BorderStyle.Ridge
        c2.BorderWidth = Unit.Pixel(2)
        r.Controls.Add(c2)



        Dim c3 As New TableHeaderCell
        c3.Text = "Department"
        c3.BorderStyle = BorderStyle.Ridge
        c3.BorderWidth = Unit.Pixel(2)
        r.Controls.Add(c3)


        Dim c4 As New TableHeaderCell
        c4.Text = "Designation"
        c4.BorderStyle = BorderStyle.Ridge
        c4.BorderWidth = Unit.Pixel(2)
        r.Controls.Add(c4)



        Dim c5 As New TableHeaderCell
        c5.Text = "BasicSalary"
        c5.BorderStyle = BorderStyle.Ridge
        c5.BorderWidth = Unit.Pixel(2)
        r.Controls.Add(c5)

        Dim c6 As New TableHeaderCell
        c6.Text = "NetSalary"
        c6.BorderStyle = BorderStyle.Ridge
        c6.BorderWidth = Unit.Pixel(2)
        r.Controls.Add(c6)



        Dim i, j As Integer

        For i = 1 To n
            Dim row As New TableRow
            Me.Table1.Controls.Add(row)

            Dim col1 As New TableCell
            col1.Text = a(i).name
            col1.BorderStyle = BorderStyle.Solid
            col1.BorderWidth = Unit.Pixel(1)
            row.Controls.Add(col1)


            Dim col2 As New TableCell
            col2.Text = a(i).id
            col2.BorderStyle = BorderStyle.Solid
            col2.BorderWidth = Unit.Pixel(1)
            row.Controls.Add(col2)


            Dim col3 As New TableCell
            col3.Text = a(i).department
            col3.BorderStyle = BorderStyle.Solid
            col3.BorderWidth = Unit.Pixel(1)
            row.Controls.Add(col3)



            Dim col4 As New TableCell
            col4.Text = a(i).designation
            col4.BorderStyle = BorderStyle.Solid
            col4.BorderWidth = Unit.Pixel(1)
            row.Controls.Add(col4)




            Dim col5 As New TableCell
            col5.Text = a(i).basic
            col5.BorderStyle = BorderStyle.Solid
            col5.BorderWidth = Unit.Pixel(1)
            row.Controls.Add(col5)


            Dim col6 As New TableCell
            col6.Text = a(i).netSalary
            col6.BorderStyle = BorderStyle.Solid
            col6.BorderWidth = Unit.Pixel(1)
            row.Controls.Add(col6)

        Next
    End Sub
End Class
