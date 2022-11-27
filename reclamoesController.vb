Imports System
Imports System.Collections.Generic
Imports System.Data
Imports System.Data.Entity
Imports System.Linq
Imports System.Net
Imports System.Web
Imports System.Web.Mvc
Imports plataformaWebEmpresaAgua

Namespace Controllers
    Public Class reclamoesController
        Inherits System.Web.Mvc.Controller

        Private db As New adminEmpresaAguaEntities2

        ' GET: reclamoes
        Function Index() As ActionResult
            Return View(db.reclamo.ToList())
        End Function
    End Class
End Namespace
