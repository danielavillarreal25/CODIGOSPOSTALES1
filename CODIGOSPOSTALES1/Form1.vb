Imports System.Data.SqlClient

Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            LlenarComboBoxEstados()
        Catch ex As Exception
            MessageBox.Show("Error al cargar el formulario: " & ex.Message)
        End Try
    End Sub

    Private Sub LlenarComboBoxEstados()
        Using conexion As SqlConnection = ConexionBD.ObtenerConexion()
            If conexion IsNot Nothing Then
                Dim query As String = "SELECT Nombre FROM Estado"
                Dim command As New SqlCommand(query, conexion)
                Dim adapter As New SqlDataAdapter(command)
                Dim table As New DataTable()

                Try
                    adapter.Fill(table)
                    cbEstados.DataSource = table
                    cbEstados.DisplayMember = "Nombre"
                    cbEstados.ValueMember = "Nombre"
                Catch ex As Exception
                    MessageBox.Show("Error al cargar los estados: " & ex.Message)
                End Try
            End If
        End Using
    End Sub

    Private Sub LlenarComboBoxMunicipios(estado As String)
        Using conexion As SqlConnection = ConexionBD.ObtenerConexion()
            If conexion IsNot Nothing Then
                Dim query As String = "SELECT Nombre FROM Municipio WHERE IdEstado = (SELECT id FROM Estado WHERE Nombre = @Estado)"
                Dim command As New SqlCommand(query, conexion)
                command.Parameters.AddWithValue("@Estado", estado)
                Dim adapter As New SqlDataAdapter(command)
                Dim table As New DataTable()

                Try
                    adapter.Fill(table)
                    cbMunicipios.DataSource = table
                    cbMunicipios.DisplayMember = "Nombre"
                    cbMunicipios.ValueMember = "Nombre"
                Catch ex As Exception
                    MessageBox.Show("Error al cargar los municipios: " & ex.Message)
                End Try
            End If
        End Using
    End Sub

    Private Sub LlenarDataGridView(Optional ByVal estado As String = "", Optional ByVal municipio As String = "")
        Using conexion As SqlConnection = ConexionBD.ObtenerConexion()
            If conexion IsNot Nothing Then
                Dim query As String = "SELECT * FROM VnombreBUSQUEDA WHERE 1=1"
                If Not String.IsNullOrEmpty(estado) Then
                    query &= " AND [Nombre Estado] = @Estado"
                End If
                If Not String.IsNullOrEmpty(municipio) Then
                    query &= " AND [Nombre Municipio] = @Municipio"
                End If
                Dim command As New SqlCommand(query, conexion)
                If Not String.IsNullOrEmpty(estado) Then
                    command.Parameters.AddWithValue("@Estado", estado)
                End If
                If Not String.IsNullOrEmpty(municipio) Then
                    command.Parameters.AddWithValue("@Municipio", municipio)
                End If
                Dim adapter As New SqlDataAdapter(command)
                Dim table As New DataTable()

                Try
                    adapter.Fill(table)
                    dgvAsentamientos.DataSource = table
                Catch ex As Exception
                    MessageBox.Show("Error al cargar los datos: " & ex.Message)
                End Try
            End If
        End Using
    End Sub

    Private Sub cbEstados_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbEstados.SelectedIndexChanged
        Try
            Dim estado As String = cbEstados.SelectedValue.ToString()
            LlenarComboBoxMunicipios(estado)
            LlenarDataGridView(estado)
        Catch ex As Exception
            MessageBox.Show("Error al cambiar el estado: " & ex.Message)
        End Try
    End Sub

    Private Sub btnFiltrar_Click(sender As Object, e As EventArgs) Handles btnFiltrar.Click
        Try
            Dim estado As String = cbEstados.SelectedValue.ToString()
            Dim municipio As String = cbMunicipios.SelectedValue?.ToString()
            LlenarDataGridView(estado, municipio)
        Catch ex As Exception
            MessageBox.Show("Error al filtrar los datos: " & ex.Message)
        End Try
    End Sub
End Class

'''**********

'Imports System.Data.SqlClient

'Public Class Form1
'    ' Cargar los datos al cargar el formulario
'    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
'        Try
'            LlenarComboBoxEstados()
'            LlenarDataGridView()
'        Catch ex As Exception
'            MessageBox.Show("Error al cargar el formulario: " & ex.Message)
'        End Try
'    End Sub

'    ' Función para llenar el ComboBox con los nombres de los estados
'    Private Sub LlenarComboBoxEstados()
'        Using conexion As SqlConnection = ConexionBD.ObtenerConexion()
'            If conexion IsNot Nothing Then
'                Dim query As String = "SELECT Nombre FROM Estado"
'                Dim command As New SqlCommand(query, conexion)
'                Dim adapter As New SqlDataAdapter(command)
'                Dim table As New DataTable()

'                Try
'                    adapter.Fill(table)
'                    cbEstados.DataSource = table
'                    cbEstados.DisplayMember = "Nombre"
'                    cbEstados.ValueMember = "Nombre"
'                Catch ex As Exception
'                    MessageBox.Show("Error al cargar los estados: " & ex.Message)
'                End Try
'            End If
'        End Using
'    End Sub

'    ' Función para llenar el DataGridView con los datos de la vista VnombreBUSQUEDA
'    Private Sub LlenarDataGridView(Optional ByVal estado As String = "")
'        Using conexion As SqlConnection = ConexionBD.ObtenerConexion()
'            If conexion IsNot Nothing Then
'                Dim query As String = "SELECT * FROM VnombreBUSQUEDA"
'                If Not String.IsNullOrEmpty(estado) Then
'                    query &= " WHERE [Nombre Estado] = @Estado"
'                End If
'                Dim command As New SqlCommand(query, conexion)
'                If Not String.IsNullOrEmpty(estado) Then
'                    command.Parameters.AddWithValue("@Estado", estado)
'                End If
'                Dim adapter As New SqlDataAdapter(command)
'                Dim table As New DataTable()

'                Try
'                    adapter.Fill(table)
'                    dgvAsentamientos.DataSource = table
'                Catch ex As Exception
'                    MessageBox.Show("Error al cargar los datos: " & ex.Message)
'                End Try
'            End If
'        End Using
'    End Sub

'    ' Evento del botón para filtrar los datos por estado
'    Private Sub btnFiltrar_Click(sender As Object, e As EventArgs) Handles btnFiltrar.Click
'        Try
'            Dim estado As String = cbEstados.SelectedValue.ToString()
'            LlenarDataGridView(estado)
'        Catch ex As Exception
'            MessageBox.Show("Error al filtrar los datos: " & ex.Message)
'        End Try
'    End Sub
'End Class
