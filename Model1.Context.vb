﻿'------------------------------------------------------------------------------
' <auto-generated>
'     Este código se generó a partir de una plantilla.
'
'     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
'     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
' </auto-generated>
'------------------------------------------------------------------------------

Imports System
Imports System.Data.Entity
Imports System.Data.Entity.Infrastructure

Partial Public Class adminEmpresaAguaEntities2
    Inherits DbContext

    Public Sub New()
        MyBase.New("name=adminEmpresaAguaEntities2")
    End Sub

    Protected Overrides Sub OnModelCreating(modelBuilder As DbModelBuilder)
        Throw New UnintentionalCodeFirstException()
    End Sub

    Public Overridable Property cliente() As DbSet(Of cliente)
    Public Overridable Property estadoVenta() As DbSet(Of estadoVenta)
    Public Overridable Property stock() As DbSet(Of stock)
    Public Overridable Property sysdiagrams() As DbSet(Of sysdiagrams)
    Public Overridable Property venta() As DbSet(Of venta)
    Public Overridable Property datosTransferencia() As DbSet(Of datosTransferencia)
    Public Overridable Property comentario() As DbSet(Of comentario)
    Public Overridable Property reclamo() As DbSet(Of reclamo)
    Public Overridable Property sugerencia() As DbSet(Of sugerencia)

End Class