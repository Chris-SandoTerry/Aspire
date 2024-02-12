var builder = DistributedApplication.CreateBuilder(args);

var apiService = builder.AddProject<Projects.AspireStarterApp_ApiService>("apiservice");

builder.AddProject<Projects.AspireStarterApp_Web>("webfrontend")
    .WithReference(apiService);

builder.Build().Run();
