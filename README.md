# How to Display Syncfusion Scheduler Inside an Accordion

This example repository demonstrates how to embed [JavaScript Scheduler](https://www.syncfusion.com/javascript-ui-controls/js-scheduler) within an Accordion layout using ASP.NET MVC. It showcases organizing scheduling components inside collapsible panels, providing a practical approach for building compact layouts and dashboard-style interfaces with integrated calendar functionality.

## Features

- Demonstrates embedding a Scheduler inside an Accordion panel
- Utilizes Syncfusion EJ2 MVC helpers for server-side rendering
- Integrates Syncfusion components via CDN
- Includes accordion expand event handling to refresh the scheduler on panel open
- Illustrates layout and integration patterns for ASP.NET MVC applications

## Prerequisites

- Visual Studio 2022 or later
- .NET Framework 4.5 or higher

## Installation

1. Open the `SyncfusionExample.sln` solution in Visual Studio
2. Restore NuGet packages (right-click solution > Restore NuGet Packages)
3. Build the solution
4. Run the application using IIS Express or a local development server

## Project Structure

- **Controllers/HomeController.cs** - Defines accordion items and initializes the view data
- **Views/Home/Index.cshtml** - Contains the Accordion and Scheduler components with event handlers
- **Views/Shared/_Layout.cshtml** - Master layout with Syncfusion script and style references

## Usage

The Scheduler is placed inside an Accordion panel body. When the accordion panel is expanded, the Scheduler component is refreshed to ensure proper rendering:

```csharp
@Html.EJS().Accordion("defaultAccordion").Items(ViewBag.accordionItems).Expanding("onExpand").Render()

<div id="Current_Enrolments" style="display: none">
    @Html.EJS().Schedule("schedule").Width("100%").Height("500px").Created("onCreate").Render()
</div>
```

The `onExpand` event handler refreshes the scheduler when the accordion panel opens:

```javascript
function onExpand(args) {
    if (isInitial) {
        var scheduleObj = document.getElementById('schedule').ej2_instances[0];
        scheduleObj.refresh();
        isInitial = false;
    }
}
```

## Documentation

- General Syncfusion docs: https://help.syncfusion.com/
- ASP.NET MVC introduction: https://ej2.syncfusion.com/aspnetmvc/documentation/introduction
- Schedule component (ASP.NET MVC): https://ej2.syncfusion.com/aspnetmvc/documentation/schedule/getting-started