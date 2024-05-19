'Imports System.Data.SqlClient
'Module Module1
'    'La variable conn es la que permite conectarnos a nuestro SQL
'    'data source = donde esta conectada nuestra base de datos
'    Public conn As New SqlClient.SqlConnection("data source = DESKTOP-NS0DOBO\SQLEXPRESS; initial catalog= Codigos; integrated security= SSPI; persist security info = false; trusted_connection = yes;")
'    'Nos permite ejecutar los comandos que tienen que ver con los 
'    'procedimientos almacenados de sql
'    Public cmd As SqlClient.SqlCommand
'    'permite leer los datos
'    Public sqlread As SqlClient.SqlDataReader
'    Public Query As String
'    Public w As Integer
'    Public bandera As Integer = 0

'    Public Function ejecutaSelect(cmd As SqlCommand) As SqlDataReader
'        Dim dr As SqlDataReader
'        conn.Open()
'        cmd.Connection = conn
'        dr = cmd.ExecuteReader()

'        conn.Close()
'        Return dr
'    End Function
'End Module

Imports System.Data.SqlClient


Module ConexionBD
    ' Declarar la cadena de conexión sin usuario ni contraseña
    Private connectionString As String = "Data Source=DESKTOP-NS0DOBO\SQLEXPRESS;Initial Catalog=CorreosMexico;Integrated Security=SSPI;"

    ' Función para obtener la conexión
    Public Function ObtenerConexion() As SqlConnection
        ' Crear una nueva conexión usando la cadena de conexión
        Dim conexion As New SqlConnection(connectionString)
        Try
            ' Abrir la conexión
            conexion.Open()
            ' Si la conexión es exitosa, retornar la conexión
            Return conexion
        Catch ex As Exception
            ' Manejar cualquier excepción que ocurra y retornar Nothing
            MessageBox.Show("Error al conectar a la base de datos: " & ex.Message)
            Return Nothing
        End Try
    End Function
End Module


