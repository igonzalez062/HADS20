Public Class Inicio
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Protected Sub BotonLogin_Click(sender As Object, e As EventArgs) Handles BotonLogin.Click
        Dim resultado As String

        resultado = LibreriaFunciones.Funciones.loginUsuario(TextBoxEmail.Text, TextBoxContraseña.Text)
        If resultado = "OK" Then
            Response.Redirect("./AppUsuarioYaRegistrado.aspx")
        ElseIf resultado = "ERRORDATOSINCORRECTOS" Then
            LabelError.Text = "DATOS INCORRECTOS"
        ElseIf resultado = "ERRORNOUSER" Then
            LabelError.Text = "NO EXISTE ESE USUARIO"
        ElseIf resultado = "ERRORAPERTURADECONEXION" Then
            LabelError.Text = "ERROR EN LA APERTURA DE LA CONEXION"
        End If
    End Sub

    Protected Sub LinkButtonOlvidadoContraseña_Click(sender As Object, e As EventArgs) Handles LinkButtonOlvidadoContraseña.Click

    End Sub
End Class