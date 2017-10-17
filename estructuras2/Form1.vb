Public Class Form1
    Public Structure loanapplicant
        Public applicantnumber As Integer
        Public name As String
        Public salary As Decimal
        Public loanrequest As Decimal
    End Structure
    Dim aplicacion As loanapplicant

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        aplicacion.applicantnumber = 1
        aplicacion.name = TextBox1.Text
        aplicacion.salary = Integer.Parse(TextBox2.Text)
        aplicacion.loanrequest = Integer.Parse(TextBox3.Text)

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        MessageBox.Show("loan aplicant no:" & aplicacion.applicantnumber & ControlChars.CrLf & "loan aplicant name:" & aplicacion.name & ControlChars.CrLf & "salary:" & aplicacion.salary & ControlChars.CrLf & "loan requested:" & aplicacion.loanrequest)
        MessageBox.Show("aplication will close now. ")
        Application.Exit()
    End Sub
End Class
