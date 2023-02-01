Module LimpiarCampos

    Public Sub limpiarCamposSocio()
        AgregarSocio.txtNombre.Clear()
        AgregarSocio.txtApellido.Clear()
        AgregarSocio.txtTelefono.Clear()
        AgregarSocio.txtDireccion.Clear()
        AgregarSocio.txtEstado.Clear()
        AgregarSocio.txtDni.Clear()
    End Sub

    Public Sub limpiarCamposAgregarUbicacion()
        AgregarUbicacion.txtPiso.Clear()
        AgregarUbicacion.txtSector.Clear()
        AgregarUbicacion.txtEstante.Clear()
    End Sub

    Public Sub limpiarCamposAgregarEditorial()
        AgregarEditorial.txtNombreEditorial.Clear()
        AgregarEditorial.txtContactoEditorial.Clear()
        AgregarEditorial.txtLocalizacionEditorial.Clear()

    End Sub

    Public Sub limpiarCamposAgregarAutor()
        AgregarAutor.txtNombre.Clear()
        AgregarAutor.txtApellido.Clear()
        AgregarAutor.txtNacionalidad.Clear()
    End Sub
    Public Sub limpiarCamposCargarLibro()
        AgregarLibro.txtIsbn.Clear()
        AgregarLibro.txtTitulo.Clear()
        AgregarLibro.cbxCategoria.ResetText()
        AgregarLibro.cbxEditorial.ResetText()
        AgregarLibro.cbxUbicacion.ResetText()
        AgregarLibro.txtAutor.Clear()
    End Sub

End Module
