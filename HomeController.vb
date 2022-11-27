Public Class HomeController
    Inherits System.Web.Mvc.Controller

    Function Index() As ActionResult
        Return View()
    End Function

    Function Stock() As ActionResult
        ViewData("Message") = "Stock diponible"

        Return View()
    End Function
    Function Sugerencias() As ActionResult
        ViewData("Message") = "Sugerencias"

        Return View()
    End Function
    Function Reclamos() As ActionResult
        ViewData("Message") = "Reclamos"

        Return View()
    End Function
    Function Comentarios() As ActionResult
        ViewData("Message") = "Comentarios"

        Return View()
    End Function
    Function Contacto() As ActionResult
        ViewData("Message") = "Contacta la empresa."

        Return View()
    End Function

    Function Cliente() As ActionResult
        ViewData("Message") = "Clientes"

        Return View()

    End Function
    Function Venta() As ActionResult
        ViewData("Message") = "Ventas"

        Return View()

    End Function
    Function MostrarTodo() As ActionResult
        ViewData("Message") = "Todo"

        Return View()

    End Function
    Function Graficos() As ActionResult
        ViewData("Message") = "Graficos"

        Return View()

    End Function
End Class
