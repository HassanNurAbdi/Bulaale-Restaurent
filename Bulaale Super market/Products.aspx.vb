Imports System.Data.SqlClient
Public Class Products
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
            refreshdata()
        End If



    End Sub

    Protected Sub GridView1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles GridView1.SelectedIndexChanged
        Dim row As GridViewRow = GridView1.SelectedRow
        txtproductID.Text = row.Cells(1).Text
        txtproductName.Text = row.Cells(2).Text
        txtprice.Text = row.Cells(3).Text

    End Sub

    Protected Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        cn.Close()
        cmd = New SqlCommand
        cn.Open()
        Dim sqlquery As String = "select * from product where productName like '%" & txtsearch.Text & "%' "
        cmd.CommandText = sqlquery
        cmd.Connection = cn
        table = New DataTable
        Da = New SqlDataAdapter(cmd)
        Da.Fill(table)
        GridView1.DataSource = table
        GridView1.DataSourceID = String.Empty
        GridView1.DataBind()



    End Sub

    Protected Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        refreshdata()

    End Sub

    Protected Sub txtsearch_TextChanged(sender As Object, e As EventArgs) Handles txtsearch.TextChanged
        cn.Close()
        cmd = New SqlCommand
        cn.Open()
        Dim sqlquery As String = "select * from product where productName like '%" & txtsearch.Text & "%' "
        cmd.CommandText = sqlquery
        cmd.Connection = cn
        table = New DataTable
        Da = New SqlDataAdapter(cmd)
        Da.Fill(table)
        GridView1.DataSource = table
        GridView1.DataSourceID = String.Empty
        GridView1.DataBind()
    End Sub


    Public Sub refreshdata()
        cn.Close()
        cmd = New SqlCommand
        cn.Open()
        Dim sqlquery As String = "select * from product "
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

    Public Sub clear()
        txtproductID.Text = String.Empty
        txtproductName.Text = String.Empty
        txtprice.Text = String.Empty
        txtsearch.Text = String.Empty
    End Sub



    Protected Sub GridView1_PageIndexChanging(sender As Object, e As GridViewPageEventArgs) Handles GridView1.PageIndexChanging
        GridView1.PageIndex = e.NewPageIndex
        Me.DataBind()
    End Sub

    Protected Sub btnInsert_Click(sender As Object, e As EventArgs) Handles btnInsert.Click
        Try
            If txtproductID.Text = "" And txtproductName.Text = "" And txtprice.Text = "" Then
                MsgBox("please fill")
            Else
                cn.Close()
                cmd = New SqlCommand("insert into product(productID,productName,price)values('" & txtproductID.Text & "','" & txtproductName.Text & "'," & txtprice.Text & ")", cn)
                cn.Open()
                cmd.ExecuteNonQuery()
                cn.Close()
                Response.Write("<script>alert('Saved product');</script>")
            End If

            refreshdata()
            clear()

        Catch ex As Exception
            Response.Write("<script>alert('Invalid error weyn');</script>")
        End Try
    End Sub

    Protected Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Try
            If txtproductID.Text = String.Empty And txtproductName.Text = String.Empty And txtprice.Text = String.Empty Then
                MsgBox("please select")
            Else
                cn.Close()
                cmd = New SqlCommand("Update product set productID='" & txtproductID.Text & "',productName='" & txtproductName.Text & "',price=" & txtprice.Text & " where productID='" & txtproductID.Text & "' ", cn)
                cn.Open()
                cmd.ExecuteNonQuery()
                cn.Close()
                Response.Write("<script>alert('Updated product');</script>")
            End If

            refreshdata()
            clear()

        Catch ex As Exception
            Response.Write("<script>alert('Invalid error weyn');</script>")
        End Try
    End Sub





    Protected Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Try
            cn.Close()
            cmd = New SqlCommand("delete from product where productID='" & txtproductID.Text & "' ", cn)
            cn.Open()
            cmd.ExecuteNonQuery()
            cn.Close()
            Response.Write("<script>alert('deleted product');</script>")


            refreshdata()
            clear()

        Catch ex As Exception
            Response.Write("<script>alert('Invalid error weyn');</script>")
        End Try
    End Sub

    Protected Sub txtproductName_TextChanged(sender As Object, e As EventArgs)

    End Sub
End Class