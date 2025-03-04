![Ocelot Logo](/images/ocelot_logo.png)

[![CircleCI](https://circleci.com/gh/ThreeMammals/Ocelot/tree/main.svg?style=svg)](https://circleci.com/gh/ThreeMammals/Ocelot/tree/main)

[![Coverage Status](https://coveralls.io/repos/github/ThreeMammals/Ocelot/badge.svg)](https://coveralls.io/github/ThreeMammals/Ocelot)

# Ocelot

Ocelot is a .NET API Gateway. This project is aimed at people using .NET running a microservices / service-oriented architecture 
that need a unified point of entry into their system. However it will work with anything that speaks HTTP and run on any platform that ASP.NET Core supports.

In particular I want easy integration with IdentityServer reference and bearer tokens. 

We have been unable to find this in my current workplace without having to write our own Javascript middlewares to handle the IdentityServer reference tokens. We would rather use the IdentityServer code that already exists to do this.

Ocelot is a bunch of middlewares in a specific order.

Ocelot manipulates the `HttpRequest` object into a state specified by its configuration until it reaches a request builder middleware, where it creates a `HttpRequestMessage` object which is used to make a request to a downstream service.
The middleware that makes the request is the last thing in the Ocelot pipeline. It does not call the next middleware.
The response from the downstream service is retrieved as the requests goes back up the Ocelot pipeline.
There is a piece of middleware that maps the `HttpResponseMessage` onto the `HttpResponse` object and that is returned to the client.
That is basically it with a bunch of other features!

## Features

A quick list of Ocelot's capabilities for more information see the [documentation](https://ocelot.readthedocs.io/en/latest/).

* Routing
* Request Aggregation
* Service Discovery with Consul & Eureka
* Service Fabric
* Kubernetes 
* WebSockets
* Authentication
* Authorization
* Rate Limiting
* Caching
* Retry policies / QoS
* Load Balancing
* Logging / Tracing / Correlation
* Headers / Method / Query String / Claims Transformation
* Custom Middleware / Delegating Handlers
* Configuration / Administration REST API
* Platform / Cloud Agnostic

## Install

Ocelot is designed to work with ASP.NET and it targets `net7.0`.

Install Ocelot and its dependencies using NuGet Package Manager:
```powershell
Install-Package Ocelot
```

Or via the .NET CLI:
```shell
dotnet add package Ocelot
```

All versions can be found [here](https://www.nuget.org/packages/Ocelot/).

## Documentation

Please click [here](https://ocelot.readthedocs.io/en/latest/) for the Ocelot documentation. This includes lots of information and will be helpful if you want to understand the features Ocelot currently offers.

## Coming up

You can see what we are working on [here](https://github.com/ThreeMammals/Ocelot/issues).

## Contributing

We love to receive contributions from the community so please keep them coming :) 

Pull requests, issues and commentary welcome!

Please complete the relevant template for issues and PRs. Sometimes it's worth getting in touch with us to discuss changes before doing any work in case this is something we are already doing or it might not make sense. We can also give advice on the easiest way to do things :)

Finally we mark all existing issues as help wanted, small, medium and large effort. If you want to contribute for the first time I suggest looking at a help wanted & small effort issue :)
