namespace FirstProject.Controllers

open Microsoft.AspNetCore.Mvc
open System

type HomeController () =
    inherit Controller()

    member this.Index () =
        let hour = DateTime.Now.Hour
        let viewModel = if hour < 12 then "Good Morning" else "Good Afternoon"
        this.View("MyView", viewModel)

