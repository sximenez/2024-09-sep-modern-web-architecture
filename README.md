# Modern web architecture

Source: [Microsoft Learn](https://learn.microsoft.com/en-gb/training/)

## Table of contents

<!--TOC-->
  - [Monolithic vs microservices](#monolithic-vs-microservices)
  - [ASP timeline](#asp-timeline)
    - [Classic ASP](#classic-asp)
<!--/TOC-->
## Monolithic vs microservices

A `monolithic` app is an app deployed as a single unit.

Versus an app composed of a collection of different services interacting with each other.

In many cases, monolithic apps are easier to build, deploy and debug versus a microservices-driven app, achieving most business requirements.

## ASP timeline

Active Server Pages.

Microsoft uses the ASP framework for web development, which has evolved several models over the years.

```mermaid
timeline
section Classic ASP

1996: 1.0
	: Objects (Request, Response, Session).

1997: 2.0
	: Additional objects (ASPError).
	: Performance and scalability optimization.

2000: 3.0
	: Additional methods (Server.Transfer, Server.Execute)
	: Performance optimization.

section ASP.NET

2002: ASP.NET 1.0
	: OOP, compilation (vs interpretation in classic ASP), Web Forms, state management, server controls.

2003: 1.1
	: Performance optimization.

2005: 2.0
	: Master Pages, new data controls, improved data binding.

2008: 3.5
	: LINQ.

2010: 4.0
	: Web Forms, HTML rendering, routing, and performance optimizatios.

2012: MVC
	: Web API, mobile web support, async controllers.

section Core

2016: 1.0
	: Cross-platform support, unified MVC, modular and high-performance framework.

2018: 2.1
	: SignalR (Websockets), Razor (frontend).

2020: 3.1
	: LTS, Blazor (UIs using C#), gRPC optimization.

2021: 5.0
	: Performane optimization.

2022: 6.0
	: Minimal API
```

### Classic ASP (.asp)

Like PHP, classic ASP embeds scripts (logic) within HTML code.

Rendering occurs on the server side, via an ASP engine:

```mermaid
sequenceDiagram
    participant Client
    participant WebServer
    participant ASPEngine
    Client->>WebServer: Request ASP Page
    WebServer->>ASPEngine: Pass Request
    ASPEngine->>ASPEngine: Interpret and Execute Scripts
    ASPEngine->>WebServer: Generate HTML
    WebServer->>Client: Send HTML Response
```

It uses VBScript, a light version of Visual Basic:

```aspnet
<!DOCTYPE html>
	<html>
		<body>
			<%
			Response.Write("Hello World!")	
			%>
		</body>
	</html>
```

### ASP.NET (.aspx)