Imports System.Data
Imports System.Data.SqlClient
Public Class ViewCart
    Dim connect As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\dhanv\source\repos\Vbproject\Vbproject\Data.mdf;Integrated Security=True")
    Dim cmd As New SqlCommand("select Total from Cart", connect)

    Private Sub ViewCart_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DataSet1.Cart' table. You can move, or remove it, as needed.
        Me.CartTableAdapter.Fill(Me.DataSet1.Cart)
        connect.Open()
        DataGridView1.DataSource = DataSet1.Cart
        Dim gr As Integer = 0
        Dim dre As SqlDataReader = cmd.ExecuteReader()
        While dre.Read()
            gr = gr + dre.GetValue(0)
        End While
        Label3.Text = "Rs." & gr
        connect.Close()
    End Sub



    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        connect.Open()
        Dim command As New SqlCommand("update Cart set Quantity= " & CInt(TextBox2.Text) & "where Product_Name='" & ComboBox1.Text & "'", connect)
        If command.ExecuteNonQuery() Then
            connect.Close()
            connect.Open()
            Dim da As New SqlDataAdapter("select * from Cart", connect)
            Dim ds As New DataSet()
            da.Fill(ds)
            DataGridView1.DataSource = ds.Tables(0)
            Dim dre As SqlDataReader = cmd.ExecuteReader()
            Dim gr As Integer = 0
            While dre.Read()
                gr = gr + dre.GetValue(0)
            End While
            Label3.Text = "Rs." & gr
            connect.Close()
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        connect.Open()
        Dim command As New SqlCommand("delete from Cart where Product_Name='" & ComboBox1.Text & "'", connect)
        If command.ExecuteNonQuery() Then
            connect.Close()
            connect.Open()
            Dim da As New SqlDataAdapter("select * from Cart", connect)
            Dim ds As New DataSet()
            da.Fill(ds)
            DataGridView1.DataSource = ds.Tables(0)
            Dim dre As SqlDataReader = cmd.ExecuteReader()
            Dim gr As Integer = 0
            While dre.Read()
                gr = gr + dre.GetValue(0)
            End While
            Label3.Text = "Rs." & gr
            connect.Close()
        End If
    End Sub
End Class