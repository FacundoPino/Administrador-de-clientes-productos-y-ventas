Public Class Globales
    Public Shared Sub DiseñoDtv(ByRef listado As DataGridView)
        listado.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
        listado.BackgroundColor = Color.FromArgb(128, 128, 255)
        listado.EnableHeadersVisualStyles = False
        listado.BorderStyle = BorderStyle.None
        listado.CellBorderStyle = DataGridViewCellBorderStyle.SunkenVertical
        listado.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None
        listado.RowHeadersVisible = True

        Dim cabecera As New DataGridViewCellStyle()
        cabecera.BackColor = Color.FromArgb(29, 29, 29)
        cabecera.ForeColor = Color.White
        cabecera.Font = New Font("Segoe UI", 10, FontStyle.Bold)
        listado.ColumnHeadersDefaultCellStyle = cabecera
    End Sub

    Public Shared Sub OcultarColumnas(ByRef listado As DataGridView)
        'listado.Columns(1).Visible = False
        ''listado.Columns(5).Visible = False
    End Sub
End Class
