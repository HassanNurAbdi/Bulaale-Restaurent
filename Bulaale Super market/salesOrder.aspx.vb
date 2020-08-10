Imports System.Data.SqlClient

Public Class salesOrder
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
            showBalance()

        End If
    End Sub

    Public Sub showdata()
        cn.Close()
        cmd = New SqlCommand
        cn.Open()
        Dim sqlquery As String = "select Orders.userID,Customer.Fullname,Customer.address,Customer.state,Customer.email,Customer.contactNo,sum(Orders.amount) as Balance from orders inner join customer on Orders.userID=Customer.userID group by  Orders.userID,Customer.Fullname,Customer.address,Customer.state,Customer.email,Customer.contactNo "
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



    Public Sub showBalance()
        cn.Close()
        cmd = New SqlCommand
        cn.Open()
        Dim sqlquery As String = "select SUM(amount) as Balance from orders "
        cmd.CommandText = sqlquery
        cmd.Connection = cn
        dr = cmd.ExecuteReader

        While dr.Read
            lblBalance.Text = dr!Balance.ToString

        End While


    End Sub

    Protected Sub GridView1_PageIndexChanging(sender As Object, e As GridViewPageEventArgs) Handles GridView1.PageIndexChanging
        GridView1.PageIndex = e.NewPageIndex
        Me.DataBind()
    End Sub

    Protected Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        showdata()
    End Sub

    Protected Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        cn.Close()
        cmd = New SqlCommand
        cn.Open()
        Dim sqlquery As String = "select Orders.userID,Customer.Fullname,Customer.address,Customer.state,Customer.email,Customer.contactNo,sum(Orders.amount) as Balance from orders inner join customer on Orders.userID=Customer.userID where Orders.userID like'%" & txtsearch.Text & "%'   group by  Orders.userID,Customer.Fullname,Customer.address,Customer.state,Customer.email,Customer.contactNo "
        cmd.CommandText = sqlquery
        cmd.Connection = cn
        table = New DataTable
        Da = New SqlDataAdapter(cmd)
        Da.Fill(table)
        GridView1.DataSource = table
        GridView1.DataSourceID = String.Empty
        GridView1.DataBind()
    End Sub
End Class