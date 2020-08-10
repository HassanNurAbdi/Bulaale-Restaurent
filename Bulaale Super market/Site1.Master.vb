Imports System.Data.SqlClient
Imports System.Configuration
Public Class Site1
    Inherits System.Web.UI.MasterPage
    Public cmd As New SqlCommand
    Public Da As New SqlDataAdapter
    Public dr As SqlDataReader
    Public ds As DataSet
    Public cb As SqlCommandBuilder
    Public table As New DataTable
    Dim strCon As String = ConfigurationManager.ConnectionStrings("con").ConnectionString
    Dim cn As New SqlConnection(strCon)

    Public customers As New Customers
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Session("role") = vbNullString Then
            lkuserlogin.Visible = True
            lksignUp.Visible = True
            lkLogout.Visible = False
            lkHelloUser.Visible = False
            lkviewproduct.Visible = True


            'footers
            lkAdmin.Visible = True
            lkproduct.Visible = False
            lkCustomer.Visible = False
            lksalesOrders.Visible = False

        ElseIf Session("role").Equals("User") Then
            lkuserlogin.Visible = False
            lksignUp.Visible = False
            lkLogout.Visible = True
            lkHelloUser.Visible = True
            lkHelloUser.Text = "Profile " + Session("username").ToString
            lbluser.Text = "Hello " + Session("username").ToString
            lkviewproduct.Visible = True


            'footers
            lkAdmin.Visible = True
            lkproduct.Visible = False
            lkCustomer.Visible = False
            lksalesOrders.Visible = False

        ElseIf Session("role").Equals("Admin") Then
            lkuserlogin.Visible = False
            lksignUp.Visible = False
            lkLogout.Visible = True
            lkHelloUser.Visible = False
            lbluser.Text = "Hello Admin"
            lkviewproduct.Visible = True


            'footers
            lkAdmin.Visible = False
            lkproduct.Visible = True
            lkCustomer.Visible = True
            lksalesOrders.Visible = True
        Else
            Response.Write("<script>alert('invalid credentials');</script>")

        End If
    End Sub

    Protected Sub btnSignUp_Click(sender As Object, e As EventArgs) Handles btnSignUp.Click
        Try
            If txtFullname.Text = String.Empty And txtContactno.Text = String.Empty And txtAddress.Text = String.Empty And cboState.SelectedValue = "Select" And txtEmail.Text = String.Empty And txtSignupuserId.Text = String.Empty And txtSignuppassword.Text = String.Empty Then
                Response.Write("<script>alert('please Fill');</script>")
            ElseIf txtFullname.Text <> String.Empty And txtContactno.Text = String.Empty And txtAddress.Text = String.Empty And cboState.SelectedValue = "Select" And txtEmail.Text = String.Empty And txtSignupuserId.Text = String.Empty And txtSignuppassword.Text = String.Empty Then
                Response.Write("<script>alert('please  all Fill');</script>")
            ElseIf txtFullname.Text = String.Empty And txtContactno.Text <> String.Empty And txtAddress.Text = String.Empty And cboState.SelectedValue = "Select" And txtEmail.Text = String.Empty And txtSignupuserId.Text = String.Empty And txtSignuppassword.Text = String.Empty Then
                Response.Write("<script>alert('please Fill');</script>")
            ElseIf txtFullname.Text = String.Empty And txtContactno.Text = String.Empty And txtAddress.Text <> String.Empty And cboState.SelectedValue = "Select" And txtEmail.Text = String.Empty And txtSignupuserId.Text = String.Empty And txtSignuppassword.Text = String.Empty Then
                Response.Write("<script>alert('please Fill');</script>")
            ElseIf txtFullname.Text = String.Empty And txtContactno.Text = String.Empty And txtAddress.Text = String.Empty And cboState.SelectedValue <> "Select" And txtEmail.Text = String.Empty And txtSignupuserId.Text = String.Empty And txtSignuppassword.Text = String.Empty Then
                Response.Write("<script>alert('please Fill');</script>")
            ElseIf txtFullname.Text = String.Empty And txtContactno.Text = String.Empty And txtAddress.Text = String.Empty And cboState.SelectedValue = "Select" And txtEmail.Text = String.Empty And txtSignupuserId.Text <> String.Empty And txtSignuppassword.Text = String.Empty Then
                Response.Write("<script>alert('please Fill');</script>")
            ElseIf txtFullname.Text = String.Empty And txtContactno.Text = String.Empty And txtAddress.Text = String.Empty And cboState.SelectedValue = "Select" And txtEmail.Text = String.Empty And txtSignupuserId.Text = String.Empty And txtSignuppassword.Text <> String.Empty Then
                Response.Write("<script>alert('please Fill');</script>")
            ElseIf txtFullname.Text <> String.Empty And txtContactno.Text <> String.Empty And txtAddress.Text = String.Empty And cboState.SelectedValue = "Select" And txtEmail.Text = String.Empty And txtSignupuserId.Text = String.Empty And txtSignuppassword.Text = String.Empty Then
                Response.Write("<script>alert('please Fill');</script>")
            ElseIf txtFullname.Text <> String.Empty And txtContactno.Text = String.Empty And txtAddress.Text <> String.Empty And cboState.SelectedValue = "Select" And txtEmail.Text = String.Empty And txtSignupuserId.Text = String.Empty And txtSignuppassword.Text = String.Empty Then
                Response.Write("<script>alert('please Fill');</script>")
            ElseIf txtFullname.Text <> String.Empty And txtContactno.Text = String.Empty And txtAddress.Text = String.Empty And cboState.SelectedValue <> "Select" And txtEmail.Text = String.Empty And txtSignupuserId.Text = String.Empty And txtSignuppassword.Text = String.Empty Then
                Response.Write("<script>alert('please Fill');</script>")
            ElseIf txtFullname.Text <> String.Empty And txtContactno.Text = String.Empty And txtAddress.Text = String.Empty And cboState.SelectedValue = "Select" And txtEmail.Text <> String.Empty And txtSignupuserId.Text = String.Empty And txtSignuppassword.Text = String.Empty Then
                Response.Write("<script>alert('please Fill');</script>")
            ElseIf txtFullname.Text <> String.Empty And txtContactno.Text = String.Empty And txtAddress.Text = String.Empty And cboState.SelectedValue = "Select" And txtEmail.Text = String.Empty And txtSignupuserId.Text <> String.Empty And txtSignuppassword.Text = String.Empty Then
                Response.Write("<script>alert('please Fill');</script>")
            ElseIf txtFullname.Text <> String.Empty And txtContactno.Text = String.Empty And txtAddress.Text = String.Empty And cboState.SelectedValue = "Select" And txtEmail.Text = String.Empty And txtSignupuserId.Text <> String.Empty And txtSignuppassword.Text <> String.Empty Then
                Response.Write("<script>alert('please Fill');</script>")
            ElseIf txtFullname.Text = String.Empty And txtContactno.Text <> String.Empty And txtAddress.Text <> String.Empty And cboState.SelectedValue = "Select" And txtEmail.Text = String.Empty And txtSignupuserId.Text = String.Empty And txtSignuppassword.Text = String.Empty Then
                Response.Write("<script>alert('please Fill');</script>")
            ElseIf txtFullname.Text = String.Empty And txtContactno.Text <> String.Empty And txtAddress.Text = String.Empty And cboState.SelectedValue <> "Select" And txtEmail.Text = String.Empty And txtSignupuserId.Text = String.Empty And txtSignuppassword.Text = String.Empty Then
                Response.Write("<script>alert('please Fill');</script>")
            ElseIf txtFullname.Text = String.Empty And txtContactno.Text <> String.Empty And txtAddress.Text = String.Empty And cboState.SelectedValue = "Select" And txtEmail.Text <> String.Empty And txtSignupuserId.Text = String.Empty And txtSignuppassword.Text = String.Empty Then
                Response.Write("<script>alert('please Fill');</script>")
            ElseIf txtFullname.Text = String.Empty And txtContactno.Text <> String.Empty And txtAddress.Text = String.Empty And cboState.SelectedValue = "Select" And txtEmail.Text = String.Empty And txtSignupuserId.Text <> String.Empty And txtSignuppassword.Text = String.Empty Then
                Response.Write("<script>alert('please Fill');</script>")
            ElseIf txtFullname.Text = String.Empty And txtContactno.Text <> String.Empty And txtAddress.Text = String.Empty And cboState.SelectedValue = "Select" And txtEmail.Text = String.Empty And txtSignupuserId.Text <> String.Empty And txtSignuppassword.Text <> String.Empty Then
                Response.Write("<script>alert('please Fill');</script>")
            ElseIf txtFullname.Text = String.Empty And txtContactno.Text = String.Empty And txtAddress.Text <> String.Empty And cboState.SelectedValue <> "Select" And txtEmail.Text = String.Empty And txtSignupuserId.Text = String.Empty And txtSignuppassword.Text = String.Empty Then
                Response.Write("<script>alert('please Fill');</script>")
            ElseIf txtFullname.Text = String.Empty And txtContactno.Text = String.Empty And txtAddress.Text <> String.Empty And cboState.SelectedValue = "Select" And txtEmail.Text <> String.Empty And txtSignupuserId.Text = String.Empty And txtSignuppassword.Text = String.Empty Then
                Response.Write("<script>alert('please Fill');</script>")
            ElseIf txtFullname.Text = String.Empty And txtContactno.Text = String.Empty And txtAddress.Text <> String.Empty And cboState.SelectedValue = "Select" And txtEmail.Text = String.Empty And txtSignupuserId.Text <> String.Empty And txtSignuppassword.Text <> String.Empty Then
                Response.Write("<script>alert('please Fill');</script>")
            ElseIf txtFullname.Text = String.Empty And txtContactno.Text = String.Empty And txtAddress.Text <> String.Empty And cboState.SelectedValue = "Select" And txtEmail.Text = String.Empty And txtSignupuserId.Text <> String.Empty And txtSignuppassword.Text <> String.Empty Then
                Response.Write("<script>alert('please Fill');</script>")
            ElseIf txtFullname.Text = String.Empty And txtContactno.Text = String.Empty And txtAddress.Text = String.Empty And cboState.SelectedValue <> "Select" And txtEmail.Text <> String.Empty And txtSignupuserId.Text <> String.Empty And txtSignuppassword.Text <> String.Empty Then
                Response.Write("<script>alert('please Fill');</script>")
            ElseIf txtFullname.Text = String.Empty And txtContactno.Text = String.Empty And txtAddress.Text <> String.Empty And cboState.SelectedValue <> "Select" And txtEmail.Text = String.Empty And txtSignupuserId.Text <> String.Empty And txtSignuppassword.Text <> String.Empty Then
                Response.Write("<script>alert('please Fill');</script>")
            ElseIf txtFullname.Text = String.Empty And txtContactno.Text = String.Empty And txtAddress.Text <> String.Empty And cboState.SelectedValue = "Select" And txtEmail.Text <> String.Empty And txtSignupuserId.Text <> String.Empty And txtSignuppassword.Text <> String.Empty Then
                Response.Write("<script>alert('please Fill');</script>")
            Else

                cn.Close()
                cmd = New SqlCommand("insert into Customer(Fullname,state,address,email,contactNo,userID,password)values('" & txtFullname.Text & "','" & cboState.Text & "','" & txtAddress.Text & "','" & txtEmail.Text & "','" & txtContactno.Text & "','" & txtSignupuserId.Text & "','" & txtSignuppassword.Text & "')", cn)
                cn.Open()
                cmd.ExecuteNonQuery()
                cn.Close()
                Response.Write("<script>alert('Welcome Bulaale Restuarant');</script>")
                Response.Write("<script>alert('Go to UserLogin to Login');</script>")
                clear()
            End If



        Catch ex As Exception
            Response.Write("<script>alert('Invalid error weyn');</script>")
        End Try
    End Sub

    Public Sub clear()
        txtFullname.Text = String.Empty
        txtEmail.Text = String.Empty
        txtContactno.Text = String.Empty
        txtAddress.Text = String.Empty
        txtSignupuserId.Text = String.Empty
        txtSignuppassword.Text = String.Empty
        cboState.SelectedIndex = 0
        txtAdminusername.Text = String.Empty
        txtAdminpassword.Text = String.Empty
        txtMemberpassword.Text = String.Empty
        txtMemberusername.Text = String.Empty

    End Sub

    Protected Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        clear()
    End Sub

    Protected Sub lkLogout_Click(sender As Object, e As EventArgs) Handles lkLogout.Click
        Session("username") = ""
        Session("role") = ""
        Response.Redirect("Home.aspx")
        lkuserlogin.Visible = True
        lksignUp.Visible = True
        lkLogout.Visible = False
        lkHelloUser.Visible = False
        lkviewproduct.Visible = True


        'footers
        lkAdmin.Visible = True
        lkproduct.Visible = False
        lkCustomer.Visible = False
        lksalesOrders.Visible = False
        clear()
    End Sub

    Protected Sub lkHelloUser_Click(sender As Object, e As EventArgs) Handles lkHelloUser.Click
        Response.Redirect("helloUser.aspx")
    End Sub

    Protected Sub lkviewproduct_Click(sender As Object, e As EventArgs) Handles lkviewproduct.Click
        Response.Redirect("viewProduct.aspx")
    End Sub



    Protected Sub lkproduct_Click(sender As Object, e As EventArgs) Handles lkproduct.Click
        Response.Redirect("Products.aspx")
    End Sub

    Protected Sub lkCustomer_Click(sender As Object, e As EventArgs) Handles lkCustomer.Click
        Response.Redirect("Customers.aspx")
    End Sub

    Protected Sub lkAboutUS_Click(sender As Object, e As EventArgs) Handles lkAboutUS.Click
        Response.Redirect("AboutUs.aspx")
    End Sub

    Protected Sub lksalesOrders_Click(sender As Object, e As EventArgs) Handles lksalesOrders.Click
        Response.Redirect("salesOrder.aspx")
    End Sub

    Protected Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If txtMemberusername.Text = String.Empty And txtMemberpassword.Text = String.Empty Then
            Response.Write("<script>alert('Please Fill');</script>")
        ElseIf txtMemberusername.Text <> String.Empty And txtMemberpassword.Text = String.Empty Then
            Response.Write("<script>alert('Please enter password');</script>")
        ElseIf txtMemberusername.Text = String.Empty And txtMemberpassword.Text <> String.Empty Then
            Response.Write("<script>alert('Please enter password');</script>")
        Else

            cn.Close()
            cmd = New SqlCommand
            cn.Open()
            Dim sqlquery As String = "select fullname,userID,password from Customer where userID='" & txtMemberusername.Text & "' and password='" & txtMemberpassword.Text & "' "
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

        End If
    End Sub

    Protected Sub loginAdmin_Click(sender As Object, e As EventArgs) Handles loginAdmin.Click
        If txtAdminusername.Text = String.Empty And txtAdminpassword.Text = String.Empty Then
            Response.Write("<script>alert('Please Fill');</script>")
        ElseIf txtAdminusername.Text <> String.Empty And txtAdminpassword.Text = String.Empty Then
            Response.Write("<script>alert('Please enter password');</script>")
        ElseIf txtAdminusername.Text = String.Empty And txtAdminpassword.Text <> String.Empty Then
            Response.Write("<script>alert('Please enter password');</script>")
        End If
        cn.Close()
        cmd = New SqlCommand
        cn.Open()
        Dim sqlquery As String = "select username,password from userAdmin where username='" & txtAdminusername.Text & "' and password='" & txtAdminpassword.Text & "' "
        cmd.CommandText = sqlquery
        cmd.Connection = cn
        dr = cmd.ExecuteReader()
        If dr.HasRows Then
            While dr.Read
                Response.Write("<script>alert('" & dr.GetValue(0).ToString & "');</script>")
                Session("username") = dr.GetValue(1).ToString
                Session("role") = "Admin"
                clear()
            End While
            Response.Redirect("Home.aspx")
        Else
            Response.Write("<script>alert('invalid username and password');</script>")
        End If
    End Sub
End Class