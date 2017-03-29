<%@ Application Language="C#" %>
<%@ Import Namespace="System.Web.Routing" %>

<script RunAt="server">

    void Application_Start(object sender, EventArgs e)
    {
        // Código que se ejecuta al iniciarse la aplicación
        RegisterRoutes(RouteTable.Routes);

    }

    void Application_End(object sender, EventArgs e)
    {
        //  Código que se ejecuta al cerrarse la aplicación

    }

    void Application_Error(object sender, EventArgs e)
    {

    }

    void Session_Start(object sender, EventArgs e)
    {
        // Código que se ejecuta al iniciarse una nueva sesión

    }

    void Session_End(object sender, EventArgs e)
    {
        // Código que se ejecuta cuando finaliza una sesión. 
        // Nota: el evento Session_End se produce solamente con el modo sessionstate
        // se establece como InProc en el archivo Web.config. Si el modo de sesión se establece como StateServer
        // o SQLServer, el evento no se produce.

    }

    void RegisterRoutes(RouteCollection routes)
    {
        routes.MapPageRoute("error",
            "error",
            "~/Board.html");
        routes.MapPageRoute("users",
            "@{user}",
            "~/User.html");
        routes.MapPageRoute("boards",
            "{board}",
            "~/Board.html");
    }

</script>
