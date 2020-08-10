Imports System.Data.SqlClient
Public Class viewProduct
    Inherits System.Web.UI.Page
    Public cmd As New SqlCommand
    Public Da As New SqlDataAdapter
    Public dr As SqlDataReader
    Public ds As DataSet
    Public cb As SqlCommandBuilder
    Public table As New DataTable
    Dim strCon As String = ConfigurationManager.ConnectionStrings("con").ConnectionString
    Dim cn As New SqlConnection(strCon)
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Not IsPostBack Then
            refreshmeatdata()
            refreshChickendata()
            refreshFishdata()
            refreshVanilladata()
            refreshDrinkdata()

        End If
    End Sub

    Public Sub refreshmeatdata()
        cn.Close()
        cmd = New SqlCommand
        cn.Open()
        Dim sqlquery As String = "select productID,productName from Product where productID like 'MT%' "
        cmd.CommandText = sqlquery
        cmd.Connection = cn
        Da = New SqlDataAdapter(cmd)
        ds = New DataSet
        Da.Fill(ds)
        DropDownListMeat.DataSource = ds
        DropDownListMeat.DataSource = ds.Tables(0)
        DropDownListMeat.DataTextField = ds.Tables(0).Columns("productName").ColumnName.ToString()
        DropDownListMeat.DataValueField = ds.Tables(0).Columns("productID").ColumnName.ToString()
        DropDownListMeat.DataBind()
        DropDownListMeat.Items.Insert(0, "Select Food")
        '        Dim i As Integer
        '        For i = 0 To DropDownListMeat.Items.Count - 1
        '            DropDownListMeat.Items(i).Attributes.Add("style", "color:" + ds.Tables(0).Rows(i)"CategoryColor").ToString())  
        'Next
        cn.Close()
    End Sub

    Public Sub refreshChickendata()
        cn.Close()
        cmd = New SqlCommand
        cn.Open()
        Dim sqlquery As String = "select productID,productName from Product where productID like 'CH%' "
        cmd.CommandText = sqlquery
        cmd.Connection = cn
        Da = New SqlDataAdapter(cmd)
        ds = New DataSet
        Da.Fill(ds)
        DropDownListChicken.DataSource = ds
        DropDownListChicken.DataSource = ds.Tables(0)
        DropDownListChicken.DataTextField = ds.Tables(0).Columns("productName").ColumnName.ToString()
        DropDownListChicken.DataValueField = ds.Tables(0).Columns("productID").ColumnName.ToString()
        DropDownListChicken.DataBind()
        DropDownListChicken.Items.Insert(0, "Select Food")
        '        Dim i As Integer
        '        For i = 0 To DropDownListMeat.Items.Count - 1
        '            DropDownListMeat.Items(i).Attributes.Add("style", "color:" + ds.Tables(0).Rows(i)"CategoryColor").ToString())  
        'Next
        cn.Close()
    End Sub

    Public Sub refreshFishdata()
        cn.Close()
        cmd = New SqlCommand
        cn.Open()
        Dim sqlquery As String = "select productID,productName from Product where productID like 'F%' "
        cmd.CommandText = sqlquery
        cmd.Connection = cn
        Da = New SqlDataAdapter(cmd)
        ds = New DataSet
        Da.Fill(ds)
        DropDownListFish.DataSource = ds
        DropDownListFish.DataSource = ds.Tables(0)
        DropDownListFish.DataTextField = ds.Tables(0).Columns("productName").ColumnName.ToString()
        DropDownListFish.DataValueField = ds.Tables(0).Columns("productID").ColumnName.ToString()
        DropDownListFish.DataBind()
        DropDownListFish.Items.Insert(0, "Select Food")
        '        Dim i As Integer
        '        For i = 0 To DropDownListMeat.Items.Count - 1
        '            DropDownListMeat.Items(i).Attributes.Add("style", "color:" + ds.Tables(0).Rows(i)"CategoryColor").ToString())  
        'Next
        cn.Close()
    End Sub

    Public Sub refreshVanilladata()
        cn.Close()
        cmd = New SqlCommand
        cn.Open()
        Dim sqlquery As String = "select productID,productName from Product where productID like 'SH%' "
        cmd.CommandText = sqlquery
        cmd.Connection = cn
        Da = New SqlDataAdapter(cmd)
        ds = New DataSet
        Da.Fill(ds)
        DropDownListVanilla.DataSource = ds
        DropDownListVanilla.DataSource = ds.Tables(0)
        DropDownListVanilla.DataTextField = ds.Tables(0).Columns("productName").ColumnName.ToString()
        DropDownListVanilla.DataValueField = ds.Tables(0).Columns("productID").ColumnName.ToString()
        DropDownListVanilla.DataBind()
        DropDownListVanilla.Items.Insert(0, "Select Food")
        '        Dim i As Integer
        '        For i = 0 To DropDownListMeat.Items.Count - 1
        '            DropDownListMeat.Items(i).Attributes.Add("style", "color:" + ds.Tables(0).Rows(i)"CategoryColor").ToString())  
        'Next
        cn.Close()
    End Sub

    Public Sub refreshDrinkdata()
        cn.Close()
        cmd = New SqlCommand
        cn.Open()
        Dim sqlquery As String = "select productID,productName from Product where productID like 'DR%' "
        cmd.CommandText = sqlquery
        cmd.Connection = cn
        Da = New SqlDataAdapter(cmd)
        ds = New DataSet
        Da.Fill(ds)
        DropDownListDrinks.DataSource = ds
        DropDownListDrinks.DataSource = ds.Tables(0)
        DropDownListDrinks.DataTextField = ds.Tables(0).Columns("productName").ColumnName.ToString()
        DropDownListDrinks.DataValueField = ds.Tables(0).Columns("productID").ColumnName.ToString()
        DropDownListDrinks.DataBind()
        DropDownListDrinks.Items.Insert(0, "Select Food")
        '        Dim i As Integer
        '        For i = 0 To DropDownListMeat.Items.Count - 1
        '            DropDownListMeat.Items(i).Attributes.Add("style", "color:" + ds.Tables(0).Rows(i)"CategoryColor").ToString())  
        'Next
        cn.Close()
    End Sub

    Protected Sub DropDownListMeat_SelectedIndexChanged(sender As Object, e As EventArgs) Handles DropDownListMeat.SelectedIndexChanged
        If DropDownListMeat.SelectedItem.Text = "Select Food" Then
            txtmeatprice.Text = String.Empty
            txtMeatProductID.Text = String.Empty
        Else
            cn.Close()
            cmd = New SqlCommand
            cn.Open()
            Dim sqlquery As String = "select productID,price from product where productName='" & DropDownListMeat.SelectedItem.Text & "' "
            cmd.CommandText = sqlquery
            cmd.Connection = cn
            dr = cmd.ExecuteReader

            While dr.Read
                txtmeatprice.Text = dr!price.ToString
                txtMeatProductID.Text = dr!productID
            End While
        End If
    End Sub

    Protected Sub DropDownListChicken_SelectedIndexChanged(sender As Object, e As EventArgs) Handles DropDownListChicken.SelectedIndexChanged
        If DropDownListChicken.SelectedItem.Text = "Select Food" Then
            txtChickenPrice.Text = String.Empty
            txtChickenProductID.Text = String.Empty
        Else
            cn.Close()
            cmd = New SqlCommand
            cn.Open()
            Dim sqlquery As String = "select productID,price from product where productName='" & DropDownListChicken.SelectedItem.Text & "' "
            cmd.CommandText = sqlquery
            cmd.Connection = cn
            dr = cmd.ExecuteReader

            While dr.Read
                txtChickenPrice.Text = dr!price.ToString
                txtChickenProductID.Text = dr!productID
            End While
        End If
    End Sub

    Protected Sub DropDownListFish_SelectedIndexChanged(sender As Object, e As EventArgs) Handles DropDownListFish.SelectedIndexChanged
        If DropDownListFish.SelectedItem.Text = "Select Food" Then
            txtFishprice.Text = String.Empty
            txtFishProductID.Text = String.Empty
        Else
            cn.Close()
            cmd = New SqlCommand
            cn.Open()
            Dim sqlquery As String = "select productID,price from product where productName='" & DropDownListFish.SelectedItem.Text & "' "
            cmd.CommandText = sqlquery
            cmd.Connection = cn
            dr = cmd.ExecuteReader

            While dr.Read
                txtFishprice.Text = dr!price.ToString
                txtFishProductID.Text = dr!productID
            End While
        End If
    End Sub

    Protected Sub DropDownListVanilla_SelectedIndexChanged(sender As Object, e As EventArgs) Handles DropDownListVanilla.SelectedIndexChanged
        If DropDownListVanilla.SelectedItem.Text = "Select Food" Then
            txtvanillaPrice.Text = String.Empty
            txtVanillaProductID.Text = String.Empty
        Else
            cn.Close()
            cmd = New SqlCommand
            cn.Open()
            Dim sqlquery As String = "select productID,price from product where productName='" & DropDownListVanilla.SelectedItem.Text & "' "
            cmd.CommandText = sqlquery
            cmd.Connection = cn
            dr = cmd.ExecuteReader

            While dr.Read
                txtvanillaPrice.Text = dr!price.ToString
                txtVanillaProductID.Text = dr!productID
            End While
        End If
    End Sub

    Protected Sub DropDownListDrinks_SelectedIndexChanged(sender As Object, e As EventArgs) Handles DropDownListDrinks.SelectedIndexChanged
        If DropDownListDrinks.SelectedItem.Text = "Select Food" Then
            txtDrinkPrice.Text = String.Empty
            txtDrinksProductID.Text = String.Empty
        Else
            cn.Close()
            cmd = New SqlCommand
            cn.Open()
            Dim sqlquery As String = "select productID,price from product where productName='" & DropDownListDrinks.SelectedItem.Text & "' "
            cmd.CommandText = sqlquery
            cmd.Connection = cn
            dr = cmd.ExecuteReader

            While dr.Read
                txtDrinkPrice.Text = dr!price.ToString
                txtDrinksProductID.Text = dr!productID
            End While
        End If
    End Sub

    Protected Sub txtmeatquantity_TextChanged(sender As Object, e As EventArgs) Handles txtmeatquantity.TextChanged
        Dim result As Double
        result = CDbl(txtmeatprice.Text) * CDbl(txtmeatquantity.Text)
        txtmeatamount.Text = result.ToString("c")
    End Sub

    Protected Sub txtChickenQuantity_TextChanged(sender As Object, e As EventArgs) Handles txtChickenQuantity.TextChanged
        Dim result As Double
        result = CDbl(txtChickenPrice.Text) * CDbl(txtChickenQuantity.Text)
        txtChickenAmount.Text = result.ToString("c")
    End Sub

    Protected Sub txtFishQuantity_TextChanged(sender As Object, e As EventArgs) Handles txtFishQuantity.TextChanged
        Dim result As Double
        result = CDbl(txtFishprice.Text) * CDbl(txtFishQuantity.Text)
        txtFishamount.Text = result.ToString("c")
    End Sub

    Protected Sub txtvanillaQuantity_TextChanged(sender As Object, e As EventArgs) Handles txtvanillaQuantity.TextChanged
        Dim result As Double
        result = CDbl(txtvanillaPrice.Text) * CDbl(txtvanillaQuantity.Text)
        txtvanillaAmount.Text = result.ToString("c")
    End Sub

    Protected Sub txtDrinkQuantity_TextChanged(sender As Object, e As EventArgs) Handles txtDrinkQuantity.TextChanged
        Dim result As Double
        result = CDbl(txtDrinkPrice.Text) * CDbl(txtDrinkQuantity.Text)
        txtDrinkAmount.Text = result.ToString("c")
    End Sub


    Public Sub clear()
        txtMeatProductID.Text = String.Empty
        txtChickenProductID.Text = String.Empty
        txtFishProductID.Text = String.Empty
        txtVanillaProductID.Text = String.Empty
        txtDrinksProductID.Text = String.Empty

        DropDownListMeat.SelectedValue = "Select Food"
        DropDownListChicken.SelectedValue = "Select Food"
        DropDownListFish.SelectedValue = "Select Food"
        DropDownListVanilla.SelectedValue = "Select Food"
        DropDownListDrinks.SelectedValue = "Select Food"
        txtmeatprice.Text = String.Empty
        txtChickenPrice.Text = String.Empty
        txtFishprice.Text = String.Empty
        txtvanillaPrice.Text = String.Empty
        txtDrinkPrice.Text = String.Empty

        txtmeatquantity.Text = String.Empty
        txtChickenQuantity.Text = String.Empty
        txtFishQuantity.Text = String.Empty
        txtvanillaQuantity.Text = String.Empty
        txtDrinkQuantity.Text = String.Empty

        txtmeatamount.Text = String.Empty
        txtChickenAmount.Text = String.Empty
        txtFishamount.Text = String.Empty
        txtvanillaAmount.Text = String.Empty
        txtDrinkAmount.Text = String.Empty

    End Sub


    Protected Sub btnmeatBuy_Click(sender As Object, e As EventArgs) Handles btnmeatBuy.Click

        If Session("role") = vbNullString Then
            Response.Write("<script>alert('Please login Member ID');</script>")

        ElseIf Session("role").Equals("User") Then


            'Try
            If DropDownListMeat.SelectedValue = "Select Food" And txtmeatquantity.Text = "" Then
                    Response.Write("<script>alert('please Fill');</script>")
                Else
                    cn.Close()
                cmd = New SqlCommand("insert into Orders(productID,productName,price,quantity,amount,userID)values('" & txtMeatProductID.Text & "','" & DropDownListMeat.SelectedItem.Text & "'," & txtmeatprice.Text & "," & txtmeatquantity.Text & "," & txtmeatamount.Text & ",'" & Session("username").ToString & "')", cn)
                cn.Open()
                    cmd.ExecuteNonQuery()
                    cn.Close()
                Response.Write("<script>alert('Bought it');</script>")
            End If

                'refreshdata()
                clear()

            'Catch ex As Exception
            '    Response.Write("<script>alert('Invalid error weyn');</script>")
            'End Try




        ElseIf Session("role").Equals("Admin") Then
                Response.Write("<script>alert('Admin Can't buy Products Please Login MemberID');</script>")
            Else
                Response.Write("<script>alert('invalid credentials');</script>")

            End If







    End Sub

    Protected Sub btnvanillaBuy_Click(sender As Object, e As EventArgs) Handles btnvanillaBuy.Click
        If Session("role") = vbNullString Then
            Response.Write("<script>alert('Please login Member ID');</script>")

        ElseIf Session("role").Equals("User") Then


            'Try
            If DropDownListVanilla.SelectedValue = "Select Food" And txtvanillaQuantity.Text = "" Then
                Response.Write("<script>alert('please Fill');</script>")
            Else
                cn.Close()
                cmd = New SqlCommand("insert into Orders(productID,productName,price,quantity,amount,userID)values('" & txtVanillaProductID.Text & "','" & DropDownListVanilla.SelectedItem.Text & "'," & txtvanillaPrice.Text & "," & txtvanillaQuantity.Text & "," & txtvanillaAmount.Text & ",'" & Session("username").ToString & "')", cn)
                cn.Open()
                cmd.ExecuteNonQuery()
                cn.Close()
                Response.Write("<script>alert('Bought it');</script>")
            End If

            'refreshdata()
            clear()

            'Catch ex As Exception
            '    Response.Write("<script>alert('Invalid error weyn');</script>")
            'End Try




        ElseIf Session("role").Equals("Admin") Then
            Response.Write("<script>alert('Admin Can't buy Products Please Login MemberID');</script>")
        Else
            Response.Write("<script>alert('invalid credentials');</script>")

        End If
    End Sub

    Protected Sub btnFishBuy_Click(sender As Object, e As EventArgs) Handles btnFishBuy.Click
        If Session("role") = vbNullString Then
            Response.Write("<script>alert('Please login Member ID');</script>")

        ElseIf Session("role").Equals("User") Then


            'Try
            If DropDownListFish.SelectedValue = "Select Food" And txtFishQuantity.Text = "" Then
                Response.Write("<script>alert('please Fill');</script>")
            Else
                cn.Close()
                cmd = New SqlCommand("insert into Orders(productID,productName,price,quantity,amount,userID)values('" & txtFishProductID.Text & "','" & DropDownListFish.SelectedItem.Text & "'," & txtFishprice.Text & "," & txtFishQuantity.Text & "," & txtFishamount.Text & ",'" & Session("username").ToString & "')", cn)
                cn.Open()
                cmd.ExecuteNonQuery()
                cn.Close()
                Response.Write("<script>alert('Bought it');</script>")
            End If

            'refreshdata()
            clear()

            'Catch ex As Exception
            '    Response.Write("<script>alert('Invalid error weyn');</script>")
            'End Try




        ElseIf Session("role").Equals("Admin") Then
            Response.Write("<script>alert('Admin Can't buy Products Please Login MemberID');</script>")
        Else
            Response.Write("<script>alert('invalid credentials');</script>")

        End If
    End Sub

    Protected Sub btnDrinkBuy_Click(sender As Object, e As EventArgs) Handles btnDrinkBuy.Click
        If Session("role") = vbNullString Then
            Response.Write("<script>alert('Please login Member ID');</script>")

        ElseIf Session("role").Equals("User") Then


            'Try
            If DropDownListDrinks.SelectedValue = "Select Food" And txtDrinkQuantity.Text = "" Then
                Response.Write("<script>alert('please Fill');</script>")
            Else
                cn.Close()
                cmd = New SqlCommand("insert into Orders(productID,productName,price,quantity,amount,userID)values('" & txtDrinksProductID.Text & "','" & DropDownListDrinks.SelectedItem.Text & "'," & txtDrinkPrice.Text & "," & txtDrinkQuantity.Text & "," & txtDrinkAmount.Text & ",'" & Session("username").ToString & "')", cn)
                cn.Open()
                cmd.ExecuteNonQuery()
                cn.Close()
                Response.Write("<script>alert('Bought it');</script>")
            End If

            'refreshdata()
            clear()

            'Catch ex As Exception
            '    Response.Write("<script>alert('Invalid error weyn');</script>")
            'End Try




        ElseIf Session("role").Equals("Admin") Then
            Response.Write("<script>alert('Admin Can't buy Products Please Login MemberID');</script>")
        Else
            Response.Write("<script>alert('invalid credentials');</script>")

        End If
    End Sub

    Protected Sub btnChickenBuy_Click(sender As Object, e As EventArgs) Handles btnChickenBuy.Click
        If Session("role") = vbNullString Then
            Response.Write("<script>alert('Please login Member ID');</script>")

        ElseIf Session("role").Equals("User") Then


            'Try
            If DropDownListChicken.SelectedValue = "Select Food" And txtChickenQuantity.Text = "" Then
                Response.Write("<script>alert('please Fill');</script>")
            Else
                cn.Close()
                cmd = New SqlCommand("insert into Orders(productID,productName,price,quantity,amount,userID)values('" & txtChickenProductID.Text & "','" & DropDownListChicken.SelectedItem.Text & "'," & txtChickenPrice.Text & "," & txtChickenQuantity.Text & "," & txtChickenAmount.Text & ",'" & Session("username").ToString & "')", cn)
                cn.Open()
                cmd.ExecuteNonQuery()
                cn.Close()
                Response.Write("<script>alert('Bought it');</script>")
            End If

            'refreshdata()
            clear()

            'Catch ex As Exception
            '    Response.Write("<script>alert('Invalid error weyn');</script>")
            'End Try




        ElseIf Session("role").Equals("Admin") Then
            Response.Write("<script>alert('Admin Can't buy Products Please Login MemberID');</script>")
        Else
            Response.Write("<script>alert('invalid credentials');</script>")

        End If
    End Sub
End Class