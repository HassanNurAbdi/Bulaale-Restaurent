Imports System.Data.SqlClient

Public Class Customers
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
        End If
    End Sub


    Public Sub showdata()
        cn.Close()
        cmd = New SqlCommand
        cn.Open()
        Dim sqlquery As String = "select Fullname,address,state,email,contactNo,userID,password from Customer "
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

    Protected Sub GridView1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles GridView1.SelectedIndexChanged
        Dim row As GridViewRow = GridView1.SelectedRow
        Dim rowid As String = row.Cells(1).Text
        txtFullname.Text = row.Cells(2).Text
        txtAddress.Text = row.Cells(3).Text
        cboState.SelectedValue = row.Cells(4).Text
        txtEmail.Text = row.Cells(5).Text
        txtContactno.Text = row.Cells(6).Text
        txtuserId.Text = row.Cells(7).Text
        txtPassword.Text = row.Cells(8).Text

    End Sub

    Public Sub clear()
        txtFullname.Text = String.Empty
        txtAddress.Text = String.Empty
        txtContactno.Text = String.Empty
        txtEmail.Text = String.Empty
        txtuserId.Text = String.Empty
        txtPassword.Text = String.Empty
        cboState.SelectedValue = "Select"
        txtsearch.Text = String.Empty

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
                Response.Write("<script>alert('Updated Customer Record');</script>")
            End If

            showdata()
            clear()

        Catch ex As Exception
            Response.Write("<script>alert('Invalid error weyn');</script>")
        End Try
    End Sub

    Protected Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Try
            Dim row As GridViewRow = GridView1.SelectedRow
            cn.Close()
        cmd = New SqlCommand("delete from orders where userID='" & txtuserId.Text & "' ", cn)
        cn.Open()
            cmd.ExecuteNonQuery()
        cn.Close()

        cn.Close()
        cmd = New SqlCommand("delete from Customer where userID='" & txtuserId.Text & "' ", cn)
        cn.Open()
        cmd.ExecuteNonQuery()
        cn.Close()
            Response.Write("<script>alert('deleted Customer Record');</script>")


            showdata()
            clear()

        Catch ex As Exception
        Response.Write("<script>alert('Invalid error weyn');</script>")
        End Try
    End Sub

    Protected Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        showdata()
    End Sub

    Protected Sub GridView1_PageIndexChanging(sender As Object, e As GridViewPageEventArgs) Handles GridView1.PageIndexChanging
        GridView1.PageIndex = e.NewPageIndex
        Me.DataBind()
    End Sub

    Protected Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        cn.Close()
        cmd = New SqlCommand
        cn.Open()
        Dim sqlquery As String = "select * from Customer where fullName like '%" & txtsearch.Text & "%' "
        cmd.CommandText = sqlquery
        cmd.Connection = cn
        table = New DataTable
        Da = New SqlDataAdapter(cmd)
        Da.Fill(table)
        GridView1.DataSource = table
        GridView1.DataSourceID = String.Empty
        GridView1.DataBind()
    End Sub

    Protected Sub txtFullname_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Protected Sub txtuserId_TextChanged(sender As Object, e As EventArgs)

    End Sub

    'Protected Sub txtsearch_TextChanged(sender As Object, e As EventArgs) Handles txtsearch.TextChanged
    '    cn.Close()
    '    cmd = New SqlCommand
    '    cn.Open()
    '    Dim sqlquery As String = "select * from Customer where fullName like '%" & txtsearch.Text & "%' "
    '    cmd.CommandText = sqlquery
    '    cmd.Connection = cn
    '    Da = New SqlDataAdapter(cmd)
    '    Da.Fill(table)
    '    GridView1.DataSource = table
    '    GridView1.DataSourceID = String.Empty
    '    GridView1.DataBind()
    'End Sub
End Class