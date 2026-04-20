# how-to-display-scheduler-within-accordion
Repository Description: An example repository demonstrating how to embed the Syncfusion JavaScript Scheduler inside an Accordion layout for web applications and sample integrations.

## Project Overview

This sample shows how to display a JavaScript Scheduler control within an Accordion panel. The project demonstrates layout composition useful for dashboards and compact UIs where calendar scheduling needs to be nested inside collapsible sections.

## Features

- Demonstrates embedding a Scheduler inside an Accordion panel
- Illustrates layout and integration patterns for web apps

## Prerequisites

- Syncfusion JavaScript libraries (client-side)
- A web host or local server to run the included example (the repository contains an ASP.NET sample solution)

## Installation

1. Restore packages for the included solution if using Visual Studio.
2. Ensure Syncfusion scripts and styles are referenced in the project pages.

## Usage

Place the Scheduler container inside an Accordion panel body. Example structure:

```html
<div id="accordion">
	<div class="card">
		<div class="card-header">Schedule</div>
		<div class="card-body">
			<div id="scheduler"></div>
		</div>
	</div>
</div>
```

## Documentation

General Syncfusion docs: https://help.syncfusion.com/

ASP.NET Core introduction: https://ej2.syncfusion.com/aspnetcore/documentation/introduction

Schedule component (ASP.NET Core): https://ej2.syncfusion.com/aspnetcore/documentation/schedule/getting-started
