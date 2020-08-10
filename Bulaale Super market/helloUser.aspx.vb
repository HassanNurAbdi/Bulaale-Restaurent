Imports System.Data.SqlClient

Public Class helloUser
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
            showdata()
            showprofile()
            showBalance()
        End If

    End Sub

    Public Sub showdata()
        cn.Close()
        cmd = New SqlCommand
        cn.Open()
        Dim sqlquery As String = "select id,productID,productName,price,quantity,Amount from orders where userID='" & Session("username").ToString & "' "
        cmd.CommandText = sqlquery
        cmd.Connection = cn
        table = New DataTable
        Da = New SqlDataAdapter(cmd)
        Da.Fill(table)
        GridView1.DataSource = table
        GridView1.DataSourceID = String.Empty
        GridView1.DataBind()
        cn.Close()
    End Sub

    Protected Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        cn.Close()
        cmd = New SqlCommand
        cn.Open()
        Dim sqlquery As String = "select id,productID,productName,price,quantity,Amount from orders where productName like '%" & txtsearch.Text & "%' and userID='" & Session("username").ToString & "'  "
        cmd.CommandText = sqlquery
        cmd.Connection = cn
        table = New DataTable
        Da = New SqlDataAdapter(cmd)
        Da.Fill(table)
        GridView1.DataSource = table
        GridView1.DataSourceID = String.Empty
        GridView1.DataBind()
    End Sub

    Public Sub showprofile()
        cn.Close()
        cmd = New SqlCommand
        cn.Open()
        Dim sqlquery As String = "select Fullname,(address) as place,state,email,contactNo,userID,password from Customer where userID='" & Session("username").ToString & "'  "
        cmd.CommandText = sqlquery
        cmd.Connection = cn
        dr = cmd.ExecuteReader
        While dr.Read
            txtFullname.Text = dr!Fullname
            txtAddress.Text = dr!place
            txtContactno.Text = dr!contactNO
            txtEmail.Text = dr!email
            txtPassword.Text = dr!password
            txtuserId.Text = dr!userID
            cboState.SelectedValue = dr!state

        End While
    End Sub

    Public Sub showBalance()
        cn.Close()
        cmd = New SqlCommand
        cn.Open()
        Dim sqlquery As String = "select SUM(amount) as Balance from orders where userID='" & Session("username").ToString & "'  "
        cmd.CommandText = sqlquery
        cmd.Connection = cn
        dr = cmd.ExecuteReader

        While dr.Read
                lblBalance.Text = dr!Balance.ToString

        End While


    End Sub


    Protected Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        showdata()
    End Sub

    Protected Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Try
            If txtFullname.Text = String.Empty And txtAddress.Text = String.Empty And cboState.SelectedValue = "Select" And txtContactno.Text = String.Empty And txtEmail.Text = String.Empty And txtuserId.Text = String.Empty And txtPassword.Text = String.Empty Then
                Response.Write("<script>alert('please fill');</script>")
            Else
                Dim row As GridViewRow = GridView1.SelectedRow
                cn.Close()
                cmd = New SqlCommand("Update Customer set Fullname='" & txtFullname.Text & "',address='" & txtAddress.Text & "',state='" & cboState.Text & "',email='" & txtEmail.Text & "',contactNo='" & txtContactno.Text & "',userID='" & txtuserId.Text & "',password='" & txtPassword.Text & "' where userID='" & txtuserId.Text & "' ", cn)
                cn.Open()
                cmd.ExecuteNonQuery()
                cn.Close()
                Response.Write("<script>alert('Updated your profile Record');</script>")
            End If

            showdata()


        Catch ex As Exception
            Response.Write("<script>alert('Invalid error weyn');</script>")
        End Try
    End Sub
End Class