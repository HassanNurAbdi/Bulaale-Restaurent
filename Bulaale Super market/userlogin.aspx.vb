Imports System.Data.SqlClient

Public Class userlogin
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

    End Sub

    Protected Sub btnlogin_Click(sender As Object, e As EventArgs) Handles btnlogin.Click
        cn.Close()
        cmd = New SqlCommand
        cn.Open()
        Dim sqlquery As String = "select fullname,userID,password from Customer where userID='" & txtusername.Text & "' and password='" & txtpassword.Text & "' "
        cmd.CommandText = sqlquery
        cmd.Connection = cn
        dr = cmd.ExecuteReader()
        If dr.HasRows Then
            While dr.Read
                Response.Write("<script>alert('" & dr.GetValue(0).ToString & "');</script>")
                Session("username") = dr.GetValue(1).ToString
                Session("role") = "User"
                clear()
            End While
            Response.Redirect("Home.aspx")
        Else
            Response.Write("<script>alert('invalid username and password');</script>")
        End If

    End Sub

    Public Sub clear()
        txtpassword.Text = String.Empty
        txtusername.Text = String.Empty
    End Sub
End Class