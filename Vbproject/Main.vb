Imports System.Data
Imports System.Data.SqlClient

Public Class Main
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim con As SqlConnection = New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\dhanv\source\repos\Vbproject\Vbproject\Data.mdf;Integrated Security=True")
        con.Open()
        Dim pr As String = Label6.Text
        pr = pr.Substring(3, pr.Length - 3)
        Dim cmd As SqlCommand = New SqlCommand("insert into Cart values('" & Label1.Text & "'," & CInt(TextBox1.Text) & "," & CInt(pr) & ",null)", con)
        If cmd.ExecuteNonQuery() Then
            Dim count As String = Label5.Text
            count = count.Substring(0, 2)
            Dim no As Integer = CInt(count)
            no = no + CInt(TextBox1.Text)
            Label5.Text = no & " items"
        Else
            MessageBox.Show("Already in Cart!")
        End If
        con.Close()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim con As SqlConnection = New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\dhanv\source\repos\Vbproject\Vbproject\Data.mdf;Integrated Security=True")
        con.Open()
        Dim pr As String = Label7.Text
        pr = pr.Substring(3, pr.Length - 3)
        Dim cmd As SqlCommand = New SqlCommand("insert into Cart values('" & Label2.Text & "'," & CInt(TextBox2.Text) & "," & CInt(pr) & ",null)", con)
        If cmd.ExecuteNonQuery() Then
            Dim count As String = Label5.Text
            count = count.Substring(0, 2)
            Dim no As Integer = CInt(count)
            no = no + CInt(TextBox2.Text)
            Label5.Text = no & " items"
        Else
            MessageBox.Show("Already in Cart!")
        End If
        con.Close()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim con As SqlConnection = New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\dhanv\source\repos\Vbproject\Vbproject\Data.mdf;Integrated Security=True")
        con.Open()
        Dim pr As String = Label8.Text
        pr = pr.Substring(3, pr.Length - 3)
        Dim cmd As SqlCommand = New SqlCommand("insert into Cart values('" & Label3.Text & "'," & CInt(TextBox3.Text) & "," & CInt(pr) & ",null)", con)
        If cmd.ExecuteNonQuery() Then
            Dim count As String = Label5.Text
            count = count.Substring(0, 2)
            Dim no As Integer = CInt(count)
            no = no + CInt(TextBox3.Text)
            Label5.Text = no & " items"
        Else
            MessageBox.Show("Already in Cart!")
        End If
        con.Close()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim con As SqlConnection = New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\dhanv\source\repos\Vbproject\Vbproject\Data.mdf;Integrated Security=True")
        con.Open()
        Dim pr As String = Label9.Text
        pr = pr.Substring(3, pr.Length - 3)
        Dim cmd As SqlCommand = New SqlCommand("insert into Cart values('" & Label4.Text & "'," & CInt(TextBox4.Text) & "," & CInt(pr) & ",null)", con)
        If cmd.ExecuteNonQuery() Then
            Dim count As String = Label5.Text
            count = count.Substring(0, 2)
            Dim no As Integer = CInt(count)
            no = no + CInt(TextBox4.Text)
            Label5.Text = no & " items"
        Else
            MessageBox.Show("Already in Cart!")
        End If
        con.Close()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        ViewCart.Show()
    End Sub

    Private Sub Main_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim con As SqlConnection = New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\dhanv\source\repos\Vbproject\Vbproject\Data.mdf;Integrated Security=True")
        con.Open()
        Dim item As New SqlCommand("select Sum(Quantity) from Cart", con)
        Dim dr As SqlDataReader = item.ExecuteReader()
        dr.Read()
        Dim no As Integer = dr.GetValue(0)
        Label5.Text = no & " items"
    End Sub
End Class