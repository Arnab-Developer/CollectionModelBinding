# ASP.NET Core model binding with collection

`SessionController` `Index` method is sending a `Student` collection to view.

```csharp
public IActionResult Index()
{
    var s = new Session()
    {
        Id = 1,
        Name = "session1",
        Students = new List<Student>()
        {
            new Student()
            {
                Id = 1,
                Name = "student1"
            },
            new Student()
            {
                Id = 2,
                Name = "student2"
            }
        }
    };
    return View(s);
}
```

In the view it uses the ASP.NET model binding to post data into `Create` method.

```html
<form asp-action="Create" asp-controller="Session" method="post">
    <input type="text" asp-for="Id" /><br />
    <input type="text" asp-for="Name" /><br />

    @for(var i = 0; i < Model.Students.Count; i++)
    {
        <input type="text" asp-for="@Model.Students[i].Id" /><br />
        <input type="text" asp-for="@Model.Students[i].Name" /><br />
    }

    <input type="submit" value="Create session" />
</form>
```

```csharp
public IActionResult Create(Session s)
{
    return View();
}
```
