namespace InfoCategoryApp.Server.Controllers

open Microsoft.AspNetCore.Mvc

[< ApiController >]
[< Route("api/[controller]") >]
type CategoryController() =
    inherit ControllerBase()

    let categories =
        dict[
            1, "Weather"
            2, "Traffic"
            3, "Sports"
            4, "Exit"
        ]

    [< HttpGet("{id}") >]
    member this.GetCategory(id: int) =
        match categories.TryGetValue(id) with
        | true, categoryMessage -> this.Ok(categoryMessage) :> IActionResult
        | _ -> this.NotFound("Category not found") :> IActionResult
